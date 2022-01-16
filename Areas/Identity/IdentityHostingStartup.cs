using System;
using ABCbankingsystem.Areas.Identity.Data;
using ABCbankingsystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ABCbankingsystem.Areas.Identity.IdentityHostingStartup))]
namespace ABCbankingsystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ABCbankingsystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ABCbankingsystemContextConnection")));

                services.AddDefaultIdentity<ABCbankingsystemUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    })
                    .AddEntityFrameworkStores<ABCbankingsystemContext>();
            });
        }
    }
}