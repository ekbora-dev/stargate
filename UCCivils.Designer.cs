namespace SAE24
{
    partial class UCCivils
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
            this.lblNomComplet = new System.Windows.Forms.Label();
            this.imgCivil = new System.Windows.Forms.PictureBox();
            this.lblPlaneteOrigine = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCivil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomComplet
            // 
            this.lblNomComplet.AutoSize = true;
            this.lblNomComplet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomComplet.Location = new System.Drawing.Point(13, 155);
            this.lblNomComplet.Name = "lblNomComplet";
            this.lblNomComplet.Size = new System.Drawing.Size(64, 25);
            this.lblNomComplet.TabIndex = 3;
            this.lblNomComplet.Text = "label1";
            // 
            // imgCivil
            // 
            this.imgCivil.Location = new System.Drawing.Point(17, 17);
            this.imgCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCivil.Name = "imgCivil";
            this.imgCivil.Size = new System.Drawing.Size(147, 123);
            this.imgCivil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCivil.TabIndex = 2;
            this.imgCivil.TabStop = false;
            // 
            // lblPlaneteOrigine
            // 
            this.lblPlaneteOrigine.AutoSize = true;
            this.lblPlaneteOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneteOrigine.Location = new System.Drawing.Point(13, 186);
            this.lblPlaneteOrigine.Name = "lblPlaneteOrigine";
            this.lblPlaneteOrigine.Size = new System.Drawing.Size(64, 25);
            this.lblPlaneteOrigine.TabIndex = 4;
            this.lblPlaneteOrigine.Text = "label1";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialite.Location = new System.Drawing.Point(13, 214);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(64, 25);
            this.lblSpecialite.TabIndex = 5;
            this.lblSpecialite.Text = "label1";
            // 
            // UCCivils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.lblPlaneteOrigine);
            this.Controls.Add(this.lblNomComplet);
            this.Controls.Add(this.imgCivil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCCivils";
            this.Size = new System.Drawing.Size(189, 254);
            ((System.ComponentModel.ISupportInitialize)(this.imgCivil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomComplet;
        private System.Windows.Forms.PictureBox imgCivil;
        private System.Windows.Forms.Label lblPlaneteOrigine;
        private System.Windows.Forms.Label lblSpecialite;
    }
}
