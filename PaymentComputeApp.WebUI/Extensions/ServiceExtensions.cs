using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentComputeApp.Core.Services;
using PaymentComputeApp.DataAccess;
using PaymentComputeApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCookiePolicyOptions(this IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
        }

        public static void ConfigureMVC(this IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public static void ConfigureIdentityBuilder(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<ILoan, StudentLoanService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
