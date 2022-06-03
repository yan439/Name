using Microsoft.AspNetCore.Mvc;
using Projet2.Models;
using Projet2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Utilisateur> sejours = new List<Utilisateur>();
            Utilisateur utilisateur1 = new Utilisateur();


            HomeViewModel hvm = new HomeViewModel
            {

            };

            return View(hvm);
        }
        public IActionResult ModifierUtilisateur(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Utilisateur utilisateur = dal.ObtientTousLesUtilisateurs().Where(u => u.Id == id).FirstOrDefault();
                    if (utilisateur == null)
                    {
                        return View("Error");
                    }
                    return View(utilisateur);
                }
            }
            return View("Error");
        }
        [HttpPost]
        public IActionResult ModifierUtilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
                return View(utilisateur);


            if (utilisateur.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    //dal.ModifierSejour(sejour.Id, sejour.Lieu, sejour.Telephone);
                    dal.ModifierUtilisateur(utilisateur);
                    return RedirectToAction("ModifierSejour", new { @id= utilisateur.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult SupprimerUtilisateur(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Utilisateur utilisateur = dal.ObtientTousLesUtilisateurs().Where(s => s.Id == id).FirstOrDefault();
                    if (utilisateur == null)
                    {
                        return View("Error");
                    }
                    return View(utilisateur);
                }
            }
            return View("Error");
        }
        [HttpPost]
        public IActionResult Supprimerutilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
                return View(utilisateur);
            if (utilisateur.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    //dal.ModifierSejour(sejour.Id, sejour.Lieu, sejour.Telephone);
                    dal.SupprimerUtilisateur(utilisateur);
                    return RedirectToAction("ModifierSejour", new { @id = utilisateur.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }

    }
}
