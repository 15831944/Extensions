﻿namespace ClickView.Extensions.RestClient.Authenticators.OAuth.Internal.Endpoints
{
    using System.Threading.Tasks;

    internal class DefaultEndpointFactory : IAuthenticatorEndpointFactory
    {
        private readonly AuthenticatorEndpoints _endpoints;

        public DefaultEndpointFactory(AuthenticatorEndpoints endpoints)
        {
            _endpoints = endpoints;
        }

        public Task<AuthenticatorEndpoints> GetAsync()
        {
            return Task.FromResult(_endpoints);
        }
    }
}
