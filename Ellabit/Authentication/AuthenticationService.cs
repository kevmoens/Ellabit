using System;
using Blazored.LocalStorage;
using Ellabit.Models;

namespace Ellabit.Authentication
{
    public class AuthenticationService
    {
        private readonly HttpClient httpClient;
        private readonly AuthStateProvider authStateProvider;
        private readonly ILocalStorageService localStorageService;

        public AuthenticationService(HttpClient httpClient,
            AuthStateProvider authStateProvider,
            ILocalStorageService localStorageService)
        {
            this.httpClient = httpClient;
            this.authStateProvider = authStateProvider;
            this.localStorageService = localStorageService;
        }
        //public async Task<AuthenticatedUserModel> Login(AuthenticationUserModel authenticationUserModel)
        //{

        //}
    }
}

