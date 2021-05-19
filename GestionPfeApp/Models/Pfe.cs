using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPfeApp.Models
{
    public enum Mention
    {
        E, TB, B, AB, P
    }

    public class Pfe
    {
        public int PfeID { get; set; }
        public string Titre { get; set; }
        public ICollection<Etudiant> Students { get; set; }
        //le pfe peut etre réalisé par un ou plusieurs etudiants
      //  public Professeur Professeur { get; set; }
        //public ICollection<Professeur> Professeurs { get; set; }//jury
        public Professeur Encadrant { get; set; }
        

        public Mention? Mention { get; set; }
        public decimal ? Note { get; set; }
        //public ICollection<Emploi> Emplois { get; set; }
    }
}
