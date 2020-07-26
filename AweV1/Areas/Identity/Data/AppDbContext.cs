using AweV1.Areas.Identity.Data;
using AweV1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AweV1.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Thesis> thesis { get; set; }
        public DbSet<Supervisor> supervisors { get; set; }
        public DbSet<Programme> programme { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Thesis>().HasData(
                new Thesis()
               {
                Id = 100,
                LastModified = DateTime.Now,
                Title = "Omni Channel Retail",
                Description = "In diesem Paper geht es um verschiedene Vertriebskanäle",
                Status = Status.Graded,
                Registration = DateTime.Now,
                Filing = DateTime.Now,
                Bachelor = true,
                Master = true,
                Type = Models.Type.Bachelor,
                Summary = "Omni Channel Retail eignet sich besonders für große Unternehemen. Eher ungeeignet in der Lebensmittelbranche.",
                StudentFirstName = "Josua",
                StudentLastName = "Homberger",
                Email = "joschikahn@web.de",
                StudentID = "2278467",
                Strengths = "Quellenarbeit, Zitieren und Synthese sind hervorragned ausgearbeitet.",
                Weaknesses = "Abstract und Fazit ausbaufähig.",
                Evaluation = "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke zum Thema Omni Channel Retail.",
                ContentVal = 5,
                LayoutVal = 5,
                StructureVal = 5,
                StyleVal = 5,
                LiteratureVal = 5,
                DifficultyVal = 5,
                NoveltyVal = 5,
                RichnessVal = 5,
                Grade = Grade.Note_10,
                ProgrammeId = 100,
                SupervisorId = 100
            });


            builder.Entity<Programme>().HasData(
                new Programme()
                {
                    Id = 100,
                    Name = "BA Wirtschaftsinformatik",

                });



            builder.Entity<Supervisor>().HasData(
                new Supervisor()
                {
                    Id = 100,
                    FirstName = "Markus",
                    LastName = "Schneider",
                    Active = true,
                    Email = "maschneider@mail.mail",

                });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);*/
        }
    }
}
