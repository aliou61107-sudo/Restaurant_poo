using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal abstract class Repas
    {
        protected string nom;
        protected double prix;
        protected bool est_servi;
        public static int compteur = 0;
        public Repas(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            this.est_servi = false;
            compteur++;
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public abstract void servirRepas();
        
        public override String ToString()
        {
            return "Nom: " + this.nom + ", Prix: " + this.prix + ", Est servi: " + this.est_servi;
        }

        public bool Est_servi
        {
            get { return est_servi; }
            set { est_servi = value; }
        }
    }
}
