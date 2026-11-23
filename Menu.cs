using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Menu: Repas
    {
        private string nomBoisson;
        private List<Plat> ListePlats;

        public Menu(string nom, double prix, string nomBoisson): base(nom, prix)
        {
            this.nomBoisson = nomBoisson;
            this.ListePlats = new List<Plat>();
        }

        public override void servirRepas()
        {
            foreach(Plat p in ListePlats)
            {
                if(!p.Est_servi)
                {
                    Console.WriteLine($"Le plat  {p} n'a pas été servi.");
                    return;
                }
            }
            this.est_servi = true;
        }

        public void ajouterPlat(Plat p)
        {
            ListePlats.Add(p);

        }

        public override string ToString()
        {
            string chaineFinale = "Menu :\n";

            foreach(Plat p in ListePlats)
            {
                chaineFinale += p.ToString();
                chaineFinale += "\n";
            }

            return chaineFinale;
        }
    }
}
