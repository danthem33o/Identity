using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Identity.Api.Utils
{
    public static class ReplaceRedirectorWithStatusCode
    {
        public static Func<RedirectContext<CookieAuthenticationOptions>, Task> Replace(HttpStatusCode statusCode) => context =>
        {
            // Adapted from https://stackoverflow.com/questions/42030137/suppress-redirect-on-api-urls-in-asp-net-core
            context.Response.StatusCode = (int)statusCode;
            return Task.CompletedTask;
        };
    }
}
