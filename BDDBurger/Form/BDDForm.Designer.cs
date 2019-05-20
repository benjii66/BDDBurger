namespace BDDBurger
{
    partial class BDDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDDForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLienBurger = new System.Windows.Forms.LinkLabel();
            this.btnCoBdd = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnCategorie);
            this.panel1.Controls.Add(this.btnCommande);
            this.panel1.Controls.Add(this.btnBurger);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 713);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCategorie
            // 
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.White;
            this.btnCategorie.Location = new System.Drawing.Point(0, 420);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(250, 134);
            this.btnCategorie.TabIndex = 3;
            this.btnCategorie.Text = "Catégorie";
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.Location = new System.Drawing.Point(0, 294);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(250, 134);
            this.btnCommande.TabIndex = 2;
            this.btnCommande.Text = "Commandes";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.FlatAppearance.BorderSize = 0;
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurger.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.ForeColor = System.Drawing.Color.White;
            this.btnBurger.Location = new System.Drawing.Point(0, 154);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(250, 134);
            this.btnBurger.TabIndex = 1;
            this.btnBurger.Text = "Burger";
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 145);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Notram", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 142);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(250, 138);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1312, 575);
            this.panelControls.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(250, 170);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 100);
            this.panelLeft.TabIndex = 2;
            // 
            // btnOff
            // 
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.Location = new System.Drawing.Point(1487, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 43);
            this.btnOff.TabIndex = 3;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(647, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Administration Burger";
            // 
            // LblLienBurger
            // 
            this.LblLienBurger.AutoSize = true;
            this.LblLienBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLienBurger.LinkColor = System.Drawing.Color.White;
            this.LblLienBurger.Location = new System.Drawing.Point(1458, 110);
            this.LblLienBurger.Name = "LblLienBurger";
            this.LblLienBurger.Size = new System.Drawing.Size(104, 25);
            this.LblLienBurger.TabIndex = 7;
            this.LblLienBurger.TabStop = true;
            this.LblLienBurger.Text = "SiteBurger";
            // 
            // btnCoBdd
            // 
            this.btnCoBdd.FlatAppearance.BorderSize = 0;
            this.btnCoBdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoBdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoBdd.ForeColor = System.Drawing.Color.White;
            this.btnCoBdd.Location = new System.Drawing.Point(250, -2);
            this.btnCoBdd.Name = "btnCoBdd";
            this.btnCoBdd.Size = new System.Drawing.Size(250, 63);
            this.btnCoBdd.TabIndex = 5;
            this.btnCoBdd.Text = "Connexion à la base";
            this.btnCoBdd.UseVisualStyleBackColor = true;
            this.btnCoBdd.Click += new System.EventHandler(this.btnCoBdd_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 549);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(250, 134);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Utilisateurs";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // BDDForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.btnCoBdd);
            this.Controls.Add(this.LblLienBurger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BDDForm";
            this.Text = "BDDForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LblLienBurger;
        private System.Windows.Forms.Button btnCoBdd;
        private System.Windows.Forms.Button btnUser;
    }
}