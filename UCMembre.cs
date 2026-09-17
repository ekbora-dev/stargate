using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SAE24
{
    public partial class UCMembre : UserControl
    {
        public UCMembre(string matricule, string nomComplet)
        {
            InitializeComponent();
            lblNomComplet.Text = nomComplet;

            DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

            DataTable militaire = MesDatas.DsGlobal.Tables["Militaire"];
            DataTable civil = MesDatas.DsGlobal.Tables["Civil"];

            DataRow[] estMilitaire = militaire.Select($"matriculeMembre = '{matricule}'");

            if (estMilitaire.Length > 0)
            {
                pboImage.ImageLocation = "images/militaire.jpg";
            }
            else
            {
                pboImage.ImageLocation = "images/civil.jpg";
            }
        }

        public UCMembre(string matricule, string nomComplet, bool estChef)
        {
            InitializeComponent();
            lblNomComplet.Text = nomComplet;

            DataTable mission = MesDatas.DsGlobal.Tables["Mission"];

            DataTable militaire = MesDatas.DsGlobal.Tables["Militaire"];
            DataTable civil = MesDatas.DsGlobal.Tables["Civil"];


            if (estChef)
            {
                lblNomComplet.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }

            DataRow[] estMilitaire = militaire.Select($"matriculeMembre = '{matricule}'");

            if (estMilitaire.Length > 0)
            {
                pboImage.ImageLocation = "images/militaire.jpg";
            }
            else
            {
                pboImage.ImageLocation = "images/civil.jpg";
            }
        }
    }
}
