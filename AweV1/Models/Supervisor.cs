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
        public string FirstName { [Display(Name = "Vorname")] get; set; }
        [Required(ErrorMessage = "Bitte Nachname eingeben!")]
        public string LastName { [Display(Name = "Nachname")] get; set; }
        public Boolean Active { [Display(Name = "aktiv")] get; set; }
        [Required(ErrorMessage = "Bitte E-Mail eingeben!")]
        public string Email { [Display(Name = "E-Mail")] get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }
    }
}