using Microsoft.EntityFrameworkCore;
using System;

namespace Projet2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Covoiturage> Covoiturages { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=testEcoM");
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Utilisateurs.AddRange(
                new Utilisateur
                {
                    Email = "disney@Land.com",
                    Nom = "Disney",
                    Prenom = "Land",
                    Adresse = "Marne",
                    MotDePasse = "Dis",
                    DateDeNaissance =  new DateTime (2009,02,22)
                },
                new Utilisateur
                {
                    Email = "Asterix@parc.com",
                    Nom = "Asterix",
                    Prenom = "Parc",
                    Adresse = "Paris",
                    MotDePasse = "Parc",
                    DateDeNaissance = new DateTime(2010,02,22)
                }
            );
            this.SaveChanges();
        }

    }
}
