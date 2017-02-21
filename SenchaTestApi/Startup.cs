using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using Microsoft.Owin.Cors;
using Owin;
using SenchaTestApi.Extension;

namespace SenchaTestApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.Formatters.Clear();
            httpConfiguration.Formatters.Add(new JsonMediaTypeFormatter());
            httpConfiguration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.LocalOnly;
            httpConfiguration.MapHttpAttributeRoutes();

            app.UseCors(CorsOptions.AllowAll);
            app.UseAllowHttpsOnly().UseWebApi(httpConfiguration);
        }
    }
}