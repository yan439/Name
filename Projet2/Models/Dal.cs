using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet2.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;

        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }
        public List<Utilisateur> ObtientTousLesUtilisateurs()
        {
            return _bddContext.Utilisateurs.ToList();
        }

         public int CreerUnCompte( string Nom, string Prenom, DateTime DateDeNaissance, string Adresse,string Email, string MotDePasse)
        {

            Utilisateur utilisateur = new Utilisateur() { Nom = Nom, Prenom = Prenom, DateDeNaissance = DateDeNaissance, Adresse = Adresse, Email=Email,  MotDePasse = MotDePasse };
            _bddContext.Utilisateurs.Add(utilisateur);
            _bddContext.SaveChanges();
            return utilisateur.Id;
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public void ModifierUtilisateur(int Id, string Nom, string Prenom, DateTime DateDeNaissance, string Adresse, string Email, string MotDePasse)
        {
            Utilisateur utilisateur = _bddContext.Utilisateurs.Find(Id);
            if (utilisateur != null)
            {
               
                utilisateur.Nom = Nom;
                utilisateur.Prenom = Prenom;
                utilisateur.Adresse = Adresse;
                utilisateur.DateDeNaissance = DateDeNaissance;
                utilisateur.MotDePasse = MotDePasse;
                _bddContext.SaveChanges();
            }
        }
        public void ModifierUtilisateur(Utilisateur utilisateur)
        {
            _bddContext.Utilisateurs.Update(utilisateur);
            _bddContext.SaveChanges();
        }
        public void SupprimerUtilisateur(int Id)
        {
            Utilisateur utilisateur = _bddContext.Utilisateurs.Find(Id);
            if (utilisateur != null)
            {
                _bddContext.Utilisateurs.Remove(utilisateur);
                _bddContext.SaveChanges();
            }
        }

        public void SupprimerUtilisateur(Utilisateur utilisateur)
        {
            _bddContext.Utilisateurs.Remove(utilisateur);
            _bddContext.SaveChanges();
        }

    }
}
