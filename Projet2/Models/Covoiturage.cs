using System;

namespace Projet2.Models
{
    public class Covoiturage 

    {

        public int Id { get; set; }
        public virtual Service Service { get; set; }
        public DateTime DateDeDepart { get; set; }

        public int NbreDePassagers { get; set; }

        public int Kilometrage { get; set; }

        public Boolean Electrique { get; set; }

        //public int PrixCovoiturage(int Kilometrage){
        //    if (Electrique == false)
        //    {
        //        if (NbreDePassagers == 0)
        //        {
        //            int Prix = 25 * Kilometrage;
        //            NbreDePassagers = +1;
        //        }
        //        else if (NbreDePassagers == 1)
        //        {
        //            int Prix = 20 * Kilometrage;
        //            NbreDePassagers = +2;
        //        }
        //        else if (NbreDePassagers == 2)
        //        {
        //            int Prix = 15 * Kilometrage;
        //            NbreDePassagers = +3;
        //        }
        //    }
        //    else
        //        if (NbreDePassagers == 0)
        //    {
        //        int Prix = 15 * Kilometrage;
        //        NbreDePassagers = +1;
        //    }
        //    else if (NbreDePassagers == 1)
        //    {
        //        int Prix = 12 * Kilometrage;
        //        NbreDePassagers = +2;
        //    }
        //    else if (NbreDePassagers == 2)
        //    {
        //        int Prix = 9 * Kilometrage;
        //        NbreDePassagers = +3;
        //    }
        //} 
    }
}
