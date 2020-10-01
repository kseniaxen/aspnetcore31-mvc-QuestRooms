using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using QuestRooms.Models;

namespace QuestRooms
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        private IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<RoomsDbContext>(opts =>
            {
                opts.UseSqlServer(
                Configuration["ConnectionStrings:QuestRoomsConnection"]);
            });
            services.AddScoped<IRoomsRepository, EFRoomsRepository>();
            services.AddServerSideBlazor();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("pagination", "Rooms/Page{roomPage::regex(^[1-9]\\d*$)=1}",
                        new { Controller = "Home", action = "Index" });
                endpoints.MapControllerRoute("roominfo", "Room{QuestID}",
                        new { Controller = "Home", action = "Room" });
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}","/Admin/Index");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
