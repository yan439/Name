using System;
using System.Collections.Generic;

namespace Projet2.Models
{
    public interface IDal : IDisposable
    {
       // void DeleteCreateDatabase();
        List<Utilisateur> ObtientTousLesUtilisateurs();
        int CreerUnCompte(string Nom, string Prenom, DateTime DateDeNaissance, string Adresse, string Email, string MotDePasse);

        void ModifierUtilisateur(int Id,string Nom, string Prenom, DateTime DateDeNaissance, string Adresse, string Email, string MotDePasse);
        void SupprimerUtilisateur( int Id);
    }
}
