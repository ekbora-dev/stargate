namespace SAE24
{
    partial class UCRaceRepertorie
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
            this.imgEspece = new System.Windows.Forms.PictureBox();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEspece)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEspece
            // 
            this.imgEspece.Location = new System.Drawing.Point(31, 12);
            this.imgEspece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgEspece.Name = "imgEspece";
            this.imgEspece.Size = new System.Drawing.Size(133, 98);
            this.imgEspece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEspece.TabIndex = 0;
            this.imgEspece.TabStop = false;
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(15, 186);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(64, 25);
            this.lblPlanete.TabIndex = 6;
            this.lblPlanete.Text = "label1";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(15, 155);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(64, 25);
            this.lblCouleur.TabIndex = 5;
            this.lblCouleur.Text = "label1";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(15, 124);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "label1";
            // 
            // UCRaceRepertorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.imgEspece);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCRaceRepertorie";
            this.Size = new System.Drawing.Size(200, 225);
            ((System.ComponentModel.ISupportInitialize)(this.imgEspece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgEspece;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblNom;
    }
}
