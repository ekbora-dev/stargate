namespace SAE24
{
    partial class UCAffichageMission
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
            this.lblPlanete = new System.Windows.Forms.Label();
            this.lblIDMission = new System.Windows.Forms.Label();
            this.lblDateAller = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblCapitaine = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnToPDF = new System.Windows.Forms.Button();
            this.btnDetailsMission = new System.Windows.Forms.Button();
            this.pboPlanete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(150, 22);
            this.lblPlanete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(85, 29);
            this.lblPlanete.TabIndex = 0;
            this.lblPlanete.Text = "label1";
            // 
            // lblIDMission
            // 
            this.lblIDMission.AutoSize = true;
            this.lblIDMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMission.Location = new System.Drawing.Point(269, 22);
            this.lblIDMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMission.Name = "lblIDMission";
            this.lblIDMission.Size = new System.Drawing.Size(85, 29);
            this.lblIDMission.TabIndex = 1;
            this.lblIDMission.Text = "label1";
            // 
            // lblDateAller
            // 
            this.lblDateAller.AutoSize = true;
            this.lblDateAller.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAller.Location = new System.Drawing.Point(150, 83);
            this.lblDateAller.Name = "lblDateAller";
            this.lblDateAller.Size = new System.Drawing.Size(79, 29);
            this.lblDateAller.TabIndex = 2;
            this.lblDateAller.Text = "label1";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRetour.Location = new System.Drawing.Point(269, 83);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(79, 29);
            this.lblDateRetour.TabIndex = 3;
            this.lblDateRetour.Text = "label1";
            // 
            // lblCapitaine
            // 
            this.lblCapitaine.AutoSize = true;
            this.lblCapitaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitaine.Location = new System.Drawing.Point(154, 154);
            this.lblCapitaine.Name = "lblCapitaine";
            this.lblCapitaine.Size = new System.Drawing.Size(79, 29);
            this.lblCapitaine.TabIndex = 5;
            this.lblCapitaine.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(460, 154);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(79, 29);
            this.lblBudget.TabIndex = 6;
            this.lblBudget.Text = "label1";
            // 
            // btnToPDF
            // 
            this.btnToPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToPDF.Image = global::SAE24.Properties.Resources.pdf;
            this.btnToPDF.Location = new System.Drawing.Point(553, 67);
            this.btnToPDF.Name = "btnToPDF";
            this.btnToPDF.Size = new System.Drawing.Size(48, 51);
            this.btnToPDF.TabIndex = 8;
            this.btnToPDF.UseVisualStyleBackColor = true;
            this.btnToPDF.Click += new System.EventHandler(this.btnToPDF_Click);
            // 
            // btnDetailsMission
            // 
            this.btnDetailsMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailsMission.Image = global::SAE24.Properties.Resources.loupe;
            this.btnDetailsMission.Location = new System.Drawing.Point(444, 67);
            this.btnDetailsMission.Name = "btnDetailsMission";
            this.btnDetailsMission.Size = new System.Drawing.Size(47, 51);
            this.btnDetailsMission.TabIndex = 7;
            this.btnDetailsMission.UseVisualStyleBackColor = true;
            this.btnDetailsMission.Click += new System.EventHandler(this.btnDetailsMission_Click);
            // 
            // pboPlanete
            // 
            this.pboPlanete.Location = new System.Drawing.Point(18, 52);
            this.pboPlanete.Name = "pboPlanete";
            this.pboPlanete.Size = new System.Drawing.Size(100, 100);
            this.pboPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboPlanete.TabIndex = 4;
            this.pboPlanete.TabStop = false;
            // 
            // UCAffichageMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnToPDF);
            this.Controls.Add(this.btnDetailsMission);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblCapitaine);
            this.Controls.Add(this.pboPlanete);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.lblDateAller);
            this.Controls.Add(this.lblIDMission);
            this.Controls.Add(this.lblPlanete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAffichageMission";
            this.Size = new System.Drawing.Size(682, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pboPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.Label lblIDMission;
        private System.Windows.Forms.Label lblDateAller;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.PictureBox pboPlanete;
        private System.Windows.Forms.Label lblCapitaine;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnDetailsMission;
        private System.Windows.Forms.Button btnToPDF;
    }
}
