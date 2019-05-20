namespace BDDBurger.UI
{
    partial class UserBurger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVBurger = new System.Windows.Forms.DataGridView();
            this.IdBurger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerDescriptionCourte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerDescriptionLongue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerImagePrincipale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerImageSecondaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerImageSecondaire2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBurgerPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBurgerCreer = new System.Windows.Forms.Button();
            this.btnBurgerModifier = new System.Windows.Forms.Button();
            this.btnBurgerSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnBurgerAfficherDGV = new System.Windows.Forms.Button();
            this.txtBurgerPrix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBurgerImageSecondaire2 = new System.Windows.Forms.TextBox();
            this.txtBurgerImageSecondaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBurgerImagePrincipale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBurgerDescriptionLongue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBurgerDescriptionCourte = new System.Windows.Forms.TextBox();
            this.txtBurgerLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbModifierBurgerPrix = new System.Windows.Forms.TextBox();
            this.tbModifierBurgerImageSecondaire2 = new System.Windows.Forms.TextBox();
            this.tbModifierBurgerImageSecondaire = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbModifierBurgerImagePrincipale = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbModifierBurgerDescriptionLongue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbModifierBurgerDescriptionCourte = new System.Windows.Forms.TextBox();
            this.tbModifierBurgerLibelle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbModifierBurgerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBurgerId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBurger
            // 
            this.DGVBurger.AllowUserToAddRows = false;
            this.DGVBurger.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVBurger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBurger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBurger.BackgroundColor = System.Drawing.Color.White;
            this.DGVBurger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBurger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVBurger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBurger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBurger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBurger,
            this.dgvBurgerLibelle,
            this.dgvBurgerDescriptionCourte,
            this.dgvBurgerDescriptionLongue,
            this.dgvBurgerImagePrincipale,
            this.dgvBurgerImageSecondaire,
            this.dgvBurgerImageSecondaire2,
            this.dgvBurgerPrix});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBurger.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBurger.Location = new System.Drawing.Point(284, 0);
            this.DGVBurger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVBurger.Name = "DGVBurger";
            this.DGVBurger.ReadOnly = true;
            this.DGVBurger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVBurger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBurger.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVBurger.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVBurger.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVBurger.RowTemplate.Height = 24;
            this.DGVBurger.Size = new System.Drawing.Size(768, 398);
            this.DGVBurger.TabIndex = 5;
            this.DGVBurger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBurger_CellContentClick);
            this.DGVBurger.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBurger_CellContentDoubleClick);
            // 
            // IdBurger
            // 
            this.IdBurger.HeaderText = "Id";
            this.IdBurger.Name = "IdBurger";
            this.IdBurger.ReadOnly = true;
            // 
            // dgvBurgerLibelle
            // 
            this.dgvBurgerLibelle.HeaderText = "Libelle";
            this.dgvBurgerLibelle.Name = "dgvBurgerLibelle";
            this.dgvBurgerLibelle.ReadOnly = true;
            // 
            // dgvBurgerDescriptionCourte
            // 
            this.dgvBurgerDescriptionCourte.HeaderText = "Petite Description";
            this.dgvBurgerDescriptionCourte.Name = "dgvBurgerDescriptionCourte";
            this.dgvBurgerDescriptionCourte.ReadOnly = true;
            // 
            // dgvBurgerDescriptionLongue
            // 
            this.dgvBurgerDescriptionLongue.HeaderText = "Longue Description";
            this.dgvBurgerDescriptionLongue.Name = "dgvBurgerDescriptionLongue";
            this.dgvBurgerDescriptionLongue.ReadOnly = true;
            // 
            // dgvBurgerImagePrincipale
            // 
            this.dgvBurgerImagePrincipale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBurgerImagePrincipale.HeaderText = "Lien Image Principale";
            this.dgvBurgerImagePrincipale.Name = "dgvBurgerImagePrincipale";
            this.dgvBurgerImagePrincipale.ReadOnly = true;
            // 
            // dgvBurgerImageSecondaire
            // 
            this.dgvBurgerImageSecondaire.HeaderText = "Lien Image Secondaire";
            this.dgvBurgerImageSecondaire.Name = "dgvBurgerImageSecondaire";
            this.dgvBurgerImageSecondaire.ReadOnly = true;
            // 
            // dgvBurgerImageSecondaire2
            // 
            this.dgvBurgerImageSecondaire2.HeaderText = "Lien Image Secondaire 2";
            this.dgvBurgerImageSecondaire2.Name = "dgvBurgerImageSecondaire2";
            this.dgvBurgerImageSecondaire2.ReadOnly = true;
            // 
            // dgvBurgerPrix
            // 
            this.dgvBurgerPrix.HeaderText = "Prix";
            this.dgvBurgerPrix.Name = "dgvBurgerPrix";
            this.dgvBurgerPrix.ReadOnly = true;
            // 
            // btnBurgerCreer
            // 
            this.btnBurgerCreer.FlatAppearance.BorderSize = 0;
            this.btnBurgerCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgerCreer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerCreer.ForeColor = System.Drawing.Color.White;
            this.btnBurgerCreer.Location = new System.Drawing.Point(352, 424);
            this.btnBurgerCreer.Name = "btnBurgerCreer";
            this.btnBurgerCreer.Size = new System.Drawing.Size(239, 43);
            this.btnBurgerCreer.TabIndex = 6;
            this.btnBurgerCreer.Text = "Créer";
            this.btnBurgerCreer.UseVisualStyleBackColor = true;
            this.btnBurgerCreer.Click += new System.EventHandler(this.btnBurgerCreer_Click);
            // 
            // btnBurgerModifier
            // 
            this.btnBurgerModifier.FlatAppearance.BorderSize = 0;
            this.btnBurgerModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgerModifier.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerModifier.ForeColor = System.Drawing.Color.White;
            this.btnBurgerModifier.Location = new System.Drawing.Point(861, 424);
            this.btnBurgerModifier.Name = "btnBurgerModifier";
            this.btnBurgerModifier.Size = new System.Drawing.Size(239, 43);
            this.btnBurgerModifier.TabIndex = 22;
            this.btnBurgerModifier.Text = "Modifier";
            this.btnBurgerModifier.UseVisualStyleBackColor = true;
            this.btnBurgerModifier.Click += new System.EventHandler(this.btnBurgerModifier_Click);
            // 
            // btnBurgerSupprimer
            // 
            this.btnBurgerSupprimer.FlatAppearance.BorderSize = 0;
            this.btnBurgerSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgerSupprimer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnBurgerSupprimer.Location = new System.Drawing.Point(1073, 424);
            this.btnBurgerSupprimer.Name = "btnBurgerSupprimer";
            this.btnBurgerSupprimer.Size = new System.Drawing.Size(239, 43);
            this.btnBurgerSupprimer.TabIndex = 23;
            this.btnBurgerSupprimer.Text = "Supprimer";
            this.btnBurgerSupprimer.UseVisualStyleBackColor = true;
            this.btnBurgerSupprimer.Click += new System.EventHandler(this.btnBurgerSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(1073, 529);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(239, 43);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnBurgerAfficherDGV
            // 
            this.btnBurgerAfficherDGV.FlatAppearance.BorderSize = 0;
            this.btnBurgerAfficherDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgerAfficherDGV.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerAfficherDGV.ForeColor = System.Drawing.Color.White;
            this.btnBurgerAfficherDGV.Location = new System.Drawing.Point(616, 424);
            this.btnBurgerAfficherDGV.Name = "btnBurgerAfficherDGV";
            this.btnBurgerAfficherDGV.Size = new System.Drawing.Size(239, 43);
            this.btnBurgerAfficherDGV.TabIndex = 25;
            this.btnBurgerAfficherDGV.Text = "Raffraîchir";
            this.btnBurgerAfficherDGV.UseVisualStyleBackColor = true;
            this.btnBurgerAfficherDGV.Click += new System.EventHandler(this.btnBurgerAfficherDGV_Click);
            // 
            // txtBurgerPrix
            // 
            this.txtBurgerPrix.Location = new System.Drawing.Point(74, 358);
            this.txtBurgerPrix.Name = "txtBurgerPrix";
            this.txtBurgerPrix.Size = new System.Drawing.Size(38, 22);
            this.txtBurgerPrix.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Prix";
            // 
            // txtBurgerImageSecondaire2
            // 
            this.txtBurgerImageSecondaire2.Location = new System.Drawing.Point(40, 320);
            this.txtBurgerImageSecondaire2.Name = "txtBurgerImageSecondaire2";
            this.txtBurgerImageSecondaire2.Size = new System.Drawing.Size(242, 22);
            this.txtBurgerImageSecondaire2.TabIndex = 47;
            // 
            // txtBurgerImageSecondaire
            // 
            this.txtBurgerImageSecondaire.Location = new System.Drawing.Point(40, 257);
            this.txtBurgerImageSecondaire.Name = "txtBurgerImageSecondaire";
            this.txtBurgerImageSecondaire.Size = new System.Drawing.Size(242, 22);
            this.txtBurgerImageSecondaire.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Lien Image Secondaire 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lien Image Secondaire";
            // 
            // txtBurgerImagePrincipale
            // 
            this.txtBurgerImagePrincipale.Location = new System.Drawing.Point(40, 201);
            this.txtBurgerImagePrincipale.Name = "txtBurgerImagePrincipale";
            this.txtBurgerImagePrincipale.Size = new System.Drawing.Size(242, 22);
            this.txtBurgerImagePrincipale.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Lien Image Principale";
            // 
            // txtBurgerDescriptionLongue
            // 
            this.txtBurgerDescriptionLongue.Location = new System.Drawing.Point(40, 143);
            this.txtBurgerDescriptionLongue.Name = "txtBurgerDescriptionLongue";
            this.txtBurgerDescriptionLongue.Size = new System.Drawing.Size(242, 22);
            this.txtBurgerDescriptionLongue.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Description Longue";
            // 
            // txtBurgerDescriptionCourte
            // 
            this.txtBurgerDescriptionCourte.Location = new System.Drawing.Point(40, 84);
            this.txtBurgerDescriptionCourte.Name = "txtBurgerDescriptionCourte";
            this.txtBurgerDescriptionCourte.Size = new System.Drawing.Size(240, 22);
            this.txtBurgerDescriptionCourte.TabIndex = 39;
            // 
            // txtBurgerLibelle
            // 
            this.txtBurgerLibelle.Location = new System.Drawing.Point(40, 22);
            this.txtBurgerLibelle.Name = "txtBurgerLibelle";
            this.txtBurgerLibelle.Size = new System.Drawing.Size(240, 22);
            this.txtBurgerLibelle.TabIndex = 38;
            this.txtBurgerLibelle.Text = "E\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Description Courte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Libellé";
            // 
            // tbModifierBurgerPrix
            // 
            this.tbModifierBurgerPrix.Location = new System.Drawing.Point(1149, 368);
            this.tbModifierBurgerPrix.Name = "tbModifierBurgerPrix";
            this.tbModifierBurgerPrix.Size = new System.Drawing.Size(50, 22);
            this.tbModifierBurgerPrix.TabIndex = 63;
            // 
            // tbModifierBurgerImageSecondaire2
            // 
            this.tbModifierBurgerImageSecondaire2.Location = new System.Drawing.Point(1071, 327);
            this.tbModifierBurgerImageSecondaire2.Name = "tbModifierBurgerImageSecondaire2";
            this.tbModifierBurgerImageSecondaire2.Size = new System.Drawing.Size(242, 22);
            this.tbModifierBurgerImageSecondaire2.TabIndex = 61;
            // 
            // tbModifierBurgerImageSecondaire
            // 
            this.tbModifierBurgerImageSecondaire.Location = new System.Drawing.Point(1071, 264);
            this.tbModifierBurgerImageSecondaire.Name = "tbModifierBurgerImageSecondaire";
            this.tbModifierBurgerImageSecondaire.Size = new System.Drawing.Size(242, 22);
            this.tbModifierBurgerImageSecondaire.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1094, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Modifier Lien Image Secondaire 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1106, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Modifier Lien Image Secondaire";
            // 
            // tbModifierBurgerImagePrincipale
            // 
            this.tbModifierBurgerImagePrincipale.Location = new System.Drawing.Point(1071, 208);
            this.tbModifierBurgerImagePrincipale.Name = "tbModifierBurgerImagePrincipale";
            this.tbModifierBurgerImagePrincipale.Size = new System.Drawing.Size(242, 22);
            this.tbModifierBurgerImagePrincipale.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1116, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Modifier Lien Image Principale";
            // 
            // tbModifierBurgerDescriptionLongue
            // 
            this.tbModifierBurgerDescriptionLongue.Location = new System.Drawing.Point(1071, 150);
            this.tbModifierBurgerDescriptionLongue.Name = "tbModifierBurgerDescriptionLongue";
            this.tbModifierBurgerDescriptionLongue.Size = new System.Drawing.Size(242, 22);
            this.tbModifierBurgerDescriptionLongue.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1128, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Modifier Description Longue";
            // 
            // tbModifierBurgerDescriptionCourte
            // 
            this.tbModifierBurgerDescriptionCourte.Location = new System.Drawing.Point(1071, 91);
            this.tbModifierBurgerDescriptionCourte.Name = "tbModifierBurgerDescriptionCourte";
            this.tbModifierBurgerDescriptionCourte.Size = new System.Drawing.Size(240, 22);
            this.tbModifierBurgerDescriptionCourte.TabIndex = 53;
            // 
            // tbModifierBurgerLibelle
            // 
            this.tbModifierBurgerLibelle.Location = new System.Drawing.Point(1071, 29);
            this.tbModifierBurgerLibelle.Name = "tbModifierBurgerLibelle";
            this.tbModifierBurgerLibelle.Size = new System.Drawing.Size(240, 22);
            this.tbModifierBurgerLibelle.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1133, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Modifier Description Courte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1208, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Modifier Libellé";
            // 
            // tbModifierBurgerId
            // 
            this.tbModifierBurgerId.Location = new System.Drawing.Point(1258, 368);
            this.tbModifierBurgerId.Name = "tbModifierBurgerId";
            this.tbModifierBurgerId.Size = new System.Drawing.Size(53, 22);
            this.tbModifierBurgerId.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1058, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Modifier Prix";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1223, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 17);
            this.label15.TabIndex = 65;
            this.label15.Text = "Id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(161, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 17);
            this.label16.TabIndex = 66;
            this.label16.Text = "Id";
            // 
            // tbBurgerId
            // 
            this.tbBurgerId.Location = new System.Drawing.Point(213, 361);
            this.tbBurgerId.Name = "tbBurgerId";
            this.tbBurgerId.Size = new System.Drawing.Size(53, 22);
            this.tbBurgerId.TabIndex = 67;
            // 
            // UserBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tbBurgerId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbModifierBurgerId);
            this.Controls.Add(this.tbModifierBurgerPrix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbModifierBurgerImageSecondaire2);
            this.Controls.Add(this.tbModifierBurgerImageSecondaire);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbModifierBurgerImagePrincipale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbModifierBurgerDescriptionLongue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbModifierBurgerDescriptionCourte);
            this.Controls.Add(this.tbModifierBurgerLibelle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBurgerPrix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBurgerImageSecondaire2);
            this.Controls.Add(this.txtBurgerImageSecondaire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBurgerImagePrincipale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBurgerDescriptionLongue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBurgerDescriptionCourte);
            this.Controls.Add(this.txtBurgerLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBurgerAfficherDGV);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnBurgerSupprimer);
            this.Controls.Add(this.btnBurgerModifier);
            this.Controls.Add(this.btnBurgerCreer);
            this.Controls.Add(this.DGVBurger);
            this.Name = "UserBurger";
            this.Size = new System.Drawing.Size(1312, 575);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBurger;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBurger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerDescriptionCourte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerDescriptionLongue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerImagePrincipale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerImageSecondaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerImageSecondaire2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBurgerPrix;
        private System.Windows.Forms.Button btnBurgerCreer;
        private System.Windows.Forms.Button btnBurgerModifier;
        private System.Windows.Forms.Button btnBurgerSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnBurgerAfficherDGV;
        private System.Windows.Forms.TextBox txtBurgerPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBurgerImageSecondaire2;
        private System.Windows.Forms.TextBox txtBurgerImageSecondaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBurgerImagePrincipale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBurgerDescriptionLongue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBurgerDescriptionCourte;
        private System.Windows.Forms.TextBox txtBurgerLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbModifierBurgerPrix;
        private System.Windows.Forms.TextBox tbModifierBurgerImageSecondaire2;
        private System.Windows.Forms.TextBox tbModifierBurgerImageSecondaire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbModifierBurgerImagePrincipale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbModifierBurgerDescriptionLongue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbModifierBurgerDescriptionCourte;
        private System.Windows.Forms.TextBox tbModifierBurgerLibelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbModifierBurgerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbBurgerId;
    }
}
