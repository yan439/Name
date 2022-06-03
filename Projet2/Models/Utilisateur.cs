using System;
using System.ComponentModel.DataAnnotations;

namespace Projet2.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
        public string Nom { get; set; }

        [Display(Name = "Date De Naissance")]
        public DateTime DateDeNaissance { get; set; }
        
        public string Adresse { get; set; }


       
        [RegularExpression("^.+@.+\\..+$", ErrorMessage = "Le Mot de passe n'est pas conforme.")]
        public string Email { get; set; }

        
        [RegularExpression(@" ^.+@.+\\..+$", ErrorMessage = "Votre Mot de passe doit contenir au moins un chiffre, une majuscule et minimum 8 characteres.")]

        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }
    }
}
