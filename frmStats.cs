using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            //Remplit cboMembre
            string sql = @"SELECT matricule, nom || '-' || prenom || '-' || grade || '-' || 'Militaire' As nomComplet
                            FROM Militaire
                            JOIN Membre ON matricule = matriculeMembre
                            UNION
                            SELECT matricule, nom || '-' || prenom || '-' || Specialite || '-' || 'Civil' As nomComplet
                            FROM Civil
                            JOIN Membre ON matricule = matriculeMembre
                            ORDER BY 1,2";
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cboMembre.DataSource = dt;
            cboMembre.DisplayMember = "nomComplet";
            cboMembre.ValueMember = "matricule";

            //Remplit cboEquipage
            string sql2 = "SELECT nomPlanete || '-' || numero AS nomMission, budget FROM Mission WHERE nbMembreRequis > 10";
            SQLiteCommand cmd2 = new SQLiteCommand(sql2, Connexion.Connec);
            DataTable dt2 = new DataTable();
            dt2.Load(cmd2.ExecuteReader());
            cboEquipage.DataSource = dt2;
            cboEquipage.DisplayMember = "nomMission";
            cboEquipage.ValueMember = "budget";

            string sqlPlanete = "SELECT nomPlanete || '-' || numeroMission as numPlanete FROM Composer GROUP BY nomPlanete, numeroMission HAVING COUNT(*) > 2";
            SQLiteCommand cmdPlanete = new SQLiteCommand(sqlPlanete, Connexion.Connec);
            DataTable dtPlanete = new DataTable();
            dtPlanete.TableName = "dtPlanete";
            dtPlanete.Load(cmdPlanete.ExecuteReader());
            if (MesDatas.DsGlobal.Tables.Contains("dtPlanete"))
            {
                MesDatas.DsGlobal.Tables.Remove(dtPlanete);
            }
            MesDatas.DsGlobal.Tables.Add(dtPlanete);

            string sqlDepense = "SELECT nomPlanete || '-' || numeroMission as numPlanete, montant, motif FROM Depense";
            SQLiteCommand cmdDepense = new SQLiteCommand(sqlDepense, Connexion.Connec);
            DataTable dtDepense = new DataTable();
            dtDepense.TableName = "dtDepense";
            dtDepense.Load(cmdDepense.ExecuteReader());
            if (MesDatas.DsGlobal.Tables.Contains("dtDepense"))
            {

                MesDatas.DsGlobal.Tables.Remove(dtDepense);
            }
            MesDatas.DsGlobal.Tables.Add(dtDepense);
            if (MesDatas.DsGlobal.Relations.Contains("relPlaneteDepense"))
            {
                MesDatas.DsGlobal.Relations.Remove("relPlaneteDepense");
            }
            DataRelation dr = new DataRelation("relPlaneteDepense",
                MesDatas.DsGlobal.Tables["dtPlanete"].Columns["numPlanete"],
                MesDatas.DsGlobal.Tables["dtDepense"].Columns["numPlanete"],
                false);
            MesDatas.DsGlobal.Relations.Add(dr);
            BindingSource bsPlanete = new BindingSource();
            bsPlanete.DataSource = dtPlanete;
            cboEquipage.DataSource = bsPlanete;
            cboEquipage.DisplayMember = "numPlanete";
            BindingSource bsDepense = new BindingSource();
            bsDepense.DataMember = "relPlaneteDepense";
            bsDepense.DataSource = bsPlanete;
            dgvEquipage.DataSource = bsDepense;

            string nmPlanete = nomplanete(((DataRowView)cboEquipage.SelectedItem)["numPlanete"].ToString());
            int numPlanete = numeroplanete(((DataRowView)cboEquipage.SelectedItem)["numPlanete"].ToString());
            string filtreplan = $"nomPlanete = '{nmPlanete}' AND numeroMission = {numPlanete}";
            DataRow[] tabLignees = MesDatas.DsGlobal.Tables["Depense"].Select(filtreplan);
            if (tabLignees.Length > 0)
            {
                DataTable Infos = new DataTable();
                Infos.TableName = "Infos";
                DataColumn motif = new DataColumn("motif", typeof(string));
                Infos.Columns.Add(motif);

                DataColumn montant = new DataColumn("montant", typeof(int));
                Infos.Columns.Add(montant);
                string filtremiss = $"nomPlanete = '{nmPlanete}' AND numero = {numPlanete}";
                DataRow[] miss = MesDatas.DsGlobal.Tables["Mission"].Select(filtremiss);
                int totalSomme = Convert.ToInt32(miss[0]["budget"]);
                for (int m = 0; m < tabLignees.Length; m++)
                {
                    DataRow ligne;
                    ligne = Infos.NewRow();
                    ligne[0] = (tabLignees[m]["motif"]).ToString();
                    ligne[1] = Convert.ToInt32((tabLignees[m]["montant"]));
                    Infos.Rows.Add(ligne);

                    totalSomme -= Convert.ToInt32((tabLignees[m]["montant"]));
                }
                dgvEquipage.DataSource = Infos;
                lblBudgetInitial.Text += (miss[0]["budget"]).ToString();
                lblBudgetActuel.Text += (totalSomme).ToString();
            }


            //Remplit dgvPlanete
            DataTable planete = MesDatas.DsGlobal.Tables["Planete"];
            DataTable Info = new DataTable();
            Info.TableName = "Info";

            DataColumn planeteNom = new DataColumn("planeteNom", typeof(string));
            Info.Columns.Add(planeteNom);

            DataColumn numero = new DataColumn("numero", typeof(int));
            Info.Columns.Add(numero);
            for (int m = 0; m < planete.Rows.Count; m++)
            {
                string filtre = $"nomPlanete = '{(planete.Rows[m]["nom"]).ToString()}'";
                DataRow[] tabLignes = MesDatas.DsGlobal.Tables["Mission"].Select(filtre);

                DataRow ligne;
                ligne = Info.NewRow();
                ligne[0] = (planete.Rows[m]["nom"]).ToString();
                ligne[1] = tabLignes.Length;
                Info.Rows.Add(ligne);
            }
            dgvPlanete.DataSource = Info;


            //Remplit dgvMission
            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];
            DataTable MissionDepense = new DataTable();
            MissionDepense.TableName = "MissionDepense";
            DataColumn nomChef = new DataColumn("nomChef", typeof(string));
            MissionDepense.Columns.Add(nomChef);
            DataColumn prenomChef = new DataColumn("prenomChef", typeof(string));
            MissionDepense.Columns.Add(prenomChef);
            DataColumn dateMontantMotif = new DataColumn("Dépenses les plus importantes", typeof(string));
            MissionDepense.Columns.Add(dateMontantMotif);

            for (int k = 0; k < missionTable.Rows.Count; k++)
            {
                string filtre = $"nomPlanete = '{missionTable.Rows[k]["nomPlanete"]}' AND numeroMission = {missionTable.Rows[k]["numero"]}";
                DataRow[] tabLigne = MesDatas.DsGlobal.Tables["Depense"].Select(filtre);
                if (tabLigne.Length > 0)
                {
                    int indexMaxMontant = 0;
                    int montantMax = Convert.ToInt32(tabLigne[0]["montant"]);
                    for (int i = 1; i < tabLigne.Length; i++)
                    {
                        if (Convert.ToInt32(tabLigne[i]["montant"]) > montantMax)
                        {
                            montantMax = Convert.ToInt32(tabLigne[i]["montant"]);
                            indexMaxMontant = i;
                        }
                    }
                    string dateDepense = tabLigne[indexMaxMontant]["dateD"].ToString();
                    string montantDepense = tabLigne[indexMaxMontant]["montant"].ToString();
                    string motifDepense = tabLigne[indexMaxMontant]["motif"].ToString();

                    string filtreBlaze = $"matricule = '{missionTable.Rows[k]["matriculeChef"]}'";
                    DataRow[] Blaze = MesDatas.DsGlobal.Tables["Membre"].Select(filtreBlaze);
                    string nom = Blaze[0]["nom"].ToString();
                    string prenom = Blaze[0]["prenom"].ToString();

                    DataRow ligne;
                    ligne = MissionDepense.NewRow();
                    ligne[0] = prenom;
                    ligne[1] = nom;
                    ligne[2] = $"{dateDepense} - {montantDepense} - {motifDepense}";
                    MissionDepense.Rows.Add(ligne);
                }
            }

            dgvMission.DataSource = MissionDepense;


            //Remplit dgvInformateur
            DataTable InformateurTable = new DataTable();
            InformateurTable.TableName = "InformateurTable";
            DataColumn nomCode = new DataColumn("nom de code", typeof(string));
            InformateurTable.Columns.Add(nomCode);
            DataColumn especeOrigine = new DataColumn("espèce d'origine", typeof(string));
            InformateurTable.Columns.Add(especeOrigine);
            DataColumn sommePercue = new DataColumn("somme totale versée", typeof(int));
            InformateurTable.Columns.Add(sommePercue);
            for (int v = 0; v < missionTable.Rows.Count; v++)
            {
                string filtre = $"nomPlanete = '{missionTable.Rows[v]["nomPlanete"]}' AND numeroMission = {missionTable.Rows[v]["numero"]}";
                DataRow[] contactTab = MesDatas.DsGlobal.Tables["Contact"].Select(filtre);

                int indexMinMontant = 0;
                if (contactTab.Length > 0)
                {
                    int montantMin = Convert.ToInt32(contactTab[0]["sommeVersee"]);
                    for (int i = 1; i < contactTab.Length; i++)
                    {
                        if (Convert.ToInt32(contactTab[i]["sommeVersee"]) < montantMin)
                        {
                            montantMin = Convert.ToInt32(contactTab[i]["sommeVersee"]);
                            indexMinMontant = i;
                        }
                    }

                    string filtreCode = $"nomCode = '{contactTab[indexMinMontant]["nomCodeInformateur"]}'";
                    DataRow[] InfoTab = MesDatas.DsGlobal.Tables["Informateur"].Select(filtreCode);
                    string filtreNomEspece = $"id = {InfoTab[0]["idEspeceEnnemi"]}";
                    DataRow[] NomEspece = MesDatas.DsGlobal.Tables["Espece"].Select(filtreNomEspece);

                    DataRow ligne;
                    ligne = InformateurTable.NewRow();
                    ligne[0] = (contactTab[indexMinMontant]["nomCodeInformateur"]).ToString();
                    ligne[1] = (NomEspece[0]["nom"]).ToString();
                    ligne[2] = Convert.ToInt32(contactTab[indexMinMontant]["sommeVersee"]);
                    InformateurTable.Rows.Add(ligne);
                }


            }
            dgvInformateur.DataSource = InformateurTable;



        }

        private void cboMembre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                flpMembre.Controls.Clear();

                string filtre = $"matriculeMembre = '{cboMembre.SelectedValue}'";
                DataRow[] tabLignes = MesDatas.DsGlobal.Tables["Composer"].Select(filtre);
                if (tabLignes.Length > 0)
                {
                    for (int i = 0; i < tabLignes.Length; i++)
                    {
                        string nomPlanete = tabLignes[i]["nomPlanete"].ToString();
                        string numeroMission = tabLignes[i]["numeroMission"].ToString();
                        string filtreMission = $"nomPlanete = '{nomPlanete}' AND numeroMission = '{numeroMission}'";

                        DataRow[] member = MesDatas.DsGlobal.Tables["Composer"].Select(filtreMission);

                        for (int j = 0; j < member.Length; j++)
                        {

                            string filtreMembre = $"matricule = '{member[j]["matriculeMembre"]}'";
                            DataRow[] nomComplet = MesDatas.DsGlobal.Tables["Membre"].Select(filtreMembre);
                            string prenom = nomComplet[0]["prenom"].ToString();
                            string nom = nomComplet[0]["nom"].ToString();

                            //Il faut afficher l'uc membre
                            string nomComplete = prenom + "\n" + nom;
                            UCMembre user = new UCMembre((member[j]["matriculeMembre"]).ToString(), nomComplete);

                            flpMembre.Controls.Add(user);
                        }


                    }

                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur : " + err.Message);
            }
        }

        private void cboEquipage_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                lblBudgetInitial.Text = "Budget Initial : ";
                lblBudgetActuel.Text = "Budget Actuel : ";
                string nmPlanete = nomplanete(((DataRowView)cboEquipage.SelectedItem)["numPlanete"].ToString());
                int numPlanete = numeroplanete(((DataRowView)cboEquipage.SelectedItem)["numPlanete"].ToString());
                string filtre = $"nomPlanete = '{nmPlanete}' AND numeroMission = {numPlanete}";
                DataRow[] tabLignes = MesDatas.DsGlobal.Tables["Depense"].Select(filtre);
                if (tabLignes.Length > 0)
                {
                    DataTable Info = new DataTable();
                    Info.TableName = "Info";
                    DataColumn motif = new DataColumn("motif", typeof(string));
                    Info.Columns.Add(motif);

                    DataColumn montant = new DataColumn("montant", typeof(int));
                    Info.Columns.Add(montant);
                    string filtremiss = $"nomPlanete = '{nmPlanete}' AND numero = {numPlanete}";
                    DataRow[] miss = MesDatas.DsGlobal.Tables["Mission"].Select(filtremiss);
                    int totalSomme = Convert.ToInt32(miss[0]["budget"]);
                    for (int m = 0; m < tabLignes.Length; m++)
                    {
                        DataRow ligne;
                        ligne = Info.NewRow();
                        ligne[0] = (tabLignes[m]["motif"]).ToString();
                        ligne[1] = Convert.ToInt32((tabLignes[m]["montant"]));
                        Info.Rows.Add(ligne);

                        totalSomme -= Convert.ToInt32((tabLignes[m]["montant"]));
                    }
                    dgvEquipage.DataSource = Info;
                    lblBudgetInitial.Text += (miss[0]["budget"]).ToString();
                    lblBudgetActuel.Text += (totalSomme).ToString();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur : " + err.Message);
            }


        }

        private int numeroplanete(string elem)
        {
            char[] separateur = new char[] { '-' };
            string[] ligne;
            ligne = elem.Split(separateur);
            return Convert.ToInt32(ligne[1]);
        }

        private string nomplanete(string elem)
        {
            char[] separateur = new char[] { '-' };
            string[] ligne;
            ligne = elem.Split(separateur);
            return ligne[0];
        }
    }
}
