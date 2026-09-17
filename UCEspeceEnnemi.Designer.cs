namespace SAE24
{
    partial class UCEspeceEnnemi
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDegreAgressivite = new System.Windows.Forms.Label();
            this.lblTypeArme = new System.Windows.Forms.Label();
            this.imgEnnemi = new System.Windows.Forms.PictureBox();
            this.lblPlanetes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnnemi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(22, 115);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 29);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "label1";
            // 
            // lblDegreAgressivite
            // 
            this.lblDegreAgressivite.AutoSize = true;
            this.lblDegreAgressivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreAgressivite.Location = new System.Drawing.Point(22, 148);
            this.lblDegreAgressivite.Name = "lblDegreAgressivite";
            this.lblDegreAgressivite.Size = new System.Drawing.Size(79, 29);
            this.lblDegreAgressivite.TabIndex = 1;
            this.lblDegreAgressivite.Text = "label2";
            // 
            // lblTypeArme
            // 
            this.lblTypeArme.AutoSize = true;
            this.lblTypeArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeArme.Location = new System.Drawing.Point(22, 184);
            this.lblTypeArme.Name = "lblTypeArme";
            this.lblTypeArme.Size = new System.Drawing.Size(79, 29);
            this.lblTypeArme.TabIndex = 2;
            this.lblTypeArme.Text = "label3";
            // 
            // imgEnnemi
            // 
            this.imgEnnemi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgEnnemi.Location = new System.Drawing.Point(27, 2);
            this.imgEnnemi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgEnnemi.Name = "imgEnnemi";
            this.imgEnnemi.Size = new System.Drawing.Size(133, 98);
            this.imgEnnemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEnnemi.TabIndex = 3;
            this.imgEnnemi.TabStop = false;
            // 
            // lblPlanetes
            // 
            this.lblPlanetes.AutoSize = true;
            this.lblPlanetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetes.Location = new System.Drawing.Point(22, 214);
            this.lblPlanetes.Name = "lblPlanetes";
            this.lblPlanetes.Size = new System.Drawing.Size(79, 29);
            this.lblPlanetes.TabIndex = 4;
            this.lblPlanetes.Text = "label1";
            // 
            // UCEspeceEnnemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lblPlanetes);
            this.Controls.Add(this.imgEnnemi);
            this.Controls.Add(this.lblTypeArme);
            this.Controls.Add(this.lblDegreAgressivite);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCEspeceEnnemi";
            this.Size = new System.Drawing.Size(318, 262);
            ((System.ComponentModel.ISupportInitialize)(this.imgEnnemi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDegreAgressivite;
        private System.Windows.Forms.Label lblTypeArme;
        private System.Windows.Forms.PictureBox imgEnnemi;
        private System.Windows.Forms.Label lblPlanetes;
    }
}
