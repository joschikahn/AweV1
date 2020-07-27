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
                    Id = 1,
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
                    ProgrammeId = 1,
                    SupervisorId = 1
                },
                new Thesis
                {
                    Id = 200,
                    LastModified = DateTime.Now,
                    Title = "Should you put all your Processes in one Basket?",
                    Description = "RPA gilt als die aufstrebende Technologie für die Automatisierung von Prozesse. In dieser Arbeit soll eine literarische Aufarbeitung von weiteren Möglichkeiten der Prozessautomatisierung erfolgen. Zusätzlich sollen qualitative Studien die aktuelle Situation aus der Praxis gegenüberstellen. Ziel soll die Einordnung von RPA im Vergleich zu anderen Technologien sein",
                    Status = Status.Filed,
                    Registration = new DateTime(2011, 6, 10),
                    Filing = new DateTime(2015, 12, 8),
                    Bachelor = false,
                    Master = true,
                    Type = Models.Type.Master,
                    Summary = "",
                    StudentFirstName = "Claudia",
                    StudentLastName = "Stern",
                    Email = "claustern@web.de",
                    StudentID = "2278467",
                    Strengths = "",
                    Weaknesses = "",
                    Evaluation = "",

                    ProgrammeId = 200,
                    SupervisorId = 1
                }, 
                new Thesis()
                {
                    Id = 201,
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
                    ProgrammeId = 1,
                    SupervisorId = 1
                }



               );


            builder.Entity<Programme>().HasData(
                new Programme()
                {
                    Id = 1,
                    Name = "BA Wirtschaftsinformatik",
                },

                new Programme()
                {
                   Id = 200,
                   Name = "BA Wirtschaftswissenschaften",
                },

                new Programme()
                {
                   Id = 201,
                   Name = "MA Information Systems",
                },

                new Programme()
                {
                   Id = 202,
                   Name = "MA Data Science",
                });



            builder.Entity<Supervisor>().HasData(
                new Supervisor()
                {
                    Id = 1,
                    FirstName = "Markus",
                    LastName = "Schneider",
                    Active = true,
                    Email = "maschneider@mail.mail",

                },

                new Supervisor()
                {
                    Id = 200,
                    FirstName = "Giacomo",
                    LastName = "Welsch",
                    Active = true,
                    Email = "mazimmerlin@web.de",
                }, 
               
                new Supervisor()
                {
                    Id =201,
                    FirstName = "Alexander",
                    LastName = "Dürr",
                    Active = true,
                    Email = "groß@gmail.com",
                },

                new Supervisor()
                {
                    Id = 202,
                    FirstName = "Lucia",
                    LastName = "Bianco",
                    Active = false,
                    Email = "lucian.bianco@gmx.com",
                });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);*/
        }
    }
}
