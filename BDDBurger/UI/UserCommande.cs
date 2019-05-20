using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDDBurger.UI
{
    public partial class UserCommande : UserControl
    {
       private Commande uneCommande;
        public UserCommande()
        {
            InitializeComponent();
        }

        private void btnRaffraîchirCommande_Click(object sender, EventArgs e)
        {
            string[] uneLigneCommande = new string[8];

            //efface le contenu du DGV
            DGVCommande.Rows.Clear();

            //select all dans la bdd
            Data.SelectAllCommande();

            //parcours de la séléction 
            foreach (Commande uneCommande in Data.LesCommandes)
            {
                uneLigneCommande[0] = uneCommande.Id.ToString();
                uneLigneCommande[1] = uneCommande.NomComplet;
                uneLigneCommande[2] = uneCommande.Email;
                uneLigneCommande[3] = uneCommande.Adresse;
                uneLigneCommande[4] = uneCommande.Ville;
                uneLigneCommande[5] = uneCommande.CodePostal;
                uneLigneCommande[6] = uneCommande.Telephone;
                uneLigneCommande[7] = uneCommande.CreeLe;
                DGVCommande.Rows.Add(uneLigneCommande);
            }
        }

      
        ///<summary>
        ///Séléction d'une ligne pour pouvoir supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void DGVCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            uneCommande = new Commande();

            uneCommande.Id = Convert.ToInt32(DGVCommande.CurrentRow.Cells[0].Value);
            uneCommande.NomComplet = DGVCommande.CurrentRow.Cells[1].Value.ToString();
            uneCommande.Email = DGVCommande.CurrentRow.Cells[2].Value.ToString();
            uneCommande.Adresse = DGVCommande.CurrentRow.Cells[3].Value.ToString();
            uneCommande.Ville = DGVCommande.CurrentRow.Cells[4].Value.ToString();
            uneCommande.CodePostal = DGVCommande.CurrentRow.Cells[5].Value.ToString();
            uneCommande.Telephone = DGVCommande.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnModifierCommande_Click(object sender, EventArgs e)
        {
            // test si la commande a déjà été crée
            if(!String.IsNullOrEmpty(tbModifierCommandeId.Text))
            {
                uneCommande = new Commande();
                uneCommande.Id = Convert.ToInt32(tbModifierCommandeId.Text);
                uneCommande.NomComplet = tbModifierCommandeNom.Text;
                uneCommande.Email = tbModifierCommandeEmail.Text;
                uneCommande.Adresse = tbModifierCommandeAdresse.Text;
                uneCommande.Ville = tbModifierCommandeVille.Text;
                uneCommande.CodePostal = tbModifierCommandeCodePostal.Text;
                uneCommande.Telephone = tbModifierCommandeTelephone.Text;

                bool resultUpdateCommande = Data.UpdateCommande(uneCommande);

                if (resultUpdateCommande)
                {
                    MessageBox.Show("Commande modifiée avec succès.", "Modifier Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec de modification de la Commande.", "Modifier Commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            bool resultDeleteCommande = Data.DeleteCommande(uneCommande);
            if(resultDeleteCommande)
            {
                MessageBox.Show("Commande supprimée avec succès.", "Supprimer Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec de suppression de la Commande.", "Supprimer Commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DGVCommande_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            uneCommande = new Commande();
            uneCommande.Id = Convert.ToInt32(DGVCommande.CurrentRow.Cells[0].Value);
            uneCommande.NomComplet = DGVCommande.CurrentRow.Cells[1].Value.ToString();
            uneCommande.Email = DGVCommande.CurrentRow.Cells[2].Value.ToString();
            uneCommande.Adresse = DGVCommande.CurrentRow.Cells[3].Value.ToString();
            uneCommande.Ville = DGVCommande.CurrentRow.Cells[4].Value.ToString();
            uneCommande.CodePostal = DGVCommande.CurrentRow.Cells[5].Value.ToString();
            uneCommande.Telephone = DGVCommande.CurrentRow.Cells[6].Value.ToString();

            //affiche les valeurs dans les tb de modifs
            tbModifierCommandeId.Text = uneCommande.Id.ToString();
            tbModifierCommandeNom.Text = uneCommande.NomComplet;
            tbModifierCommandeEmail.Text = uneCommande.Email;
            tbModifierCommandeAdresse.Text = uneCommande.Adresse;
            tbModifierCommandeVille.Text = uneCommande.Ville;
            tbModifierCommandeCodePostal.Text = uneCommande.CodePostal;
            tbModifierCommandeTelephone.Text = uneCommande.Telephone;
            



        }

        private void tbModifierCommandeId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
