using Projet2.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProjet2
{
    public class UnitTest1
    {
        [Fact]
        public void Creation_Utilisateur_Verification()
        {
            using (Dal dal = new Dal())
            {
                // Nous supprimons et créons la db avant le test
                dal.DeleteCreateDatabase();

                // Nous créons un lieu de vacances
                dal.CreerUnCompte("Madi", "Houda", new DateTime(1995, 04, 27), "Poissy", "houda@gmail.com", "houda");

                // Nous vérifions que le lieu a bien été créé
                List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
                Assert.NotNull(utilisateurs);
                Assert.Single(utilisateurs);
                Assert.Equal("Madi", utilisateurs[0].Nom);
                Assert.Equal("Houda", utilisateurs[0].Prenom);
                Assert.Equal(new DateTime(1995, 04, 27), utilisateurs[0].DateDeNaissance);
                Assert.Equal("Poissy", utilisateurs[0].Adresse);
                Assert.Equal("houda.idam@gmail.com", utilisateurs[0].Email);
                Assert.Equal("houda", utilisateurs[0].MotDePasse);


            }
        }
        //[Fact]
        //public void Modifier_Utilisateur_Verification()
        //{
        //    // Nous supprimons la base si elle existe puis nous la créons
        //    using (Dal dal = new Dal())
        //    {
        //        // Nous supprimons et créons la db avant le test
        //        dal.DeleteCreateDatabase();

        //        // Nous créons un séjour
        //        string Email = dal.CreerUnCompte("Madi", "Houda", new DateTime(1995, 04, 27), "Poissy",  "houda");

        //        // Nous modifions le séjour grâce à notre nouvelle fonction
        //        dal.ModifierUtilisateur( "Madi", "Farah", new DateTime(2000, 05, 29), "Paris", Email , "projet");

        //        // nous vérifions que le séjour a bien été modifié
        //        List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
        //        Assert.NotNull(utilisateurs);
        //        Assert.Single(utilisateurs);
        //        Assert.Equal("Madi", utilisateurs[0].Nom);
        //        Assert.Equal("Farah", utilisateurs[0].Prenom);
        //        Assert.Equal(new DateTime(2000, 05, 29), utilisateurs[0].DateDeNaissance);
        //        Assert.Equal("Paris", utilisateurs[0].Adresse);
        //        Assert.Equal("Projet", utilisateurs[0].MotDePasse);

        //    }
        //}
    }
}
