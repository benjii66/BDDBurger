using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDBurger
{
   public class Commande
    {
        #region Attributs

        private int idcommande;
        private string full_name, email, address, city, zip_code, telephone, created_at;


        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Commande()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.idcommande; }
            set { this.idcommande = value; }
        }

        public string NomComplet
        {
            get { return this.full_name; }
            set { this.full_name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Adresse
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Ville
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string CodePostal
        {
            get { return this.zip_code; }
            set { this.zip_code = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public string CreeLe
        {
            get { return this.created_at; }
            set { this.created_at = value; }
        }

        #endregion
    }
}
