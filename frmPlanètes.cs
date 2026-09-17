using System;
using System.Data;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmPlanetes : Form
    {
        public frmPlanetes()
        {
            InitializeComponent();
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Chargement des planètes

        private void frmPlanètes_Load(object sender, EventArgs e)
        {
            Filtre();
        }

        //Filtre
        private void Filtre()
        {
            flpPlanete.Controls.Clear();
            DataTable planete = MesDatas.DsGlobal.Tables["Planete"];

            string filtre = "1=1";

            // Filtre nom planete
            if (!string.IsNullOrEmpty(txtTrouver.Text))
            {
                filtre += " AND nom LIKE '" + txtTrouver.Text.Replace("'", "''") + "%'";
            }

            // Filtres température
            if (rdbTempInconnue.Checked)
            {
                filtre += " AND temperature IS NULL";
            }
            else if (rdbFroide.Checked)
            {
                filtre += " AND temperature < 0";
            }
            else if (rdbNormal.Checked)
            {
                filtre += " AND temperature >= 0 AND temperature <= 30";
            }
            else if (rdbMoyenne.Checked)
            {
                filtre += " AND temperature > 30 AND temperature <= 50";
            }
            else if (rdbChaude.Checked)
            {
                filtre += " AND temperature > 50";
            }

            // Filtres dataBaz

            if (rdbDbInconnue.Checked)
            {
                filtre += " AND dataBazON IS NULL";
            }
            else if (rdbOn.Checked)
            {
                filtre += " AND dataBazON > 0";
            }
            else if (rdbOff.Checked)
            {
                filtre += " AND dataBazON <= 0";
            }

            DataRow[] drows = planete.Select(filtre);

            //Afficher la carte de la planète avec les filtres choisi
            foreach (DataRow drow in drows)
            {
                UCPlanete planeteCard = new UCPlanete(drow["nom"].ToString(), drow["temperature"].ToString(), drow["gravite"].ToString(), drow["dataBazOn"].ToString());
                flpPlanete.Controls.Add(planeteCard);
            }
        }

        //Recherche
        private void btnTrouver_Click(object sender, EventArgs e)
        {
            Filtre();
        }

        private void txtTrouver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Filtre();
            }
        }

        private void txtTrouver_TextChanged(object sender, EventArgs e)
        {
            if (txtTrouver.Text.Length > 0)
            {
                txtTrouver.Text = char.ToUpper(txtTrouver.Text[0]) + txtTrouver.Text.Substring(1).ToLower();

                // Replace le curseur à la fin du texte
                txtTrouver.SelectionStart = txtTrouver.Text.Length;
            }
        }
        private void btnReinitialiserRecherche_Click(object sender, EventArgs e)
        {
            rdbTempInconnue.Checked = false;
            rdbFroide.Checked = false;
            rdbNormal.Checked = false;
            rdbMoyenne.Checked = false;
            rdbChaude.Checked = false;
            rdbDbInconnue.Checked = false;
            rdbOn.Checked = false;
            rdbOff.Checked = false;
            txtTrouver.Text = "";

            Filtre();
        }

        //rdb par température

        private void rdbTempInconnue_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbFroide_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbMoyenne_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbChaude_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        //rdb nb databaz choisi
        private void rdbOff_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbOn_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void rdbDbInconnue_CheckedChanged(object sender, EventArgs e)
        {
            Filtre();
        }
    }
}
