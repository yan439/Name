using System;

namespace Projet2.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Prix { get; set; }

        public DateTime DateDeTransaction { get; set; }

        public string NumeroDeCompteContributeur { get; set; }

        public string NumeroDeCompteConsommateur { get; set; }

        public string NumeroDeCompteEcoMobil { get; set; }

        public byte Commission { get; set; }

        public int CalculPaiement(int Prix, byte Commission)
        {
            return Prix - (Prix * Commission) / 100;
        }
    }
}
