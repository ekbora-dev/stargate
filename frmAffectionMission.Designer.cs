namespace SAE24
{
    partial class frmAffectionMission
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
            this.blAffectation = new System.Windows.Forms.Label();
            this.cboMembre = new System.Windows.Forms.ComboBox();
            this.btAjouterMembre = new System.Windows.Forms.Button();
            this.btValiderMembres = new System.Windows.Forms.Button();
            this.lblObjectif = new System.Windows.Forms.Label();
            this.cboEspece = new System.Windows.Forms.ComboBox();
            this.txtNbCaptureEspece = new System.Windows.Forms.TextBox();
            this.btValiderObjectifs = new System.Windows.Forms.Button();
            this.btAjouterCaptures = new System.Windows.Forms.Button();
            this.lboMembre = new System.Windows.Forms.ListBox();
            this.lboCapture = new System.Windows.Forms.ListBox();
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blAffectation
            // 
            this.blAffectation.AutoSize = true;
            this.blAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blAffectation.Location = new System.Drawing.Point(107, 26);
            this.blAffectation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blAffectation.Name = "blAffectation";
            this.blAffectation.Size = new System.Drawing.Size(411, 25);
            this.blAffectation.TabIndex = 0;
            this.blAffectation.Text = "4 - Affectation des membres - reste à affecter :";
            // 
            // cboMembre
            // 
            this.cboMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembre.FormattingEnabled = true;
            this.cboMembre.Location = new System.Drawing.Point(112, 69);
            this.cboMembre.Margin = new System.Windows.Forms.Padding(4);
            this.cboMembre.Name = "cboMembre";
            this.cboMembre.Size = new System.Drawing.Size(320, 33);
            this.cboMembre.TabIndex = 2;
            // 
            // btAjouterMembre
            // 
            this.btAjouterMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouterMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterMembre.Location = new System.Drawing.Point(487, 69);
            this.btAjouterMembre.Margin = new System.Windows.Forms.Padding(4);
            this.btAjouterMembre.Name = "btAjouterMembre";
            this.btAjouterMembre.Size = new System.Drawing.Size(128, 43);
            this.btAjouterMembre.TabIndex = 3;
            this.btAjouterMembre.Text = "Ajouter";
            this.btAjouterMembre.UseVisualStyleBackColor = true;
            this.btAjouterMembre.Click += new System.EventHandler(this.btAjouterMembre_Click);
            // 
            // btValiderMembres
            // 
            this.btValiderMembres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValiderMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValiderMembres.Location = new System.Drawing.Point(487, 207);
            this.btValiderMembres.Margin = new System.Windows.Forms.Padding(4);
            this.btValiderMembres.Name = "btValiderMembres";
            this.btValiderMembres.Size = new System.Drawing.Size(202, 37);
            this.btValiderMembres.TabIndex = 4;
            this.btValiderMembres.Text = "Valider Membres";
            this.btValiderMembres.UseVisualStyleBackColor = true;
            this.btValiderMembres.Click += new System.EventHandler(this.btValiderMembres_Click);
            // 
            // lblObjectif
            // 
            this.lblObjectif.AutoSize = true;
            this.lblObjectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectif.Location = new System.Drawing.Point(67, 265);
            this.lblObjectif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjectif.Name = "lblObjectif";
            this.lblObjectif.Size = new System.Drawing.Size(203, 25);
            this.lblObjectif.TabIndex = 5;
            this.lblObjectif.Text = "5 - Objectif de capture";
            // 
            // cboEspece
            // 
            this.cboEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEspece.FormattingEnabled = true;
            this.cboEspece.Location = new System.Drawing.Point(112, 341);
            this.cboEspece.Margin = new System.Windows.Forms.Padding(4);
            this.cboEspece.Name = "cboEspece";
            this.cboEspece.Size = new System.Drawing.Size(166, 33);
            this.cboEspece.TabIndex = 6;
            // 
            // txtNbCaptureEspece
            // 
            this.txtNbCaptureEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbCaptureEspece.Location = new System.Drawing.Point(328, 341);
            this.txtNbCaptureEspece.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbCaptureEspece.Name = "txtNbCaptureEspece";
            this.txtNbCaptureEspece.Size = new System.Drawing.Size(80, 30);
            this.txtNbCaptureEspece.TabIndex = 7;
            this.txtNbCaptureEspece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlien_KeyPress);
            // 
            // btValiderObjectifs
            // 
            this.btValiderObjectifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValiderObjectifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValiderObjectifs.Location = new System.Drawing.Point(487, 476);
            this.btValiderObjectifs.Margin = new System.Windows.Forms.Padding(4);
            this.btValiderObjectifs.Name = "btValiderObjectifs";
            this.btValiderObjectifs.Size = new System.Drawing.Size(195, 35);
            this.btValiderObjectifs.TabIndex = 8;
            this.btValiderObjectifs.Text = "Valider Objectifs";
            this.btValiderObjectifs.UseVisualStyleBackColor = true;
            this.btValiderObjectifs.Click += new System.EventHandler(this.btValiderObjectifs_Click);
            // 
            // btAjouterCaptures
            // 
            this.btAjouterCaptures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouterCaptures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterCaptures.Location = new System.Drawing.Point(487, 341);
            this.btAjouterCaptures.Margin = new System.Windows.Forms.Padding(4);
            this.btAjouterCaptures.Name = "btAjouterCaptures";
            this.btAjouterCaptures.Size = new System.Drawing.Size(128, 30);
            this.btAjouterCaptures.TabIndex = 9;
            this.btAjouterCaptures.Text = "Ajouter";
            this.btAjouterCaptures.UseVisualStyleBackColor = true;
            this.btAjouterCaptures.Click += new System.EventHandler(this.btAjouterCaptures_Click);
            // 
            // lboMembre
            // 
            this.lboMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboMembre.FormattingEnabled = true;
            this.lboMembre.ItemHeight = 25;
            this.lboMembre.Location = new System.Drawing.Point(112, 115);
            this.lboMembre.Margin = new System.Windows.Forms.Padding(4);
            this.lboMembre.Name = "lboMembre";
            this.lboMembre.Size = new System.Drawing.Size(366, 129);
            this.lboMembre.TabIndex = 10;
            // 
            // lboCapture
            // 
            this.lboCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCapture.FormattingEnabled = true;
            this.lboCapture.ItemHeight = 25;
            this.lboCapture.Location = new System.Drawing.Point(112, 382);
            this.lboCapture.Margin = new System.Windows.Forms.Padding(4);
            this.lboCapture.Name = "lboCapture";
            this.lboCapture.Size = new System.Drawing.Size(366, 129);
            this.lboCapture.TabIndex = 11;
            // 
            // btnSupprimerMembre
            // 
            this.btnSupprimerMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMembre.Location = new System.Drawing.Point(486, 133);
            this.btnSupprimerMembre.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(129, 41);
            this.btnSupprimerMembre.TabIndex = 12;
            this.btnSupprimerMembre.Text = "Supprimer";
            this.btnSupprimerMembre.UseVisualStyleBackColor = true;
            this.btnSupprimerMembre.Click += new System.EventHandler(this.btnSupprimerMembre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Espèce à capturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // lblReste
            // 
            this.lblReste.AutoSize = true;
            this.lblReste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReste.Location = new System.Drawing.Point(547, 26);
            this.lblReste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReste.Name = "lblReste";
            this.lblReste.Size = new System.Drawing.Size(0, 25);
            this.lblReste.TabIndex = 1;
            // 
            // frmAffectionMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(864, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimerMembre);
            this.Controls.Add(this.lboCapture);
            this.Controls.Add(this.lboMembre);
            this.Controls.Add(this.btAjouterCaptures);
            this.Controls.Add(this.btValiderObjectifs);
            this.Controls.Add(this.txtNbCaptureEspece);
            this.Controls.Add(this.cboEspece);
            this.Controls.Add(this.lblObjectif);
            this.Controls.Add(this.btValiderMembres);
            this.Controls.Add(this.btAjouterMembre);
            this.Controls.Add(this.cboMembre);
            this.Controls.Add(this.lblReste);
            this.Controls.Add(this.blAffectation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAffectionMission";
            this.Load += new System.EventHandler(this.frmAffectationMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blAffectation;
        private System.Windows.Forms.ComboBox cboMembre;
        private System.Windows.Forms.Button btAjouterMembre;
        private System.Windows.Forms.Button btValiderMembres;
        private System.Windows.Forms.Label lblObjectif;
        private System.Windows.Forms.ComboBox cboEspece;
        private System.Windows.Forms.TextBox txtNbCaptureEspece;
        private System.Windows.Forms.Button btValiderObjectifs;
        private System.Windows.Forms.Button btAjouterCaptures;
        private System.Windows.Forms.ListBox lboMembre;
        private System.Windows.Forms.ListBox lboCapture;
        private System.Windows.Forms.Button btnSupprimerMembre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReste;
    }
}