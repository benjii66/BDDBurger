using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDDBurger.UI;

namespace BDDBurger
{
    public partial class BDDForm : Form
    {   
     public BDDForm()
        {
            InitializeComponent();
            panelLeft.Height = btnBurger.Height;
            panelLeft.Top = btnBurger.Top;
            UserHome uh = new UserHome();
            AddControlsToPanel(uh);
        }


        //la barre de défilement sur le côté
        private void barrePanel(Control btn)
        {
            panelLeft.Top = btn.Top;
            panelLeft.Height = btn.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //pour afficher l'interface lié au bouton sélectionné
       
        private void AddControlsToPanel (Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);

        }

        //quand on clique sur le bouton, l'interface utilisateur s'affiche dans la zone du bas du form
        private void btnBurger_Click(object sender, EventArgs e)
        {
            barrePanel(btnBurger);
            UserBurger ub = new UserBurger();
            AddControlsToPanel(ub);
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            barrePanel(btnCommande);
            UserCommande uc = new UserCommande();
            AddControlsToPanel(uc);
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            barrePanel(btnCategorie);
            UserCategorie ucat = new UserCategorie();
            AddControlsToPanel(ucat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserHome uh = new UserHome();
            AddControlsToPanel(uh);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            UserHome uh = new UserHome();
            AddControlsToPanel(uh);
        }

        private void btnCoBdd_Click(object sender, EventArgs e)
        {
            Data.ConnexionMySQL();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            barrePanel(btnUser);
            UserUtilisateur uuser = new UserUtilisateur();
            AddControlsToPanel(uuser);

        }
    }
}
