﻿using Microsoft.Owin;
using Owin;
using System.Globalization;

[assembly: OwinStartupAttribute(typeof(E_learning_platform.Startup))]
namespace E_learning_platform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }

    }
}
