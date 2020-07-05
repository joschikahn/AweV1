//Joschi du trottel
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AweV1.Areas.Identity.Data;
using AweV1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AweV1.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public AppDbContext() { }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            Thesis thesis1 = new Thesis()
            {
                Id = 1,
                LastModified = DateTime.Now,
                Title = "Omni Channel Retail",
                Description = "Wahnsinns Arbeit",
                Status = Status.Filed,
                Registration = DateTime.Now,
                Filing = DateTime.Now,
                type = Models.Type.Bachelor,
                Summary = "Es geht um Omni Channels",
                StudentFirstName = "Tschoschi",
                StudenLastName = "Hamburger",
                Email = "joschikahn@web.de",
                StudentID = 2278467,
                Strengths = "Alles Super",
                Weaknesses = "Weak was?",
                Evaluation = "war ganz ok",
                ContentVal = 5,
                LayoutVal = 5,
                StructureVal = 5,
                StyleVal = 5,
                LiteratureVal = 5,
                DifficultyVal = 5,
                NoveltyVal = 5,
                RichnessVal = 5,
                Grade = 1
            };


            var theses = new List<Thesis>();
            theses.Add(thesis1);

            builder.Entity<Thesis>().HasData(
              thesis1 
          );

            builder.Entity<Programme>().HasData(
                new Programme() { Id = 1, Name = "Dichtael Schwarz", thesisList = theses }
            );

            
          
            builder.Entity<Supervisor>().HasData(
                new Supervisor() { 
                    Id = 1, 
                    FirstName ="Elliot",
                    LastName ="Anderson", 
                    Active = true,
                    Email = "mail@mail.mail",
                    thesisList = theses
                }
                );
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Thesis> thesis { get; set; }
        public DbSet<Supervisor> supervisors { get; set; }
        public DbSet<Programme> programme { get; set; }
    }
}
