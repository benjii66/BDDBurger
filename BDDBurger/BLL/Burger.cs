using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDBurger
{
    public class Burger
    {
        #region Attributs

        private int idburger;
        private string libelle, description_court, description_long, image_principale, image_secondaire1, image_secondaire2, prix; 
        

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Burger()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.idburger; }
            set { this.idburger = value; }
        }

        public string Libelle
        {
            get { return this.libelle; }
            set { this.libelle = value; }
        }

        public string DescriptionCourte
        {
            get { return this.description_court; }
            set { this.description_court = value; }
        }

        public string DescriptionLongue
        {
            get { return this.description_long; }
            set { this.description_long = value; }
        }

        public string ImagePrincipale
        {
            get { return this.image_principale; }
            set { this.image_principale = value; }
        }

        public string ImageSecondaire
        {
            get { return this.image_secondaire1; }
            set { this.image_secondaire1 = value; }
        }

        public string ImageSecondaire2
        {
            get { return this.image_secondaire2; }
            set { this.image_secondaire2 = value; }
        }

        public string Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        #endregion

    }
}
