using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
// heroku login
// git init
// heroku git:remote -a ouvrier
// git add .
// git commit -am 'better'
//heroku buildpacks:set https://github.com/jincod/dotnetcore-buildpack
//heroku buildpacks:set jincod/dotnetcore
// git push heroku master