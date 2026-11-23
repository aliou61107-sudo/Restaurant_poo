using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Commande : IComparable, IAddition

    {
        private int numero;
        private static int compteur = 0;
        private int numeroTable;
        private DateTime date;
        private int nbCouvert;
        private bool fidelite;
        private double montant = 0;
        private Client client;

        private List<Repas> lesRepas;

        public Commande(int numeroTable, DateTime date, int nbCouvert, bool fidelite, Client client)
        {
            this.numero = ++compteur;
            this.numeroTable = numeroTable;
            this.date = date;
            this.nbCouvert = nbCouvert;
            this.fidelite = fidelite;
            this.client = client;
            lesRepas = new List<Repas>();
        }

        public void ajouterRepas(Repas r)
        {
            lesRepas.Add(r);
            Console.WriteLine($"Le repas {r} a ete ajouter avec success...");
        }

        public bool EtatCommande()
        {
            foreach (Repas r in lesRepas)
            {
                if (!r.Est_servi)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return $"Commade :\n" +
            $"Numero de commande : {numero}\n" +
            $"Numero de table : {numeroTable}\n" +
            $"Date : {date}\n" +
            $"Nombre de couvert : {nbCouvert}\n" +
            $"Fidelite : {fidelite}\n" +
            $"Montant : {montant}";
        }

        public int CompareTo(object o)
        {
            Commande commande = (Commande)o;

            return this.date.CompareTo(commande.date);
        }

        public void CalculerAddition()
        {
            double total = 0;
            foreach (Repas repas in lesRepas)
            {

                total += repas.Prix;

            }
            this.montant = total;

            if (this.fidelite)
            {
                if (client.PointFid > total)
                {
                    client.PointFid = client.PointFid - total;
                    this.montant = 0;

                }
                else
                {

                    total = total - client.PointFid;
                    this.montant = total;
                    client.PointFid = 0;
                }


            }
            client.PointFid += this.montant * 0.05;
        }
    }
}
