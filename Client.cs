using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private double tel;
        private string email;
        private double pointFid ;
        public double PointFid
        {
            get { return pointFid; }
            set { pointFid = value; }
        }


        public Client(string nom, string prenom, double tel ,string email, double pointFid)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.email = email;

            this.pointFid = pointFid;
        }

        public override string ToString()
        {
            return $"Client :\nNom : {nom}\nPrenom : {prenom}\nTelephone : {tel}\n" +
                $"Email : {email}" +
                $"Point : {pointFid}";
        }
    }
}
