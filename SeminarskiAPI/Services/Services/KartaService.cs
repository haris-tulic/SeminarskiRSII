using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public class KartaService : IKartaService   
    {
        private readonly Database.eAutobusi _context;
        private readonly IMapper _mapper;
        private readonly IKupacService _kupac;
        private readonly IKartaKupacService _kartaKupac;

        public KartaService(Database.eAutobusi context, IMapper mapper, IKupacService kupac, IKartaKupacService kartaKupac)
        {
            _context = context;
            _mapper = mapper;
            _kupac = kupac;
            _kartaKupac = kartaKupac;
        }
        public eAutobusModel.KartaModel Delete(int id)
        {
            var entity = _context.Karta.Find(id);
            //_context.Karta.Remove(entity);
            entity.IsDeleted = true;
            _context.SaveChanges();
            return _mapper.Map<KartaModel>(entity);
        }

        public List<KartaModel> Get(KartaGetRequest request)
        {
            var query = _context.Karta.Include(v => v.VrstaKarte)
                                    .Include(k=>k.KupacList)
                                    .Include(t => t.TipKarte)
                                    .Include(p=>p.PlaceneKarte)
                                    .Include("KupacList.Kupac")
                                    .Include(o=>o.Odrediste)
                                    .Include(p=>p.Polaziste)
                                    .Where(k=>k.IsDeleted==false)
                                    .AsQueryable();
            var list = query.ToList();
            var listM = new List<KartaModel>();
            _mapper.Map(list, listM);
            for (int i = 0; i < list.Count(); i++)
            {
                listM[i].VrstaKarte = list[i].VrstaKarte.Naziv;
                listM[i].TipKarte = list[i].TipKarte.Naziv;
                listM[i].Relacija = list[i].Polaziste.NazivLokacijeStanice + " - " + list[i].Odrediste.NazivLokacijeStanice;
                foreach (var item in list[i].KupacList)
                {
                    listM[i].DatumVadjenjaKarte = item.DatumVadjenjaKarte;
                    listM[i].DatumVazenjaKarte = item.DatumVazenjaKarte;
                    listM[i].ImePrezimeKupca = item.Kupac.Ime + " " + item.Kupac.Prezime;
                }
              
            }
            return listM;

        }

        public KartaModel GetById(int id)
        {
            var entity = _context.Karta.Include(k=>k.PlaceneKarte).Include(k=>k.KupacList).Where(x=>x.KartaID==id).FirstOrDefault();
            return _mapper.Map<KartaModel>(entity);
          
        }

        public KartaModel Insert(KartaUpsertRequest request)
        {
            var kupac = new KupacInsertRequest()
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                AdresaStanovanja = request.AdresaStanovanja,
                BrojTelefona = request.BrojTelefona,
                Email = request.Email,
            };
            var entity = _mapper.Map<Karta>(request);
            bool postoji = ProvjeriKartu(kupac);
                if (!postoji)
                {
                    _context.Karta.Add(entity);
                    _context.SaveChanges();
                    KupacModel newKupac = new KupacModel();
                    Kupac pronadjeni = _kupac.PronadjiKupca(kupac);
                    if (pronadjeni == null)
                    {
                        newKupac = _kupac.Insert(kupac);

                    }
                    else
                    {
                        newKupac.KupacID = pronadjeni.KupacID;
                    }
                    var kupacKarta = new KartaKupacUpsertRequest()
                    {
                        Aktivna = true,
                        DatumVadjenjaKarte = request.DatumVadjenjaKarte,
                        DatumVazenjaKarte = request.DatumVazenjaKarte,
                        KartaID = entity.KartaID,
                        KupacID = newKupac.KupacID,
                        Pravac = request.Pravac,
                        PravacS = request.PravacS,
                    };

                    KartaKupacModel osobineKarte = _kartaKupac.Insert(kupacKarta);
                    request.KupacID = newKupac.KupacID;
                    request.KartaID = entity.KartaID;
                    return _mapper.Map<KartaModel>(request);
                }
            return null;  
        }

        private bool ProvjeriKartu(KupacInsertRequest trazeni)
        {
            var pronadjiKupca = _kupac.PronadjiKupca(trazeni);
            if (pronadjiKupca!=null && pronadjiKupca.KartaList!=null)
            {
                foreach (var item in pronadjiKupca.KartaList)
                {
                    if (DateTime.Now>item.DatumVazenjaKarte)
                    {
                        item.Aktivna = false;
                    }
                }
                foreach (var item in pronadjiKupca.KartaList)
                {

                    if (item.Aktivna && item.DatumVazenjaKarte>DateTime.Now)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public KartaModel Update(KartaUpsertRequest request, int id)
        {
            var update = _context.Karta.Find(id);
            _mapper.Map(request, update);
            _context.SaveChanges();
            return _mapper.Map<KartaModel>(update);
        }
    }
}
