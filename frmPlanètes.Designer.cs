namespace SAE24
{
    partial class frmPlanetes
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
            this.btnTrouver = new System.Windows.Forms.Button();
            this.txtTrouver = new System.Windows.Forms.TextBox();
            this.btnAcceuil = new System.Windows.Forms.Button();
            this.flpPlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReinitialiserRecherche = new System.Windows.Forms.Button();
            this.grpFiltreTemperature = new System.Windows.Forms.GroupBox();
            this.rdbTempInconnue = new System.Windows.Forms.RadioButton();
            this.rdbFroide = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbChaude = new System.Windows.Forms.RadioButton();
            this.rdbMoyenne = new System.Windows.Forms.RadioButton();
            this.grpDataBaz = new System.Windows.Forms.GroupBox();
            this.rdbDbInconnue = new System.Windows.Forms.RadioButton();
            this.rdbOn = new System.Windows.Forms.RadioButton();
            this.rdbOff = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFiltreTemperature.SuspendLayout();
            this.grpDataBaz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrouver
            // 
            this.btnTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrouver.Location = new System.Drawing.Point(644, 63);
            this.btnTrouver.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrouver.Name = "btnTrouver";
            this.btnTrouver.Size = new System.Drawing.Size(210, 39);
            this.btnTrouver.TabIndex = 1;
            this.btnTrouver.Text = "Trouver la planète";
            this.btnTrouver.UseVisualStyleBackColor = true;
            this.btnTrouver.Click += new System.EventHandler(this.btnTrouver_Click);
            // 
            // txtTrouver
            // 
            this.txtTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrouver.Location = new System.Drawing.Point(383, 65);
            this.txtTrouver.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrouver.Name = "txtTrouver";
            this.txtTrouver.Size = new System.Drawing.Size(245, 30);
            this.txtTrouver.TabIndex = 2;
            this.txtTrouver.TextChanged += new System.EventHandler(this.txtTrouver_TextChanged);
            this.txtTrouver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrouver_KeyPress);
            // 
            // btnAcceuil
            // 
            this.btnAcceuil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceuil.Location = new System.Drawing.Point(921, 319);
            this.btnAcceuil.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceuil.Name = "btnAcceuil";
            this.btnAcceuil.Size = new System.Drawing.Size(156, 44);
            this.btnAcceuil.TabIndex = 3;
            this.btnAcceuil.Text = "Acceuil";
            this.btnAcceuil.UseVisualStyleBackColor = true;
            this.btnAcceuil.Click += new System.EventHandler(this.btnAcceuil_Click);
            // 
            // flpPlanete
            // 
            this.flpPlanete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPlanete.AutoScroll = true;
            this.flpPlanete.BackColor = System.Drawing.Color.Transparent;
            this.flpPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpPlanete.Location = new System.Drawing.Point(282, 131);
            this.flpPlanete.Margin = new System.Windows.Forms.Padding(4);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(827, 707);
            this.flpPlanete.TabIndex = 4;
            // 
            // btnReinitialiserRecherche
            // 
            this.btnReinitialiserRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiserRecherche.Location = new System.Drawing.Point(59, 129);
            this.btnReinitialiserRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnReinitialiserRecherche.Name = "btnReinitialiserRecherche";
            this.btnReinitialiserRecherche.Size = new System.Drawing.Size(183, 65);
            this.btnReinitialiserRecherche.TabIndex = 5;
            this.btnReinitialiserRecherche.Text = "Réinitialiser la recherche";
            this.btnReinitialiserRecherche.UseVisualStyleBackColor = true;
            this.btnReinitialiserRecherche.Click += new System.EventHandler(this.btnReinitialiserRecherche_Click);
            // 
            // grpFiltreTemperature
            // 
            this.grpFiltreTemperature.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltreTemperature.Controls.Add(this.rdbTempInconnue);
            this.grpFiltreTemperature.Controls.Add(this.rdbFroide);
            this.grpFiltreTemperature.Controls.Add(this.rdbNormal);
            this.grpFiltreTemperature.Controls.Add(this.rdbChaude);
            this.grpFiltreTemperature.Controls.Add(this.rdbMoyenne);
            this.grpFiltreTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltreTemperature.ForeColor = System.Drawing.Color.White;
            this.grpFiltreTemperature.Location = new System.Drawing.Point(85, 202);
            this.grpFiltreTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltreTemperature.Name = "grpFiltreTemperature";
            this.grpFiltreTemperature.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltreTemperature.Size = new System.Drawing.Size(169, 198);
            this.grpFiltreTemperature.TabIndex = 6;
            this.grpFiltreTemperature.TabStop = false;
            this.grpFiltreTemperature.Text = "Température :";
            // 
            // rdbTempInconnue
            // 
            this.rdbTempInconnue.AutoSize = true;
            this.rdbTempInconnue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTempInconnue.Location = new System.Drawing.Point(11, 39);
            this.rdbTempInconnue.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTempInconnue.Name = "rdbTempInconnue";
            this.rdbTempInconnue.Size = new System.Drawing.Size(114, 29);
            this.rdbTempInconnue.TabIndex = 9;
            this.rdbTempInconnue.TabStop = true;
            this.rdbTempInconnue.Text = "Inconnue";
            this.rdbTempInconnue.UseVisualStyleBackColor = true;
            this.rdbTempInconnue.CheckedChanged += new System.EventHandler(this.rdbTempInconnue_CheckedChanged);
            // 
            // rdbFroide
            // 
            this.rdbFroide.AutoSize = true;
            this.rdbFroide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFroide.Location = new System.Drawing.Point(11, 68);
            this.rdbFroide.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFroide.Name = "rdbFroide";
            this.rdbFroide.Size = new System.Drawing.Size(88, 29);
            this.rdbFroide.TabIndex = 10;
            this.rdbFroide.TabStop = true;
            this.rdbFroide.Text = "Froide";
            this.rdbFroide.UseVisualStyleBackColor = true;
            this.rdbFroide.CheckedChanged += new System.EventHandler(this.rdbFroide_CheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.Location = new System.Drawing.Point(11, 96);
            this.rdbNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(95, 29);
            this.rdbNormal.TabIndex = 11;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbChaude
            // 
            this.rdbChaude.AutoSize = true;
            this.rdbChaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChaude.Location = new System.Drawing.Point(11, 153);
            this.rdbChaude.Margin = new System.Windows.Forms.Padding(4);
            this.rdbChaude.Name = "rdbChaude";
            this.rdbChaude.Size = new System.Drawing.Size(103, 29);
            this.rdbChaude.TabIndex = 13;
            this.rdbChaude.TabStop = true;
            this.rdbChaude.Text = "Chaude";
            this.rdbChaude.UseVisualStyleBackColor = true;
            this.rdbChaude.CheckedChanged += new System.EventHandler(this.rdbChaude_CheckedChanged);
            // 
            // rdbMoyenne
            // 
            this.rdbMoyenne.AutoSize = true;
            this.rdbMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMoyenne.Location = new System.Drawing.Point(11, 124);
            this.rdbMoyenne.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMoyenne.Name = "rdbMoyenne";
            this.rdbMoyenne.Size = new System.Drawing.Size(115, 29);
            this.rdbMoyenne.TabIndex = 12;
            this.rdbMoyenne.TabStop = true;
            this.rdbMoyenne.Text = "Moyenne";
            this.rdbMoyenne.UseVisualStyleBackColor = true;
            this.rdbMoyenne.CheckedChanged += new System.EventHandler(this.rdbMoyenne_CheckedChanged);
            // 
            // grpDataBaz
            // 
            this.grpDataBaz.BackColor = System.Drawing.Color.Transparent;
            this.grpDataBaz.Controls.Add(this.rdbDbInconnue);
            this.grpDataBaz.Controls.Add(this.rdbOn);
            this.grpDataBaz.Controls.Add(this.rdbOff);
            this.grpDataBaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataBaz.ForeColor = System.Drawing.Color.White;
            this.grpDataBaz.Location = new System.Drawing.Point(85, 407);
            this.grpDataBaz.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataBaz.Name = "grpDataBaz";
            this.grpDataBaz.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataBaz.Size = new System.Drawing.Size(127, 134);
            this.grpDataBaz.TabIndex = 8;
            this.grpDataBaz.TabStop = false;
            this.grpDataBaz.Text = "DataBaz :";
            // 
            // rdbDbInconnue
            // 
            this.rdbDbInconnue.AutoSize = true;
            this.rdbDbInconnue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDbInconnue.Location = new System.Drawing.Point(11, 37);
            this.rdbDbInconnue.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDbInconnue.Name = "rdbDbInconnue";
            this.rdbDbInconnue.Size = new System.Drawing.Size(114, 29);
            this.rdbDbInconnue.TabIndex = 16;
            this.rdbDbInconnue.TabStop = true;
            this.rdbDbInconnue.Text = "Inconnue";
            this.rdbDbInconnue.UseVisualStyleBackColor = true;
            this.rdbDbInconnue.CheckedChanged += new System.EventHandler(this.rdbDbInconnue_CheckedChanged);
            // 
            // rdbOn
            // 
            this.rdbOn.AutoSize = true;
            this.rdbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOn.Location = new System.Drawing.Point(11, 94);
            this.rdbOn.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOn.Name = "rdbOn";
            this.rdbOn.Size = new System.Drawing.Size(60, 29);
            this.rdbOn.TabIndex = 15;
            this.rdbOn.TabStop = true;
            this.rdbOn.Text = "On";
            this.rdbOn.UseVisualStyleBackColor = true;
            this.rdbOn.CheckedChanged += new System.EventHandler(this.rdbOn_CheckedChanged);
            // 
            // rdbOff
            // 
            this.rdbOff.AutoSize = true;
            this.rdbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOff.Location = new System.Drawing.Point(11, 65);
            this.rdbOff.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOff.Name = "rdbOff";
            this.rdbOff.Size = new System.Drawing.Size(59, 29);
            this.rdbOff.TabIndex = 14;
            this.rdbOff.TabStop = true;
            this.rdbOff.Text = "Off";
            this.rdbOff.UseVisualStyleBackColor = true;
            this.rdbOff.CheckedChanged += new System.EventHandler(this.rdbOff_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Planète";
            // 
            // frmPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::SAE24.Properties.Resources.fond3;
            this.ClientSize = new System.Drawing.Size(1124, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDataBaz);
            this.Controls.Add(this.grpFiltreTemperature);
            this.Controls.Add(this.btnReinitialiserRecherche);
            this.Controls.Add(this.flpPlanete);
            this.Controls.Add(this.btnAcceuil);
            this.Controls.Add(this.txtTrouver);
            this.Controls.Add(this.btnTrouver);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlanetes";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Planètes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlanètes_Load);
            this.grpFiltreTemperature.ResumeLayout(false);
            this.grpFiltreTemperature.PerformLayout();
            this.grpDataBaz.ResumeLayout(false);
            this.grpDataBaz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTrouver;
        private System.Windows.Forms.TextBox txtTrouver;
        private System.Windows.Forms.Button btnAcceuil;
        private System.Windows.Forms.FlowLayoutPanel flpPlanete;
        private System.Windows.Forms.Button btnReinitialiserRecherche;
        private System.Windows.Forms.GroupBox grpFiltreTemperature;
        private System.Windows.Forms.GroupBox grpDataBaz;
        private System.Windows.Forms.RadioButton rdbTempInconnue;
        private System.Windows.Forms.RadioButton rdbFroide;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbMoyenne;
        private System.Windows.Forms.RadioButton rdbChaude;
        private System.Windows.Forms.RadioButton rdbOff;
        private System.Windows.Forms.RadioButton rdbOn;
        private System.Windows.Forms.RadioButton rdbDbInconnue;
        private System.Windows.Forms.Label label1;
    }
}