﻿// ---------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

namespace Microsoft.Azure.Devices.Applications.PredictiveMaintenance.Web
{
    using System.Web.Http;
    using global::Owin;

    public partial class Startup
    {
        public static HttpConfiguration HttpConfiguration { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            Startup.HttpConfiguration = new System.Web.Http.HttpConfiguration();

<<<<<<< HEAD
            this.ConfigureAuth(app);
            //app.MapSignalR();
=======
            this.ConfigureAuth(app, configProvider);
            this.ConfigureAutofac(app);
            //this.ConfigureWebApi(app);
>>>>>>> az_local
        }
    }
}