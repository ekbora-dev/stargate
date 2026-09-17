namespace SAE24
{
    partial class frmAffichageMission
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
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblRetour = new System.Windows.Forms.Label();
            this.gboFeuille = new System.Windows.Forms.GroupBox();
            this.txtFeuille = new System.Windows.Forms.RichTextBox();
            this.lboCapture = new System.Windows.Forms.ListBox();
            this.btnJournal = new System.Windows.Forms.Button();
            this.flpEquipage = new System.Windows.Forms.FlowLayoutPanel();
            this.pboPlanete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboInformateur = new System.Windows.Forms.ComboBox();
            this.Informateur = new System.Windows.Forms.Label();
            this.txtSommeContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppreciationContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpContact = new System.Windows.Forms.DateTimePicker();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAjouterDep = new System.Windows.Forms.Button();
            this.cboTypeDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontantDep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotifDep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateDep = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAjouterCapture = new System.Windows.Forms.Button();
            this.txtNbCapture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEspeceEnnemi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAjouterEvent = new System.Windows.Forms.Button();
            this.txtCommentaireEvent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAjouterDataBaz = new System.Windows.Forms.Button();
            this.txtQteDataBaz = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboAllie = new System.Windows.Forms.ComboBox();
            this.btnFermerMission = new System.Windows.Forms.Button();
            this.lblDataBaz = new System.Windows.Forms.Label();
            this.gboFeuille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlanete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(33, 30);
            this.lblMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(128, 29);
            this.lblMission.TabIndex = 1;
            this.lblMission.Text = "MISSION ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(34, 124);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(190, 20);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Date de départ prévue : ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(530, 124);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(77, 20);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "Budget : ";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.Location = new System.Drawing.Point(530, 176);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(181, 20);
            this.lblSolde.TabIndex = 4;
            this.lblSolde.Text = "Solde après dépense : ";
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetour.Location = new System.Drawing.Point(34, 176);
            this.lblRetour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(187, 20);
            this.lblRetour.TabIndex = 5;
            this.lblRetour.Text = "Date de retour prévue : ";
            // 
            // gboFeuille
            // 
            this.gboFeuille.Controls.Add(this.txtFeuille);
            this.gboFeuille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFeuille.Location = new System.Drawing.Point(13, 209);
            this.gboFeuille.Margin = new System.Windows.Forms.Padding(4);
            this.gboFeuille.Name = "gboFeuille";
            this.gboFeuille.Padding = new System.Windows.Forms.Padding(4);
            this.gboFeuille.Size = new System.Drawing.Size(787, 134);
            this.gboFeuille.TabIndex = 6;
            this.gboFeuille.TabStop = false;
            this.gboFeuille.Text = "Feuille de Route";
            // 
            // txtFeuille
            // 
            this.txtFeuille.Location = new System.Drawing.Point(8, 23);
            this.txtFeuille.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeuille.Name = "txtFeuille";
            this.txtFeuille.Size = new System.Drawing.Size(769, 103);
            this.txtFeuille.TabIndex = 0;
            this.txtFeuille.Text = "";
            // 
            // lboCapture
            // 
            this.lboCapture.AccessibleDescription = "";
            this.lboCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCapture.FormattingEnabled = true;
            this.lboCapture.ItemHeight = 20;
            this.lboCapture.Location = new System.Drawing.Point(13, 716);
            this.lboCapture.Margin = new System.Windows.Forms.Padding(4);
            this.lboCapture.Name = "lboCapture";
            this.lboCapture.Size = new System.Drawing.Size(787, 84);
            this.lboCapture.TabIndex = 9;
            // 
            // btnJournal
            // 
            this.btnJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJournal.Location = new System.Drawing.Point(836, 372);
            this.btnJournal.Margin = new System.Windows.Forms.Padding(4);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(134, 66);
            this.btnJournal.TabIndex = 10;
            this.btnJournal.Text = "Journal de bord";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // flpEquipage
            // 
            this.flpEquipage.AutoScroll = true;
            this.flpEquipage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEquipage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpEquipage.Location = new System.Drawing.Point(13, 372);
            this.flpEquipage.Name = "flpEquipage";
            this.flpEquipage.Size = new System.Drawing.Size(787, 306);
            this.flpEquipage.TabIndex = 11;
            // 
            // pboPlanete
            // 
            this.pboPlanete.Location = new System.Drawing.Point(402, 13);
            this.pboPlanete.Margin = new System.Windows.Forms.Padding(4);
            this.pboPlanete.Name = "pboPlanete";
            this.pboPlanete.Size = new System.Drawing.Size(110, 99);
            this.pboPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboPlanete.TabIndex = 0;
            this.pboPlanete.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Objectif de capture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Membre de la mission";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1007, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 797);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout d\'un évènement";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(31, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 759);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboInformateur);
            this.tabPage1.Controls.Add(this.Informateur);
            this.tabPage1.Controls.Add(this.txtSommeContact);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAppreciationContact);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpContact);
            this.tabPage1.Controls.Add(this.btnAjouterContact);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nouveau contact";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboInformateur
            // 
            this.cboInformateur.FormattingEnabled = true;
            this.cboInformateur.Location = new System.Drawing.Point(176, 332);
            this.cboInformateur.Name = "cboInformateur";
            this.cboInformateur.Size = new System.Drawing.Size(234, 28);
            this.cboInformateur.TabIndex = 9;
            // 
            // Informateur
            // 
            this.Informateur.AutoSize = true;
            this.Informateur.Location = new System.Drawing.Point(44, 335);
            this.Informateur.Name = "Informateur";
            this.Informateur.Size = new System.Drawing.Size(94, 20);
            this.Informateur.TabIndex = 8;
            this.Informateur.Text = "Informateur";
            // 
            // txtSommeContact
            // 
            this.txtSommeContact.Location = new System.Drawing.Point(163, 262);
            this.txtSommeContact.Name = "txtSommeContact";
            this.txtSommeContact.Size = new System.Drawing.Size(117, 27);
            this.txtSommeContact.TabIndex = 7;
            this.txtSommeContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSommeContact_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Somme";
            // 
            // txtAppreciationContact
            // 
            this.txtAppreciationContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppreciationContact.Location = new System.Drawing.Point(176, 100);
            this.txtAppreciationContact.Multiline = true;
            this.txtAppreciationContact.Name = "txtAppreciationContact";
            this.txtAppreciationContact.Size = new System.Drawing.Size(299, 104);
            this.txtAppreciationContact.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Commentaires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // dtpContact
            // 
            this.dtpContact.Location = new System.Drawing.Point(163, 37);
            this.dtpContact.Name = "dtpContact";
            this.dtpContact.Size = new System.Drawing.Size(268, 27);
            this.dtpContact.TabIndex = 2;
            this.dtpContact.ValueChanged += new System.EventHandler(this.dtpContact_ValueChanged);
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(460, 397);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(121, 47);
            this.btnAjouterContact.TabIndex = 1;
            this.btnAjouterContact.Text = "Ajouter";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAjouterDep);
            this.tabPage2.Controls.Add(this.cboTypeDep);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtMontantDep);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtMotifDep);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpDateDep);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nouvelle dépense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAjouterDep
            // 
            this.btnAjouterDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterDep.Location = new System.Drawing.Point(443, 395);
            this.btnAjouterDep.Name = "btnAjouterDep";
            this.btnAjouterDep.Size = new System.Drawing.Size(114, 40);
            this.btnAjouterDep.TabIndex = 18;
            this.btnAjouterDep.Text = "Ajouter";
            this.btnAjouterDep.UseVisualStyleBackColor = true;
            this.btnAjouterDep.Click += new System.EventHandler(this.btnAjouterDep_Click);
            // 
            // cboTypeDep
            // 
            this.cboTypeDep.FormattingEnabled = true;
            this.cboTypeDep.Location = new System.Drawing.Point(220, 331);
            this.cboTypeDep.Name = "cboTypeDep";
            this.cboTypeDep.Size = new System.Drawing.Size(194, 28);
            this.cboTypeDep.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type de dépense";
            // 
            // txtMontantDep
            // 
            this.txtMontantDep.Location = new System.Drawing.Point(163, 271);
            this.txtMontantDep.Name = "txtMontantDep";
            this.txtMontantDep.Size = new System.Drawing.Size(117, 27);
            this.txtMontantDep.TabIndex = 15;
            this.txtMontantDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantDep_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Montant";
            // 
            // txtMotifDep
            // 
            this.txtMotifDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotifDep.Location = new System.Drawing.Point(163, 112);
            this.txtMotifDep.Multiline = true;
            this.txtMotifDep.Name = "txtMotifDep";
            this.txtMotifDep.Size = new System.Drawing.Size(299, 104);
            this.txtMotifDep.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Motif";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date";
            // 
            // dtpDateDep
            // 
            this.dtpDateDep.Location = new System.Drawing.Point(163, 46);
            this.dtpDateDep.Name = "dtpDateDep";
            this.dtpDateDep.Size = new System.Drawing.Size(268, 27);
            this.dtpDateDep.TabIndex = 10;
            this.dtpDateDep.ValueChanged += new System.EventHandler(this.dtpDateDep_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAjouterCapture);
            this.tabPage3.Controls.Add(this.txtNbCapture);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cboEspeceEnnemi);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(606, 726);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nouvelle capture";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAjouterCapture
            // 
            this.btnAjouterCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterCapture.Location = new System.Drawing.Point(361, 201);
            this.btnAjouterCapture.Name = "btnAjouterCapture";
            this.btnAjouterCapture.Size = new System.Drawing.Size(116, 38);
            this.btnAjouterCapture.TabIndex = 19;
            this.btnAjouterCapture.Text = "Ajouter";
            this.btnAjouterCapture.UseVisualStyleBackColor = true;
            this.btnAjouterCapture.Click += new System.EventHandler(this.btnAjouterCapture_Click);
            // 
            // txtNbCapture
            // 
            this.txtNbCapture.Location = new System.Drawing.Point(206, 112);
            this.txtNbCapture.Name = "txtNbCapture";
            this.txtNbCapture.Size = new System.Drawing.Size(100, 27);
            this.txtNbCapture.TabIndex = 3;
            this.txtNbCapture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbCapture_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nombre capturé";
            // 
            // cboEspeceEnnemi
            // 
            this.cboEspeceEnnemi.FormattingEnabled = true;
            this.cboEspeceEnnemi.Location = new System.Drawing.Point(206, 67);
            this.cboEspeceEnnemi.Name = "cboEspeceEnnemi";
            this.cboEspeceEnnemi.Size = new System.Drawing.Size(154, 28);
            this.cboEspeceEnnemi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Espèce capturé";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAjouterEvent);
            this.tabPage4.Controls.Add(this.txtCommentaireEvent);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.dtpEvent);
            this.tabPage4.Controls.Add(this.Date);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(606, 726);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nouvel évènement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAjouterEvent
            // 
            this.btnAjouterEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterEvent.Location = new System.Drawing.Point(410, 326);
            this.btnAjouterEvent.Name = "btnAjouterEvent";
            this.btnAjouterEvent.Size = new System.Drawing.Size(112, 51);
            this.btnAjouterEvent.TabIndex = 4;
            this.btnAjouterEvent.Text = "Ajouter";
            this.btnAjouterEvent.UseVisualStyleBackColor = true;
            this.btnAjouterEvent.Click += new System.EventHandler(this.btnAjouterEvent_Click);
            // 
            // txtCommentaireEvent
            // 
            this.txtCommentaireEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommentaireEvent.Location = new System.Drawing.Point(49, 113);
            this.txtCommentaireEvent.Multiline = true;
            this.txtCommentaireEvent.Name = "txtCommentaireEvent";
            this.txtCommentaireEvent.Size = new System.Drawing.Size(286, 175);
            this.txtCommentaireEvent.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Commentaire";
            // 
            // dtpEvent
            // 
            this.dtpEvent.Location = new System.Drawing.Point(145, 42);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(286, 27);
            this.dtpEvent.TabIndex = 1;
            this.dtpEvent.ValueChanged += new System.EventHandler(this.dtpEvent_ValueChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(45, 47);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(45, 20);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.btnAjouterDataBaz);
            this.tabPage5.Controls.Add(this.txtQteDataBaz);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.cboAllie);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(606, 726);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Négociation de DataBaz";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "t";
            // 
            // btnAjouterDataBaz
            // 
            this.btnAjouterDataBaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterDataBaz.Location = new System.Drawing.Point(442, 198);
            this.btnAjouterDataBaz.Name = "btnAjouterDataBaz";
            this.btnAjouterDataBaz.Size = new System.Drawing.Size(112, 51);
            this.btnAjouterDataBaz.TabIndex = 5;
            this.btnAjouterDataBaz.Text = "Ajouter";
            this.btnAjouterDataBaz.UseVisualStyleBackColor = true;
            this.btnAjouterDataBaz.Click += new System.EventHandler(this.btnAjouterDataBaz_Click);
            // 
            // txtQteDataBaz
            // 
            this.txtQteDataBaz.Location = new System.Drawing.Point(174, 122);
            this.txtQteDataBaz.Name = "txtQteDataBaz";
            this.txtQteDataBaz.Size = new System.Drawing.Size(94, 27);
            this.txtQteDataBaz.TabIndex = 3;
            this.txtQteDataBaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQteDataBaz_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "DataBaz négocié";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nom de l\'allié";
            // 
            // cboAllie
            // 
            this.cboAllie.FormattingEnabled = true;
            this.cboAllie.Location = new System.Drawing.Point(162, 66);
            this.cboAllie.Name = "cboAllie";
            this.cboAllie.Size = new System.Drawing.Size(199, 28);
            this.cboAllie.TabIndex = 0;
            // 
            // btnFermerMission
            // 
            this.btnFermerMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermerMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermerMission.Location = new System.Drawing.Point(836, 277);
            this.btnFermerMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermerMission.Name = "btnFermerMission";
            this.btnFermerMission.Size = new System.Drawing.Size(134, 66);
            this.btnFermerMission.TabIndex = 15;
            this.btnFermerMission.Text = "Accueil";
            this.btnFermerMission.UseVisualStyleBackColor = true;
            this.btnFermerMission.Click += new System.EventHandler(this.btnFermerMission_Click);
            // 
            // lblDataBaz
            // 
            this.lblDataBaz.AutoSize = true;
            this.lblDataBaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBaz.Location = new System.Drawing.Point(530, 78);
            this.lblDataBaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBaz.Name = "lblDataBaz";
            this.lblDataBaz.Size = new System.Drawing.Size(164, 20);
            this.lblDataBaz.TabIndex = 16;
            this.lblDataBaz.Text = "Objectif de databaz :";
            // 
            // frmAffichageMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1780, 920);
            this.Controls.Add(this.lblDataBaz);
            this.Controls.Add(this.btnFermerMission);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpEquipage);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.lboCapture);
            this.Controls.Add(this.gboFeuille);
            this.Controls.Add(this.lblRetour);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.pboPlanete);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAffichageMission";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAffichageMission_Load);
            this.gboFeuille.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboPlanete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboPlanete;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.GroupBox gboFeuille;
        private System.Windows.Forms.RichTextBox txtFeuille;
        private System.Windows.Forms.ListBox lboCapture;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.FlowLayoutPanel flpEquipage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpContact;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtSommeContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAppreciationContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInformateur;
        private System.Windows.Forms.Label Informateur;
        private System.Windows.Forms.ComboBox cboTypeDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontantDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotifDep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateDep;
        private System.Windows.Forms.Button btnAjouterDep;
        private System.Windows.Forms.ComboBox cboEspeceEnnemi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNbCapture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAjouterCapture;
        private System.Windows.Forms.Button btnAjouterEvent;
        private System.Windows.Forms.TextBox txtCommentaireEvent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button btnFermerMission;
        private System.Windows.Forms.Label lblDataBaz;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cboAllie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAjouterDataBaz;
        private System.Windows.Forms.TextBox txtQteDataBaz;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}