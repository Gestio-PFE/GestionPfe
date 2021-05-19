using GestionPfeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPfeApp.Models
{
    public class Etudiant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Matricule")]
        public int EtudiantID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nom { get; set; }
        //Required fait des propriétés de nom des champs obligatoires.
        [Required]
        [StringLength(50)] 
        public string Prenom { get; set; }
        public string Email { get; set; }

        public long Tel { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateNaissance { get; set; }

        public Pfe Pfe { get; set; }
        // public ICollection<Enrollment> Enrollments { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return Nom + ", " + Prenom;
            }
        }
        /*FullName est une propriété calculée qui retourne une valeur créée par concaténation de deux autres propriétés. 
         * Par conséquent,
         * elle a uniquement un accesseur get et aucune colonne FullName n’est générée dans la base de données.*/

    }
}