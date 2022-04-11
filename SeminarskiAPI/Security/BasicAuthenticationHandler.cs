using eAutobusModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisnikService _korisnikService;
        private readonly ILoginService _loginService;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock,IKorisnikService korisnikService, ILoginService loginService) : base(options, logger, encoder, clock)
        {
            _korisnikService = korisnikService;
            _loginService = loginService;
        }

        bool _korisnik = false;
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
            {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing authorization header");
            }
            KorisnikModel user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var userName = credentials[0];
                var password = credentials[1];
                user = await _loginService.Autentificiraj(userName, password);
                //if (user==null)
                //{
                //    user = _loginService.AutentificirajKupca(userName, password);
                //    _korisnik = true;
                //}
            }
            catch 
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }
            if (user != null)
            {

                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                new Claim(ClaimTypes.Name, user.Ime),
                };
                
                claims.Add(new Claim(ClaimTypes.Role, user.Uloge.Naziv));


                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return AuthenticateResult.Success(ticket);

            }
            return AuthenticateResult.Fail("");
        }
    }
}
