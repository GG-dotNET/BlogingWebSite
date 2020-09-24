using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySite1.Domain;
using MySite1.Domain.Repositories.Abstract;
using MySite1.Domain.Repositories.EntityFramework;
using MySite1.Service;

namespace MySite1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services)
        {
            // ïîäêëþ÷àåì êîíôèã èç appsettings.json
            Configuration.Bind("Project", new Config());


            // ïîäêëþ÷àåì íóæíûé ôóíêöèîíàë ïðèëîæåíèÿ â êà÷åñòâå ñåðâèñîâ
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();


            // ïîäêëþ÷àåì êîíòåêñò ÁÄ
            services.AddDbContext<AppDbContext>(x =>
                x.UseSqlServer(Config.ConnectionString));


            // íàñòðàèâàåì identity ñèñòåìó
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            // íàñòðàèâàåì authentification cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });


            // íàñòðàèâàåì ïîëèòèêó àâòîðèçàöèè äëÿ Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });


            // Äîáàâëÿåì ïîääåðæêó  êîíòðîëëåðîâ è ïðåäñòàâëåíèé MVC
            services.AddControllersWithViews(x =>
                {
                    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                })
                // âûñòàâëÿåì ñîâìåñòèìîñòü ñ asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Ïäêëþ÷àåì ïîääåðæêó ñòàòè÷íûõ ôàéëîâ â ïðèëîæåíèè (css, js è ò.ä.)
            app.UseStaticFiles();

            app.UseRouting();

            // ïîäêëþ÷àåì àóòåíòèôèêàöèþ è àâòîðèçàöèþ
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
