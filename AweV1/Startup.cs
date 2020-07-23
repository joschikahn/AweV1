
using System.Threading.Tasks;
using AweV1.Areas.Identity.Data;
using AweV1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;

namespace AweV1
{
    public class Startup
    {
        private object context;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("AppDbContextConnection")));

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AppDbContextConnection")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            RotativaConfiguration.Setup(env.WebRootPath, "Rotativa"); 
            CreateUsersRoles(um, rm).Wait();
     
        }

        private async Task CreateUsersRoles(UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            AppUser user = await um.FindByNameAsync("admin@gmail.com");
            if (user == null)
            {
                user = new AppUser() { Email = "admin@gmail.com", UserName = "admin@gmail.com" };
                await um.CreateAsync(user, "Passw0rd!");
            }

            IdentityRole role = await rm.FindByNameAsync("Administrator");
            if (role == null)
            {
                role = new IdentityRole("Administrator");
                await rm.CreateAsync(role);
            }

            bool inrole = await um.IsInRoleAsync(user, "Administrator");
            if (!inrole)
                await um.AddToRoleAsync(user, "Administrator");
            return;
        }
    }
}
