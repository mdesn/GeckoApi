using System;
using RestSharp;
using RestSharp.Authenticators;

namespace TradeGeckoApi.Service
{
    public interface IAuthenticationService
    {
        void SetAuthorizeCode(string code);
        IAuthenticator CreateRequestAuthenticator();
        Uri GenerateAuthorizeUrl();
    }
}