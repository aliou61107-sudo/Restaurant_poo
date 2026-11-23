using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Plat: Repas
    {
        private string description;
        public Plat(string nom, double prix, string description): base(nom,prix)
        {
            this.description = description;
        }

        public override void servirRepas()
        {
            this.est_servi = true;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.description;
        }
    }
}
