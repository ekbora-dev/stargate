namespace SAE24
{
    partial class UCPlanete
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
            this.grpPlanete = new System.Windows.Forms.GroupBox();
            this.lblDatabaz = new System.Windows.Forms.Label();
            this.lblGravité = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.imgTemperature = new System.Windows.Forms.PictureBox();
            this.lblNomPlanete = new System.Windows.Forms.Label();
            this.imgPlanete = new System.Windows.Forms.PictureBox();
            this.grpPlanete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlanete
            // 
            this.grpPlanete.BackColor = System.Drawing.Color.White;
            this.grpPlanete.Controls.Add(this.lblDatabaz);
            this.grpPlanete.Controls.Add(this.lblGravité);
            this.grpPlanete.Controls.Add(this.lblTemperature);
            this.grpPlanete.Controls.Add(this.imgTemperature);
            this.grpPlanete.Controls.Add(this.lblNomPlanete);
            this.grpPlanete.Controls.Add(this.imgPlanete);
            this.grpPlanete.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpPlanete.Location = new System.Drawing.Point(0, 0);
            this.grpPlanete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlanete.Name = "grpPlanete";
            this.grpPlanete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlanete.Size = new System.Drawing.Size(267, 394);
            this.grpPlanete.TabIndex = 0;
            this.grpPlanete.TabStop = false;
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.AutoSize = true;
            this.lblDatabaz.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDatabaz.Location = new System.Drawing.Point(36, 366);
            this.lblDatabaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(0, 16);
            this.lblDatabaz.TabIndex = 5;
            // 
            // lblGravité
            // 
            this.lblGravité.AutoSize = true;
            this.lblGravité.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGravité.Location = new System.Drawing.Point(36, 325);
            this.lblGravité.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGravité.Name = "lblGravité";
            this.lblGravité.Size = new System.Drawing.Size(0, 16);
            this.lblGravité.TabIndex = 4;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTemperature.Location = new System.Drawing.Point(93, 268);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(0, 16);
            this.lblTemperature.TabIndex = 3;
            // 
            // imgTemperature
            // 
            this.imgTemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgTemperature.Location = new System.Drawing.Point(40, 255);
            this.imgTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgTemperature.Name = "imgTemperature";
            this.imgTemperature.Size = new System.Drawing.Size(53, 49);
            this.imgTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTemperature.TabIndex = 2;
            this.imgTemperature.TabStop = false;
            // 
            // lblNomPlanete
            // 
            this.lblNomPlanete.AutoSize = true;
            this.lblNomPlanete.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNomPlanete.Location = new System.Drawing.Point(93, 220);
            this.lblNomPlanete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPlanete.Name = "lblNomPlanete";
            this.lblNomPlanete.Size = new System.Drawing.Size(0, 16);
            this.lblNomPlanete.TabIndex = 1;
            // 
            // imgPlanete
            // 
            this.imgPlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPlanete.Location = new System.Drawing.Point(40, 23);
            this.imgPlanete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPlanete.Name = "imgPlanete";
            this.imgPlanete.Size = new System.Drawing.Size(187, 172);
            this.imgPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlanete.TabIndex = 0;
            this.imgPlanete.TabStop = false;
            // 
            // UCPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPlanete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCPlanete";
            this.Size = new System.Drawing.Size(267, 394);
            this.Click += new System.EventHandler(this.UCPlanete_Click);
            this.grpPlanete.ResumeLayout(false);
            this.grpPlanete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlanete;
        private System.Windows.Forms.Label lblNomPlanete;
        private System.Windows.Forms.PictureBox imgPlanete;
        private System.Windows.Forms.PictureBox imgTemperature;
        private System.Windows.Forms.Label lblDatabaz;
        private System.Windows.Forms.Label lblGravité;
        private System.Windows.Forms.Label lblTemperature;
    }
}
