using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class UCPlanete: UserControl
    {
        public UCPlanete(string nom, string temperature, string gravite, string dataBazON)
        {
            InitializeComponent();

            foreach(Control c in grpPlanete.Controls)
            {
                c.Click += UCPlanete_Click;
            }

           

            //info de la carte

            lblNomPlanete.Text = nom;
            lblTemperature.Text = temperature + "°C";
            lblGravité.Text = "Gravité : "  + gravite;
            if (string.IsNullOrWhiteSpace(temperature))
            {
                lblDatabaz.Text = "Aucune données sur les dataBaz";
            }
            else if (int.TryParse(dataBazON, out int presence)){

                if (presence > 0)
                {
                    lblDatabaz.Text = "Présence de DataBaz";
                }
                else
                {
                    lblDatabaz.Text = "Aucune DataBaz présente";
                }
            }
            
            

            //img planètes

            if (lblNomPlanete.Text != string.Empty)
            {
                imgPlanete.Size = new Size(140, 140);
                imgPlanete.Image = Image.FromFile($"./imagePlanete/{lblNomPlanete.Text}.jpg");
                
            }

            //img tmpérature

            imgTemperature.Size = new Size(40, 40);

            if (string.IsNullOrWhiteSpace(temperature))
            {
                imgTemperature.Image = Image.FromFile("./imageTemperature/Inconnue.jpg");
            }
            else if (int.TryParse(temperature, out int temp))
            {
                if (temp > 50)
                {
                    imgTemperature.Image = Image.FromFile("./imageTemperature/Chaude.jpg");
                }
                else if (temp > 30 && temp <= 50)
                {
                    imgTemperature.Image = Image.FromFile("./imageTemperature/Moyenne.jpg");
                }
                else if (temp >= 0 && temp <= 30)
                {
                    imgTemperature.Image = Image.FromFile("./imageTemperature/Normal.jpg");
                }
                else
                {
                    imgTemperature.Image = Image.FromFile("./imageTemperature/Froide.jpg");
                }
            }
        }

        private void UCPlanete_Click(object sender, EventArgs e)
        {
            frmDetailPlanete pageDetailPlanete = new frmDetailPlanete(lblNomPlanete.Text, lblTemperature.Text, lblGravité.Text, lblDatabaz.Text);
            DialogResult dr = pageDetailPlanete.ShowDialog();
        }
    }
}
