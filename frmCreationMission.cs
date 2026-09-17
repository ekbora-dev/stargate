using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmCreationMission : Form
    {
        string dateDep, dateRet;
        public frmCreationMission()
        {
            InitializeComponent();
        }

        private void txtMembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtDataBaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Remplit la combo-box chef
            try
            {
                dateDep = dtpDepart.Value.ToString("yyyy-MM-dd");
                dateRet = dtpRetour.Value.ToString("yyyy-MM-dd");

                string sql = @"SELECT DISTINCT matricule as matriculeMembre, nom || ' ' || prenom || ' - ' || grade as nomComplet 
                                FROM Membre 
                                JOIN Militaire ON matriculeMembre = matricule
                                ORDER BY nomComplet";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@dateDep", dateDep);
                cmd.Parameters.AddWithValue("@dateRet", dateRet);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cboChef.DataSource = dt;
                cboChef.DisplayMember = "nomComplet";
                cboChef.ValueMember = "matriculeMembre";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }


            //Remplit la combo-box chef


            try
            {
                string sql2 = "SELECT nom FROM Planete";
                SQLiteCommand cmd2 = new SQLiteCommand(sql2, Connexion.Connec);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    cboPlanete.Items.Add(dr2.GetString(0));
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

        private void rechargerCboMembre() // Pour mettre à jour la combo membre pour récupérer les chefs disponibles.
        {
            dateDep = dtpDepart.Value.ToString("yyyy-MM-dd");
            dateRet = dtpRetour.Value.ToString("yyyy-MM-dd");

            string sql = $@"SELECT DISTINCT nom || ' ' || prenom || ' - ' || grade as nomComplet, matriculeMembre, nomPlanete || numero, dateDepart 
                                FROM Membre 
                                JOIN Militaire ON matricule = matriculeMembre 
                                LEFT JOIN Mission m ON matriculeChef = matriculeMembre 
                                WHERE dateRetour < '{dateDep}' OR dateDepart > '{dateRet}'
                                ORDER BY 1";
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cboChef.DataSource = dt;
            cboChef.DisplayMember = "nomComplet";
            cboChef.ValueMember = "matriculeMembre";
        }

        private bool conditions()
        {
            if (cboPlanete.SelectedValue != null && cboChef.SelectedValue != null && dtpDepart.Value != null && dtpRetour.Value != null || txtFeuilleRoute.Text != "" || txtMembre.Text == "" || txtBudget.Text != "" || txtDataBaz.Text != null)
            {
                return true;
            } 
            else
            {
                MessageBox.Show("Vérifiez si vous avez rempli tout les champs", "Erreur");
                return false;
            }
        }
        private void btValider_Click(object sender, EventArgs e)
        {
            if (conditions())
            {
                SQLiteTransaction trans = Connexion.Connec.BeginTransaction();
                try
                {
                    string sql = "INSERT INTO Mission VALUES (@nomplanete, @numero, @membre, @depart, @retour, @matricule, @feuille, @databaz, @budget)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                    cmd.Transaction = trans;

                    cmd.Parameters.AddWithValue("@membre", Convert.ToInt32(txtMembre.Text));
                    cmd.Parameters.AddWithValue("@nomplanete", cboPlanete.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(lblNumero.Text));
                    cmd.Parameters.AddWithValue("@depart", DateTime.Parse(dtpDepart.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@retour", DateTime.Parse(dtpRetour.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@matricule", cboChef.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@feuille", txtFeuilleRoute.Text);
                    cmd.Parameters.AddWithValue("@databaz", Convert.ToInt32(txtDataBaz.Text));
                    cmd.Parameters.AddWithValue("@budget", Convert.ToInt32(txtBudget.Text));

                    trans.Commit();
                    cmd.ExecuteNonQuery();

                    MesDatas.DsGlobal.Tables.Remove("Mission");
                    string sqlSelectMiss = "SELECT * FROM Mission";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlSelectMiss, Connexion.Connec);
                    da.Fill(MesDatas.DsGlobal, "Mission");

                    frmAffectionMission affectionMission = new frmAffectionMission(cboPlanete.SelectedItem.ToString(), lblNumero.Text.ToString(), cboChef.SelectedValue.ToString(), Convert.ToInt32(txtMembre.Text.ToString()), DateTime.Parse(dtpDepart.Text).ToString("yyyy-MM-dd"), DateTime.Parse(dtpRetour.Text).ToString("yyyy-MM-dd"));
                    DialogResult dr = affectionMission.ShowDialog();


                    this.Hide();
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                    trans.Rollback();
                }

            }
        }


        private void btnValiderPlanete_Click(object sender, EventArgs e)
        {
            string sql = "SELECT nomPlanete, max(numero) FROM Mission where nomPlanete = '" + cboPlanete.SelectedItem + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            SQLiteDataReader dr = cmd.ExecuteReader();

            int valeur = 1;
            while (dr.Read())
            {
                if (dr[0] == DBNull.Value || dr[0] == null)
                {
                    valeur = 1;
                    break;
                }
                else if (dr[0].ToString() == cboPlanete.SelectedItem.ToString())
                {
                    valeur = dr.GetInt32(1) + 1;
                }


            }
            lblNomMission.Text = "NOM DE LA MISSION : " + cboPlanete.SelectedItem.ToString();
            lblNumero.Text = valeur.ToString();

            btnValiderPlanete.Enabled = false;
            cboPlanete.Enabled = false;
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDepart.Value;
            rechargerCboMembre();
            if (dateTime < DateTime.Today)
            {
                MessageBox.Show("Mettez une date supérieure ou égale à la date d'aujourd'hui");
                dtpDepart.Value = DateTime.Today;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dtpRetour_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dtpRetour.Value;
            rechargerCboMembre();
            if (dateTime < DateTime.Today)
            {
                MessageBox.Show("Mettez une date supérieure ou égale à la date d'aujourd'hui");
                dtpRetour.Value = DateTime.Today;
            }

            if (dateTime < dtpDepart.Value)
            {
                MessageBox.Show("Mettez une date supérieure ou égale à la date de départ");
                dtpRetour.Value = DateTime.Today;
            }
        }
    }
}
