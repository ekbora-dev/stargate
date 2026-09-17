namespace SAE24
{
    partial class UCEspeceAllie
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
            this.lblBienveillance = new System.Windows.Forms.Label();
            this.lblInstru = new System.Windows.Forms.Label();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.imgAllie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAllie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(24, 121);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "label1";
            // 
            // lblBienveillance
            // 
            this.lblBienveillance.AutoSize = true;
            this.lblBienveillance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienveillance.Location = new System.Drawing.Point(24, 150);
            this.lblBienveillance.Name = "lblBienveillance";
            this.lblBienveillance.Size = new System.Drawing.Size(64, 25);
            this.lblBienveillance.TabIndex = 1;
            this.lblBienveillance.Text = "label1";
            // 
            // lblInstru
            // 
            this.lblInstru.AutoSize = true;
            this.lblInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstru.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblInstru.Location = new System.Drawing.Point(24, 209);
            this.lblInstru.Name = "lblInstru";
            this.lblInstru.Size = new System.Drawing.Size(64, 25);
            this.lblInstru.TabIndex = 2;
            this.lblInstru.Text = "label1";
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(24, 183);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(64, 25);
            this.lblPlanete.TabIndex = 3;
            this.lblPlanete.Text = "label1";
            // 
            // imgAllie
            // 
            this.imgAllie.Location = new System.Drawing.Point(28, 2);
            this.imgAllie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgAllie.Name = "imgAllie";
            this.imgAllie.Size = new System.Drawing.Size(133, 98);
            this.imgAllie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAllie.TabIndex = 4;
            this.imgAllie.TabStop = false;
            // 
            // UCEspeceAllie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.imgAllie);
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.lblInstru);
            this.Controls.Add(this.lblBienveillance);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCEspeceAllie";
            this.Size = new System.Drawing.Size(212, 249);
            ((System.ComponentModel.ISupportInitialize)(this.imgAllie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBienveillance;
        private System.Windows.Forms.Label lblInstru;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.PictureBox imgAllie;
    }
}
