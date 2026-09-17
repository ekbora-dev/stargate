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
    public partial class UCEspeceAllie : UserControl
    {
        public UCEspeceAllie(string nom,string couleur, string bienveillance, string instrument, string planetes, int idAllie)
        {
            InitializeComponent();
            lblNom.Text = nom + " - " + couleur;
            lblBienveillance.Text = "Bienveillance : " + bienveillance;
            lblPlanete.Text = planetes;
            lblInstru.Text = "Instrument : " + instrument;

            imgAllie.Size = new Size(100, 80);
            imgAllie .Image = Image.FromFile($"./imageEspeces/{idAllie}.jpg");
        }
    }
}
