using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "programme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "thesis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Registration = table.Column<DateTime>(nullable: true),
                    Filing = table.Column<DateTime>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    Bachelor = table.Column<bool>(nullable: false),
                    Master = table.Column<bool>(nullable: false),
                    StudentFirstName = table.Column<string>(nullable: true),
                    StudentLastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StudentID = table.Column<string>(nullable: true),
                    Strengths = table.Column<string>(nullable: true),
                    Weaknesses = table.Column<string>(nullable: true),
                    Evaluation = table.Column<string>(nullable: true),
                    ContentVal = table.Column<int>(nullable: true),
                    LayoutVal = table.Column<int>(nullable: true),
                    StructureVal = table.Column<int>(nullable: true),
                    StyleVal = table.Column<int>(nullable: true),
                    LiteratureVal = table.Column<int>(nullable: true),
                    DifficultyVal = table.Column<int>(nullable: true),
                    NoveltyVal = table.Column<int>(nullable: true),
                    RichnessVal = table.Column<int>(nullable: true),
                    ContentWt = table.Column<int>(nullable: false),
                    LayoutWt = table.Column<int>(nullable: false),
                    StyleWt = table.Column<int>(nullable: false),
                    LiteratureWt = table.Column<int>(nullable: false),
                    StructureWt = table.Column<int>(nullable: false),
                    DifficultyWt = table.Column<int>(nullable: false),
                    NoveltyWt = table.Column<int>(nullable: false),
                    RichnessWt = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: true),
                    SupervisorId = table.Column<int>(nullable: false),
                    ProgrammeId = table.Column<int>(nullable: true),
                    UploadFile = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_thesis_programme_ProgrammeId",
                        column: x => x.ProgrammeId,
                        principalTable: "programme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_thesis_supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BA Wirtschaftsinformatik" },
                    { 200, "BA Wirtschaftswissenschaften" },
                    { 201, "MA Information Systems" },
                    { 202, "MA Data Science" }
                });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, true, "maschneider@mail.mail", "Markus", "Schneider" },
                    { 200, true, "giacomoWelsch@web.de", "Giacomo", "Welsch" },
                    { 201, true, "dürr@gmail.com", "Alexander", "Dürr" },
                    { 202, true, "frederic.thiesse@uni-wuerzburg.de", "Frédéric", "Thiesse" },
                    { 203, false, "mau789@gmail.com", "Charlotte", "Maurer" }
                });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[,]
                {
                    { 1, false, 5, 30, "In diesem Paper geht es um verschiedene Vertriebskanäle", 5, 5, "joschikahn@web.de", "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke zum Thema Omni Channel Retail.", new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 1, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, 1, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 5, 10, 4, "Quellenarbeit, Zitieren und Synthese sind hervorragned ausgearbeitet.", 5, 10, "Josua", "2278467", "Homberger", 5, 10, "Omni Channel Retail eignet sich besonders für große Unternehemen. Eher ungeeignet in der Lebensmittelbranche.", 1, "Omni Channel Retail", 0, null, "Abstract und Fazit ausbaufähig." },
                    { 200, true, null, 30, "RPA gilt als die aufstrebende Technologie für die Automatisierung von Prozesse. In dieser Arbeit soll eine literarische Aufarbeitung von weiteren Möglichkeiten der Prozessautomatisierung erfolgen. Zusätzlich sollen qualitative Studien die aktuelle Situation aus der Praxis gegenüberstellen. Ziel soll die Einordnung von RPA im Vergleich zu anderen Technologien sein", null, 5, "claustern@web.de", "", new DateTime(2015, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), null, 15, null, 10, true, null, 10, 200, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 3, "", null, 10, "Claudia", "2278467", "Stern", null, 10, "", 1, "Should you put all your Processes in one Basket?", 1, null, "" },
                    { 204, true, 2, 30, "Die Blockchain-Technologie kann als eine verteilte Ledger-Datenbank beschrieben werden, die das Potenzial hat, traditionelle Geschäftsmodelle zu verändern. Ein üblicher Weg für solche Startups, sich selbst zu finanzieren, sind Initial Coin Offerings (ICOs) - eine Art Crowdfunding ähnlich wie Initial Public Offerings (IPOs). Im Gegensatz zu IPOs zielen ICOs jedoch darauf ab, Kapital durch die Schaffung und den Verkauf einer virtuellen Währung zu beschaffen, die ihren Inhabern eine Reihe von Rechten, einschließlich des Zugangs zu einer Plattform, gewährt und auf dem Sekundärmarkt weiterverkauft werden kann.", 5, 5, "leonie.merdinger@uni-wuerzburg.de", "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke.", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 3, 15, 5, 10, true, 3, 10, 201, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, 4, "Gute Strukturierung der Arbeit mit guten praxisnähe. Saubere Arbeit in der Art und Weise des Zitierens und der Quellenarbeit.", 5, 10, "Leonie", "561321", "Merdinger", 2, 10, "Ein ausgearbeitetes Businessmodel Canva über ICOs (Initial Coin Offerings)", 1, "Ein konsolidiertes Business Model Canvas über Blockchain basierte Startups: Erkenntnisse aus Initital Coin Offerings", 0, null, "Abstract und Fazit ausbaufähig, zudem ist die Synthese mangelhaft" },
                    { 201, true, null, 30, "In der internationalen Information Systems-Forschung wird erklärende Statistik häufig mit vorhersagender Statistik verwechselt. Im Rahmen dieser Abschlussarbeit soll der Gebrauch vorhersagender Statistik daher strukturiert analysiert werden.", null, 5, null, null, null, null, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), null, 15, null, 10, false, null, 10, null, null, null, 10, 0, null, null, 10, null, null, null, null, 10, null, 200, "Strukturierte Literaturanalyse zu Predictive Analytics in der Information Systems-Forschung", 0, null, null },
                    { 203, true, null, 30, "Wenden Sie sich bei Interesse bitte direkt an mich, ich erkläre Ihnen die Details zu dem Thema. - Giacomo Welsch", null, 5, "leon.89@web.de", null, null, null, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), null, 15, null, 10, true, null, 10, 202, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 2, null, null, 10, "Leon", "WS798456", "Manninger", null, 10, null, 200, "Was macht Kollaborationsanwendungen aus? - Entwicklung einer Taxonomie", 0, null, null },
                    { 202, true, null, 30, "Eine der derzeit bedeutsamsten „Emerging Technologies“ ist das Quantencomputing (QC), welches eine Steigerung der Verarbeitungskapazität von Rechnern um mehrere Größenordnungen verspricht. Aus Anwendersicht ergibt sich dadurch jedoch nicht nur ein enormes Effizienzsteigerungspotenzial. Vielmehr würde QC auch völlig neue Anwendungen ermöglichen, die bislang aufgrund ihrer Rechenkomplexität nicht implementierbar sind. Umgekehrt wäre QC aber auch eine Gefahr für heutige Anwendungen, die auf eben dieser Komplexität basieren, bspw. Kryptowährungen wie der Bitcoin. Ziel der Arbeit ist es vor diesem Hintergrund, anhand einer Literaturanalyse die technischen Grundlagen und den aktuellen Stand der Entwicklung von Quantencomputern zusammenzufassen. Andererseits soll diskutiert werden, inwiefern QC wie oben skizziert ein disruptives Potenzial besitzt. Wird das Thema als Master Thesis bearbeitet, sollen auch aktuelle Angebote für die QC-Entwicklung evaluiert werden (z.B. IBM Qiskit).", null, 5, null, null, null, null, new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), null, 15, null, 10, true, null, 10, null, null, null, 10, 1, null, null, 10, null, null, null, null, 10, null, 202, "Ist Quantencomputing disruptiv?", 0, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_thesis_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_thesis_SupervisorId",
                table: "thesis",
                column: "SupervisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "thesis");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "programme");

            migrationBuilder.DropTable(
                name: "supervisors");
        }
    }
}
