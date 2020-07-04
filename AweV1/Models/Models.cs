using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AweV1.Models
{


    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Thesis> thesis { get; set; }
    }


    //TODO Mit Fremdschlüssel Entitäten verbinden 
    //TODO Mehrzeiliger Text? -> Limits setzen oder reicht String? -> rich text
    //TODO Grade - Enum oder int?? -> Aufgabenstellung nachlesen
    //TODO lastmodified -> TimeStamp: wie wird das sauber dargestellt?
    //TODO Englische übersetzung -> teilweise schlecht übersetzt

    
    public class Thesis
    {
        public int Id { get; set; }

        [Required, Timestamp]
        [Display(Name = "Letzte Datenänderung")]
        public DateTime LastModified { get; set; }



        //                               ******************** Thema/Arbeit ********************
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public Status Status { get; set; }

        [Timestamp]
        [Display(Name = "Anmeldung")]
        public DateTime Registration { get; set; }

        [Timestamp]
        [Display(Name = "Abgabe")]
        public DateTime Filing { get; set; }

        [Display(Name = "Typ")]
        public Type type { get; set; }

        [Display(Name = "Zusammenfassung")]
        public string Summary { get; set; }



        //                              ******************** Student ********************

        // Studentname wurde in Vor und Nachname aufgeteilt - In Aufgabenstellung Name in einem
        [Display(Name = "Student Vorname")]
        public string StudentFirstName { get; set; }

        [Display(Name = "Student Nachname")]
        public string StudenLastName { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Matrikelnummer")]
        public int StudentID { get; set; }



        //                               ******************* Benotung **********************
        
        [Display(Name = "Stärken")]
        public string Strengths { get; set; }

        [Display(Name = "Schwächen")]
        public string Weaknesses { get; set; }

        [Display(Name = "Evaluation")]
        public string Evaluation { get; set; }

        //Bewertung
        [Range(1, 5)]
        [Display(Name = "Inhalt Pkt.")]
        public int ContentVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Layout Pkt.")]
        public int LayoutVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Struktur Pkt.")]
        public int StructureVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Stil Pkt.")]
        public int StyleVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Literatur Pkt.")]
        public int LiteratureVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Komplexität Pkt.")]
        public int DifficultyVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Neuheit Pkt.")]
        public int NoveltyVal { get; set; }

        [Range(1, 5)]
        [Display(Name = "Reichhaltigkeit Pkt.")]
        public int RichnessVal { get; set; }


        //Gewichtung
        [Range(0,100)]
        [DefaultValue(30)]
        [Display(Name = "Inhalt Gewichtung")]
        public int ContentWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(15)]
        [Display(Name = "Layout Gewichtung")]
        public int LayoutWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(10)]
        [Display(Name = "Stil Gewichtung")]
        public int StyleWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(10)]
        [Display(Name = "Literatur Gewichtung")]
        public int LiteratureWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(10)]
        [Display(Name = "Struktur Gewichtung")]
        public int StructureWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(5)]
        [Display(Name = "Komplexität Gewichtung")]
        public int DifficultyWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(10)]
        [Display(Name = "Neuheit Gewichtung")]
        public int NoveltyWt { get; set; }

        [Range(0, 100)]
        [DefaultValue(10)]
        [Display(Name = "Reichhaltigkeit Gewichtung")]
        public int RichnessWt { get; set; }

        [Display(Name = "Note")]
        public decimal Grade { get; set; }

        //                               ******************* Benotung **********************


    }
    [Display(Name = "Betreuer")]
    public class Supervisor
    {

        public int Id { get; set; }
        public string FirstName { [Display(Name = "Vorname")] get; set; }
        public string LastName { [Display(Name = "Nachname")] get; set; }
        public Boolean Active { [Display(Name = "aktiv")] get; set; }
        public string Email { [Display(Name = "E-Mail")] get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }
    }
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }

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
}