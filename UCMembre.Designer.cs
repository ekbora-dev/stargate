namespace SAE24
{
    partial class UCMembre
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
            this.pboImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomComplet
            // 
            this.lblNomComplet.AutoSize = true;
            this.lblNomComplet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomComplet.Location = new System.Drawing.Point(33, 122);
            this.lblNomComplet.Name = "lblNomComplet";
            this.lblNomComplet.Size = new System.Drawing.Size(64, 25);
            this.lblNomComplet.TabIndex = 1;
            this.lblNomComplet.Text = "label1";
            // 
            // pboImage
            // 
            this.pboImage.Location = new System.Drawing.Point(27, 13);
            this.pboImage.Name = "pboImage";
            this.pboImage.Size = new System.Drawing.Size(93, 106);
            this.pboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboImage.TabIndex = 0;
            this.pboImage.TabStop = false;
            // 
            // UCMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lblNomComplet);
            this.Controls.Add(this.pboImage);
            this.Name = "UCMembre";
            this.Size = new System.Drawing.Size(146, 187);
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboImage;
        private System.Windows.Forms.Label lblNomComplet;
    }
}
