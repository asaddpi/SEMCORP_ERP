using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.LocalStorage;



namespace TOCOMA_ERP_System.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        private ILocalStorageService _localStorageService;
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService,ILocalStorageService localStorageService)
        {
            _sessionStorageService = sessionStorageService;
            _localStorageService = localStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            //var emailAddress = await _sessionStorageService.GetItemAsync<string>("emailAddress");
            
            var emailAddress = await _localStorageService.GetItemAsync<string>("emailAddress");

            ClaimsIdentity identity;
            if (emailAddress!=null)
            {
                 identity = new ClaimsIdentity(new[]
                {
                 new Claim(ClaimTypes.Name,emailAddress),

                }, "apiauth_type");
            }
            else
            {
                 identity = new ClaimsIdentity();
            }
            //var identity = new ClaimsIdentity(new[]
            //{
            // new Claim(ClaimTypes.Name,"asaduz@tocoma.com.bd"),

            //}, "apiauth_type");
            //var user = new ClaimsPrincipal(identity);
            
            
            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }
        public void MarkUserAsAuthenticated(string emailaddress)
        {
            var identity = new ClaimsIdentity(new[]
            {
             new Claim(ClaimTypes.Name,emailaddress),

            }, "apiauth_type");
            //var user = new ClaimsPrincipal(identity);
            //var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        public void MarkUserAsLoggOut()
        {
            _sessionStorageService.RemoveItemAsync("emailAddress");
            _localStorageService.ClearAsync();
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        
    }
}
