namespace SAE24
{
    partial class frmAccueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.btnNewMission = new System.Windows.Forms.Button();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnInfosPlanetes = new System.Windows.Forms.Button();
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMission = new System.Windows.Forms.Label();
            this.cboFiltre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermerAppli = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMission
            // 
            this.btnNewMission.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMission.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewMission.FlatAppearance.BorderSize = 2;
            this.btnNewMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNewMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMission.ForeColor = System.Drawing.Color.White;
            this.btnNewMission.Location = new System.Drawing.Point(201, 234);
            this.btnNewMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewMission.Name = "btnNewMission";
            this.btnNewMission.Size = new System.Drawing.Size(332, 95);
            this.btnNewMission.TabIndex = 4;
            this.btnNewMission.Text = "Nouvelle mission";
            this.btnNewMission.UseVisualStyleBackColor = false;
            this.btnNewMission.Click += new System.EventHandler(this.btnNewMission_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.BackColor = System.Drawing.Color.Transparent;
            this.btnRaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaces.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRaces.FlatAppearance.BorderSize = 2;
            this.btnRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaces.ForeColor = System.Drawing.Color.White;
            this.btnRaces.Location = new System.Drawing.Point(201, 382);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(332, 95);
            this.btnRaces.TabIndex = 5;
            this.btnRaces.Text = "Découverte des races";
            this.btnRaces.UseVisualStyleBackColor = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnInfosPlanetes
            // 
            this.btnInfosPlanetes.BackColor = System.Drawing.Color.Transparent;
            this.btnInfosPlanetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfosPlanetes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfosPlanetes.FlatAppearance.BorderSize = 2;
            this.btnInfosPlanetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInfosPlanetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfosPlanetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfosPlanetes.ForeColor = System.Drawing.Color.White;
            this.btnInfosPlanetes.Location = new System.Drawing.Point(201, 529);
            this.btnInfosPlanetes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfosPlanetes.Name = "btnInfosPlanetes";
            this.btnInfosPlanetes.Size = new System.Drawing.Size(332, 95);
            this.btnInfosPlanetes.TabIndex = 6;
            this.btnInfosPlanetes.Text = "Infos Planètes";
            this.btnInfosPlanetes.UseVisualStyleBackColor = false;
            this.btnInfosPlanetes.Click += new System.EventHandler(this.btnInfosPlanetes_Click);
            // 
            // flpMissions
            // 
            this.flpMissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMissions.AutoScroll = true;
            this.flpMissions.BackColor = System.Drawing.Color.Transparent;
            this.flpMissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpMissions.Location = new System.Drawing.Point(851, 111);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(980, 685);
            this.flpMissions.TabIndex = 7;
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.BackColor = System.Drawing.Color.Transparent;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.ForeColor = System.Drawing.Color.White;
            this.lblMission.Location = new System.Drawing.Point(1259, 60);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(227, 29);
            this.lblMission.TabIndex = 8;
            this.lblMission.Text = "Toutes les missions";
            // 
            // cboFiltre
            // 
            this.cboFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltre.FormattingEnabled = true;
            this.cboFiltre.Items.AddRange(new object[] {
            "En cours",
            "A venir",
            "Passée"});
            this.cboFiltre.Location = new System.Drawing.Point(598, 102);
            this.cboFiltre.Name = "cboFiltre";
            this.cboFiltre.Size = new System.Drawing.Size(188, 37);
            this.cboFiltre.TabIndex = 9;
            this.cboFiltre.SelectedIndexChanged += new System.EventHandler(this.cboFiltre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(593, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrer l\'affichage des missions";
            // 
            // btnFermerAppli
            // 
            this.btnFermerAppli.BackColor = System.Drawing.Color.Transparent;
            this.btnFermerAppli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermerAppli.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFermerAppli.FlatAppearance.BorderSize = 2;
            this.btnFermerAppli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFermerAppli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermerAppli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermerAppli.ForeColor = System.Drawing.Color.White;
            this.btnFermerAppli.Location = new System.Drawing.Point(49, 22);
            this.btnFermerAppli.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermerAppli.Name = "btnFermerAppli";
            this.btnFermerAppli.Size = new System.Drawing.Size(169, 63);
            this.btnFermerAppli.TabIndex = 11;
            this.btnFermerAppli.Text = "Quitter";
            this.btnFermerAppli.UseVisualStyleBackColor = false;
            this.btnFermerAppli.Click += new System.EventHandler(this.btnFermerAppli_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStats.FlatAppearance.BorderSize = 2;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(201, 669);
            this.btnStats.Margin = new System.Windows.Forms.Padding(4);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(332, 95);
            this.btnStats.TabIndex = 12;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::SAE24.Properties.Resources.fond3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 907);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnFermerAppli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFiltre);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.flpMissions);
            this.Controls.Add(this.btnInfosPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnNewMission);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.Text = "Tableau de bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnInfosPlanetes;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.ComboBox cboFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermerAppli;
        private System.Windows.Forms.Button btnStats;
    }
}

