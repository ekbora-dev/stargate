namespace SAE24
{
    partial class frmJournalDeBord
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
            this.gboJournal = new System.Windows.Forms.GroupBox();
            this.btSupSup = new System.Windows.Forms.Button();
            this.btSup = new System.Windows.Forms.Button();
            this.btInf = new System.Windows.Forms.Button();
            this.btInfInf = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gboDepense = new System.Windows.Forms.GroupBox();
            this.dgvDepense = new System.Windows.Forms.DataGridView();
            this.gboContact = new System.Windows.Forms.GroupBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.lblSomme = new System.Windows.Forms.Label();
            this.lblDepense = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.gboJournal.SuspendLayout();
            this.gboDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).BeginInit();
            this.gboContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // gboJournal
            // 
            this.gboJournal.Controls.Add(this.btSupSup);
            this.gboJournal.Controls.Add(this.btSup);
            this.gboJournal.Controls.Add(this.btInf);
            this.gboJournal.Controls.Add(this.btInfInf);
            this.gboJournal.Controls.Add(this.lblMessage);
            this.gboJournal.Controls.Add(this.lblDate);
            this.gboJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboJournal.Location = new System.Drawing.Point(57, 42);
            this.gboJournal.Margin = new System.Windows.Forms.Padding(4);
            this.gboJournal.Name = "gboJournal";
            this.gboJournal.Padding = new System.Windows.Forms.Padding(4);
            this.gboJournal.Size = new System.Drawing.Size(496, 149);
            this.gboJournal.TabIndex = 0;
            this.gboJournal.TabStop = false;
            this.gboJournal.Text = "Evenements du journal";
            // 
            // btSupSup
            // 
            this.btSupSup.Location = new System.Drawing.Point(289, 90);
            this.btSupSup.Margin = new System.Windows.Forms.Padding(4);
            this.btSupSup.Name = "btSupSup";
            this.btSupSup.Size = new System.Drawing.Size(47, 37);
            this.btSupSup.TabIndex = 5;
            this.btSupSup.Text = ">>";
            this.btSupSup.UseVisualStyleBackColor = true;
            this.btSupSup.Click += new System.EventHandler(this.btSupSup_Click);
            // 
            // btSup
            // 
            this.btSup.Location = new System.Drawing.Point(204, 90);
            this.btSup.Margin = new System.Windows.Forms.Padding(4);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(47, 37);
            this.btSup.TabIndex = 6;
            this.btSup.Text = ">";
            this.btSup.UseVisualStyleBackColor = true;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // btInf
            // 
            this.btInf.Location = new System.Drawing.Point(124, 90);
            this.btInf.Margin = new System.Windows.Forms.Padding(4);
            this.btInf.Name = "btInf";
            this.btInf.Size = new System.Drawing.Size(47, 37);
            this.btInf.TabIndex = 7;
            this.btInf.Text = "<";
            this.btInf.UseVisualStyleBackColor = true;
            this.btInf.Click += new System.EventHandler(this.btInf_Click);
            // 
            // btInfInf
            // 
            this.btInfInf.Location = new System.Drawing.Point(51, 90);
            this.btInfInf.Margin = new System.Windows.Forms.Padding(4);
            this.btInfInf.Name = "btInfInf";
            this.btInfInf.Size = new System.Drawing.Size(47, 37);
            this.btInfInf.TabIndex = 8;
            this.btInfInf.Text = "<<";
            this.btInfInf.UseVisualStyleBackColor = true;
            this.btInfInf.Click += new System.EventHandler(this.btInfInf_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(47, 70);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 25);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Tag = " ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 34);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Tag = " ";
            // 
            // gboDepense
            // 
            this.gboDepense.Controls.Add(this.dgvDepense);
            this.gboDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDepense.Location = new System.Drawing.Point(600, 42);
            this.gboDepense.Margin = new System.Windows.Forms.Padding(4);
            this.gboDepense.Name = "gboDepense";
            this.gboDepense.Padding = new System.Windows.Forms.Padding(4);
            this.gboDepense.Size = new System.Drawing.Size(385, 337);
            this.gboDepense.TabIndex = 1;
            this.gboDepense.TabStop = false;
            this.gboDepense.Text = "Dépenses effectuées";
            // 
            // dgvDepense
            // 
            this.dgvDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepense.Location = new System.Drawing.Point(27, 48);
            this.dgvDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepense.Name = "dgvDepense";
            this.dgvDepense.RowHeadersWidth = 51;
            this.dgvDepense.Size = new System.Drawing.Size(333, 260);
            this.dgvDepense.TabIndex = 5;
            // 
            // gboContact
            // 
            this.gboContact.Controls.Add(this.dgvContact);
            this.gboContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboContact.Location = new System.Drawing.Point(57, 222);
            this.gboContact.Margin = new System.Windows.Forms.Padding(4);
            this.gboContact.Name = "gboContact";
            this.gboContact.Padding = new System.Windows.Forms.Padding(4);
            this.gboContact.Size = new System.Drawing.Size(450, 205);
            this.gboContact.TabIndex = 1;
            this.gboContact.TabStop = false;
            this.gboContact.Text = "Contact avec les informateurs";
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Location = new System.Drawing.Point(8, 31);
            this.dgvContact.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.RowHeadersWidth = 51;
            this.dgvContact.Size = new System.Drawing.Size(416, 166);
            this.dgvContact.TabIndex = 0;
            // 
            // lblSomme
            // 
            this.lblSomme.AutoSize = true;
            this.lblSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomme.Location = new System.Drawing.Point(205, 431);
            this.lblSomme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSomme.Name = "lblSomme";
            this.lblSomme.Size = new System.Drawing.Size(262, 25);
            this.lblSomme.TabIndex = 2;
            this.lblSomme.Tag = " ";
            this.lblSomme.Text = "Total des sommes versées : ";
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepense.Location = new System.Drawing.Point(623, 431);
            this.lblDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(200, 25);
            this.lblDepense.TabIndex = 3;
            this.lblDepense.Tag = " ";
            this.lblDepense.Text = "Total des dépenses : ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(611, 473);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 5;
            this.lblError.Tag = " ";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(454, 473);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(170, 50);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer le journal";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDepense);
            this.Controls.Add(this.lblSomme);
            this.Controls.Add(this.gboContact);
            this.Controls.Add(this.gboDepense);
            this.Controls.Add(this.gboJournal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJournalDeBord";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJournalDeBord_FormClosed);
            this.Load += new System.EventHandler(this.frmJournalDeBord_Load);
            this.gboJournal.ResumeLayout(false);
            this.gboJournal.PerformLayout();
            this.gboDepense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).EndInit();
            this.gboContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboJournal;
        private System.Windows.Forms.GroupBox gboDepense;
        private System.Windows.Forms.GroupBox gboContact;
        private System.Windows.Forms.Label lblSomme;
        private System.Windows.Forms.Button btSupSup;
        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btInf;
        private System.Windows.Forms.Button btInfInf;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridView dgvDepense;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFermer;
    }
}