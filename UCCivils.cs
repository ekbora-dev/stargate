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
    public partial class UCCivils : UserControl
    {
        public UCCivils(string nomComplet, string specialite, string nomPlaneteOrigine)
        {
            InitializeComponent();

            lblNomComplet.Text = nomComplet;
            lblPlaneteOrigine.Text = "Originaire de : " + nomPlaneteOrigine;
            lblSpecialite.Text = specialite;

            imgCivil.Size = new Size(110, 100);

            if (specialite == "Astronome")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Astronome.jpg");
            }
            else if (specialite == "Médecin")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Médecin.jpg");
            }
            else if (specialite == "Pilote")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Pilote.jpg");
            }
            else if (specialite == "Cuisinier")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Cuisinier.jpg");
            }
            else if (specialite == "Mécanicien")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Mécanicien.jpg");
            }
            else if (specialite == "Biologiste")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Biologiste.jpg");
            }
            else if (specialite == "Infirmier")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Infirmier.jpg");
            }
            else if (specialite == "Géologue")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Géologue.jpg");
            }
            else if (specialite == "Volcanologue")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Volcanologue.jpg");
            }
            else if (specialite == "Négociateur")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Négociateur.jpg");
            }
            else if (specialite == "Logisticien")
            {
                imgCivil.Image = Image.FromFile("./imagesCivils/Logisticien.jpg");
            }
        }
    }
}
