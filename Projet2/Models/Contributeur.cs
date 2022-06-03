using System.Collections.Generic;

namespace Projet2.Models
{
    public class Contributeur : Utilisateur
    {
        public virtual List<Service> Services { get; set; }
    }
}
