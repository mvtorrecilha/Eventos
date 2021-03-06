﻿using Eventos.Services.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Eventos.Tests.ApiTest.IntegrationTests
{
    public class Environment
    {
        public static TestServer Server;
        public static HttpClient Client;

        public static void CriarServidor()
        {
            Server = new TestServer(
              new WebHostBuilder()
                .UseEnvironment("Testing")           
                .UseUrls("http://localhost:5000")
                .UseStartup<StartupTest>());

            Client = Server.CreateClient();
        }
    }
}
