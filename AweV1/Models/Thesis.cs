using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AweV1.Models
{


    public class Thesis : IValidatableObject
    {

        public int Id { get; set; }

        [Display(Name = "Letzte Datenänderung")]
        public DateTime LastModified { get; set; } = DateTime.Now;



        //                               ******************** Thema/Arbeit ********************
        [Required(ErrorMessage = "Bitte Titel hinzufügen!")]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bitte Beschreibung hinzufügen!")]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public Status Status { get; set; }

        [Display(Name = "Anmeldung")]
        public DateTime? Registration { get; set; }

        [Display(Name = "Abgabe")]
        public DateTime? Filing { get; set; }

        [Display(Name = "Typ")]
        public Type Type { get; set; }

        [Display(Name = "Zusammenfassung")]
        public string Summary { get; set; }

        public bool Bachelor { get; set; }

        public bool Master { get; set; }



        //                              ******************** Student ********************

        // Studentname wurde in Vor und Nachname aufgeteilt - In Aufgabenstellung Name in einem
        [Display(Name = "Vorname")]
        public string StudentFirstName { get; set; }

        [Display(Name = "Nachname")]
        public string StudentLastName { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Display(Name = "Matrikelnummer")]
        public string StudentID { get; set; }



        //                               ******************* Benotung **********************

        [Display(Name = "Stärken")]
        public string Strengths { get; set; }

        [Display(Name = "Schwächen")]
        public string Weaknesses { get; set; }

        [Display(Name = "Evaluation")]
        public string Evaluation { get; set; }

        //Bewertung
        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Inhalt Pkt.")]
        public int? ContentVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Layout Pkt.")]
        public int? LayoutVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Struktur Pkt.")]
        public int? StructureVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Stil Pkt.")]
        public int? StyleVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Literatur Pkt.")]
        public int? LiteratureVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Komplexität Pkt.")]
        public int? DifficultyVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Neuheit Pkt.")]
        public int? NoveltyVal { get; set; }

        [Range(1, 5, ErrorMessage = "Bitte eine Zahl zwischen 1-5 eingeben!")]
        [Display(Name = "Reichhaltigkeit Pkt.")]
        public int? RichnessVal { get; set; }


        //Gewichtung
        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Inhalt Gewichtung")]
        public int ContentWt { get; set; } = 30;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Layout Gewichtung")]
        public int LayoutWt { get; set; } = 15;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Stil Gewichtung")]
        public int StyleWt { get; set; } = 10;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Literatur Gewichtung")]
        public int LiteratureWt { get; set; } = 10;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Struktur Gewichtung")]
        public int StructureWt { get; set; } = 10;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Komplexität Gewichtung")]
        public int DifficultyWt { get; set; } = 5;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Neuheit Gewichtung")]
        public int NoveltyWt { get; set; } = 10;

        [Range(0, 100, ErrorMessage = "Bitte eine Zahl zwischen 0-100 eingeben!")]
        [Display(Name = "Reichhaltigkeit Gewichtung")]
        public int RichnessWt { get; set; } = 10;

        [Display(Name = "Note")]
        public Grade? Grade { get; set; }


        //Fremdschlüssel
        [Required(ErrorMessage = "Bitte geben Sie den Supervisor an!")]
        public int SupervisorId { get; set; }
        public Supervisor Supervisor { get; set; }

        [Required(ErrorMessage = "Bitte geben Sie ein Programm an!")]
        public int ProgrammeId { get; set; }
        public Programme Programme { get; set; }

        public byte[] UploadFile { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Sind Gewichtungen 100?
            if (ContentWt + LayoutWt + StructureWt + StyleWt + LiteratureWt +
                DifficultyWt + NoveltyWt + RichnessWt != 100)
            {
                int sum = ContentWt + LayoutWt + StructureWt + StyleWt +
                          LiteratureWt + DifficultyWt + NoveltyWt + RichnessWt;
                return new ValidationResult[]
                    {new ValidationResult("Die Summe der Gewichtungen muss 100 sein, aber ist " + sum)};
            }
            // Ist Bachelor und/oder Master ausgewählt?
            else if (Bachelor == false && Master == false)
            {
                return new ValidationResult[]
                    {new ValidationResult("Bitte Bachelor oder Master wählen")};
            }
            // Ist Anmeldedatum vor Abgabedatum?
            else if (Registration > Filing)
            {
                return new ValidationResult[]
                    {new ValidationResult("Anmeldedatum muss vor dem Abgabedatum liegen!")};

            }
            // Was sollte alles eingetragen sein, wenn es Status benotet ist?
            else if ((Status == Status.Graded) && (Grade == Models.Grade.Note_Empty))
            {
                return new ValidationResult[] { new ValidationResult("Bitte Note einfügen!") };

            }
            else if ((Status == Status.Graded) && (NoveltyVal == null || RichnessVal == null ||
                                                          StructureVal == null || StyleVal == null ||
                                                          LiteratureVal == null ||
                                                          LayoutVal == null ||
                                                          DifficultyVal == null ||
                                                          ContentVal == null))
            {
                return new ValidationResult[] { new ValidationResult("Bitte alle Punkte einfügen!") };

            }
            // Was sollte alles eingetragen sein, wenn der Status registered, filed oder graded ist?
            else if ((Status == Status.Registered || Status == Status.Filed ||
                      Status == Status.Graded) && Registration == null)
            {
                return new ValidationResult[] { new ValidationResult("Anmeldedatum einfügen!") };

            }
            else if ((Status == Status.Registered || Status == Status.Filed ||
                      Status == Status.Graded) &&
                     (StudentID == null || StudentFirstName == null ||
                      StudentLastName == null || Email == null))
            {
                return new ValidationResult[]
                {
                        new ValidationResult(
                            "Bitte Daten von Student eingeben (Matrikelnummer, Vorname, Nachname, E-Mail)!")
                };

            }
            // Was sollte eingetragen sein, wenn der Status filed ist?
            else if ((Status == Status.Filed || Status == Status.Graded) && Filing == null)
            {
                return new ValidationResult[] { new ValidationResult("Bitte Abgabedatum einfügen!") };
            }

            return new ValidationResult[] { };
        }
    }
    public enum Status
    {
        [Display(Name = "Frei")]
        Free = 0,

        [Display(Name = "Vorgemerkt")]
        Reserved = 1,

        [Display(Name = "Angemeldet")]
        Registered = 2,

        [Display(Name = "Abgegeben")]
        Filed = 3,

        [Display(Name = "Bewertet")]
        Graded = 4,
    }
    public enum Type
    {
        Bachelor = 0,
        Master = 1
    }

    public enum Grade
    {
        [Display(Name = "---")]
        Note_Empty = 0,
        [Display(Name = "1.0")]
        Note_10 = 1,
        [Display(Name = "1.3")]
        Note_13 = 2,
        [Display(Name = "1.7")]
        Note_17 = 3,
        [Display(Name = "2.0")]
        Note_20 = 4,
        [Display(Name = "2.3")]
        Note_23 = 5,
        [Display(Name = "2.7")]
        Note_27 = 6,
        [Display(Name = "3.0")]
        Note_30 = 7,
        [Display(Name = "3.3")]
        Note_33 = 8,
        [Display(Name = "3.7")]
        Note_37 = 9,
        [Display(Name = "4.0")]
        Note_40 = 10,
        [Display(Name = "5.0")]
        Note_50 = 11,

    }

}
/*
ViewBag.supervisors = _context.supervisors.ToList();

    @{
    List<SelectListItem> supervisors = new List<SelectListItem>();
    foreach (var i in ViewBag.supervisors)
    {supvervisors.Add(NewsStyleUriParser SelectListItem() { Text = if.LastName.ToString(), Value = if.Id.TosTring() });
    }
    }

     </div>
            <div class="form-group">
                <label asp-for="Supervisor" class="control-label"></label>
                <select asp-for="Supervisor" asp-items="supervisors" class="form-control"></select>
                <span asp-validation-for="Supervisor" class="text-danger"></span>
            </div>*/
