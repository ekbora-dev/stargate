using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace SAE24
{
    public partial class frmAccueil : Form
    {

        public frmAccueil()
        {
            InitializeComponent();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            string sql;
            SQLiteDataAdapter da;
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");

            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();
                sql = "SELECT * FROM " + nomTable;

                da = new SQLiteDataAdapter(sql, Connexion.Connec);
                da.Fill(MesDatas.DsGlobal, nomTable);
            }

            sql = "SELECT DISTINCT couleur FROM Espece ORDER BY 1";

            da = new SQLiteDataAdapter(sql, Connexion.Connec);
            da.Fill(MesDatas.DsGlobal, "Couleurs");

            lblMission.Text = "Toutes les missions";
            DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

            for (int i = 0; i < mission.Rows.Count; i++)
            {
                DataRow[] reqChef = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{mission.Rows[i]["matriculeChef"]}'");
                UCAffichageMission UCmission = new UCAffichageMission(mission.Rows[i]["nomPlanete"].ToString(), mission.Rows[i]["numero"].ToString(), mission.Rows[i]["dateDepart"].ToString(), mission.Rows[i]["dateRetour"].ToString(), reqChef[0]["matricule"].ToString(), mission.Rows[i]["budget"].ToString());
                flpMissions.Controls.Add(UCmission);
            }
        }

        private void btnNewMission_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            frmPageConnexion page = new frmPageConnexion();
            DialogResult dr = page.ShowDialog();
        }

        private void btnRaces_Click(object sender, EventArgs e)
        {
            frmRaceRepertorie race = new frmRaceRepertorie();
            DialogResult dr = race.ShowDialog();
        }

        private void btnInfosPlanetes_Click(object sender, EventArgs e)
        {
            frmPlanetes frmPlanete = new frmPlanetes();
            DialogResult dr = frmPlanete.ShowDialog();
        }

        private void cboFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMissions.Controls.Clear();

            if (cboFiltre.SelectedItem.ToString() == "En cours")
            {
                lblMission.Text = "Mission en cours";
                DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

                for (int i = 0; i < mission.Rows.Count; i++)
                {
                    DateTime aujourdhui = DateTime.Today;
                    DateTime debutMission = DateTime.Parse(mission.Rows[i]["dateDepart"].ToString());
                    DateTime finMission = DateTime.Parse(mission.Rows[i]["dateRetour"].ToString());

                    if (aujourdhui > debutMission && aujourdhui < finMission || aujourdhui == debutMission && aujourdhui < finMission || aujourdhui > debutMission && aujourdhui == finMission)
                    {
                        DataRow[] reqChef = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{mission.Rows[i]["matriculeChef"]}'");
                        UCAffichageMission UCmission = new UCAffichageMission(mission.Rows[i]["nomPlanete"].ToString(), mission.Rows[i]["numero"].ToString(), mission.Rows[i]["dateDepart"].ToString(), mission.Rows[i]["dateRetour"].ToString(), reqChef[0]["matricule"].ToString(), mission.Rows[i]["budget"].ToString());
                        flpMissions.Controls.Add(UCmission);
                    }
                }
            }

            if (cboFiltre.SelectedItem.ToString() == "Passée")
            {
                lblMission.Text = "Mission passés";
                DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

                for (int i = 0; i < mission.Rows.Count; i++)
                {
                    DateTime aujourdhui = DateTime.Today;
                    DateTime finMission = DateTime.Parse(mission.Rows[i]["dateRetour"].ToString());

                    if (aujourdhui > finMission)
                    {
                        DataRow[] reqChef = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{mission.Rows[i]["matriculeChef"]}'");
                        UCAffichageMission UCmission = new UCAffichageMission(mission.Rows[i]["nomPlanete"].ToString(), mission.Rows[i]["numero"].ToString(), mission.Rows[i]["dateDepart"].ToString(), mission.Rows[i]["dateRetour"].ToString(), reqChef[0]["matricule"].ToString(), mission.Rows[i]["budget"].ToString());
                        flpMissions.Controls.Add(UCmission);
                    }
                }
            }

            if (cboFiltre.SelectedItem.ToString() == "A venir")
            {
                lblMission.Text = "Mission à venir";
                DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

                for (int i = 0; i < mission.Rows.Count; i++)
                {
                    DateTime aujourdhui = DateTime.Today;
                    DateTime debutMission = DateTime.Parse(mission.Rows[i]["dateDepart"].ToString());
                    DateTime finMission = DateTime.Parse(mission.Rows[i]["dateRetour"].ToString());

                    if (aujourdhui < debutMission)
                    {
                        DataRow[] reqChef = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{mission.Rows[i]["matriculeChef"]}'");
                        UCAffichageMission UCmission = new UCAffichageMission(mission.Rows[i]["nomPlanete"].ToString(), mission.Rows[i]["numero"].ToString(), mission.Rows[i]["dateDepart"].ToString(), mission.Rows[i]["dateRetour"].ToString(), reqChef[0]["matricule"].ToString(), mission.Rows[i]["budget"].ToString());
                        flpMissions.Controls.Add(UCmission);
                    }
                }
            }
        }

        private void btnFermerAppli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats formStats = new frmStats();
            formStats.Show();
        }
    }
}
