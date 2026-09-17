using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmAffichageMission : Form
    {
        private string nomPlanete;
        private int numero;

        private int soldeApresDep;

        DateTime dateAllerDtp, dateRetourDtp;


        // this.ucAjoutEvenement1.Location = new System.Drawing.Point(31, 187) (
        public frmAffichageMission(string pl, int nm)
        {
            InitializeComponent();
            this.nomPlanete = pl;
            this.numero = nm;

            this.Text = "Mission : " + pl + nm; // Titre de la fenêtre
        }

        private void majSolde()
        {
            DataRow[] mission = MesDatas.DsGlobal.Tables["Mission"].Select($"nomPlanete = '{nomPlanete}' AND numero = '{numero}'");
            if (mission.Length == 0) return;

            int budgetInitial = Convert.ToInt32(mission[0]["budget"]);

            int totalDepenses = 0;
            DataRow[] depenses = MesDatas.DsGlobal.Tables["Depense"].Select($"nomPlanete = '{nomPlanete}' AND numeroMission = '{numero}'");
            foreach (DataRow dep in depenses)
            {
                totalDepenses += Convert.ToInt32(dep["montant"]);
            }

            int totalContacts = 0;
            DataRow[] contacts = MesDatas.DsGlobal.Tables["Contact"].Select($"nomPlanete = '{nomPlanete}' AND numeroMission = '{numero}'");
            foreach (DataRow cont in contacts)
            {
                totalContacts += Convert.ToInt32(cont["sommeVersee"]);
            }

            soldeApresDep = budgetInitial - totalDepenses - totalContacts;
            lblSolde.Text = "Solde après dépense : " + soldeApresDep.ToString() + " G$";
        }


        private void frmAffichageMission_Load(object sender, EventArgs e)
        {
            pboPlanete.Image = Image.FromFile($"./imagePlanete/{nomPlanete}.jpg");
            lblMission.Text = "Mission : " + nomPlanete + numero;
            DataTable mission = MesDatas.DsGlobal.Tables["Mission"];
            string dateAller, dateRetour, budget, feuilleRoute, qteDataBaz;
            DataRow[] dr = mission.Select($"nomPlanete = '{nomPlanete}' AND numero = '{numero}'");

            dateAller = "Départ le : " + DateTime.Parse(dr[0]["dateDepart"].ToString()).ToString("dd/MM/yyyy");
            dateRetour = "Retour le : " + DateTime.Parse(dr[0]["dateRetour"].ToString()).ToString("dd/MM/yyyy");
            feuilleRoute = dr[0]["feuilleDeRoute"].ToString();
            budget = "Budget : " + dr[0]["budget"].ToString() + " G$";
            qteDataBaz = "Objectif de databaz : " + dr[0]["objectifDatabaz"].ToString() + " t";

            dateAllerDtp = DateTime.Parse(dr[0]["dateDepart"].ToString());
            dateRetourDtp = DateTime.Parse(dr[0]["dateRetour"].ToString());


            majSolde(); // Affichage du solde


            DataTable composer = MesDatas.DsGlobal.Tables["Composer"];
            DataRow[] compositionMission = composer.Select($"nomPlanete = '{nomPlanete}' AND numeroMission = '{numero}'");


            DataTable membre = MesDatas.DsGlobal.Tables["Membre"];
            string nom, prenom, matricule;

            string chefMission = dr[0]["matriculeChef"].ToString();

            for (int i = 0; i < compositionMission.Length; i++)
            {
                DataRow[] membreMission = membre.Select($"matricule = '{compositionMission[i]["matriculeMembre"]}'");
                nom = membreMission[0]["nom"].ToString();
                prenom = membreMission[0]["prenom"].ToString();
                matricule = membreMission[0]["matricule"].ToString();

                string nomComplet = prenom + "\n" + nom;
                bool estChef = matricule == chefMission;
                UCMembre carteMembre = new UCMembre(matricule, nomComplet, estChef);
                flpEquipage.Controls.Add(carteMembre);
            }

            lblDepart.Text = dateAller;
            lblRetour.Text = dateRetour;
            txtFeuille.Text = feuilleRoute;
            lblBudget.Text = budget;
            lblDataBaz.Text = qteDataBaz;

            DataTable espece = MesDatas.DsGlobal.Tables["Espece"];
            DataTable objectif = MesDatas.DsGlobal.Tables["ObjectifCapture"];

            DataRow[] objectifCaptureMission = objectif.Select($"nomPlanete = '{nomPlanete}' AND numeroMission = '{numero}'");

            for (int i = 0; i < objectifCaptureMission.Length; i++)
            {
                DataRow[] especeCapturee = espece.Select($"id = '{objectifCaptureMission[i]["idEspeceEnnemi"]}'");
                lboCapture.Items.Add(especeCapturee[0]["nom"].ToString() + " -> " + objectifCaptureMission[i]["objectif"]);
            }

            if (objectifCaptureMission.Length == 0)
            {
                lboCapture.Items.Add("Pas d'objectif de capture pour cette mission !");
            }


            // Chargement des combos, etc... dans la partie "Ajout d'évènement"

            DataTable informateur = MesDatas.DsGlobal.Tables["Informateur"];
            DataTable ennemi = MesDatas.DsGlobal.Tables["Ennemi"];
            DataTable typeDepense = MesDatas.DsGlobal.Tables["TypeDepense"];

            cboInformateur.DataSource = informateur;
            cboInformateur.DisplayMember = "nom";
            cboInformateur.ValueMember = "nomCode";

            DataTable especesEnnemi = espece.Clone();

            for (int i = 0; i < ennemi.Rows.Count; i++)
            {
                string idEspeceEnnemi = ennemi.Rows[i]["idEspece"].ToString();

                DataRow[] especeFiltree = espece.Select($"id = '{idEspeceEnnemi}'");

                especesEnnemi.ImportRow(especeFiltree[0]);
            }

            cboEspeceEnnemi.DataSource = especesEnnemi;
            cboEspeceEnnemi.DisplayMember = "nom";
            cboEspeceEnnemi.ValueMember = "id";

            cboTypeDep.DataSource = typeDepense;
            cboTypeDep.DisplayMember = "libelle";
            cboTypeDep.ValueMember = "id";


            DataTable allie = MesDatas.DsGlobal.Tables["Allie"];

            DataTable especesAllie = espece.Clone();

            for (int i = 0; i < allie.Rows.Count; i++)
            {
                string idEspeceAllie = allie.Rows[i]["idEspece"].ToString();

                DataRow[] especeFiltree = espece.Select($"id = '{idEspeceAllie}'");

                especesAllie.ImportRow(especeFiltree[0]);
            }

            cboAllie.DataSource = especesAllie;
            cboAllie.DisplayMember = "nom";
            cboAllie.ValueMember = "id";

        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            frmJournalDeBord journal = new frmJournalDeBord(nomPlanete, numero);
            DialogResult dr = journal.ShowDialog();
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            if (dtpContact.Value == null || txtAppreciationContact.Text == "" || cboInformateur.SelectedValue == null || txtSommeContact.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
                return;
            }

            int sommeContact = Convert.ToInt32(txtSommeContact.Text);
            if (soldeApresDep - sommeContact < 0)
            {
                MessageBox.Show("Hors budget ! Vous n'avez pas les fonds nécessaires pour payer cet informateur.");
                return;
            }

            try
            {
                string sql = "INSERT INTO Contact VALUES (@nomPlanete, @numeroMission, @dateC, @sommeVersee, @appreciation, @nomCodeInformateur)";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", numero);
                cmd.Parameters.AddWithValue("@dateC", dtpContact.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sommeVersee", sommeContact);
                cmd.Parameters.AddWithValue("@appreciation", txtAppreciationContact.Text);
                cmd.Parameters.AddWithValue("@nomCodeInformateur", cboInformateur.SelectedValue);

                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            MesDatas.DsGlobal.Tables.Remove("Contact");
            string sqlSelectCon = "SELECT * FROM Contact";
            SQLiteDataAdapter daDep = new SQLiteDataAdapter(sqlSelectCon, Connexion.Connec);
            daDep.Fill(MesDatas.DsGlobal, "Contact");

            majSolde();

            dtpContact.Value = DateTime.Today;
            txtAppreciationContact.Text = "";
            txtSommeContact.Text = "";
        }

        private void btnAjouterDep_Click(object sender, EventArgs e)
        {
            if (dtpDateDep.Value == null || txtMontantDep.Text == "" || txtMotifDep.Text == "" || cboTypeDep.SelectedValue == null)
            {
                MessageBox.Show("Merci de remplir tous les champs");
                return;
            }

            int montantDepense = Convert.ToInt32(txtMontantDep.Text);
            if (soldeApresDep - montantDepense < 0)
            {
                MessageBox.Show("Hors budget ! Vous n'avez pas les fonds nécessaires.");
                return;
            }

            int idDep;

            try
            {
                string sql = $"SELECT MAX(id) FROM Depense WHERE numeroMission = '{numero}' AND nomPlanete = '{nomPlanete}'";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                object id = cmd.ExecuteScalar();
                if (id == DBNull.Value || id == null)
                {
                    idDep = 1;
                }
                else
                {
                    idDep = Convert.ToInt32(id) + 1;
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            try
            {
                string sql = "INSERT INTO Depense VALUES (@nomPlanete, @numeroMission, @id, @dateD, @montant, @motif, @idTypeDepense)";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", numero);
                cmd.Parameters.AddWithValue("@id", idDep);
                cmd.Parameters.AddWithValue("@dateD", dtpDateDep.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@montant", montantDepense);
                cmd.Parameters.AddWithValue("@motif", txtMotifDep.Text);
                cmd.Parameters.AddWithValue("@idTypeDepense", cboTypeDep.SelectedValue);

                cmd.ExecuteNonQuery();

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            MesDatas.DsGlobal.Tables.Remove("Depense");
            string sqlSelectDep = "SELECT * FROM Depense";
            SQLiteDataAdapter daDep = new SQLiteDataAdapter(sqlSelectDep, Connexion.Connec);
            daDep.Fill(MesDatas.DsGlobal, "Depense");

            majSolde();

            dtpDateDep.Value = DateTime.Today;
            txtMontantDep.Text = "";
            txtMotifDep.Text = "";
            cboTypeDep.SelectedIndex = 0;
        }

        private void btnAjouterCapture_Click(object sender, EventArgs e)
        {
            if (cboEspeceEnnemi.SelectedValue == null || txtNbCapture.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                string sql = "INSERT INTO Capturer VALUES (@nomPlanete, @numeroMission, @idEspeceEnnemi, @objectif)";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", numero);
                cmd.Parameters.AddWithValue("@idEspeceEnnemi", Convert.ToInt32(cboEspeceEnnemi.SelectedValue));
                cmd.Parameters.AddWithValue("@objectif", Convert.ToInt32(txtNbCapture.Text));

                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            MesDatas.DsGlobal.Tables.Remove("Capturer");

            string sqlSelectDep = "SELECT * FROM Capturer";
            SQLiteDataAdapter daDep = new SQLiteDataAdapter(sqlSelectDep, Connexion.Connec);
            daDep.Fill(MesDatas.DsGlobal, "Capturer");

            cboEspeceEnnemi.SelectedIndex = 0;
            txtNbCapture.Text = "";
        }

        private void btnAjouterEvent_Click(object sender, EventArgs e)
        {
            if (dtpEvent.Value == null || txtCommentaireEvent.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

            try
            {
                string sql = "INSERT INTO JournalDeBord VALUES (@nomPlanete, @numeroMission, @dateJ, @commentaires)";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", numero);
                cmd.Parameters.AddWithValue("@dateJ", dtpEvent.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@commentaires", txtCommentaireEvent.Text);

                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            MesDatas.DsGlobal.Tables.Remove("JournalDeBord");

            string sqlSelectJournal = "SELECT * FROM JournalDeBord";
            SQLiteDataAdapter daDep = new SQLiteDataAdapter(sqlSelectJournal, Connexion.Connec);
            daDep.Fill(MesDatas.DsGlobal, "JournalDeBord");

            dtpEvent.Value = DateTime.Today;
            txtCommentaireEvent.Text = "";
        }

        private void txtSommeContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMontantDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNbCapture_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnFermerMission_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAjouterDataBaz_Click(object sender, EventArgs e)
        {
            if (cboAllie.ValueMember == null || txtQteDataBaz.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

            try
            {
                string sql = "INSERT INTO Negocier VALUES (@nomPlanete, @numeroMission, @idEspeceAllie, @qteDataBaz)";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", numero);
                cmd.Parameters.AddWithValue("@idEspeceAllie", Convert.ToInt32(cboAllie.SelectedValue));
                cmd.Parameters.AddWithValue("@qteDataBaz", Convert.ToInt32(txtQteDataBaz.Text));

                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            MesDatas.DsGlobal.Tables.Remove("Negocier");

            string sqlSelectNego = "SELECT * FROM Negocier";
            SQLiteDataAdapter daDep = new SQLiteDataAdapter(sqlSelectNego, Connexion.Connec);
            daDep.Fill(MesDatas.DsGlobal, "Negocier");

            txtQteDataBaz.Text = "";
            cboAllie.SelectedIndex = 0;
        }

        private void txtQteDataBaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void dtpDateDep_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateDep.Value < dateAllerDtp || dtpDateDep.Value > dateRetourDtp)
            {
                MessageBox.Show("Choisissez une date entre le début et la fin de la mission !");
                return;
            }
        }

        private void dtpEvent_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEvent.Value < dateAllerDtp || dtpEvent.Value > dateRetourDtp)
            {
                MessageBox.Show("Choisissez une date entre le début et la fin de la mission !");
                return;
            }
        }

        private void dtpContact_ValueChanged(object sender, EventArgs e)
        {
            if (dtpContact.Value < dateAllerDtp || dtpContact.Value > dateRetourDtp)
            {
                MessageBox.Show("Choisissez une date entre le début et la fin de la mission !");
                return;
            }
        }
    }
}
