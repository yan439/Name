using System;
using System.ComponentModel.DataAnnotations;

namespace Projet2.Models
{
    public class Service
    {
        [Key] 
        public int IdService  { get; set; }

        public DateTime DateDeCreation { get; set; }

        public int NumeroDeReservation { get; set; }

        public string CodeSecret { get; set; }

    }
}
