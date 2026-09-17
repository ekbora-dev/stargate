
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmPageConnexion : Form
    {
        public frmPageConnexion()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT mdp FROM Admin WHERE login = '{txtLogin.Text}'";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                object resultat = cmd.ExecuteScalar();

                if (resultat != DBNull.Value && resultat != null)
                {
                    string mdpStocke = resultat.ToString();
                    //Vérification du mot de passe
                    bool valide = BCrypt.Net.BCrypt.Verify(txtMDP.Text, mdpStocke);
                    //Résultat de l'authentification
                    if (valide)
                    {
                        frmCreationMission frmCreerMission = new frmCreationMission();
                        DialogResult dr = frmCreerMission.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        txtMDP.Text = "";
                        erpErreurMDP.SetError(txtMDP, "Login ou mot de passe incorrect !");
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
