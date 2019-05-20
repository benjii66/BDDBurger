using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDDBurger.UI;

namespace BDDBurger.UI
{
    public partial class UserCategorie : UserControl
    {
        private Categorie uneCategorie;
        public UserCategorie()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCategorieCreer_Click(object sender, EventArgs e)
        {
            uneCategorie = new Categorie
            {
                Libelle = tbCategorieLibelle.Text,
                Description = tbCategorieDescription.Text,
                Image = tbCategorieImage.Text,
          
            };

            bool resultCreationCategorie = Data.CreateCategorie(uneCategorie);

            if(resultCreationCategorie)
            {
                MessageBox.Show("La Catégorie a bien été crée.", "Ajout de la Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec lors de la création de la Catégorie.", "Ajout de la Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnCategorieRaffraîchir_Click(object sender, EventArgs e)
        {
            string[] uneLigneCatégorie = new string[4];


            //efface le contenu du DGV
            DGVCategorie.Rows.Clear();

            //select all dans la bdd
            Data.SelectAllCategories();


            //parcours de la séléction
            foreach (Categorie uneCategorie in Data.LesCategories)
            {
                uneLigneCatégorie[0] = uneCategorie.Id.ToString();
                uneLigneCatégorie[1] = uneCategorie.Libelle;
                uneLigneCatégorie[2] = uneCategorie.Description;
                uneLigneCatégorie[3] = uneCategorie.Image;
                DGVCategorie.Rows.Add(uneLigneCatégorie);
            }

           
        }

        /// <summary>
        /// Sélection d'une ligne par un simple clic pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void DGVCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void btnCategorieModifier_Click(object sender, EventArgs e)
        {
            // test si le burger est déjà crée
            if (!String.IsNullOrEmpty(tbModifierCategorieLibelle.Text))
            {
                uneCategorie = new Categorie();
                uneCategorie.Id = Convert.ToInt32(tbModifierCategorieId.Text);
                uneCategorie.Libelle = tbModifierCategorieLibelle.Text;
                uneCategorie.Description = tbModifierCategorieLibelle.Text;
                uneCategorie.Image = tbModifierCategorieImage.Text;



                bool resultUpdateCategorie = Data.UpdateCategorie(uneCategorie);

                if (resultUpdateCategorie)
                {
                    MessageBox.Show("Catégorie modifiée avec succès.", "Modifier Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec de modification de la Catégorie.", "Modifier Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCategorieSupprimer_Click(object sender, EventArgs e)
        {
            bool resultDeleteCategorie = Data.DeleteCategorie(uneCategorie);

            if (resultDeleteCategorie)
            {
                MessageBox.Show("Catégorie supprimée avec succès.", "Supprimer Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec de suppression de la Catégorie.", "Supprimer Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGVCategorie_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la catégorie sélectionnée
            uneCategorie = new Categorie();
            uneCategorie.Id = Convert.ToInt32(DGVCategorie.CurrentRow.Cells[0].Value);
            uneCategorie.Libelle = DGVCategorie.CurrentRow.Cells[1].Value.ToString();
            uneCategorie.Description = DGVCategorie.CurrentRow.Cells[2].Value.ToString();
            uneCategorie.Image = DGVCategorie.CurrentRow.Cells[3].Value.ToString();

            //affiche dans le tb de modification
            tbModifierCategorieId.Text = uneCategorie.Id.ToString();
            tbModifierCategorieLibelle.Text = uneCategorie.Libelle;
            tbModifierCategorieDescription.Text = uneCategorie.Description;
            tbModifierCategorieImage.Text = uneCategorie.Image;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
