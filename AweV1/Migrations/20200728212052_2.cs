using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local), new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local), new DateTime(2020, 7, 28, 23, 20, 52, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 201,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 202,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 203,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 204,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[,]
                {
                    { 205, true, null, 30, "Im Gegensatz zu früheren Automatiserungswellen ermöglichen Technologien wie das maschinelle Lernen zunehmend auch die Digitalisierung von \"white collar\"-Jobs, für die vermeintlich hohe Qualifikationen und spezifisch menschliche Fähigkeiten bislang als notwendige Voraussetzung angesehen wurden. Ein prominentes Beispiel sind Rechtsdienstleistungen wie z.B. die Beratung durch einen Anwalt, die Erstellung eines Testaments oder die Durchsetzung von Flugpassagierrechten. Ziel der Arbeit ist es, einen Überblick über Anwendungsgebiete und Projekte/Startups zu geben und mögliche Hürden für die breite Adoption (z.B. gesetzliche Regularien) zu diskutieren.", null, 5, null, null, null, null, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), null, 15, null, 10, false, null, 10, null, null, null, 10, 0, null, null, 10, null, null, null, null, 10, null, 202, "LegalTech: Der Markt für digitale Rechtsdienstleistungen", null, null, null },
                    { 206, false, null, 30, "Im Rahmen der Arbeit soll ein bestehender Amazon Alexa Skill zum Streaming eines Podcasts weiterentwickelt werden. Ziel ist die Optimierung des Dialogs, den Konsumenten mit dem Sprachassistenten führen müssen, um zu den gewünschten Inhalten (d.h. Podcast-Folgen) zu gelangen. Relevante Themen sind hier Topic-/Schlagwort-Suche, personalisierte Vorschläge/Recommendations und UI-Verbesserungen.", null, 5, null, null, null, null, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), null, 15, null, 10, true, null, 10, null, null, null, 10, 0, null, null, 10, null, null, null, null, 10, null, 200, "Podcast Streaming via Amazon Alexa: Implementierung einer intelligenten Dialogführung mittels Textmining", null, null, null },
                    { 207, true, 4, 30, "Aufgrund der Art von ICO-Plattformen stellt Betrug ein bedeutendes Problem dar, da die ICO-Plattformen durch die typischen Merkmale des Internets gekennzeichnet sind. Einige Emittenten von ICOs täuschen ihre Geschäfte vor und veruntreuen das gesammelte, während einige Investoren die Anonymität nutzen, um \"Pump-and-Dump\"-Systeme durchzuführen. Schätzungsweise 10% des mit ICOs gesammelten Geldes wurden 2017 gestohlen (EY, 2017). Um das Vertrauen der Investoren zu gewinnen, stellen die Gründer so viele Informationen wie möglich zur Verfügung. Eine der Hauptinformationsquellen für Investoren sind ICO-Listing Webseiten wie z. B. icobench.com. Im Rahmen der Masterarbeit sollen Machine-Learning Modelle erstellt und evaluiert werden, um eine frühzeitige Erkennung von Betrug zu ermöglichen. Zum Training der verschiedenen Modelle erhalten Sie einen umfangreichen Datensatz.", 5, 5, "amelingjustus@gmail.com", "Unterm Strich eine gute strukturierte Arbeit", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), 5, 15, 5, 10, true, 3, 10, 200, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10, 4, "Gute Strukturierung der Arbeit", 5, 10, "Justus", "1234567", "Ameling", 4, 10, "Prädiktives Modell zur Fraud detection mit sckit-learn", 201, "Machine Learning zur Betrugserkennung auf ICO-Plattformen", 0, null, "Abstract ausbaufähig " },
                    { 208, true, 4, 30, "Beschäftigt sich mit dem Einfluss von Twitter auf die Entscheidungen der Legeslative. Arbeit des Jahres 1994.", 5, 5, "davidbreiding@gmail.com", "Unterm Strich eine gute strukturierte Arbeit", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), 5, 15, 5, 10, true, 3, 10, 200, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10, 4, "Gute Strukturierung der Arbeit", 5, 10, "David", "0004567", "Breiding", 4, 10, "Prädiktives Modell zur Fraud detection mit sckit-learn", 201, "The impact of twitter adoption of lawmakers´ voting orientation", 0, null, "Abstract ausbaufähig " },
                    { 209, true, 4, 30, "Beschäftigt sich mit der Frage, ob die Verwendung einer XML Struktur noch zeitgemäß ist oder ob JSON dies ablösen sollte.", 5, 5, "davidbreiding@gmail.com", "Unterm Strich eine gute strukturierte Arbeit", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), 5, 15, 5, 10, true, 3, 10, 200, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10, 4, "Gute Strukturierung der Arbeit", 5, 10, "David", "0004567", "Breiding", 4, 10, "XML oder JSON", 201, "AJAX X(ML)treme good? Or J(SON)UST standard.", 0, null, "Abstract ausbaufähig " },
                    { 210, false, null, 30, "Beschäftigt sich mit der Frage, ob es tatsächlich an jeder Rebe eine Netzwerkverbindung bedarf.  Eine praxisnahe Arbeit am Weingut Weiß.", null, 5, "michiweiß@web.de", null, null, null, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), null, 15, null, 10, true, null, 10, 202, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 2, null, null, 10, "Michael", "ac498456", "Weiß", null, 10, null, 200, "Digitalisierung der Weinindustrie - IOT an jeder Rebe.", 0, null, null },
                    { 211, true, null, 30, "Erst kürzlich ist der Politiker Philipp Amthor durch It-affinität aufgefallen. In dieser Arbeit soll die Entwicklung der großen Interesse an Ki-Anwendungen beleuchtet werden.", null, 5, null, null, null, null, new DateTime(2020, 7, 28, 23, 20, 52, 94, DateTimeKind.Local), null, 15, null, 10, true, null, 10, null, null, null, 10, 1, null, null, 10, null, null, null, null, 10, null, 202, "Augustus Intelligence - mehr Schein als Sein?", null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 28, 13, 24, 43, 120, DateTimeKind.Local), new DateTime(2020, 7, 28, 13, 24, 43, 119, DateTimeKind.Local), new DateTime(2020, 7, 28, 13, 24, 43, 120, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 201,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 202,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 203,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 204,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));
        }
    }
}
