namespace SAE24
{
    partial class frmRaceRepertorie
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
            this.flpEspece = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtNomEspece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAllie = new System.Windows.Forms.RadioButton();
            this.rdbEnnemi = new System.Windows.Forms.RadioButton();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpEspece
            // 
            this.flpEspece.AutoScroll = true;
            this.flpEspece.BackColor = System.Drawing.Color.Transparent;
            this.flpEspece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpEspece.Location = new System.Drawing.Point(23, 50);
            this.flpEspece.Name = "flpEspece";
            this.flpEspece.Size = new System.Drawing.Size(906, 541);
            this.flpEspece.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des espèces ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtNomEspece);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCouleur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(956, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrer";
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.White;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.Black;
            this.btnRechercher.Location = new System.Drawing.Point(16, 136);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(130, 34);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtNomEspece
            // 
            this.txtNomEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEspece.Location = new System.Drawing.Point(111, 38);
            this.txtNomEspece.Name = "txtNomEspece";
            this.txtNomEspece.Size = new System.Drawing.Size(121, 28);
            this.txtNomEspece.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Couleur";
            // 
            // cboCouleur
            // 
            this.cboCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(111, 88);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(121, 30);
            this.cboCouleur.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbAllie);
            this.groupBox2.Controls.Add(this.rdbEnnemi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(956, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ennemi ou allié ?";
            // 
            // rdbAllie
            // 
            this.rdbAllie.AutoSize = true;
            this.rdbAllie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllie.Location = new System.Drawing.Point(6, 83);
            this.rdbAllie.Name = "rdbAllie";
            this.rdbAllie.Size = new System.Drawing.Size(65, 26);
            this.rdbAllie.TabIndex = 1;
            this.rdbAllie.TabStop = true;
            this.rdbAllie.Text = "Allié";
            this.rdbAllie.UseVisualStyleBackColor = true;
            this.rdbAllie.CheckedChanged += new System.EventHandler(this.rdbAllie_CheckedChanged);
            // 
            // rdbEnnemi
            // 
            this.rdbEnnemi.AutoSize = true;
            this.rdbEnnemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnnemi.Location = new System.Drawing.Point(6, 35);
            this.rdbEnnemi.Name = "rdbEnnemi";
            this.rdbEnnemi.Size = new System.Drawing.Size(91, 26);
            this.rdbEnnemi.TabIndex = 0;
            this.rdbEnnemi.TabStop = true;
            this.rdbEnnemi.Text = "Ennemi";
            this.rdbEnnemi.UseVisualStyleBackColor = true;
            this.rdbEnnemi.CheckedChanged += new System.EventHandler(this.rdbEnnemi_CheckedChanged);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(1013, 22);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(144, 55);
            this.btnAccueil.TabIndex = 4;
            this.btnAccueil.Text = "Retour à l\'accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.Location = new System.Drawing.Point(988, 526);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(184, 69);
            this.btnReinitialiser.TabIndex = 5;
            this.btnReinitialiser.Text = "Reinitialiser les filtres";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // frmRaceRepertorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::SAE24.Properties.Resources.fond3;
            this.ClientSize = new System.Drawing.Size(1252, 648);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpEspece);
            this.Name = "frmRaceRepertorie";
            this.Text = "Liste des espèces";
            this.Load += new System.EventHandler(this.frmRaceRepertorie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEspece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomEspece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAllie;
        private System.Windows.Forms.RadioButton rdbEnnemi;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnReinitialiser;
    }
}