using eAutobusModel;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace eAutobus.Mobile
{
    public class APIService
    {
        private string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }
#if DEBUG
        string _apiUrl = "http://localhost:19070/api";
#endif
#if RELEASE
        private string _apiUrl="https://mywebsite.com";
#endif
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
         {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Netačan username ili password!", "Uredu");
                }
                throw;
            }

        
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
    
    }
}

