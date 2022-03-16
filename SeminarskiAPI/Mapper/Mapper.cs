using AutoMapper;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Mapper
{
    public class Mapper:Profile
    {
        public Mapper() 
        {
            CreateMap<Database.Autobus, eAutobusModel.AutobusiModel>().ReverseMap();
            CreateMap<AutobusInsertRequest, Database.Autobus>().ReverseMap();

            CreateMap<Database.AutobusVozac, eAutobusModel.AutobusVozacModel>().ReverseMap();
            CreateMap<AutobusVozacUpsertRequest, Database.AutobusVozac>().ReverseMap();

            CreateMap<Database.Cjenovnik, eAutobusModel.CjenovnikModel>().ReverseMap();
            CreateMap<CjenovnikInsertRequest, Database.Cjenovnik>().ReverseMap();

            CreateMap<Database.Garaza, eAutobusModel.GarazaModel>().ReverseMap();
            CreateMap<GarazaUpsertRequest, Database.Garaza>().ReverseMap();

            CreateMap<Database.Grad, eAutobusModel.GradModel>().ReverseMap();
            CreateMap<GradInsertRequest, Database.Grad>().ReverseMap();
            
            CreateMap<Database.Karta, eAutobusModel.KartaModel>().ReverseMap();
            CreateMap<KartaUpsertRequest, Database.Karta>().ReverseMap();
            
            CreateMap<Database.Kupac, eAutobusModel.KupacModel>().ReverseMap();
            CreateMap<KupacInsertRequest, Database.Kupac>().ReverseMap();
            
            CreateMap<Database.RasporedVoznje, eAutobusModel.RasporedVoznjeModel>().ReverseMap();
            CreateMap<RasporedVoznjeUpsertRequest, Database.RasporedVoznje>().ReverseMap();

            CreateMap<Database.Stanica, eAutobusModel.StanicaModel>().ReverseMap();
            CreateMap<StanicaInsertRequest, Database.Stanica>().ReverseMap();

            CreateMap<Database.TipKarte, eAutobusModel.TipKarteModel>().ReverseMap();
            CreateMap<TipKarteInsertRequest, Database.TipKarte>().ReverseMap();

            CreateMap<Database.Korisnik, eAutobusModel.KorisnikModel>().ReverseMap();
            CreateMap<KorisnikUpsertRequest, Database.Korisnik>().ReverseMap();

            CreateMap<Database.Uloge, eAutobusModel.UlogeModel>().ReverseMap();
            CreateMap<UlogeInsertRequest, Database.Uloge>().ReverseMap();



            CreateMap<Database.Vozac, eAutobusModel.VozacModel>().ReverseMap();
            CreateMap<VozacUpsertRequest, Database.Vozac>().ReverseMap();

            CreateMap<Database.VrstaKarte, eAutobusModel.VrstaKarteModel>().ReverseMap();
            CreateMap<VrstaKarteInsertRequest, Database.VrstaKarte>().ReverseMap();

            CreateMap<Database.Zona, eAutobusModel.ZonaModel>().ReverseMap();
            CreateMap<ZonaInsertRequest, Database.Zona>().ReverseMap();

            CreateMap<Database.Korisnik, eAutobusModel.VozacModel>().ReverseMap();
            CreateMap<Database.Korisnik, eAutobusModel.UpravaModel>().ReverseMap();
            CreateMap<Database.Korisnik, eAutobusModel.KupacModel>().ReverseMap();

            CreateMap<Database.KorisniciUloge, eAutobusModel.KorisniciUlogeModel>().ReverseMap();

            CreateMap<Database.KartaKupac, eAutobusModel.KartaKupacModel>().ReverseMap();
            CreateMap<KartaKupacUpsertRequest, Database.KartaKupac>().ReverseMap();

            CreateMap<Database.Recenzija, eAutobusModel.RecenzijaModel>().ReverseMap();
            CreateMap<RecenzijaUpsertRequest, Database.Recenzija>().ReverseMap();
        }
    }
}
