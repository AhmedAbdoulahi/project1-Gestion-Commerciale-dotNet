namespace mini_projet1.Formulaires
{
    partial class UserControlProduit
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
            this.dgproduit = new System.Windows.Forms.DataGridView();
            this.cmbxRecherche = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsauvegarde = new System.Windows.Forms.Button();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgproduit
            // 
            this.dgproduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            this.dgproduit.EnableHeadersVisualStyles = false;
            this.dgproduit.Location = new System.Drawing.Point(59, 150);
            this.dgproduit.Name = "dgproduit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgproduit.RowHeadersVisible = false;
            this.dgproduit.Size = new System.Drawing.Size(815, 295);
            this.dgproduit.TabIndex = 17;
            // 
            // cmbxRecherche
            // 
            this.cmbxRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRecherche.ForeColor = System.Drawing.Color.Silver;
            this.cmbxRecherche.FormattingEnabled = true;
            this.cmbxRecherche.Items.AddRange(new object[] {
            "Libelle",
            "Categorie",
            "quantite",
            "prix"});
            this.cmbxRecherche.Location = new System.Drawing.Point(217, 99);
            this.cmbxRecherche.Name = "cmbxRecherche";
            this.cmbxRecherche.Size = new System.Drawing.Size(282, 28);
            this.cmbxRecherche.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(525, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 3);
            this.panel3.TabIndex = 15;
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.Gray;
            this.txtRechercher.Location = new System.Drawing.Point(526, 99);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(224, 27);
            this.txtRechercher.TabIndex = 14;
            this.txtRechercher.Text = "Rechercher";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(59, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(59, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 3);
            this.panel1.TabIndex = 12;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimer.Image = global::mini_projet1.Properties.Resources.Close_2_icon;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(652, 15);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(222, 54);
            this.btnsupprimer.TabIndex = 11;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifier.Image = global::mini_projet1.Properties.Resources.Recycle_iconaaa;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(355, 15);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(222, 54);
            this.btnmodifier.TabIndex = 10;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouter.Image = global::mini_projet1.Properties.Resources.Actions_list_add_icon;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(59, 15);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(222, 54);
            this.btnajouter.TabIndex = 9;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsauvegarde
            // 
            this.btnsauvegarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsauvegarde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsauvegarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsauvegarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsauvegarde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsauvegarde.Image = global::mini_projet1.Properties.Resources.Excel_icon;
            this.btnsauvegarde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsauvegarde.Location = new System.Drawing.Point(652, 466);
            this.btnsauvegarde.Name = "btnsauvegarde";
            this.btnsauvegarde.Size = new System.Drawing.Size(222, 54);
            this.btnsauvegarde.TabIndex = 20;
            this.btnsauvegarde.Text = "Sauvegarder";
            this.btnsauvegarde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsauvegarde.UseVisualStyleBackColor = false;
            // 
            // btnImprimerTout
            // 
            this.btnImprimerTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimerTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnImprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerTout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimerTout.Image = global::mini_projet1.Properties.Resources.Imprimer;
            this.btnImprimerTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimerTout.Location = new System.Drawing.Point(355, 466);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(222, 54);
            this.btnImprimerTout.TabIndex = 19;
            this.btnImprimerTout.Text = "Imprimer tout";
            this.btnImprimerTout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimerTout.UseVisualStyleBackColor = false;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimer.Image = global::mini_projet1.Properties.Resources.Imprimer;
            this.btnImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimer.Location = new System.Drawing.Point(59, 466);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(222, 54);
            this.btnImprimer.TabIndex = 18;
            this.btnImprimer.Text = "Imprimer ";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id_prod";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "libelle";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "prix";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "categorie";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "quantité";
            this.Column5.Name = "Column5";
            // 
            // UserControlProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsauvegarde);
            this.Controls.Add(this.btnImprimerTout);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dgproduit);
            this.Controls.Add(this.cmbxRecherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "UserControlProduit";
            this.Size = new System.Drawing.Size(932, 532);
            this.Load += new System.EventHandler(this.UserControlProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgproduit;
        private System.Windows.Forms.ComboBox cmbxRecherche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsauvegarde;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
