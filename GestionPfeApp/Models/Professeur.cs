using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPfeApp.Models
{
    public class Professeur
    {
        public int ProfesseurID { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public String NomProf { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public String PrenomProf { get; set; }
        //public String Departement { get; set; }

       

       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return NomProf + ", " + PrenomProf; }
        }

        public Departement Departement { get; set; }
        public ICollection<Pfe> Pfes { get; set; }

       // public ICollection<Planning> Plannings { get; set; }
    }
}
