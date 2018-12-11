using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVC.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MVC.Areas.Identity.IdentityHostingStartup))]
namespace MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PRPCIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PRPCIdentityDbContextConnection")));

                services.AddAuthentication().AddFacebook(facebookOptions =>
                {
                    facebookOptions.AppId = "915051392039430";
                    facebookOptions.AppSecret = "ff6dd7877bc951f1414415b4f0c5cd73";
                });

                services.AddAuthentication().AddGoogle(googleOptions =>
                {
                    googleOptions.ClientId = "227821793833-8opil5o96uss650ugpbjcjbmrs1a71lc.apps.googleusercontent.com";
                    googleOptions.ClientSecret = "8Xqv8dNuXAm-jDGCNsGX6gTV";
                });

                services.AddDefaultIdentity<PRPCUser>()
                    .AddEntityFrameworkStores<PRPCIdentityDbContext>();
            });
        }
    }
}
