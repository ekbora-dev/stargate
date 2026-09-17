namespace SAE24
{
    partial class frmStats
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
            this.flpMembre = new System.Windows.Forms.FlowLayoutPanel();
            this.cboMembre = new System.Windows.Forms.ComboBox();
            this.cboEquipage = new System.Windows.Forms.ComboBox();
            this.gbMembre = new System.Windows.Forms.GroupBox();
            this.dgvEquipage = new System.Windows.Forms.DataGridView();
            this.lblBudgetInitial = new System.Windows.Forms.Label();
            this.lblBudgetActuel = new System.Windows.Forms.Label();
            this.gbEquipage = new System.Windows.Forms.GroupBox();
            this.gbPlanete = new System.Windows.Forms.GroupBox();
            this.dgvPlanete = new System.Windows.Forms.DataGridView();
            this.gbMission = new System.Windows.Forms.GroupBox();
            this.dgvMission = new System.Windows.Forms.DataGridView();
            this.gbInformateur = new System.Windows.Forms.GroupBox();
            this.dgvInformateur = new System.Windows.Forms.DataGridView();
            this.gbMembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipage)).BeginInit();
            this.gbEquipage.SuspendLayout();
            this.gbPlanete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanete)).BeginInit();
            this.gbMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).BeginInit();
            this.gbInformateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateur)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMembre
            // 
            this.flpMembre.AutoScroll = true;
            this.flpMembre.Location = new System.Drawing.Point(24, 66);
            this.flpMembre.Margin = new System.Windows.Forms.Padding(4);
            this.flpMembre.Name = "flpMembre";
            this.flpMembre.Size = new System.Drawing.Size(569, 281);
            this.flpMembre.TabIndex = 0;
            // 
            // cboMembre
            // 
            this.cboMembre.FormattingEnabled = true;
            this.cboMembre.Location = new System.Drawing.Point(24, 23);
            this.cboMembre.Margin = new System.Windows.Forms.Padding(4);
            this.cboMembre.Name = "cboMembre";
            this.cboMembre.Size = new System.Drawing.Size(423, 28);
            this.cboMembre.TabIndex = 1;
            this.cboMembre.SelectionChangeCommitted += new System.EventHandler(this.cboMembre_SelectionChangeCommitted);
            // 
            // cboEquipage
            // 
            this.cboEquipage.FormattingEnabled = true;
            this.cboEquipage.Location = new System.Drawing.Point(20, 23);
            this.cboEquipage.Margin = new System.Windows.Forms.Padding(4);
            this.cboEquipage.Name = "cboEquipage";
            this.cboEquipage.Size = new System.Drawing.Size(201, 28);
            this.cboEquipage.TabIndex = 2;
            this.cboEquipage.SelectionChangeCommitted += new System.EventHandler(this.cboEquipage_SelectionChangeCommitted);
            // 
            // gbMembre
            // 
            this.gbMembre.BackColor = System.Drawing.Color.Transparent;
            this.gbMembre.Controls.Add(this.cboMembre);
            this.gbMembre.Controls.Add(this.flpMembre);
            this.gbMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMembre.ForeColor = System.Drawing.Color.White;
            this.gbMembre.Location = new System.Drawing.Point(47, 43);
            this.gbMembre.Margin = new System.Windows.Forms.Padding(4);
            this.gbMembre.Name = "gbMembre";
            this.gbMembre.Padding = new System.Windows.Forms.Padding(4);
            this.gbMembre.Size = new System.Drawing.Size(617, 370);
            this.gbMembre.TabIndex = 4;
            this.gbMembre.TabStop = false;
            this.gbMembre.Text = "Liste des coéquipiers";
            // 
            // dgvEquipage
            // 
            this.dgvEquipage.AllowUserToAddRows = false;
            this.dgvEquipage.AllowUserToDeleteRows = false;
            this.dgvEquipage.AllowUserToResizeColumns = false;
            this.dgvEquipage.AllowUserToResizeRows = false;
            this.dgvEquipage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipage.Location = new System.Drawing.Point(20, 66);
            this.dgvEquipage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquipage.Name = "dgvEquipage";
            this.dgvEquipage.ReadOnly = true;
            this.dgvEquipage.RowHeadersWidth = 51;
            this.dgvEquipage.Size = new System.Drawing.Size(591, 126);
            this.dgvEquipage.TabIndex = 5;
            // 
            // lblBudgetInitial
            // 
            this.lblBudgetInitial.AutoSize = true;
            this.lblBudgetInitial.Location = new System.Drawing.Point(633, 90);
            this.lblBudgetInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetInitial.Name = "lblBudgetInitial";
            this.lblBudgetInitial.Size = new System.Drawing.Size(121, 20);
            this.lblBudgetInitial.TabIndex = 6;
            this.lblBudgetInitial.Text = "Budget Initial : ";
            // 
            // lblBudgetActuel
            // 
            this.lblBudgetActuel.AutoSize = true;
            this.lblBudgetActuel.Location = new System.Drawing.Point(633, 138);
            this.lblBudgetActuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetActuel.Name = "lblBudgetActuel";
            this.lblBudgetActuel.Size = new System.Drawing.Size(129, 20);
            this.lblBudgetActuel.TabIndex = 7;
            this.lblBudgetActuel.Text = "Budget Actuel : ";
            // 
            // gbEquipage
            // 
            this.gbEquipage.BackColor = System.Drawing.Color.Transparent;
            this.gbEquipage.Controls.Add(this.cboEquipage);
            this.gbEquipage.Controls.Add(this.lblBudgetActuel);
            this.gbEquipage.Controls.Add(this.dgvEquipage);
            this.gbEquipage.Controls.Add(this.lblBudgetInitial);
            this.gbEquipage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEquipage.ForeColor = System.Drawing.Color.White;
            this.gbEquipage.Location = new System.Drawing.Point(672, 133);
            this.gbEquipage.Margin = new System.Windows.Forms.Padding(4);
            this.gbEquipage.Name = "gbEquipage";
            this.gbEquipage.Padding = new System.Windows.Forms.Padding(4);
            this.gbEquipage.Size = new System.Drawing.Size(860, 212);
            this.gbEquipage.TabIndex = 8;
            this.gbEquipage.TabStop = false;
            this.gbEquipage.Text = "Liste des budgets alloués pour 10";
            // 
            // gbPlanete
            // 
            this.gbPlanete.BackColor = System.Drawing.Color.Transparent;
            this.gbPlanete.Controls.Add(this.dgvPlanete);
            this.gbPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlanete.ForeColor = System.Drawing.Color.White;
            this.gbPlanete.Location = new System.Drawing.Point(13, 421);
            this.gbPlanete.Margin = new System.Windows.Forms.Padding(4);
            this.gbPlanete.Name = "gbPlanete";
            this.gbPlanete.Padding = new System.Windows.Forms.Padding(4);
            this.gbPlanete.Size = new System.Drawing.Size(348, 212);
            this.gbPlanete.TabIndex = 9;
            this.gbPlanete.TabStop = false;
            this.gbPlanete.Text = "Nombre de missions";
            // 
            // dgvPlanete
            // 
            this.dgvPlanete.AllowUserToAddRows = false;
            this.dgvPlanete.AllowUserToDeleteRows = false;
            this.dgvPlanete.AllowUserToResizeColumns = false;
            this.dgvPlanete.AllowUserToResizeRows = false;
            this.dgvPlanete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanete.Location = new System.Drawing.Point(28, 43);
            this.dgvPlanete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlanete.Name = "dgvPlanete";
            this.dgvPlanete.ReadOnly = true;
            this.dgvPlanete.RowHeadersWidth = 51;
            this.dgvPlanete.Size = new System.Drawing.Size(295, 143);
            this.dgvPlanete.TabIndex = 10;
            // 
            // gbMission
            // 
            this.gbMission.BackColor = System.Drawing.Color.Transparent;
            this.gbMission.Controls.Add(this.dgvMission);
            this.gbMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMission.ForeColor = System.Drawing.Color.White;
            this.gbMission.Location = new System.Drawing.Point(381, 421);
            this.gbMission.Margin = new System.Windows.Forms.Padding(4);
            this.gbMission.Name = "gbMission";
            this.gbMission.Padding = new System.Windows.Forms.Padding(4);
            this.gbMission.Size = new System.Drawing.Size(585, 190);
            this.gbMission.TabIndex = 10;
            this.gbMission.TabStop = false;
            this.gbMission.Text = "Dépenses Missions";
            // 
            // dgvMission
            // 
            this.dgvMission.AllowUserToAddRows = false;
            this.dgvMission.AllowUserToDeleteRows = false;
            this.dgvMission.AllowUserToResizeColumns = false;
            this.dgvMission.AllowUserToResizeRows = false;
            this.dgvMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMission.Location = new System.Drawing.Point(24, 23);
            this.dgvMission.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMission.Name = "dgvMission";
            this.dgvMission.ReadOnly = true;
            this.dgvMission.RowHeadersWidth = 51;
            this.dgvMission.Size = new System.Drawing.Size(553, 159);
            this.dgvMission.TabIndex = 0;
            // 
            // gbInformateur
            // 
            this.gbInformateur.BackColor = System.Drawing.Color.Transparent;
            this.gbInformateur.Controls.Add(this.dgvInformateur);
            this.gbInformateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformateur.ForeColor = System.Drawing.Color.White;
            this.gbInformateur.Location = new System.Drawing.Point(1027, 421);
            this.gbInformateur.Margin = new System.Windows.Forms.Padding(4);
            this.gbInformateur.Name = "gbInformateur";
            this.gbInformateur.Padding = new System.Windows.Forms.Padding(4);
            this.gbInformateur.Size = new System.Drawing.Size(526, 190);
            this.gbInformateur.TabIndex = 11;
            this.gbInformateur.TabStop = false;
            this.gbInformateur.Text = "Informateurs";
            // 
            // dgvInformateur
            // 
            this.dgvInformateur.AllowUserToAddRows = false;
            this.dgvInformateur.AllowUserToDeleteRows = false;
            this.dgvInformateur.AllowUserToResizeColumns = false;
            this.dgvInformateur.AllowUserToResizeRows = false;
            this.dgvInformateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformateur.Location = new System.Drawing.Point(24, 23);
            this.dgvInformateur.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInformateur.Name = "dgvInformateur";
            this.dgvInformateur.ReadOnly = true;
            this.dgvInformateur.RowHeadersWidth = 51;
            this.dgvInformateur.Size = new System.Drawing.Size(473, 159);
            this.dgvInformateur.TabIndex = 0;
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::SAE24.Properties.Resources.fond3;
            this.ClientSize = new System.Drawing.Size(1595, 748);
            this.Controls.Add(this.gbInformateur);
            this.Controls.Add(this.gbMission);
            this.Controls.Add(this.gbPlanete);
            this.Controls.Add(this.gbEquipage);
            this.Controls.Add(this.gbMembre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStats";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.frmStats_Load);
            this.gbMembre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipage)).EndInit();
            this.gbEquipage.ResumeLayout(false);
            this.gbEquipage.PerformLayout();
            this.gbPlanete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanete)).EndInit();
            this.gbMission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).EndInit();
            this.gbInformateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMembre;
        private System.Windows.Forms.ComboBox cboMembre;
        private System.Windows.Forms.ComboBox cboEquipage;
        private System.Windows.Forms.GroupBox gbMembre;
        private System.Windows.Forms.DataGridView dgvEquipage;
        private System.Windows.Forms.Label lblBudgetInitial;
        private System.Windows.Forms.Label lblBudgetActuel;
        private System.Windows.Forms.GroupBox gbEquipage;
        private System.Windows.Forms.GroupBox gbPlanete;
        private System.Windows.Forms.DataGridView dgvPlanete;
        private System.Windows.Forms.GroupBox gbMission;
        private System.Windows.Forms.DataGridView dgvMission;
        private System.Windows.Forms.GroupBox gbInformateur;
        private System.Windows.Forms.DataGridView dgvInformateur;
    }
}