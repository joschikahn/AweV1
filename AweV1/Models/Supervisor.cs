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
        public string FirstName { [Display(Name = "Vorname")] get; set; }
        public string LastName { [Display(Name = "Nachname")] get; set; }
        public Boolean Active { [Display(Name = "aktiv")] get; set; }
        public string Email { [Display(Name = "E-Mail")] get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }
    }
}