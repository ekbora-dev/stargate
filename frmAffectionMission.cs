using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmAffectionMission : Form
    {
        private string planete;
        private string numeroMission;
        private string chef;
        private int nbMembre;
        private string dateAller;
        private string dateRetour;

        private Dictionary<string, string> membresMission = new Dictionary<string, string>();
        private Dictionary<int, int> especeACapturer = new Dictionary<int, int>();
        public frmAffectionMission(string pl, string num, string chf, int nb, string dateA, string dateR)
        {
            InitializeComponent();
            this.chef = chf;
            this.nbMembre = nb;
            this.planete = pl;
            this.numeroMission = num;
            this.dateAller = dateA;
            this.dateRetour = dateR;

            this.Text = "Affection des membres pour la mission " + planete + numeroMission;
        }

        private void refreshMembres()
        {
            lboMembre.DataSource = null;
            lboMembre.DataSource = new BindingSource(membresMission.ToList(), null);
            lboMembre.DisplayMember = "Value";
            lboMembre.ValueMember = "Key";
        }

        private void frmAffectationMission_Load(object sender, EventArgs e)
        {
            this.Text = "Affectation de membres et espèces à capturer à la mission : " + planete + numeroMission;
            lboMembre.DataSource = new BindingSource(membresMission.ToList(), null);
            lboMembre.DisplayMember = "Value";
            lboMembre.ValueMember = "Key";

            //Remplit cboMembre
            try
            {
                string sql = $@"SELECT matricule, nom ||' '|| prenom ||' - '|| grade as NomComplet FROM Membre 
                            JOIN Militaire ON matriculeMembre = matricule
                            WHERE matricule != '{chef}'
                            AND matricule NOT IN (
                            SELECT c.matriculeMembre 
                            FROM Composer c
                            JOIN Mission m ON c.nomPlanete = m.nomPlanete AND c.numeroMission = m.numero
                            WHERE m.dateDepart <= @dateRetour AND m.dateRetour >= @dateAller
                            )
                            UNION
                            SELECT matricule, nom ||' '|| prenom ||' - '|| Specialite as NomComplet FROM Membre
                            JOIN Civil ON matriculeMembre = matricule
                            WHERE matricule NOT IN (
                            SELECT c.matriculeMembre 
                            FROM Composer c
                            JOIN Mission m ON c.nomPlanete = m.nomPlanete AND c.numeroMission = m.numero
                            WHERE m.dateDepart <= @dateRetour AND m.dateRetour >= @dateAller
                            ORDER BY 1
                            )";


                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@chef", chef);
                cmd.Parameters.AddWithValue("@dateAller", dateAller);
                cmd.Parameters.AddWithValue("@dateRetour", dateRetour);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cboMembre.DataSource = dt;
                cboMembre.DisplayMember = "nomComplet";
                cboMembre.ValueMember = "matricule";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            // On ajoute le chef de mission dans la table Composer
            try
            {
                string sqlInsertionChef = $"INSERT INTO Composer VALUES (@nomPlanete, @numeroMission, @matriculeMembre)";
                SQLiteCommand command = new SQLiteCommand(sqlInsertionChef, Connexion.Connec);
                command.Parameters.AddWithValue("@nomPlanete", planete);
                command.Parameters.AddWithValue("@numeroMission", numeroMission);
                command.Parameters.AddWithValue("@matriculeMembre", chef);
                command.ExecuteNonQuery();
                nbMembre--;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }



            //Remplit cboEspece
            string sql2 = "SELECT idEspece, nom || '-' || couleur as nomCompletee FROM Espece JOIN Ennemi ON id = idEspece WHERE id = idEspece ORDER BY 1";
            SQLiteCommand cmd3 = new SQLiteCommand(sql2, Connexion.Connec);
            DataTable dt2 = new DataTable();
            dt2.Load(cmd3.ExecuteReader());

            cboEspece.DataSource = dt2;
            cboEspece.DisplayMember = "nomCompletee";
            cboEspece.ValueMember = "idEspece";

            lblReste.Text = (this.nbMembre).ToString();
        }

        private void btAjouterCaptures_Click(object sender, EventArgs e)
        {
            foreach (int id in especeACapturer.Values)
            {
                if (id == Convert.ToInt32(cboEspece.SelectedValue))
                {
                    MessageBox.Show("Espece déjà présent !");
                    return;
                }
            }

            if (cboEspece.SelectedValue != null)
            {
                especeACapturer.Add(Convert.ToInt32(cboEspece.SelectedValue), Convert.ToInt32(((DataRowView)cboEspece.SelectedItem)["idEspece"]));
                string sql2 = $"SELECT nom FROM Espece WHERE id = {Convert.ToInt32(cboEspece.SelectedValue)}";
                SQLiteCommand cmd3 = new SQLiteCommand(sql2, Connexion.Connec);
                string nomEspece = cmd3.ExecuteScalar().ToString();
                lboCapture.Items.Add($"{nomEspece} à capturer : {txtNbCaptureEspece.Text}");
            }
        }

        private void txtAlien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btAjouterMembre_Click(object sender, EventArgs e)
        {

            if (cboMembre.SelectedValue != null)
            {
                if (this.nbMembre > 0)
                {
                    string idMembreSelectionne = cboMembre.SelectedValue.ToString();
                    string nomComplet = ((DataRowView)cboMembre.SelectedItem)["NomComplet"].ToString();

                    if (membresMission.ContainsKey(idMembreSelectionne))
                    {
                        MessageBox.Show("Ce membre est déjà présent dans la mission.");
                        return;
                    }

                    membresMission.Add(idMembreSelectionne, nomComplet);

                    refreshMembres();

                    this.nbMembre--;
                    lblReste.Text = this.nbMembre.ToString();

                }
                else
                {
                    MessageBox.Show("Limite de membres dépassée");
                    btAjouterMembre.Enabled = false;
                }
            }
        }

        private void btValiderMembres_Click(object sender, EventArgs e)
        {
            if (membresMission.Count > 0)
            {
                foreach (string matricule in membresMission.Keys)
                {
                    string sql = "INSERT INTO Composer VALUES (@nomPlanete, @numeroMission, @matriculeMembre)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@nomPlanete", planete);
                    cmd.Parameters.AddWithValue("@numeroMission", numeroMission);
                    cmd.Parameters.AddWithValue("@matriculeMembre", matricule);

                    cmd.ExecuteNonQuery();

                    cboMembre.Enabled = false;
                    lboMembre.Enabled = false;
                }
            }
        }

        private void btValiderObjectifs_Click(object sender, EventArgs e)
        {
            if (especeACapturer.Count > 0)
            {
                SQLiteTransaction trans = Connexion.Connec.BeginTransaction();
                try
                {
                    foreach (KeyValuePair<int, int> espece in especeACapturer)
                    {
                        string sql = "INSERT INTO ObjectifCapture VALUES (@nomPlanete, @numeroMission, @idEspeceEnnemi, @objectif)";
                        SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                        cmd.Transaction = trans;

                        cmd.Parameters.AddWithValue("@nomPlanete", planete);
                        cmd.Parameters.AddWithValue("@numeroMission", numeroMission);
                        cmd.Parameters.AddWithValue("@idEspeceEnnemi", espece.Key);
                        cmd.Parameters.AddWithValue("@objectif", espece.Value);

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    this.DialogResult = DialogResult.OK;
                    cboEspece.Enabled = false;
                    lboCapture.Enabled = false;
                }
                catch (SQLiteException err)
                {
                    trans.Rollback();
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnSupprimerMembre_Click(object sender, EventArgs e)
        {
            if (lboMembre.SelectedItem != null)
            {
                membresMission.Remove(lboMembre.SelectedValue.ToString());
                refreshMembres(); // Mise a jour de la lbo
                nbMembre++;
                lblReste.Text = (this.nbMembre).ToString();
            }
        }
    }
}
