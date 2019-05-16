﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace KavaDocsUserManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateWebHostBuilder(args);
            builder.Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {

            var builder = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
            //.UseIIS()
            //.UseHttpSys(options =>
            //{
            //    options.Authentication.Schemes = AuthenticationSchemes.None;
            //    options.Authentication.AllowAnonymous = true;
            //    options.MaxConnections = 100;
            //    options.MaxRequestBodySize = 30000000;
            //    options.UrlPrefixes.Add("http://localhost:5002");
            //})


            return builder;

        }
    }
}