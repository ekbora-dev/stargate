using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmDetailPlanete : Form
    {
        private string nomPlanete;
        private string temperature;
        private string gravite;
        private string dataBaz;

        public frmDetailPlanete(string nom, string temp, string gravit, string dataBaz)
        {
            InitializeComponent();
            this.nomPlanete = nom;
            this.temperature = temp;
            this.gravite = gravit;
            this.dataBaz = dataBaz;
        }

        struct detailPlanete
        {
            public string pesanteur;
            public string atmosphere;

            public detailPlanete(string pes, string atm)
            {
                pesanteur = pes;
                atmosphere = atm;
            }
        }

        private void frmDetailPlanete_Load(object sender, EventArgs e)
        {

            lblTitre.Text = "Bienvenue sur " + this.nomPlanete + " :";

            //Partie planète choisi

            Dictionary<string, detailPlanete> dico = new Dictionary<string, detailPlanete>();
            string[] tab = { "Mercure", "Vénus", "Terre", "Mars", "Jupiter", "Saturne", "Uranus", "Neptune", "La 9ème planète", "Kobaia", "Setna", "Malaria", "Aurae", "Aina", "Sckxyss", "Sohia", "Muh" };
            string[] tabPes = { "3,7 N/kg", "8,87 N/kg", "9,81 N/kg", "3,71 N/kg", "24,79 N/kg", "10,44 N/kg", "8,69 N/kg", "11,15 N/kg", "Inconnu", "5,2 N/kg", "12,4 N/kg", "18,7 N/kg", "2,9 N/kg", "14,1 N/kg", "7,6 N/kg", "21,3 N/kg", "9,4 N/kg" };
            string[] tabatm = { "Très faible (oxygène, sodium, hydrogène)", "Dioxyde de carbone et azote", "Azote et oxygène", "Dioxyde de carbone", "Hydrogène et hélium", "Hydrogène et hélium", "Hydrogène, hélium et méthane", "Hydrogène, hélium et méthane", "Inconnu", "Azote et oxygène", "Méthane et hydrogène", "Dioxyde de carbone", "Très faible (argon et hélium)", "Hydrogène et ammoniac", "Azote et vapeur d’eau", "Soufre et dioxyde de carbone", "Oxygène et néon" };

            for (int i = 0; i < tab.Length; i++)
            {
                dico.Add(tab[i], new detailPlanete(tabPes[i], tabatm[i]));
            }

            lblPesanteur.Text = "Pesanteur : " + dico[this.nomPlanete].pesanteur;
            lblAtmosphere.Text = "Atmosphère : " + dico[this.nomPlanete].atmosphere;

            FiltresMissions();

            FiltresCivils();
            lblNbHab.Text = "Nombre total d'habitants sélectionnées sur " + this.nomPlanete + " :";

            FiltresEspeces();
        }

        //Tous les filtres
        private void FiltresMissions()
        {
            flpMissions.Controls.Clear();

            string aujourdhui = DateTime.Today.ToString("yyyy-MM-dd");

            string filtre = "nomPlanete = '" + this.nomPlanete + "'";

            if (rdbAllMiss.Checked)
            {
                filtre += "";
            }
            else if (rdbMissRealiser.Checked)
            {
                filtre += " AND dateRetour < #" + aujourdhui + "#";
            }
            else if (rdbMissEnCours.Checked)
            {
                filtre += " AND dateDepart <= #" + aujourdhui + "# AND dateRetour >= #" + aujourdhui + "#";
            }
            else if (rdbMissAVenir.Checked)
            {
                filtre += " AND dateDepart > #" + aujourdhui + "#";
            }

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            DataRow[] dRowMiss = dtMissions.Select(filtre);

            int nbMissSelect = 0;

            if (rdbMissRealiser.Checked)
            {
                nbMissSelect += dRowMiss.Length;
            }
            else if (rdbMissEnCours.Checked)
            {
                nbMissSelect += dRowMiss.Length;
            }
            else if (rdbMissAVenir.Checked)
            {
                nbMissSelect += dRowMiss.Length;
            }
            else
            {
                nbMissSelect += dRowMiss.Length;
            }

            lblNbMissSelectionnees.Text = "Nombre total de missions sélectionnées sur " + this.nomPlanete + " : " + nbMissSelect;


            foreach (DataRow drMiss in dRowMiss)
            {

                UCAffichageMission UCmission = new UCAffichageMission(drMiss[0].ToString(), drMiss[1].ToString(), Convert.ToDateTime(drMiss["dateDepart"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(drMiss["dateRetour"]).ToString("yyyy-MM-dd"), drMiss["matriculeChef"].ToString(), drMiss[5].ToString());
                flpMissions.Controls.Add(UCmission);
            }
        }

        private void FiltresCivils()
        {
            flpHabitants.Controls.Clear();
            DataTable dtCivils = MesDatas.DsGlobal.Tables["Civil"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            string filtre = "nomPlaneteOrigine = '" + this.nomPlanete + "'";

            if (rdbTousCivil.Checked)
            {
                // Rien de plus a mettre dans le filtre
            }
            else if (rdbAstronome.Checked)
            {
                filtre += " AND Specialite = 'Astronome'";
            }
            else if (rdbBiologiste.Checked)
            {
                filtre += " AND Specialite = 'Biologiste'";
            }
            else if (rdbCuisinier.Checked)
            {
                filtre += " AND Specialite = 'Cuisinier'";
            }
            else if (rdbGeologue.Checked)
            {
                filtre += " AND Specialite = 'Géologue'";
            }
            else if (rdbInfirmier.Checked)
            {
                filtre += " AND Specialite = 'Infirmier'";
            }
            else if (rdbLogisticien.Checked)
            {
                filtre += " AND Specialite = 'Logisticien'";
            }
            else if (rdbMecanicien.Checked)
            {
                filtre += " AND Specialite = 'Mécanicien'";
            }
            else if (rdbMedecin.Checked)
            {
                filtre += " AND Specialite = 'Médecin'";
            }
            else if (rdbNegociateur.Checked)
            {
                filtre += " AND Specialite = 'Négociateur'";
            }
            else if (rdbPilote.Checked)
            {
                filtre += " AND Specialite = 'Pilote'";
            }
            else if (rdbVolcanologue.Checked)
            {
                filtre += " AND Specialite = 'Volcanologue'";
            }

            DataRow[] drCivils = dtCivils.Select(filtre);

            foreach (DataRow drCivil in drCivils)
            {
                string nomComplet = "";

                DataRow[] drMembre = dtMembres.Select("matricule = '" + drCivil["matriculeMembre"] + "'");
                if (drMembre.Length > 0)
                {
                    nomComplet = drMembre[0]["prenom"] + " " + drMembre[0]["nom"];
                }

                UCCivils ucCivil = new UCCivils(nomComplet, drCivil["Specialite"].ToString(), drCivil["nomPlaneteOrigine"].ToString());
                flpHabitants.Controls.Add(ucCivil);
            }

            lblNbHab.Text = "Nombre d'habitants sur " + this.nomPlanete + " : " + drCivils.Length;
        }
        private void FiltresEspeces()
        {
            flpEspeces.Controls.Clear();

            DataRow[] drHab = MesDatas.DsGlobal.Tables["Habiter"].Select("nomPlanete = '" + this.nomPlanete + "'");
            DataTable espece = MesDatas.DsGlobal.Tables["Espece"];

            foreach (DataRow dRowHab in drHab)
            {
                int id = Convert.ToInt32(dRowHab["idEspece"]);
                DataRow[] dr = espece.Select("id = " + id);

                if (dr.Length > 0)
                {
                    string nom = dr[0]["nom"].ToString();
                    string couleur = dr[0]["couleur"].ToString();
                    string planetes = trouverPlaneteEspece(id.ToString());

                    if (rdbEspecesAlliées.Checked)
                    {
                        flpEspeces.Controls.Clear();
                        DataRow[] drAllie = MesDatas.DsGlobal.Tables["Allie"].Select("idEspece = " + id);

                        if (drAllie.Length > 0)
                        {
                            UCEspeceAllie alliee = new UCEspeceAllie(nom, couleur, drAllie[0]["degreBienveillance"].ToString(), drAllie[0]["instrumentMusique"].ToString(), planetes, id);
                            flpEspeces.Controls.Add(alliee);
                        }
                    }
                    else if (rdbEspecesEnnemies.Checked)
                    {
                        DataRow[] drEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select("idEspece = " + id);

                        if (drEnnemi.Length > 0)
                        {
                            UCEspeceEnnemi ennemies = new UCEspeceEnnemi(nom, couleur, drEnnemi[0]["degreAgressivite"].ToString(), drEnnemi[0]["typeArme"].ToString(), planetes, id);
                            flpEspeces.Controls.Add(ennemies);
                        }
                    }
                    else
                    {
                        UCRaceRepertorie allEspeces = new UCRaceRepertorie(nom, couleur, planetes, id);
                        flpEspeces.Controls.Add(allEspeces);
                    }
                }
            }
            lblNbEspeces.Text = "Nombre total d'espèces sélectionnées sur " + this.nomPlanete + " : ";
            lblNbEspeces.Text += flpEspeces.Controls.Count;
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

        //Chaque rdb pour les filtres 

        //rdb missions
        private void rdbAllMiss_CheckedChanged(object sender, EventArgs e)
        {
            FiltresMissions();
        }

        private void rdbMissRealiser_CheckedChanged(object sender, EventArgs e)
        {
            FiltresMissions();
        }

        private void rdbMissEnCours_CheckedChanged(object sender, EventArgs e)
        {
            FiltresMissions();
        }

        private void rdbMissAVenir_CheckedChanged(object sender, EventArgs e)
        {
            FiltresMissions();
        }

        //rdb espèces
        private void rdbToutesLesEspeces_CheckedChanged(object sender, EventArgs e)
        {
            FiltresEspeces();
        }

        private void rdbEspecesAlliées_CheckedChanged(object sender, EventArgs e)
        {
            FiltresEspeces();
        }

        private void rdbEspecesEnnemies_CheckedChanged(object sender, EventArgs e)
        {
            FiltresEspeces();
        }

        //rdb civils originaire de la planète choisi
        private void rdbTousCivil_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbAstronome_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbBiologiste_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbCuisinier_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbGeologue_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbInfirmier_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbLogisticien_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbMecanicien_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbMedecin_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbVolcanologue_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbNegociateur_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void rdbPilote_CheckedChanged(object sender, EventArgs e)
        {
            FiltresCivils();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}