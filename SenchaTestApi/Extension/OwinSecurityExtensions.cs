using System;
using System.Net;
using Owin;

namespace SenchaTestApi.Extension
{
    public static class OwinSecurityExtensions
    {
        public static IAppBuilder UseAllowHttpsOnly(this IAppBuilder appBuilder)
        {
            return appBuilder.Use(async (context, next) =>
            {
                if (context.Request.Scheme != Uri.UriSchemeHttps)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                }
                else
                {
                    await next.Invoke();
                }
            });
        }
    }
}