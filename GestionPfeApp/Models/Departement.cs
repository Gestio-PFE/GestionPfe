using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestionPfeApp.Models
{
    public class Departement
    {
        public int DepartementID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }//date debut de departement

       // public int? IdProf { get; set; }//chef departement

        //public Professeur Administrator { get; set; }//chaque dep a un admin
       // public ICollection<Course> Courses { get; set; }
        public ICollection<Professeur> ProfesseurDep { get; set; }
    }
}
