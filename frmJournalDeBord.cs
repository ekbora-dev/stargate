using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SAE24
{
    public partial class frmJournalDeBord : Form
    {

        private string nomPlanete = "Sckxyss";
        private int numero = 1;
        int index;
        DataTable newJournal;




        public frmJournalDeBord(string pl, int nm)
        {
            InitializeComponent();
            MessageBox.Show(MesDatas.DsGlobal.Tables.Count.ToString());
            this.nomPlanete = pl;
            this.numero = nm;

            this.Text = "Journal de bord de la mission " + nomPlanete + numero;


            string journalFiltre = $"nomPlanete = '{nomPlanete}' AND numero = {numero}";
            DataRow[] newtabLigne = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(journalFiltre);
            if (newtabLigne.Length > 0)
            {
                newJournal = newtabLigne.CopyToDataTable<DataRow>();
                newJournal.TableName = "newJournal";
            }
            else
            {
                btInf.Visible = false;
                btSup.Visible = false;
                btSupSup.Visible = false;
                btInfInf.Visible = false;
                lblMessage.Text = "Pas de com";
            }


        }

        private void frmJournalDeBord_Load(object sender, EventArgs e)
        {
            try
            {
                string filtre = $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}";

                if (newJournal != null && newJournal.Rows.Count > 0)
                {
                    lblDate.Text = (newJournal.Rows[0]["dateJ"]).ToString();
                    lblMessage.Text = (newJournal.Rows[0]["commentaires"]).ToString();
                    index = 0;
                }

                DataRow[] tabLignes = MesDatas.DsGlobal.Tables["Contact"].Select(filtre);
                if (tabLignes.Length > 0)
                {
                    DataTable newContact = tabLignes.CopyToDataTable<DataRow>();
                    newContact.TableName = "newContact";

                    DataTable info = MesDatas.DsGlobal.Tables["Informateur"];

                    string[] informateur = new string[newContact.Rows.Count];
                    for (int i = 0; i < newContact.Rows.Count; i++)
                    {
                        string codeInfo = (newContact.Rows[i]["nomCodeInformateur"]).ToString();
                        string filtreInformateur = $"nomCode = '{codeInfo}'";
                        DataRow[] dr = info.Select(filtreInformateur);
                        informateur[i] = dr[0]["nom"].ToString();
                    }

                    DataTable Info = new DataTable();
                    Info.TableName = "Info";
                    DataColumn dateC = new DataColumn("dateC", typeof(string));
                    Info.Columns.Add(dateC);
                    DataColumn somme = new DataColumn("somme", typeof(int));
                    Info.Columns.Add(somme);
                    DataColumn appreciation = new DataColumn("appreciation", typeof(string));
                    Info.Columns.Add(appreciation);
                    DataColumn nomInformateur = new DataColumn("nomInformateur", typeof(string));
                    Info.Columns.Add(nomInformateur);

                    int totalSomme = 0;
                    for (int m = 0; m < newContact.Rows.Count; m++)
                    {
                        DataRow ligne;
                        ligne = Info.NewRow();
                        ligne[0] = (newContact.Rows[m]["dateC"]).ToString();
                        ligne[1] = Convert.ToInt32((newContact.Rows[m]["sommeVersee"]));
                        ligne[2] = (newContact.Rows[m]["appreciation"]).ToString();
                        ligne[3] = informateur[m];
                        Info.Rows.Add(ligne);
                        totalSomme += Convert.ToInt32((newContact.Rows[m]["sommeVersee"]));
                    }
                    dgvContact.DataSource = Info;
                    lblSomme.Text += totalSomme.ToString();
                }
                else
                {
                    dgvContact.Visible = false;
                    lblSomme.Visible = false;
                    lblError.Text = "Rien au niveau des contacts donc pas d'informateur";
                }

                DataRow[] tabLigne = MesDatas.DsGlobal.Tables["Depense"].Select(filtre);
                if (tabLigne.Length > 0)
                {
                    DataTable typeDep = MesDatas.DsGlobal.Tables["TypeDepense"];
                    DataTable newDepense = tabLigne.CopyToDataTable<DataRow>();
                    newDepense.TableName = "newDepense";

                    string[] libelleTypeDepense = new string[newDepense.Rows.Count];
                    for (int i = 0; i < newDepense.Rows.Count; i++)
                    {
                        string codeDep = (newDepense.Rows[i]["idTypeDepense"]).ToString();
                        string filtreTypeDepense = $"id = '{codeDep}'";
                        DataRow[] dr = typeDep.Select(filtreTypeDepense);
                        libelleTypeDepense[i] = dr[0]["libelle"].ToString();
                    }

                    DataTable DepenseGlobale = new DataTable();
                    DepenseGlobale.TableName = "DepenseGlobale";
                    DataColumn id = new DataColumn("id", typeof(int));
                    DepenseGlobale.Columns.Add(id);
                    DataColumn dateD = new DataColumn("dateD", typeof(string));
                    DepenseGlobale.Columns.Add(dateD);
                    DataColumn motif = new DataColumn("motif", typeof(string));
                    DepenseGlobale.Columns.Add(motif);
                    DataColumn montant = new DataColumn("montant", typeof(int));
                    DepenseGlobale.Columns.Add(montant);
                    DataColumn typeDepense = new DataColumn("typeDepense", typeof(string));
                    DepenseGlobale.Columns.Add(typeDepense);

                    int totalDepense = 0;
                    for (int m = 0; m < newDepense.Rows.Count; m++)
                    {
                        DataRow ligne;
                        ligne = DepenseGlobale.NewRow();
                        ligne[0] = Convert.ToInt32((newDepense.Rows[m]["id"]));
                        ligne[1] = (newDepense.Rows[m]["dateD"]).ToString();
                        ligne[2] = (newDepense.Rows[m]["motif"]).ToString();
                        ligne[3] = Convert.ToInt32((newDepense.Rows[m]["montant"]));
                        ligne[4] = libelleTypeDepense[m];
                        DepenseGlobale.Rows.Add(ligne);
                        totalDepense += Convert.ToInt32((newDepense.Rows[m]["montant"]));
                    }
                    dgvDepense.DataSource = DepenseGlobale;
                    lblDepense.Text += totalDepense.ToString();
                }
                else
                {
                    dgvDepense.Visible = false;
                    lblDepense.Visible = false;
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur : " + err.Message);
            }
        }


        private void btInfInf_Click(object sender, EventArgs e)
        {
            index = 0;
            lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
            lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();

        }

        private void btSupSup_Click(object sender, EventArgs e)
        {
            index = newJournal.Rows.Count - 1;
            lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
            lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();

        }

        private void btInf_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = newJournal.Rows.Count - 1;
                lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
                lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();

            }
            else
            {
                index--;
                lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
                lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if (index == newJournal.Rows.Count - 1)
            {
                index = 0;
                lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
                lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();

            }
            else
            {
                index++;
                lblDate.Text = (newJournal.Rows[index]["dateJ"]).ToString();
                lblMessage.Text = (newJournal.Rows[index]["commentaires"]).ToString();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmJournalDeBord_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
