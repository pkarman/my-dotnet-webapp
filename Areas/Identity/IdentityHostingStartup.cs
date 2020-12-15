using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using myWebApp.Areas.Identity.Data;
using myWebApp.Data;

[assembly: HostingStartup(typeof(myWebApp.Areas.Identity.IdentityHostingStartup))]
namespace myWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BloggingContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("BloggingContext")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BloggingContext>();
            });
        }
    }
}
