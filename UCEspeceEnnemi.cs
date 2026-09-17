using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class UCEspeceEnnemi : UserControl
    {
        public UCEspeceEnnemi(string nom, string couleur, string degreAgressivite, string typeArme, string planetes, int idEnnemi)
        {
            InitializeComponent();
            lblNom.Text = nom + " - " + couleur;
            lblDegreAgressivite.Text = "Agressivité : " + degreAgressivite;
            lblTypeArme.Text = "Arme : " + typeArme;
            lblPlanetes.Text = planetes;

            imgEnnemi .Size = new Size(100, 80);
            imgEnnemi .Image = Image.FromFile($"./imageEspeces/{idEnnemi}.jpg");
        }
    }
}
