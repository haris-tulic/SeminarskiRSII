using Acr.UserDialogs;
using eAutobus.Mobile.Models;
using eAutobus.Mobile.Views;
using eAutobusModel;
using eAutobusModel.Requests;
using Stripe;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace eAutobus.Mobile.ViewModels
{
    public class PlatiOnlineViewModel : BaseViewModel
    {
        private readonly APIService _tipKarte = new APIService("TipKarte");
        private readonly APIService _vrstaKarte = new APIService("VrstaKarte");
        private readonly APIService _kupac = new APIService("Kupac");
        private readonly APIService _kartaK = new APIService("Karta");
        private readonly APIService _platiKartu = new APIService("PlatiKartu");



        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    if (str.Length > 10 && c != ' ')
                        return false;
                }
            }

            return true;
        }
        //private readonly INavigation Navigation;
        public ICommand PlatiCommand { get; set; }

        public PlatiOnlineViewModel()
        {
            PlatiCommand = new Command(async () => await KupiKartuOnline());

        }
        


        private string StripeTestApiKey = "pk_test_51KeOHDDgK4DOihzEMKoCVOhLxa7SXMmuxCzkG7muYEGV4a0SZX34DIWMefCFxDH3oYpTgICyWpVIvD9Qvf8kDo4s00XKS3XzSl";

        private CreditCard _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string _number;
        private string _cvc;
        public KartaModel _novaKarta;
        public PlatiKartuModel _karta;
        private KartaModel _odabranaKarta;
        private KupacModel _kupacK;
        private string _tipKarteNaziv = string.Empty;
        private string _vrstaKarteNaziv = string.Empty;
        private string _imeKupca = string.Empty;
        private string _email = string.Empty;
        private DateTime _datumIzdavanja;
        private DateTime _datumVazenja;

        public DateTime DatumIzdavanja
        {
            get
            {
                return _datumIzdavanja;
            }
            set
            {
                SetProperty(ref _datumIzdavanja, value);
            }
        }

        public DateTime DatumVazenja
        {
            get
            {
                return _datumVazenja;
            }
            set
            {
                SetProperty(ref _datumVazenja, value);
            }
        }
        public KupacModel Kupac
        {
            get { return _kupacK; }
            set { SetProperty(ref _kupacK, value); }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                SetProperty(ref _email, value);
            }
        }

        public string ImeKupca
        {
            get { return _imeKupca; }
            set { SetProperty(ref _imeKupca, value); }
        }
        public string TipKarteNaziv
        {
            get { return _tipKarteNaziv; }
            set
            {
                SetProperty(ref _tipKarteNaziv, value);
            }
        }
        public string VrstaKarteNaziv
        {
            get { return _vrstaKarteNaziv; }
            set
            {
                SetProperty(ref _vrstaKarteNaziv, value);
            }
        }

        private double _ukupnaCijena;
        public double UkupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public string Cvc
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }
        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }
        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }
        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        public CreditCard CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }
        public KartaModel Karta
        {
            get { return _odabranaKarta; }
            set
            {
                SetProperty(ref _odabranaKarta, value);
            }
        }
        public async void UcitajPodatke()
        {
            var tipKarte = await _tipKarte.GetById<TipKarteModel>(_novaKarta.TipKarteID);
            var vrstaKarte = await _vrstaKarte.GetById<VrstaKarteModel>(_novaKarta.VrstaKarteID);
            var kupac = await _kupac.GetById<KupacModel>(_novaKarta.KupacID);
            var karta = await _kartaK.GetById<KartaModel>(_novaKarta.KartaID);
            Kupac = kupac;
            UkupnaCijena = _novaKarta.Cijena;
            ImeKupca = kupac.Ime + " " + kupac.Prezime;
            TipKarteNaziv = tipKarte.Naziv;
            VrstaKarteNaziv = vrstaKarte.Naziv;
            if (!string.IsNullOrEmpty(kupac.Email))
            {
                Email = kupac.Email;
            }
            Karta = karta;

            DatumIzdavanja = _novaKarta.DatumVadjenjaKarte;
            DatumVazenja = _novaKarta.DatumVazenjaKarte;
        }


        public async Task<string> CreateTokenAsync()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;

                var Tokenoptions = new TokenCreateOptions()
                {
                    Card = new TokenCardOptions()
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = ImeKupca, //kupac ime i prezime
                        AddressLine1 = "Orašje L21",
                        AddressLine2 = "11",
                        AddressCity = "Konjic",
                        AddressZip = "88400",
                        AddressState = "Konjic12",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "usd",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return await Task.FromResult(stripeToken.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<bool> MakePaymentAsync(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51KeOHDDgK4DOihzEO7yRFmzgc0GjCjmAzgAzwc5ZYoTtFAFVQ0h89JNx0yER0cM1TjdI18TPOJclgMVWUBS5p34P00N57vXNgc";

                var options = new ChargeCreateOptions();

                options.Amount = Convert.ToInt64(UkupnaCijena) * 100; //cijena karte
                options.Currency = "usd";
                options.Description = TipKarteNaziv + " " + VrstaKarteNaziv; //naziv karte
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                if (!string.IsNullOrEmpty(Email))
                {
                    options.ReceiptEmail = Email.ToString();
                }

                var service = new ChargeService();
                Charge charge = service.Create(options);
                //UserDialogs.Instance.Alert("Plaćanje uspješno!"); // na bosanski
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.Write(TipKarteNaziv + " " + VrstaKarteNaziv + " (CreateCharge)" + ex.Message); //naziv karte
                throw ex;
            }
        }

        public async Task KupiKartuOnline()
        {
            if (ExpMonth == null || ExpMonth == "" || ExpYear == null || ExpYear == "" || Number == null || Number == "" || Cvc == null || Cvc == "")
            {
                //UserDialogs.Instance.Alert("You have to fill all fields!", "Payment failed", "OK");
                return;
            }
            if (ExpMonth != null || ExpMonth != "" || ExpYear != null || ExpYear != "" || Number != null || Number != "" || Cvc != null || Cvc != "")
            {
                if (!IsDigitsOnly(ExpMonth) || !IsDigitsOnly(ExpMonth) || !IsDigitsOnly(Number) || !IsDigitsOnly(Cvc))
                {
                   // UserDialogs.Instance.Alert("You can't use letters!", "Payment failed", "OK");
                    return;
                }
            }
            CreditCardModel = new CreditCard();
            CreditCardModel.ExpMonth = (int)Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = (int)Convert.ToInt64(ExpYear);
            CreditCardModel.Number = Number;
            CreditCardModel.Cvc = Cvc;
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                //UserDialogs.Instance.ShowLoading("Procesuiranje uplate ...",MaskType.Black); // na bosanski
                await Task.Run(async () =>
                {
                    var Token = CreateTokenAsync();
                    Console.Write(TipKarteNaziv + " " + VrstaKarteNaziv + "Token :" + Token); //karta naziv
                                if (Token.ToString() != null)
                    {
                        IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                    }
                    else
                    {
                       // UserDialogs.Instance.Alert("Loši kredencijali", null, "OK"); // na bosanski
                    }
                });
            }
            catch (Exception ex)
            {
               // UserDialogs.Instance.HideLoading();
                //UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write(TipKarteNaziv + " " + VrstaKarteNaziv + ex.Message); // karza naziv
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    var request = new PlatiKartuUpsertRequest()
                    {
                        KupacID = Kupac.KupacID,
                        KartaID = Karta.KartaID,
                        Cijena = UkupnaCijena,
                        JeLiPlacena = true,
                        DatumVadjenjaKarte=DatumIzdavanja,
                        DatumVazenjaKarte=DatumVazenja,
                    };

                    //pozvati servis za add
                    await _platiKartu.Insert<PlatiKartuModel>(request);
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Uspješno","Zahvaljujemo vam se na uspješnoj kupovini!","Uredu");
                    await Xamarin.Forms.Application.Current.MainPage.Navigation.PopToRootAsync();
                    // skontati gdje da te redirect nakon kupovine
                    Console.Write(TipKarteNaziv + " " + VrstaKarteNaziv + "Uplata uspješna"); // karta naziv
                    
                    //UserDialogs.Instance.HideLoading();

                }
                else
                {
                    //UserDialogs.Instance.HideLoading();
                    //UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Upozorenje","Kartu nije moguće platiti!","Uredu");

                    Console.Write(TipKarteNaziv + " " + VrstaKarteNaziv + "Uplata neuspješna "); // karta naziv
                }
            }
        }
    }


}




