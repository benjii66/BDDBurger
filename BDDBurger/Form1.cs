using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDDBurger
{
    public partial class Form1 : Form
    {
        private Burger unBurger;
        private Categorie uneCategorie;
        private Commande uneCommande;

        public string Libelle { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCoBdd_Click(object sender, EventArgs e)
        {
            Data.ConnexionMySQL();
        }

        private void btnBurgerCreer_Click(object sender, EventArgs e)
        {
            unBurger = new Burger
            {
                Libelle = txtBurgerLibelle.Text,
                DescriptionCourte = txtBurgerDescriptionCourte.Text,
                DescriptionLongue = txtBurgerDescriptionLongue.Text,
                ImagePrincipale = txtBurgerImagePrincipale.Text,
                ImageSecondaire = txtBurgerImageSecondaire.Text,
                ImageSecondaire2 = txtBurgerImageSecondaire2.Text,
                Prix = txtBurgerPrix.Text
            };

            bool resultCreationBurger = Data.CreateBurger(unBurger);

            if(resultCreationBurger)
            {
                MessageBox.Show("Le burger a bien été crée.", "Ajout du burger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec lors de la création du burger.", "Ajout du burger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        private void btnBurgerAfficherDGV_Click(object sender, EventArgs e)
        {
            string[] uneLigneBurger = new string[8];

            //efface le contenu du DGV 
            DGVBurger.Rows.Clear();

            //select all dans la bdd
            Data.SelectAllBurger();

            //parcours de la séléction
            foreach (Burger unBurger in Data.LesBurgers)
            {
                uneLigneBurger[0] = unBurger.Id.ToString();
                uneLigneBurger[1] = unBurger.Libelle;
                uneLigneBurger[2] = unBurger.DescriptionCourte;
                uneLigneBurger[3] = unBurger.DescriptionLongue;
                uneLigneBurger[4] = unBurger.ImagePrincipale;
                uneLigneBurger[5] = unBurger.ImageSecondaire;
                uneLigneBurger[6] = unBurger.ImageSecondaire2;
                uneLigneBurger[7] = unBurger.Prix;
                DGVBurger.Rows.Add(uneLigneBurger);
            }
        }

        /// <summary>
        /// Sélection d'une ligne par un simple clic pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void DGVBurger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère le burger sélectionné
            unBurger = new Burger();
            unBurger.Id = Convert.ToInt32(DGVBurger.CurrentRow.Cells[0].Value);
            unBurger.Libelle = DGVBurger.CurrentRow.Cells[1].Value.ToString();
            unBurger.DescriptionCourte = DGVBurger.CurrentRow.Cells[2].Value.ToString();
            unBurger.DescriptionLongue = DGVBurger.CurrentRow.Cells[3].Value.ToString();
            unBurger.ImagePrincipale = DGVBurger.CurrentRow.Cells[4].Value.ToString();
            unBurger.ImageSecondaire = DGVBurger.CurrentRow.Cells[5].Value.ToString();
            unBurger.ImageSecondaire2 = DGVBurger.CurrentRow.Cells[6].Value.ToString();
            unBurger.Prix = DGVBurger.CurrentRow.Cells[7].Value.ToString();
        }

           
            /// <summary>
            /// Sélection d'une ligne par un double clic pour envoyer les données dans le formulaire de modification
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// <param name="e"></param>
            /// 
            private void DGVBurger_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Enregistre la modification d'un Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void btnBurgerModifier_Click(object sender, EventArgs e)
        {
            // test si le burger est déjà crée
            if (!String.IsNullOrEmpty(txtBurgerModifierId.Text))
            {
                unBurger = new Burger();
                unBurger.Id = Convert.ToInt32(txtBurgerModifierId.Text);
                unBurger.Libelle = txtBurgerModifierLibelle.Text;

                bool resultUpdateBurger = Data.UpdateBurger(unBurger);

                if(resultUpdateBurger)
                {
                    MessageBox.Show("Burger modifié avec succès.", "Modifier Burger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec de modification du Burger.", "Modifier Burger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // pour supprimer le burger sélectionné
        private void btnBurgerSupprimer_Click(object sender, EventArgs e)
        {
            bool resultDeleteBurger = Data.DeleteBurger(unBurger);

            if (resultDeleteBurger)
            {
                MessageBox.Show("Burger supprimé avec succès.", "Supprimer Burger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec de suppression du burger.", "Supprimer Burger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVBurger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère le burger sélectionné
            unBurger = new Burger();
            unBurger.Id = Convert.ToInt32(DGVBurger.CurrentRow.Cells[0].Value);
            unBurger.Libelle = DGVBurger.CurrentRow.Cells[1].Value.ToString();
            unBurger.DescriptionCourte = DGVBurger.CurrentRow.Cells[2].Value.ToString();
            unBurger.DescriptionLongue = DGVBurger.CurrentRow.Cells[3].Value.ToString();
            unBurger.ImagePrincipale = DGVBurger.CurrentRow.Cells[4].Value.ToString();
            unBurger.ImageSecondaire = DGVBurger.CurrentRow.Cells[5].Value.ToString();
            unBurger.ImageSecondaire2 = DGVBurger.CurrentRow.Cells[6].Value.ToString();
            unBurger.Prix = DGVBurger.CurrentRow.Cells[7].Value.ToString();

            //affiche les valeurs de le TB de modification
            txtBurgerModifierId.Text = unBurger.Id.ToString();
            txtBurgerModifierLibelle.Text = unBurger.Libelle;
            txtBurgerModifierDescriptionCourte.Text = unBurger.DescriptionCourte;
            txtBurgerModifierDescriptionLongue.Text = unBurger.DescriptionLongue;
            txtBurgerModifierImagePrincipale.Text = unBurger.ImagePrincipale;
            txtBurgerModifierImageSecondaire.Text = unBurger.ImageSecondaire;
            txtBurgerModifierImageSecondaire2.Text = unBurger.ImageSecondaire2;
            txtBurgerModifierPrix.Text = unBurger.Prix;

        }


        private void btnClientOk_Click(object sender, EventArgs e)
        {

        }

        private void mnuMainServerConnect_Click(object sender, EventArgs e)
        {

        }

        private void lblClientAdresse_Click(object sender, EventArgs e)
        {

        }

        private void txtBurgerModifierImageSecondaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBurgerModifierPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBurgerModifierImagePrincipale_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBurgerModifierDescriptionLongue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBurgerModifierDescriptionCourte_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBurgerModifierLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageCommande_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

      
    }
}
