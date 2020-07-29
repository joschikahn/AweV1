﻿// <auto-generated />
using System;
using AweV1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AweV1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200728212052_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AweV1.Areas.Identity.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AweV1.Models.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("programme");

                    b.HasData(
                        new { Id = 1, Name = "BA Wirtschaftsinformatik" },
                        new { Id = 200, Name = "BA Wirtschaftswissenschaften" },
                        new { Id = 201, Name = "MA Information Systems" },
                        new { Id = 202, Name = "MA Data Science" }
                    );
                });

            modelBuilder.Entity("AweV1.Models.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("supervisors");

                    b.HasData(
                        new { Id = 1, Active = true, Email = "maschneider@mail.mail", FirstName = "Markus", LastName = "Schneider" },
                        new { Id = 200, Active = true, Email = "giacomoWelsch@web.de", FirstName = "Giacomo", LastName = "Welsch" },
                        new { Id = 201, Active = true, Email = "dürr@gmail.com", FirstName = "Alexander", LastName = "Dürr" },
                        new { Id = 202, Active = true, Email = "frederic.thiesse@uni-wuerzburg.de", FirstName = "Frédéric", LastName = "Thiesse" },
                        new { Id = 203, Active = false, Email = "mau789@gmail.com", FirstName = "Charlotte", LastName = "Maurer" }
                    );
                });

            modelBuilder.Entity("AweV1.Models.Thesis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bachelor");

                    b.Property<int?>("ContentVal");

                    b.Property<int>("ContentWt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("DifficultyVal");

                    b.Property<int>("DifficultyWt");

                    b.Property<string>("Email");

                    b.Property<string>("Evaluation");

                    b.Property<DateTime?>("Filing");

                    b.Property<int?>("Grade");

                    b.Property<DateTime>("LastModified");

                    b.Property<int?>("LayoutVal");

                    b.Property<int>("LayoutWt");

                    b.Property<int?>("LiteratureVal");

                    b.Property<int>("LiteratureWt");

                    b.Property<bool>("Master");

                    b.Property<int?>("NoveltyVal");

                    b.Property<int>("NoveltyWt");

                    b.Property<int?>("ProgrammeId");

                    b.Property<DateTime?>("Registration");

                    b.Property<int?>("RichnessVal");

                    b.Property<int>("RichnessWt");

                    b.Property<int>("Status");

                    b.Property<string>("Strengths");

                    b.Property<int?>("StructureVal");

                    b.Property<int>("StructureWt");

                    b.Property<string>("StudentFirstName");

                    b.Property<string>("StudentID");

                    b.Property<string>("StudentLastName");

                    b.Property<int?>("StyleVal");

                    b.Property<int>("StyleWt");

                    b.Property<string>("Summary");

                    b.Property<int>("SupervisorId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int?>("Type");

                    b.Property<byte[]>("UploadFile");

                    b.Property<string>("Weaknesses");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammeId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("thesis");

                    b.HasData(
                        new { Id = 1, Bachelor = false, ContentVal = 5, ContentWt = 30, Description = "In diesem Paper geht es um verschiedene Vertriebskanäle", DifficultyVal = 5, DifficultyWt = 5, Email = "joschikahn@web.de", Evaluation = "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke zum Thema Omni Channel Retail.", Filing = new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local), Grade = 1, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local), LayoutVal = 5, LayoutWt = 15, LiteratureVal = 5, LiteratureWt = 10, Master = true, NoveltyVal = 5, NoveltyWt = 10, ProgrammeId = 1, Registration = new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local), RichnessVal = 5, RichnessWt = 10, Status = 4, Strengths = "Quellenarbeit, Zitieren und Synthese sind hervorragned ausgearbeitet.", StructureVal = 5, StructureWt = 10, StudentFirstName = "Josua", StudentID = "2278467", StudentLastName = "Homberger", StyleVal = 5, StyleWt = 10, Summary = "Omni Channel Retail eignet sich besonders für große Unternehemen. Eher ungeeignet in der Lebensmittelbranche.", SupervisorId = 1, Title = "Omni Channel Retail", Type = 0, Weaknesses = "Abstract und Fazit ausbaufähig." },
                        new { Id = 200, Bachelor = true, ContentWt = 30, Description = "RPA gilt als die aufstrebende Technologie für die Automatisierung von Prozesse. In dieser Arbeit soll eine literarische Aufarbeitung von weiteren Möglichkeiten der Prozessautomatisierung erfolgen. Zusätzlich sollen qualitative Studien die aktuelle Situation aus der Praxis gegenüberstellen. Ziel soll die Einordnung von RPA im Vergleich zu anderen Technologien sein", DifficultyWt = 5, Email = "claustern@web.de", Evaluation = "", Filing = new DateTime(2015, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, ProgrammeId = 200, Registration = new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessWt = 10, Status = 3, Strengths = "", StructureWt = 10, StudentFirstName = "Claudia", StudentID = "2278467", StudentLastName = "Stern", StyleWt = 10, Summary = "", SupervisorId = 1, Title = "Should you put all your Processes in one Basket?", Type = 1, Weaknesses = "" },
                        new { Id = 201, Bachelor = true, ContentWt = 30, Description = "In der internationalen Information Systems-Forschung wird erklärende Statistik häufig mit vorhersagender Statistik verwechselt. Im Rahmen dieser Abschlussarbeit soll der Gebrauch vorhersagender Statistik daher strukturiert analysiert werden.", DifficultyWt = 5, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = false, NoveltyWt = 10, RichnessWt = 10, Status = 0, StructureWt = 10, StyleWt = 10, SupervisorId = 200, Title = "Strukturierte Literaturanalyse zu Predictive Analytics in der Information Systems-Forschung" },
                        new { Id = 202, Bachelor = true, ContentWt = 30, Description = "Eine der derzeit bedeutsamsten „Emerging Technologies“ ist das Quantencomputing (QC), welches eine Steigerung der Verarbeitungskapazität von Rechnern um mehrere Größenordnungen verspricht. Aus Anwendersicht ergibt sich dadurch jedoch nicht nur ein enormes Effizienzsteigerungspotenzial. Vielmehr würde QC auch völlig neue Anwendungen ermöglichen, die bislang aufgrund ihrer Rechenkomplexität nicht implementierbar sind. Umgekehrt wäre QC aber auch eine Gefahr für heutige Anwendungen, die auf eben dieser Komplexität basieren, bspw. Kryptowährungen wie der Bitcoin. Ziel der Arbeit ist es vor diesem Hintergrund, anhand einer Literaturanalyse die technischen Grundlagen und den aktuellen Stand der Entwicklung von Quantencomputern zusammenzufassen. Andererseits soll diskutiert werden, inwiefern QC wie oben skizziert ein disruptives Potenzial besitzt. Wird das Thema als Master Thesis bearbeitet, sollen auch aktuelle Angebote für die QC-Entwicklung evaluiert werden (z.B. IBM Qiskit).", DifficultyWt = 5, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, RichnessWt = 10, Status = 1, StructureWt = 10, StyleWt = 10, SupervisorId = 202, Title = "Ist Quantencomputing disruptiv?" },
                        new { Id = 203, Bachelor = true, ContentWt = 30, Description = "Wenden Sie sich bei Interesse bitte direkt an mich, ich erkläre Ihnen die Details zu dem Thema. - Giacomo Welsch", DifficultyWt = 5, Email = "leon.89@web.de", LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, ProgrammeId = 202, Registration = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessWt = 10, Status = 2, StructureWt = 10, StudentFirstName = "Leon", StudentID = "WS798456", StudentLastName = "Manninger", StyleWt = 10, SupervisorId = 200, Title = "Was macht Kollaborationsanwendungen aus? - Entwicklung einer Taxonomie", Type = 0 },
                        new { Id = 204, Bachelor = true, ContentVal = 2, ContentWt = 30, Description = "Die Blockchain-Technologie kann als eine verteilte Ledger-Datenbank beschrieben werden, die das Potenzial hat, traditionelle Geschäftsmodelle zu verändern. Ein üblicher Weg für solche Startups, sich selbst zu finanzieren, sind Initial Coin Offerings (ICOs) - eine Art Crowdfunding ähnlich wie Initial Public Offerings (IPOs). Im Gegensatz zu IPOs zielen ICOs jedoch darauf ab, Kapital durch die Schaffung und den Verkauf einer virtuellen Währung zu beschaffen, die ihren Inhabern eine Reihe von Rechten, einschließlich des Zugangs zu einer Plattform, gewährt und auf dem Sekundärmarkt weiterverkauft werden kann.", DifficultyVal = 5, DifficultyWt = 5, Email = "leonie.merdinger@uni-wuerzburg.de", Evaluation = "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke.", Filing = new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Grade = 4, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutVal = 3, LayoutWt = 15, LiteratureVal = 5, LiteratureWt = 10, Master = true, NoveltyVal = 3, NoveltyWt = 10, ProgrammeId = 201, Registration = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessVal = 2, RichnessWt = 10, Status = 4, Strengths = "Gute Strukturierung der Arbeit mit guten praxisnähe. Saubere Arbeit in der Art und Weise des Zitierens und der Quellenarbeit.", StructureVal = 5, StructureWt = 10, StudentFirstName = "Leonie", StudentID = "561321", StudentLastName = "Merdinger", StyleVal = 2, StyleWt = 10, Summary = "Ein ausgearbeitetes Businessmodel Canva über ICOs (Initial Coin Offerings)", SupervisorId = 1, Title = "Ein konsolidiertes Business Model Canvas über Blockchain basierte Startups: Erkenntnisse aus Initital Coin Offerings", Type = 0, Weaknesses = "Abstract und Fazit ausbaufähig, zudem ist die Synthese mangelhaft" },
                        new { Id = 205, Bachelor = true, ContentWt = 30, Description = "Im Gegensatz zu früheren Automatiserungswellen ermöglichen Technologien wie das maschinelle Lernen zunehmend auch die Digitalisierung von \"white collar\"-Jobs, für die vermeintlich hohe Qualifikationen und spezifisch menschliche Fähigkeiten bislang als notwendige Voraussetzung angesehen wurden. Ein prominentes Beispiel sind Rechtsdienstleistungen wie z.B. die Beratung durch einen Anwalt, die Erstellung eines Testaments oder die Durchsetzung von Flugpassagierrechten. Ziel der Arbeit ist es, einen Überblick über Anwendungsgebiete und Projekte/Startups zu geben und mögliche Hürden für die breite Adoption (z.B. gesetzliche Regularien) zu diskutieren.", DifficultyWt = 5, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = false, NoveltyWt = 10, RichnessWt = 10, Status = 0, StructureWt = 10, StyleWt = 10, SupervisorId = 202, Title = "LegalTech: Der Markt für digitale Rechtsdienstleistungen" },
                        new { Id = 206, Bachelor = false, ContentWt = 30, Description = "Im Rahmen der Arbeit soll ein bestehender Amazon Alexa Skill zum Streaming eines Podcasts weiterentwickelt werden. Ziel ist die Optimierung des Dialogs, den Konsumenten mit dem Sprachassistenten führen müssen, um zu den gewünschten Inhalten (d.h. Podcast-Folgen) zu gelangen. Relevante Themen sind hier Topic-/Schlagwort-Suche, personalisierte Vorschläge/Recommendations und UI-Verbesserungen.", DifficultyWt = 5, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, RichnessWt = 10, Status = 0, StructureWt = 10, StyleWt = 10, SupervisorId = 200, Title = "Podcast Streaming via Amazon Alexa: Implementierung einer intelligenten Dialogführung mittels Textmining" },
                        new { Id = 207, Bachelor = true, ContentVal = 4, ContentWt = 30, Description = "Aufgrund der Art von ICO-Plattformen stellt Betrug ein bedeutendes Problem dar, da die ICO-Plattformen durch die typischen Merkmale des Internets gekennzeichnet sind. Einige Emittenten von ICOs täuschen ihre Geschäfte vor und veruntreuen das gesammelte, während einige Investoren die Anonymität nutzen, um \"Pump-and-Dump\"-Systeme durchzuführen. Schätzungsweise 10% des mit ICOs gesammelten Geldes wurden 2017 gestohlen (EY, 2017). Um das Vertrauen der Investoren zu gewinnen, stellen die Gründer so viele Informationen wie möglich zur Verfügung. Eine der Hauptinformationsquellen für Investoren sind ICO-Listing Webseiten wie z. B. icobench.com. Im Rahmen der Masterarbeit sollen Machine-Learning Modelle erstellt und evaluiert werden, um eine frühzeitige Erkennung von Betrug zu ermöglichen. Zum Training der verschiedenen Modelle erhalten Sie einen umfangreichen Datensatz.", DifficultyVal = 5, DifficultyWt = 5, Email = "amelingjustus@gmail.com", Evaluation = "Unterm Strich eine gute strukturierte Arbeit", Filing = new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Grade = 1, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutVal = 5, LayoutWt = 15, LiteratureVal = 5, LiteratureWt = 10, Master = true, NoveltyVal = 3, NoveltyWt = 10, ProgrammeId = 200, Registration = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessVal = 5, RichnessWt = 10, Status = 4, Strengths = "Gute Strukturierung der Arbeit", StructureVal = 5, StructureWt = 10, StudentFirstName = "Justus", StudentID = "1234567", StudentLastName = "Ameling", StyleVal = 4, StyleWt = 10, Summary = "Prädiktives Modell zur Fraud detection mit sckit-learn", SupervisorId = 201, Title = "Machine Learning zur Betrugserkennung auf ICO-Plattformen", Type = 0, Weaknesses = "Abstract ausbaufähig " },
                        new { Id = 208, Bachelor = true, ContentVal = 4, ContentWt = 30, Description = "Beschäftigt sich mit dem Einfluss von Twitter auf die Entscheidungen der Legeslative. Arbeit des Jahres 1994.", DifficultyVal = 5, DifficultyWt = 5, Email = "davidbreiding@gmail.com", Evaluation = "Unterm Strich eine gute strukturierte Arbeit", Filing = new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Grade = 1, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutVal = 5, LayoutWt = 15, LiteratureVal = 5, LiteratureWt = 10, Master = true, NoveltyVal = 3, NoveltyWt = 10, ProgrammeId = 200, Registration = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessVal = 5, RichnessWt = 10, Status = 4, Strengths = "Gute Strukturierung der Arbeit", StructureVal = 5, StructureWt = 10, StudentFirstName = "David", StudentID = "0004567", StudentLastName = "Breiding", StyleVal = 4, StyleWt = 10, Summary = "Prädiktives Modell zur Fraud detection mit sckit-learn", SupervisorId = 201, Title = "The impact of twitter adoption of lawmakers´ voting orientation", Type = 0, Weaknesses = "Abstract ausbaufähig " },
                        new { Id = 209, Bachelor = true, ContentVal = 4, ContentWt = 30, Description = "Beschäftigt sich mit der Frage, ob die Verwendung einer XML Struktur noch zeitgemäß ist oder ob JSON dies ablösen sollte.", DifficultyVal = 5, DifficultyWt = 5, Email = "davidbreiding@gmail.com", Evaluation = "Unterm Strich eine gute strukturierte Arbeit", Filing = new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Grade = 1, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutVal = 5, LayoutWt = 15, LiteratureVal = 5, LiteratureWt = 10, Master = true, NoveltyVal = 3, NoveltyWt = 10, ProgrammeId = 200, Registration = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessVal = 5, RichnessWt = 10, Status = 4, Strengths = "Gute Strukturierung der Arbeit", StructureVal = 5, StructureWt = 10, StudentFirstName = "David", StudentID = "0004567", StudentLastName = "Breiding", StyleVal = 4, StyleWt = 10, Summary = "XML oder JSON", SupervisorId = 201, Title = "AJAX X(ML)treme good? Or J(SON)UST standard.", Type = 0, Weaknesses = "Abstract ausbaufähig " },
                        new { Id = 210, Bachelor = false, ContentWt = 30, Description = "Beschäftigt sich mit der Frage, ob es tatsächlich an jeder Rebe eine Netzwerkverbindung bedarf.  Eine praxisnahe Arbeit am Weingut Weiß.", DifficultyWt = 5, Email = "michiweiß@web.de", LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, ProgrammeId = 202, Registration = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), RichnessWt = 10, Status = 2, StructureWt = 10, StudentFirstName = "Michael", StudentID = "ac498456", StudentLastName = "Weiß", StyleWt = 10, SupervisorId = 200, Title = "Digitalisierung der Weinindustrie - IOT an jeder Rebe.", Type = 0 },
                        new { Id = 211, Bachelor = true, ContentWt = 30, Description = "Erst kürzlich ist der Politiker Philipp Amthor durch It-affinität aufgefallen. In dieser Arbeit soll die Entwicklung der großen Interesse an Ki-Anwendungen beleuchtet werden.", DifficultyWt = 5, LastModified = new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), LayoutWt = 15, LiteratureWt = 10, Master = true, NoveltyWt = 10, RichnessWt = 10, Status = 1, StructureWt = 10, StyleWt = 10, SupervisorId = 202, Title = "Augustus Intelligence - mehr Schein als Sein?" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AweV1.Models.Thesis", b =>
                {
                    b.HasOne("AweV1.Models.Programme", "Programme")
                        .WithMany("thesisList")
                        .HasForeignKey("ProgrammeId");

                    b.HasOne("AweV1.Models.Supervisor", "Supervisor")
                        .WithMany("thesisList")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}