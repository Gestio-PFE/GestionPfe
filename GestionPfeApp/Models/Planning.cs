using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPfeApp.Models
{
    public class Planning
    {
        public int PlanningID { get; set; }
        public Pfe Pfe { get; set; }
        //   public ICollection<Professeur> ProfesseurJ { get; set; }//la jury
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateSoutenance { get; set; }
        public int Salle { get; set; }//numero de salle de soutenance

        public ICollection<Professeur> Professeurs { get; set; }//jury

    }
}
