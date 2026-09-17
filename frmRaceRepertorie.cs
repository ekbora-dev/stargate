using System;
using System.Data;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmRaceRepertorie : Form
    {
        public frmRaceRepertorie()
        {
            InitializeComponent();
        }

        private void frmRaceRepertorie_Load(object sender, EventArgs e)
        {
            // Charger la comboBox
            DataTable dt = MesDatas.DsGlobal.Tables["Couleurs"];


            cboCouleur.DataSource = dt;
            cboCouleur.DisplayMember = "couleur";
            cboCouleur.ValueMember = "couleur";

            DataTable especes = MesDatas.DsGlobal.Tables["Espece"];

            for (int i = 0; i < especes.Rows.Count; i++)
            {
                string planetes = trouverPlaneteEspece(especes.Rows[i]["id"].ToString());


                UCRaceRepertorie EspeceCard = new UCRaceRepertorie(especes.Rows[i]["nom"].ToString(), especes.Rows[i]["couleur"].ToString(), planetes, Convert.ToInt32(especes.Rows[i]["id"]));
                flpEspece.Controls.Add(EspeceCard);
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire
            this.DialogResult = DialogResult.OK;
        }

        private string trouverPlaneteEspece(string idEspece)
        {
            DataTable habiter = MesDatas.DsGlobal.Tables["Habiter"];
            string planetes = "";

            string filtre = "idEspece = " + idEspece;

            DataRow[] dr = habiter.Select(filtre);

            for (int j = 0; j < dr.Length; j++)
            {
                planetes += dr[j]["nomPlanete"].ToString() + "/";
            }

            if (planetes == "")
            {
                planetes = "Origine inconnu";
            }


            return planetes.TrimEnd('/');
        }

        private void rdbEnnemi_CheckedChanged(object sender, EventArgs e)
        {
            flpEspece.Controls.Clear();
            DataTable espece = MesDatas.DsGlobal.Tables["Espece"];
            DataTable ennemi = MesDatas.DsGlobal.Tables["Ennemi"];

            for (int i = 0; i < ennemi.Rows.Count; i++)
            {
                int idEnnemi = Convert.ToInt32(ennemi.Rows[i]["idEspece"]);

                string filtre = "id = " + idEnnemi;

                DataRow[] dr = espece.Select(filtre);

                string planetes = trouverPlaneteEspece(dr[0]["id"].ToString());

                UCEspeceEnnemi EnnemiCard = new UCEspeceEnnemi(dr[0]["nom"].ToString(), dr[0]["couleur"].ToString(), ennemi.Rows[i]["degreAgressivite"].ToString(), ennemi.Rows[i]["typeArme"].ToString(), planetes, idEnnemi);
                flpEspece.Controls.Add(EnnemiCard);
            }
        }

        private void rdbAllie_CheckedChanged(object sender, EventArgs e)
        {
            flpEspece.Controls.Clear();
            DataTable espece = MesDatas.DsGlobal.Tables["Espece"];
            DataTable allie = MesDatas.DsGlobal.Tables["Allie"];

            for (int i = 0; i < allie.Rows.Count; i++)
            {
                int idAllie = Convert.ToInt32(allie.Rows[i]["idEspece"]);

                string filtre = "id = " + idAllie;

                DataRow[] dr = espece.Select(filtre);

                string planetes = trouverPlaneteEspece(dr[0]["id"].ToString());

                UCEspeceAllie AllieCard = new UCEspeceAllie(dr[0]["nom"].ToString(), dr[0]["couleur"].ToString(), allie.Rows[i]["degreBienveillance"].ToString(), allie.Rows[i]["instrumentMusique"].ToString(), planetes, idAllie);
                flpEspece.Controls.Add(AllieCard);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            flpEspece.Controls.Clear();
            DataTable especes = MesDatas.DsGlobal.Tables["Espece"];

            for (int i = 0; i < especes.Rows.Count; i++)
            {
                string planetes = trouverPlaneteEspece(especes.Rows[i]["id"].ToString());

                if (especes.Rows[i]["nom"].ToString().Contains(txtNomEspece.Text) && cboCouleur.Text == especes.Rows[i]["couleur"].ToString())
                {
                    UCRaceRepertorie card = new UCRaceRepertorie(especes.Rows[i]["nom"].ToString(), especes.Rows[i]["couleur"].ToString(), planetes, Convert.ToInt32(especes.Rows[i]["id"]));
                    flpEspece.Controls.Add(card);
                }

                /*
                Console.WriteLine(cboCouleur.SelectedItem.ToString() + "--" + especes.Rows[i]["couleur"].ToString());
                if (cboCouleur.Text == especes.Rows[i]["couleur"].ToString())
                {
                    UCRaceRepertorie card = new UCRaceRepertorie(especes.Rows[i]["nom"].ToString(), especes.Rows[i]["couleur"].ToString(), planetes);
                    flpEspece.Controls.Add(card);
                }
                */
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            rdbAllie.Checked = false;
            rdbEnnemi.Checked = false;
            flpEspece.Controls.Clear();
            DataTable especes = MesDatas.DsGlobal.Tables["Espece"];

            for (int i = 0; i < especes.Rows.Count; i++)
            {
                string planetes = trouverPlaneteEspece(especes.Rows[i]["id"].ToString());
                UCRaceRepertorie EspeceCard = new UCRaceRepertorie(especes.Rows[i]["nom"].ToString(), especes.Rows[i]["couleur"].ToString(), planetes, Convert.ToInt32(especes.Rows[i]["id"]));
                flpEspece.Controls.Add(EspeceCard);
            }
        }
    }
}

