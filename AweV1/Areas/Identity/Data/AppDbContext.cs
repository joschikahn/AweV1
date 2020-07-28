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
                    Bachelor = false,
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
                    Bachelor = true,
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
                    Title = "Strukturierte Literaturanalyse zu Predictive Analytics in der Information Systems-Forschung",
                    Description = "In der internationalen Information Systems-Forschung wird erklärende Statistik häufig mit vorhersagender Statistik verwechselt. Im Rahmen dieser Abschlussarbeit soll der Gebrauch vorhersagender Statistik daher strukturiert analysiert werden.",
                    Status = Status.Free,
                    Bachelor = true,
                    Master = false,
                    SupervisorId = 200
                },

                new Thesis()
                {
                    Id = 202,
                    LastModified = DateTime.Now,
                    Title = "Ist Quantencomputing disruptiv?",
                    Description = "Eine der derzeit bedeutsamsten „Emerging Technologies“ ist das Quantencomputing (QC), welches eine Steigerung der Verarbeitungskapazität von Rechnern um mehrere Größenordnungen verspricht. Aus Anwendersicht ergibt sich dadurch jedoch nicht nur ein enormes Effizienzsteigerungspotenzial. Vielmehr würde QC auch völlig neue Anwendungen ermöglichen, die bislang aufgrund ihrer Rechenkomplexität nicht implementierbar sind. Umgekehrt wäre QC aber auch eine Gefahr für heutige Anwendungen, die auf eben dieser Komplexität basieren, bspw. Kryptowährungen wie der Bitcoin. Ziel der Arbeit ist es vor diesem Hintergrund, anhand einer Literaturanalyse die technischen Grundlagen und den aktuellen Stand der Entwicklung von Quantencomputern zusammenzufassen. Andererseits soll diskutiert werden, inwiefern QC wie oben skizziert ein disruptives Potenzial besitzt. Wird das Thema als Master Thesis bearbeitet, sollen auch aktuelle Angebote für die QC-Entwicklung evaluiert werden (z.B. IBM Qiskit).",
                    Status = Status.Reserved,
                    Bachelor = true,
                    Master = true,
                    SupervisorId = 202
                },

                new Thesis()
                {
                    Id = 203,
                    LastModified = DateTime.Now,
                    Title = "Was macht Kollaborationsanwendungen aus? - Entwicklung einer Taxonomie",
                    Description = "Wenden Sie sich bei Interesse bitte direkt an mich, ich erkläre Ihnen die Details zu dem Thema. - Giacomo Welsch",
                    Status = Status.Registered,
                    Registration = new DateTime(2020, 7, 29),
                    Bachelor = true,
                    Master = true,
                    Type = Models.Type.Bachelor,
                    StudentFirstName = "Leon",
                    StudentLastName = "Manninger",
                    Email = "leon.89@web.de",
                    StudentID = "WS798456",
                    ProgrammeId = 202,
                    SupervisorId = 200
                },
                new Thesis()
                {
                    Id = 204,
                    LastModified = DateTime.Now,
                    Title = "Ein konsolidiertes Business Model Canvas über Blockchain basierte Startups: Erkenntnisse aus Initital Coin Offerings",
                    Description = "Die Blockchain-Technologie kann als eine verteilte Ledger-Datenbank beschrieben werden, die das Potenzial hat, traditionelle Geschäftsmodelle zu verändern. Ein üblicher Weg für solche Startups, sich selbst zu finanzieren, sind Initial Coin Offerings (ICOs) - eine Art Crowdfunding ähnlich wie Initial Public Offerings (IPOs). Im Gegensatz zu IPOs zielen ICOs jedoch darauf ab, Kapital durch die Schaffung und den Verkauf einer virtuellen Währung zu beschaffen, die ihren Inhabern eine Reihe von Rechten, einschließlich des Zugangs zu einer Plattform, gewährt und auf dem Sekundärmarkt weiterverkauft werden kann.",
                    Status = Status.Graded,
                    Registration = new DateTime(2020, 7, 25),
                    Filing = new DateTime(2020, 10, 23),
                    Bachelor = true,
                    Master = true,
                    Type = Models.Type.Bachelor,
                    Summary = "Ein ausgearbeitetes Businessmodel Canva über ICOs (Initial Coin Offerings)",
                    StudentFirstName = "Leonie",
                    StudentLastName = "Merdinger",
                    Email = "leonie.merdinger@uni-wuerzburg.de",
                    StudentID = "561321",
                    Strengths = "Gute Strukturierung der Arbeit mit guten praxisnähe. Saubere Arbeit in der Art und Weise des Zitierens und der Quellenarbeit.",
                    Weaknesses = "Abstract und Fazit ausbaufähig, zudem ist die Synthese mangelhaft",
                    Evaluation = "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke.",
                    ContentVal = 2,
                    LayoutVal = 3,
                    StructureVal = 5,
                    StyleVal = 2,
                    LiteratureVal = 5,
                    DifficultyVal = 5,
                    NoveltyVal = 3,
                    RichnessVal = 2,
                    Grade = Grade.Note_20,
                    ProgrammeId = 201,
                    SupervisorId = 1
                },
                new Thesis()
                {
                    Id = 205,
                    LastModified = DateTime.Now,
                    Title = "LegalTech: Der Markt für digitale Rechtsdienstleistungen",
                    Description = "Im Gegensatz zu früheren Automatiserungswellen ermöglichen Technologien wie das maschinelle Lernen zunehmend auch die Digitalisierung von \"white collar\"-Jobs, für die vermeintlich hohe Qualifikationen und spezifisch menschliche Fähigkeiten bislang als notwendige Voraussetzung angesehen wurden. Ein prominentes Beispiel sind Rechtsdienstleistungen wie z.B. die Beratung durch einen Anwalt, die Erstellung eines Testaments oder die Durchsetzung von Flugpassagierrechten. Ziel der Arbeit ist es, einen Überblick über Anwendungsgebiete und Projekte/Startups zu geben und mögliche Hürden für die breite Adoption (z.B. gesetzliche Regularien) zu diskutieren.",
                    Status = Status.Free,
                    Bachelor = true,
                    Master = false,
                    SupervisorId = 202
                },
                new Thesis()
                {
                    Id = 206,
                    LastModified = DateTime.Now,
                    Title = "Podcast Streaming via Amazon Alexa: Implementierung einer intelligenten Dialogführung mittels Textmining",
                    Description = "Im Rahmen der Arbeit soll ein bestehender Amazon Alexa Skill zum Streaming eines Podcasts weiterentwickelt werden. Ziel ist die Optimierung des Dialogs, den Konsumenten mit dem Sprachassistenten führen müssen, um zu den gewünschten Inhalten (d.h. Podcast-Folgen) zu gelangen. Relevante Themen sind hier Topic-/Schlagwort-Suche, personalisierte Vorschläge/Recommendations und UI-Verbesserungen.",
                    Status = Status.Free,
                    Bachelor = false,
                    Master = true,
                    SupervisorId = 200
                },
                new Thesis()
                {
                    Id = 207,
                    LastModified = DateTime.Now,
                    Title = "Machine Learning zur Betrugserkennung auf ICO-Plattformen",
                    Description = "Aufgrund der Art von ICO-Plattformen stellt Betrug ein bedeutendes Problem dar, da die ICO-Plattformen durch die typischen Merkmale des Internets gekennzeichnet sind. Einige Emittenten von ICOs täuschen ihre Geschäfte vor und veruntreuen das gesammelte, während einige Investoren die Anonymität nutzen, um \"Pump-and-Dump\"-Systeme durchzuführen. Schätzungsweise 10% des mit ICOs gesammelten Geldes wurden 2017 gestohlen (EY, 2017). Um das Vertrauen der Investoren zu gewinnen, stellen die Gründer so viele Informationen wie möglich zur Verfügung. Eine der Hauptinformationsquellen für Investoren sind ICO-Listing Webseiten wie z. B. icobench.com. Im Rahmen der Masterarbeit sollen Machine-Learning Modelle erstellt und evaluiert werden, um eine frühzeitige Erkennung von Betrug zu ermöglichen. Zum Training der verschiedenen Modelle erhalten Sie einen umfangreichen Datensatz.",
                    Status = Status.Graded,
                    Registration = new DateTime(2020, 7, 25),
                    Filing = new DateTime(2020, 10, 23),
                    Bachelor = true,
                    Master = true,
                    Type = Models.Type.Bachelor,
                    Summary = "Prädiktives Modell zur Fraud detection mit sckit-learn",
                    StudentFirstName = "Justus",
                    StudentLastName = "Ameling",
                    Email = "amelingjustus@gmail.com",
                    StudentID = "1234567",
                    Strengths = "Gute Strukturierung der Arbeit",
                    Weaknesses = "Abstract ausbaufähig ",
                    Evaluation = "Unterm Strich eine gute strukturierte Arbeit",
                    ContentVal = 4,
                    LayoutVal = 5,
                    StructureVal = 5,
                    StyleVal = 4,
                    LiteratureVal = 5,
                    DifficultyVal = 5,
                    NoveltyVal = 3,
                    RichnessVal = 5,
                    Grade = Grade.Note_10,
                    ProgrammeId = 200,
                    SupervisorId = 201
                },
                 new Thesis()
                 {
                     Id = 208,
                     LastModified = DateTime.Now,
                     Title = "The impact of twitter adoption of lawmakers´ voting orientation",
                     Description = "Beschäftigt sich mit dem Einfluss von Twitter auf die Entscheidungen der Legeslative. Arbeit des Jahres 1994.",
                     Status = Status.Graded,
                     Registration = new DateTime(2020, 7, 25),
                     Filing = new DateTime(2020, 10, 23),
                     Bachelor = true,
                     Master = true,
                     Type = Models.Type.Bachelor,
                     Summary = "Prädiktives Modell zur Fraud detection mit sckit-learn",
                     StudentFirstName = "David",
                     StudentLastName = "Breiding",
                     Email = "davidbreiding@gmail.com",
                     StudentID = "0004567",
                     Strengths = "Gute Strukturierung der Arbeit",
                     Weaknesses = "Abstract ausbaufähig ",
                     Evaluation = "Unterm Strich eine gute strukturierte Arbeit",
                     ContentVal = 4,
                     LayoutVal = 5,
                     StructureVal = 5,
                     StyleVal = 4,
                     LiteratureVal = 5,
                     DifficultyVal = 5,
                     NoveltyVal = 3,
                     RichnessVal = 5,
                     Grade = Grade.Note_10,
                     ProgrammeId = 200,
                     SupervisorId = 201
                 },
                new Thesis()
                {
                    Id = 209,
                    LastModified = DateTime.Now,
                    Title = "AJAX X(ML)treme good? Or J(SON)UST standard.",
                    Description = "Beschäftigt sich mit der Frage, ob die Verwendung einer XML Struktur noch zeitgemäß ist oder ob JSON dies ablösen sollte.",
                    Status = Status.Graded,
                    Registration = new DateTime(2020, 7, 25),
                    Filing = new DateTime(2020, 10, 23),
                    Bachelor = true,
                    Master = true,
                    Type = Models.Type.Bachelor,
                    Summary = "XML oder JSON",
                    StudentFirstName = "David",
                    StudentLastName = "Breiding",
                    Email = "davidbreiding@gmail.com",
                    StudentID = "0004567",
                    Strengths = "Gute Strukturierung der Arbeit",
                    Weaknesses = "Abstract ausbaufähig ",
                    Evaluation = "Unterm Strich eine gute strukturierte Arbeit",
                    ContentVal = 4,
                    LayoutVal = 5,
                    StructureVal = 5,
                    StyleVal = 4,
                    LiteratureVal = 5,
                    DifficultyVal = 5,
                    NoveltyVal = 3,
                    RichnessVal = 5,
                    Grade = Grade.Note_10,
                    ProgrammeId = 200,
                    SupervisorId = 201
                },
                new Thesis()
                {
                    Id = 210,
                    LastModified = DateTime.Now,
                    Title = "Digitalisierung der Weinindustrie - IOT an jeder Rebe.",
                    Description = "Beschäftigt sich mit der Frage, ob es tatsächlich an jeder Rebe eine Netzwerkverbindung bedarf.  Eine praxisnahe Arbeit am Weingut Weiß.",
                    Status = Status.Registered,
                    Registration = new DateTime(2020, 7, 29),
                    Bachelor = false,
                    Master = true,
                    Type = Models.Type.Bachelor,
                    StudentFirstName = "Michael",
                    StudentLastName = "Weiß",
                    Email = "michiweiß@web.de",
                    StudentID = "ac498456",
                    ProgrammeId = 202,
                    SupervisorId = 200
                },
                new Thesis()
                {
                    Id = 211,
                    LastModified = DateTime.Now,
                    Title = "Augustus Intelligence - mehr Schein als Sein?",
                    Description = "Erst kürzlich ist der Politiker Philipp Amthor durch It-affinität aufgefallen. In dieser Arbeit soll die Entwicklung der großen Interesse an Ki-Anwendungen beleuchtet werden.",
                    Status = Status.Reserved,
                    Bachelor = true,
                    Master = true,
                    SupervisorId = 202
                });


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
                    Email = "giacomoWelsch@web.de",
                },

                new Supervisor()
                {
                    Id = 201,
                    FirstName = "Alexander",
                    LastName = "Dürr",
                    Active = true,
                    Email = "dürr@gmail.com",
                },



                new Supervisor()
                {
                    Id = 202,
                    FirstName = "Frédéric",
                    LastName = "Thiesse",
                    Active = true,
                    Email = "frederic.thiesse@uni-wuerzburg.de",
                },

                new Supervisor()
                {
                    Id = 203,
                    FirstName = "Charlotte",
                    LastName = "Maurer",
                    Active = false,
                    Email = "mau789@gmail.com",
                });

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);*/
        }
    }
}
