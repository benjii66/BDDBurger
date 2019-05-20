namespace BDDBurger.UI
{
    partial class UserCategorie
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVCategorie = new System.Windows.Forms.DataGridView();
            this.IdBurger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerImageSecondaire2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorieImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCategorieImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCategorieDescription = new System.Windows.Forms.TextBox();
            this.tbCategorieLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCategorieSupprimer = new System.Windows.Forms.Button();
            this.btnCategorieCreer = new System.Windows.Forms.Button();
            this.btnCategorieModifier = new System.Windows.Forms.Button();
            this.btnCategorieRaffraîchir = new System.Windows.Forms.Button();
            this.tbModifierCategorieImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModifierCategorieDescription = new System.Windows.Forms.TextBox();
            this.tbModifierCategorieLibelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbModifierCategorieId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCategorie
            // 
            this.DGVCategorie.AllowUserToAddRows = false;
            this.DGVCategorie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategorie.BackgroundColor = System.Drawing.Color.White;
            this.DGVCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBurger,
            this.dgvBurgerImageSecondaire2,
            this.dgvBurgerPrix,
            this.CategorieImage});
            this.DGVCategorie.Location = new System.Drawing.Point(284, 0);
            this.DGVCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVCategorie.Name = "DGVCategorie";
            this.DGVCategorie.ReadOnly = true;
            this.DGVCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVCategorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategorie.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVCategorie.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCategorie.RowTemplate.Height = 24;
            this.DGVCategorie.Size = new System.Drawing.Size(768, 398);
            this.DGVCategorie.TabIndex = 6;
            this.DGVCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategorie_CellContentClick);
            this.DGVCategorie.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategorie_CellContentDoubleClick);
            // 
            // IdBurger
            // 
            this.IdBurger.HeaderText = "Id";
            this.IdBurger.Name = "IdBurger";
            this.IdBurger.ReadOnly = true;
            // 
            // dgvBurgerImageSecondaire2
            // 
            this.dgvBurgerImageSecondaire2.HeaderText = "Libelle";
            this.dgvBurgerImageSecondaire2.Name = "dgvBurgerImageSecondaire2";
            this.dgvBurgerImageSecondaire2.ReadOnly = true;
            // 
            // dgvBurgerPrix
            // 
            this.dgvBurgerPrix.HeaderText = "Description";
            this.dgvBurgerPrix.Name = "dgvBurgerPrix";
            this.dgvBurgerPrix.ReadOnly = true;
            // 
            // CategorieImage
            // 
            this.CategorieImage.HeaderText = "Image";
            this.CategorieImage.Name = "CategorieImage";
            this.CategorieImage.ReadOnly = true;
            // 
            // tbCategorieImage
            // 
            this.tbCategorieImage.Location = new System.Drawing.Point(26, 378);
            this.tbCategorieImage.Name = "tbCategorieImage";
            this.tbCategorieImage.Size = new System.Drawing.Size(242, 22);
            this.tbCategorieImage.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Image";
            // 
            // tbCategorieDescription
            // 
            this.tbCategorieDescription.Location = new System.Drawing.Point(28, 210);
            this.tbCategorieDescription.Name = "tbCategorieDescription";
            this.tbCategorieDescription.Size = new System.Drawing.Size(240, 22);
            this.tbCategorieDescription.TabIndex = 31;
            // 
            // tbCategorieLibelle
            // 
            this.tbCategorieLibelle.Location = new System.Drawing.Point(28, 84);
            this.tbCategorieLibelle.Name = "tbCategorieLibelle";
            this.tbCategorieLibelle.Size = new System.Drawing.Size(240, 22);
            this.tbCategorieLibelle.TabIndex = 30;
            this.tbCategorieLibelle.Text = "E\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Libelle";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(1070, 528);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(239, 43);
            this.btnAnnuler.TabIndex = 43;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCategorieSupprimer
            // 
            this.btnCategorieSupprimer.FlatAppearance.BorderSize = 0;
            this.btnCategorieSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorieSupprimer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnCategorieSupprimer.Location = new System.Drawing.Point(1070, 423);
            this.btnCategorieSupprimer.Name = "btnCategorieSupprimer";
            this.btnCategorieSupprimer.Size = new System.Drawing.Size(239, 43);
            this.btnCategorieSupprimer.TabIndex = 42;
            this.btnCategorieSupprimer.Text = "Supprimer";
            this.btnCategorieSupprimer.UseVisualStyleBackColor = true;
            this.btnCategorieSupprimer.Click += new System.EventHandler(this.btnCategorieSupprimer_Click);
            // 
            // btnCategorieCreer
            // 
            this.btnCategorieCreer.FlatAppearance.BorderSize = 0;
            this.btnCategorieCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorieCreer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieCreer.ForeColor = System.Drawing.Color.White;
            this.btnCategorieCreer.Location = new System.Drawing.Point(235, 423);
            this.btnCategorieCreer.Name = "btnCategorieCreer";
            this.btnCategorieCreer.Size = new System.Drawing.Size(239, 43);
            this.btnCategorieCreer.TabIndex = 40;
            this.btnCategorieCreer.Text = "Créer";
            this.btnCategorieCreer.UseVisualStyleBackColor = true;
            this.btnCategorieCreer.Click += new System.EventHandler(this.btnCategorieCreer_Click);
            // 
            // btnCategorieModifier
            // 
            this.btnCategorieModifier.FlatAppearance.BorderSize = 0;
            this.btnCategorieModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorieModifier.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieModifier.ForeColor = System.Drawing.Color.White;
            this.btnCategorieModifier.Location = new System.Drawing.Point(528, 423);
            this.btnCategorieModifier.Name = "btnCategorieModifier";
            this.btnCategorieModifier.Size = new System.Drawing.Size(239, 43);
            this.btnCategorieModifier.TabIndex = 44;
            this.btnCategorieModifier.Text = "Modifier";
            this.btnCategorieModifier.UseVisualStyleBackColor = true;
            this.btnCategorieModifier.Click += new System.EventHandler(this.btnCategorieModifier_Click);
            // 
            // btnCategorieRaffraîchir
            // 
            this.btnCategorieRaffraîchir.FlatAppearance.BorderSize = 0;
            this.btnCategorieRaffraîchir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorieRaffraîchir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieRaffraîchir.ForeColor = System.Drawing.Color.White;
            this.btnCategorieRaffraîchir.Location = new System.Drawing.Point(844, 423);
            this.btnCategorieRaffraîchir.Name = "btnCategorieRaffraîchir";
            this.btnCategorieRaffraîchir.Size = new System.Drawing.Size(239, 43);
            this.btnCategorieRaffraîchir.TabIndex = 41;
            this.btnCategorieRaffraîchir.Text = "Raffraîchir";
            this.btnCategorieRaffraîchir.UseVisualStyleBackColor = true;
            this.btnCategorieRaffraîchir.Click += new System.EventHandler(this.btnCategorieRaffraîchir_Click);
            // 
            // tbModifierCategorieImage
            // 
            this.tbModifierCategorieImage.Location = new System.Drawing.Point(1070, 382);
            this.tbModifierCategorieImage.Name = "tbModifierCategorieImage";
            this.tbModifierCategorieImage.Size = new System.Drawing.Size(242, 22);
            this.tbModifierCategorieImage.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1212, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Modifier Image";
            // 
            // tbModifierCategorieDescription
            // 
            this.tbModifierCategorieDescription.Location = new System.Drawing.Point(1072, 293);
            this.tbModifierCategorieDescription.Name = "tbModifierCategorieDescription";
            this.tbModifierCategorieDescription.Size = new System.Drawing.Size(240, 22);
            this.tbModifierCategorieDescription.TabIndex = 48;
            // 
            // tbModifierCategorieLibelle
            // 
            this.tbModifierCategorieLibelle.Location = new System.Drawing.Point(1072, 210);
            this.tbModifierCategorieLibelle.Name = "tbModifierCategorieLibelle";
            this.tbModifierCategorieLibelle.Size = new System.Drawing.Size(240, 22);
            this.tbModifierCategorieLibelle.TabIndex = 47;
            this.tbModifierCategorieLibelle.Text = "E\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1179, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Modifier Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1212, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Modifier Libelle";
            // 
            // tbModifierCategorieId
            // 
            this.tbModifierCategorieId.Location = new System.Drawing.Point(1209, 84);
            this.tbModifierCategorieId.Name = "tbModifierCategorieId";
            this.tbModifierCategorieId.Size = new System.Drawing.Size(100, 22);
            this.tbModifierCategorieId.TabIndex = 51;
            this.tbModifierCategorieId.Text = "E\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1206, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Modifier ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UserCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbModifierCategorieId);
            this.Controls.Add(this.tbModifierCategorieImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbModifierCategorieDescription);
            this.Controls.Add(this.tbModifierCategorieLibelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCategorieModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCategorieSupprimer);
            this.Controls.Add(this.btnCategorieRaffraîchir);
            this.Controls.Add(this.btnCategorieCreer);
            this.Controls.Add(this.tbCategorieImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCategorieDescription);
            this.Controls.Add(this.tbCategorieLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVCategorie);
            this.Name = "UserCategorie";
            this.Size = new System.Drawing.Size(1312, 575);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBurger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerImageSecondaire2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorieImage;
        private System.Windows.Forms.TextBox tbCategorieImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCategorieDescription;
        private System.Windows.Forms.TextBox tbCategorieLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCategorieSupprimer;
        private System.Windows.Forms.Button btnCategorieCreer;
        private System.Windows.Forms.Button btnCategorieModifier;
        private System.Windows.Forms.Button btnCategorieRaffraîchir;
        private System.Windows.Forms.TextBox tbModifierCategorieImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbModifierCategorieDescription;
        private System.Windows.Forms.TextBox tbModifierCategorieLibelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbModifierCategorieId;
        private System.Windows.Forms.Label label7;
    }
}
