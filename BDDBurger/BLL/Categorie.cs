using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDBurger
{
   public class Categorie
    {
        #region Attributs

        private int idcategorie;
        private string libelle, description, image;


        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Categorie()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.idcategorie; }
            set { this.idcategorie = value; }
        }

        public string Libelle
        {
            get { return this.libelle; }
            set { this.libelle = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Image
        
        {
            get { return this.image; }
            set { this.image = value; }
        }

        #endregion

    }
}
