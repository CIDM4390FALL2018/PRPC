using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;

 

namespace MVC
{
    public class Startup
    {
         public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
   
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //added here, I think just need to figure out name of dbcontext and application user and identity role
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<prpcDbContext>()
                    .AddDefaultTokenProviders();
                    //end of added
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
                })
                //.AddCookie()
                /* .AddGoogle(options =>
                {
                    options.ConsumerKey = "662777637634-vb4qdskhiv55ftcchc2drujkqv03om6b.apps.googleusercontent.com ";
                    options.ConsumerSecret = "jiUJDFe0aW8oabhuIkWPZMwp";
                });
                */
                
                /*.AddCookie()*/
                .AddCookie(options =>
                {
                    options.LoginPath ="/login";
                    //options.LogoutPath ="/logout";
                })
                .AddFacebook(facebookOptions =>
                {
                   // string AppId = "2033389120292330";
                   // facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                    facebookOptions.AppId = "2033389120292330";
                    facebookOptions.AppSecret = "96fb05cabb7c05b288ac0548be27d475";
                    /* app.UseCookieAuthentication(new CookieAuthenticationOptions{
                    LoginPath = new PathString("/Index/"),
                   // AuthenticationType = "Facebook Authentication",
                },
                    )*/
                   // RedirectToPageResult = "https://localhost:5001";
                });
             services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
//added below here, didn't fix it
             services.ConfigureApplicationCookie(options =>
             {
                 options.LoginPath = "/Identity/Account/Login";
                 options.SlidingExpiration = true;
             });
//end of adding
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        
        //Added below
           /*  services.AddIdentity<PRPCUser, user>()
                .AddEntityFrameworkStores<PRPCRepositoryDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
         */
        //til here
        }
         
         //added here
       /* public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddAuthentication (this Microsoft.Extensions.DependencyInjection.IServiceCollection services){
            
        }
        public static Microsoft.AspNetCore.Authentication.AuthenticationBuilder AddAuthentication (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.AspNetCore.Authentication.AuthenticationOptions> configureOptions){

        }
        public static Microsoft.AspNetCore.Authentication.AuthenticationBuilder AddAuthentication (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string defaultScheme){}
*/
//to here
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

           /*  app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            */
            app.Run(async (context) =>
            {
                if (!context.User.Identity.IsAuthenticated)
                {
                    await context.ChallengeAsync();
                }
                await context.Response.WriteAsync("Hello "+context.User.Identity.Name+"!\r");
            });
        }
        
    }
    
}
