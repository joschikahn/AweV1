using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class Testdaten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "giacomoWelsch@web.de", "Giacomo", "Welsch" });

            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "dürr@gmail.com", "Alexander", "Dürr" });

            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Active", "Email", "FirstName", "LastName" },
                values: new object[] { true, "frederic.thiesse@uni-wuerzburg.de", "Frédéric", "Thiesse" });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[] { 203, false, "mau789@gmail.com", "Charlotte", "Maurer" });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bachelor", "Filing", "LastModified", "Registration" },
                values: new object[] { false, new DateTime(2020, 7, 27, 17, 36, 45, 463, DateTimeKind.Local), new DateTime(2020, 7, 27, 17, 36, 45, 462, DateTimeKind.Local), new DateTime(2020, 7, 27, 17, 36, 45, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Bachelor", "LastModified" },
                values: new object[] { true, new DateTime(2020, 7, 27, 17, 36, 45, 465, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[,]
                {
                    { 201, true, null, 30, "In der internationalen Information Systems-Forschung wird erklärende Statistik häufig mit vorhersagender Statistik verwechselt. Im Rahmen dieser Abschlussarbeit soll der Gebrauch vorhersagender Statistik daher strukturiert analysiert werden.", null, 5, null, null, null, null, new DateTime(2020, 7, 27, 17, 36, 45, 465, DateTimeKind.Local), null, 15, null, 10, false, null, 10, null, null, null, 10, 0, null, null, 10, null, null, null, null, 10, null, 200, "Strukturierte Literaturanalyse zu Predictive Analytics in der Information Systems-Forschung", 0, null, null },
                    { 202, true, null, 30, "Eine der derzeit bedeutsamsten „Emerging Technologies“ ist das Quantencomputing (QC), welches eine Steigerung der Verarbeitungskapazität von Rechnern um mehrere Größenordnungen verspricht. Aus Anwendersicht ergibt sich dadurch jedoch nicht nur ein enormes Effizienzsteigerungspotenzial. Vielmehr würde QC auch völlig neue Anwendungen ermöglichen, die bislang aufgrund ihrer Rechenkomplexität nicht implementierbar sind. Umgekehrt wäre QC aber auch eine Gefahr für heutige Anwendungen, die auf eben dieser Komplexität basieren, bspw. Kryptowährungen wie der Bitcoin. Ziel der Arbeit ist es vor diesem Hintergrund, anhand einer Literaturanalyse die technischen Grundlagen und den aktuellen Stand der Entwicklung von Quantencomputern zusammenzufassen. Andererseits soll diskutiert werden, inwiefern QC wie oben skizziert ein disruptives Potenzial besitzt. Wird das Thema als Master Thesis bearbeitet, sollen auch aktuelle Angebote für die QC-Entwicklung evaluiert werden (z.B. IBM Qiskit).", null, 5, null, null, null, null, new DateTime(2020, 7, 27, 17, 36, 45, 465, DateTimeKind.Local), null, 15, null, 10, true, null, 10, null, null, null, 10, 1, null, null, 10, null, null, null, null, 10, null, 202, "Ist Quantencomputing disruptiv?", 0, null, null },
                    { 203, true, null, 30, "Wenden Sie sich bei Interesse bitte direkt an mich, ich erkläre Ihnen die Details zu dem Thema. - Giacomo Welsch", null, 5, "leon.89@web.de", null, null, null, new DateTime(2020, 7, 27, 17, 36, 45, 465, DateTimeKind.Local), null, 15, null, 10, true, null, 10, 202, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 2, null, null, 10, "Leon", "WS798456", "Manninger", null, 10, null, 200, "Was macht Kollaborationsanwendungen aus? - Entwicklung einer Taxonomie", 0, null, null },
                    { 204, true, 2, 30, "Die Blockchain-Technologie kann als eine verteilte Ledger-Datenbank beschrieben werden, die das Potenzial hat, traditionelle Geschäftsmodelle zu verändern. Ein üblicher Weg für solche Startups, sich selbst zu finanzieren, sind Initial Coin Offerings (ICOs) - eine Art Crowdfunding ähnlich wie Initial Public Offerings (IPOs). Im Gegensatz zu IPOs zielen ICOs jedoch darauf ab, Kapital durch die Schaffung und den Verkauf einer virtuellen Währung zu beschaffen, die ihren Inhabern eine Reihe von Rechten, einschließlich des Zugangs zu einer Plattform, gewährt und auf dem Sekundärmarkt weiterverkauft werden kann.", 5, 5, "leonie.merdinger@uni-wuerzburg.de", "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke.", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 7, 27, 17, 36, 45, 465, DateTimeKind.Local), 3, 15, 5, 10, true, 3, 10, 201, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, 4, "Gute Strukturierung der Arbeit mit guten praxisnähe. Saubere Arbeit in der Art und Weise des Zitierens und der Quellenarbeit.", 5, 10, "Leonie", "561321", "Merdinger", 2, 10, "Ein ausgearbeitetes Businessmodel Canva über ICOs (Initial Coin Offerings)", 1, "Ein konsolidiertes Business Model Canvas über Blockchain basierte Startups: Erkenntnisse aus Initital Coin Offerings", 0, null, "Abstract und Fazit ausbaufähig, zudem ist die Synthese mangelhaft" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mazimmerlin@web.de", "Max", "Zimmerlin" });

            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "groß@gmail.com", "Simone", "Groß" });

            migrationBuilder.UpdateData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Active", "Email", "FirstName", "LastName" },
                values: new object[] { false, "lucian.bianco@gmx.com", "Lucia", "Bianco" });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bachelor", "Filing", "LastModified", "Registration" },
                values: new object[] { true, new DateTime(2020, 7, 27, 15, 39, 20, 545, DateTimeKind.Local), new DateTime(2020, 7, 27, 15, 39, 20, 544, DateTimeKind.Local), new DateTime(2020, 7, 27, 15, 39, 20, 545, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Bachelor", "LastModified" },
                values: new object[] { false, new DateTime(2020, 7, 27, 15, 39, 20, 547, DateTimeKind.Local) });
        }
    }
}
