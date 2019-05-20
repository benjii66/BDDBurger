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
    public partial class UserUtilisateur : UserControl
    {
        private Commande unUtilisateur;

        public UserUtilisateur()
        {
            InitializeComponent();
        }

        private void UserUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void DGVUtilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            unUtilisateur = new Commande();

            unUtilisateur.NomComplet = DGVUtilisateur.CurrentRow.Cells[1].Value.ToString();
            unUtilisateur.Email = DGVUtilisateur.CurrentRow.Cells[2].Value.ToString();
            unUtilisateur.Adresse = DGVUtilisateur.CurrentRow.Cells[3].Value.ToString();
            unUtilisateur.Ville = DGVUtilisateur.CurrentRow.Cells[4].Value.ToString();
            unUtilisateur.CodePostal = DGVUtilisateur.CurrentRow.Cells[5].Value.ToString();
            unUtilisateur.Telephone = DGVUtilisateur.CurrentRow.Cells[6].Value.ToString();
            unUtilisateur.CreeLe = DGVUtilisateur.CurrentRow.Cells[7].Value.ToString();
        }

        private void DGVUtilisateur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            unUtilisateur = new Commande();
            unUtilisateur.Id = Convert.ToInt32(DGVUtilisateur.CurrentRow.Cells[0].Value);
            unUtilisateur.NomComplet = DGVUtilisateur.CurrentRow.Cells[1].Value.ToString();
            unUtilisateur.Email = DGVUtilisateur.CurrentRow.Cells[2].Value.ToString();
            unUtilisateur.Adresse = DGVUtilisateur.CurrentRow.Cells[3].Value.ToString();
            unUtilisateur.Ville = DGVUtilisateur.CurrentRow.Cells[4].Value.ToString();
            unUtilisateur.CodePostal = DGVUtilisateur.CurrentRow.Cells[5].Value.ToString();
            unUtilisateur.Telephone = DGVUtilisateur.CurrentRow.Cells[6].Value.ToString();
            unUtilisateur.CreeLe = DGVUtilisateur.CurrentRow.Cells[7].Value.ToString();

            //affiche les valeurs dans les tb de modifs
            tbModifierUtilisateurNom.Text = unUtilisateur.NomComplet;
            tbModifierUtilisateurEmail.Text = unUtilisateur.Email;
            tbModifierUtilisateurAdresse.Text = unUtilisateur.Adresse;
            tbModifierUtilisateurVille.Text = unUtilisateur.Ville;
            tbModifierUtilisateurCodePostal.Text = unUtilisateur.CodePostal;
        }

        private void btnRaffraîchirUtilisateur_Click(object sender, EventArgs e)
        {
            string[] uneLigneCommande = new string[8];

            //efface le contenu du DGV
            DGVUtilisateur.Rows.Clear();

            //select all dans la bdd
            Data.SelectAllCommande();

            //parcours de la séléction 
            foreach (Commande unUtilisateur in Data.LesCommandes)
            {
                uneLigneCommande[0] = unUtilisateur.Id.ToString();
                uneLigneCommande[1] = unUtilisateur.NomComplet;
                uneLigneCommande[2] = unUtilisateur.Email;
                uneLigneCommande[3] = unUtilisateur.Adresse;
                uneLigneCommande[4] = unUtilisateur.Ville;
                uneLigneCommande[5] = unUtilisateur.CodePostal;
                uneLigneCommande[6] = unUtilisateur.Telephone;
                DGVUtilisateur.Rows.Add(uneLigneCommande);
            }
        }

        private void btnUtilisateurCreer_Click(object sender, EventArgs e)
        {
            unUtilisateur = new Commande
            {
                NomComplet = tbUtilisateurNom.Text,
                Email = tbUtilisateurEmail.Text,
                Adresse = tbUtilisateurAdresse.Text,
                Ville = tbUtilisateurVille.Text,
                CodePostal = tbUtilisateurCodePostal.Text,
                Telephone = tbUtilisateurTelephone.Text
              

            };

            bool resultCreationBurger = Data.CreateCommande(unUtilisateur);

            if (resultCreationBurger)
            {
                MessageBox.Show("L'utilisateur a bien été crée.", "Ajout de l'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec lors de la création de l'utilisateur.", "Ajout de l'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            bool resultDeleteCommande = Data.DeleteCommande(unUtilisateur);
            if (resultDeleteCommande)
            {
                MessageBox.Show("Utilisateur supprimé avec succès.", "Supprimer Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Échec de suppression de l'utilisateur.", "Supprimer Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            // test si la commande a déjà été crée
            if (!String.IsNullOrEmpty(tbModifierUtilisateurNom.Text))
            {
                unUtilisateur = new Commande();
                unUtilisateur.NomComplet = tbModifierUtilisateurNom.Text;
                unUtilisateur.Email = tbUtilisateurEmail.Text;
                unUtilisateur.Adresse = tbUtilisateurAdresse.Text;
                unUtilisateur.Ville = tbUtilisateurVille.Text;
                unUtilisateur.CodePostal = tbUtilisateurCodePostal.Text;            
                unUtilisateur.Telephone = tbUtilisateurTelephone.Text;

                bool resultUpdateCommande = Data.UpdateCommande(unUtilisateur);

                if (resultUpdateCommande)
                {
                    MessageBox.Show("Utilisateur modifié avec succès.", "Modifier Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec de modification de l'utilisateur.", "Modifier Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DGVUtilisateur_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            unUtilisateur = new Commande();

            unUtilisateur.NomComplet = DGVUtilisateur.CurrentRow.Cells[1].Value.ToString();
            unUtilisateur.Email = DGVUtilisateur.CurrentRow.Cells[2].Value.ToString();
            unUtilisateur.Adresse = DGVUtilisateur.CurrentRow.Cells[3].Value.ToString();
            unUtilisateur.Ville = DGVUtilisateur.CurrentRow.Cells[4].Value.ToString();
            unUtilisateur.CodePostal = DGVUtilisateur.CurrentRow.Cells[5].Value.ToString();
            unUtilisateur.Telephone = DGVUtilisateur.CurrentRow.Cells[6].Value.ToString();
            unUtilisateur.CreeLe = DGVUtilisateur.CurrentRow.Cells[6].Value.ToString();
        }


        private void DGVUtilisateur_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //récupère la commande sélectionnée
            unUtilisateur = new Commande();
            unUtilisateur.Id = Convert.ToInt32(DGVUtilisateur.CurrentRow.Cells[0].Value);
            unUtilisateur.NomComplet = DGVUtilisateur.CurrentRow.Cells[1].Value.ToString();
            unUtilisateur.Email = DGVUtilisateur.CurrentRow.Cells[2].Value.ToString();
            unUtilisateur.Adresse = DGVUtilisateur.CurrentRow.Cells[3].Value.ToString();
            unUtilisateur.Ville = DGVUtilisateur.CurrentRow.Cells[4].Value.ToString();
            unUtilisateur.CodePostal = DGVUtilisateur.CurrentRow.Cells[5].Value.ToString();
            unUtilisateur.Telephone = DGVUtilisateur.CurrentRow.Cells[6].Value.ToString();

            //affiche les valeurs dans les tb de modifs
            tbModifierUtilisateurNom.Text = unUtilisateur.NomComplet;
            tbModifierUtilisateurEmail.Text = unUtilisateur.Email;
            tbModifierUtilisateurAdresse.Text = unUtilisateur.Adresse;
            tbModifierUtilisateurVille.Text = unUtilisateur.Ville;
            tbModifierUtilisateurCodePostal.Text = unUtilisateur.CodePostal;
            tbModifierUtilisateurTelephone.Text = unUtilisateur.Telephone;
        }
    }
}
