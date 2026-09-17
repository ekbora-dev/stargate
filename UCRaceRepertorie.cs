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
    public partial class UCRaceRepertorie : UserControl
    {
        public UCRaceRepertorie(string nom, string couleur, string planetes, int idEspece)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblCouleur.Text = couleur;
            lblPlanete.Text = planetes;

            imgEspece.Size = new Size(100, 80);
            imgEspece.Image = Image.FromFile($"./imageEspeces/{idEspece}.jpg");
        }
    }
}
