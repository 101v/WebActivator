﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebActivation;
using System.Web.Routing;
using System.Web.Mvc;

namespace TestLibrary {
    public class MyStartupCode : IApplicationStart {
        public void Start() {
            var routes = RouteTable.Routes;

            routes.MapRoute(
                "Foo", // Route name
                "CoolHome", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}
