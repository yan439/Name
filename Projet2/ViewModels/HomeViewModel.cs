using Projet2.Models;
using System;

namespace Projet2.ViewModels
{
    public class HomeViewModel
    {
        
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
