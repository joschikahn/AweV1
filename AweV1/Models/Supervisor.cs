using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AweV1.Models
{
    [Display(Name = "Betreuer")]
    public class Supervisor
    {
        public int Id { get; set; }
       
        [Required(ErrorMessage = "Bitte Vorname eingeben!")]
        [Display (Name ="Vorname")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Bitte Nachname eingeben!")]
        [Display(Name = "Nachname")]
        public string LastName { get; set; }
      
        [Display(Name = "Aktiv")]
        public Boolean Active { get; set; }
       
        [Required(ErrorMessage = "Bitte E-Mail eingeben!")]
        [Display(Name = "E-Mail")]
        public string Email {  get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }
    }
}