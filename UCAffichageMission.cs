using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using iFONT = iTextSharp.text.Font;

namespace SAE24
{
    public partial class UCAffichageMission : UserControl
    {
        public UCAffichageMission(string planete, string idMission, string dateAller, string dateRetour, string capitaine, string budget)
        {
            InitializeComponent();

            lblPlanete.Text = planete;
            lblIDMission.Text = idMission;
            lblDateAller.Text = DateTime.Parse(dateAller).ToString("dd/MM/yyyy");
            lblDateRetour.Text = DateTime.Parse(dateRetour).ToString("dd/MM/yyyy");

            string sql = $"SELECT nom ||' '|| prenom as nomComplet FROM Membre WHERE matricule = '{capitaine}'";
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            object nomComplet = cmd.ExecuteScalar();
            lblCapitaine.Text = nomComplet.ToString();
            lblBudget.Text = budget + " G$";

            pboPlanete.ImageLocation = $"./imagePlanete/{planete}.jpg";

            DateTime debut = DateTime.Parse(dateAller);
            DateTime fin = DateTime.Parse(dateRetour);

            if (DateTime.Today < debut)
            {
                btnToPDF.Enabled = false;
            }
        }

        private void btnDetailsMission_Click(object sender, EventArgs e)
        {
            frmAffichageMission frmAffichage = new frmAffichageMission(lblPlanete.Text, Convert.ToInt32(lblIDMission.Text));
            DialogResult dr = frmAffichage.ShowDialog();
        }

        private void btnToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {

                sfd.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                sfd.FileName = "Mission " + lblPlanete.Text + "-" + lblIDMission.Text + ".pdf";

                Genere_Pdf(sfd.FileName);
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);

            }
            System.Diagnostics.Process.Start(sfd.FileName);
        }

        private void Genere_Pdf(string exPath)

        {
            try
            {
                Document doc = new Document(PageSize.A4);

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(exPath, FileMode.OpenOrCreate));

                doc.Open();
                doc.SetMargins(15, 15, 15, 15);



                iFONT titre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.BLACK);
                iFONT soustitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
                iFONT souligner = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, iFONT.UNDERLINE, BaseColor.BLACK);

                doc.Add(new Paragraph("Rapport de mission : " + lblPlanete.Text + "-" + lblIDMission.Text + "\n\n", titre));

                doc.Add(new Paragraph("Départ le " + lblDateAller.Text + "\n", soustitre));
                doc.Add(new Paragraph("Retour le " + lblDateRetour.Text + "\n", soustitre));

                doc.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------" + "\n\n"));

                doc.Add(new Paragraph("Sous la responsabilté " + lblCapitaine.Text + "\n", soustitre));

                doc.Add(new Paragraph("Budget inital : " + lblBudget.Text + "\n\n", soustitre));

                doc.Add(new Paragraph("Feuille de route :\n", souligner));

                string filtrePlanete = $"nomPlanete = '{lblPlanete.Text}' AND numero = '{lblIDMission.Text}'";
                DataRow[] drFeuilleDeRoute = MesDatas.DsGlobal.Tables["Mission"].Select(filtrePlanete);

                if (drFeuilleDeRoute.Length > 0)
                {
                    for (int i = 0; i < drFeuilleDeRoute.Length; i++)
                    {
                        doc.Add(new Paragraph(drFeuilleDeRoute[i]["feuilleDeRoute"].ToString() + "\n\n"));
                    }
                }

                doc.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------" + "\n\n"));


                doc.Add(new Paragraph("Liste des membres :\n\n", soustitre));

                string filtrePlanete2 = $"nomPlanete = '{lblPlanete.Text}' AND numeroMission = '{lblIDMission.Text}'";
                DataRow[] drListeMembre = MesDatas.DsGlobal.Tables["Composer"].Select(filtrePlanete2);

                if (drListeMembre.Length > 0)
                {
                    for (int i = 0; i < drListeMembre.Length; i++)
                    {
                        string filtreMatricule = $"matricule = '{drListeMembre[i]["matriculeMembre"]}'";
                        DataRow[] Membre = MesDatas.DsGlobal.Tables["Membre"].Select(filtreMatricule);
                        if (Membre.Length > 0)
                        {
                            doc.Add(new Paragraph("\t-> " + Membre[0]["prenom"].ToString() + " " + Membre[0]["nom"].ToString() + "\n"));
                        }
                    }
                }

                doc.Add(new Paragraph("\nJournal de bord :\n\n", soustitre));

                DataRow[] drJournalDeBord = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(filtrePlanete);

                if (drJournalDeBord.Length > 0)
                {
                    for (int i = 0; i < drJournalDeBord.Length; i++)
                    {
                        string commentaireEchappe = drJournalDeBord[i]["commentaires"].ToString().Replace("'", "''");

                        string filtreCom = $"dateJ = '{drJournalDeBord[i]["dateJ"]}' And commentaires = '{commentaireEchappe}'";
                        DataRow[] com = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(filtreCom);
                        if (com.Length > 0)
                        {
                            doc.Add(new Paragraph("Le " + com[0]["dateJ"].ToString() + " -> " + com[0]["commentaires"].ToString() + "\n\n"));
                        }
                    }
                }


                doc.Add(new Paragraph("Dépenses effetuées :\n\n", soustitre));

                DataRow[] drDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(filtrePlanete2);

                if (drDepenses.Length > 0)
                {
                    for (int i = 0; i < drDepenses.Length; i++)
                    {
                        string motifEchappe = drDepenses[i]["motif"].ToString().Replace("'", "''");

                        string filtreDepense = $"dateD = '{drDepenses[i]["dateD"]}' And motif = '{motifEchappe}' AND montant = '{drDepenses[i]["montant"]}'";
                        DataRow[] depense = MesDatas.DsGlobal.Tables["Depense"].Select(filtreDepense);
                        if (depense.Length > 0)
                        {
                            doc.Add(new Paragraph(drDepenses.Length + ") le " + depense[0]["dateD"].ToString() + " : " + depense[0]["motif"].ToString() + " -> " + depense[0]["montant"].ToString() + "\n\n"));
                        }
                    }
                }

                doc.Add(new Paragraph("Contacts avec des informateurs :\n\n", soustitre));

                string phraseComplete = "";
                DataRow[] contactInfo = MesDatas.DsGlobal.Tables["Contact"].Select(filtrePlanete2);
                if (contactInfo.Length > 0)
                {
                    for (int i = 0; i < contactInfo.Length; i++)
                    {
                        string filtreContact = $"nomCode = '{contactInfo[i]["nomCodeInformateur"]}'";

                        DataRow[] contactBlaze = MesDatas.DsGlobal.Tables["Informateur"].Select(filtreContact);
                        string filtreEspece = $"id = '{contactBlaze[0]["idEspeceEnnemi"]}'";

                        DataRow[] contactEspece = MesDatas.DsGlobal.Tables["Espece"].Select(filtreEspece);
                        if (contactBlaze.Length > 0 && contactEspece.Length > 0)
                        {
                            phraseComplete += $"Le {contactInfo[i]["dateC"].ToString()} : rencontre avec {contactBlaze[0]["nom"].ToString()} de la race des {contactEspece[0]["nom"].ToString()} -> {contactInfo[i]["sommeVersee"].ToString()} G$ ({contactInfo[i]["appreciation"].ToString()})";
                        }
                        doc.Add(new Paragraph(phraseComplete + "\n\n"));
                        phraseComplete = "";
                    }
                }

                doc.Add(new Paragraph("Bilan des captures : \n\n", soustitre));


                float[] columnWidths = { 100f, 100f, 100f, 100f };
                PdfPTable table = new PdfPTable(columnWidths);
                string[] periodes = { "Nom de l'espèce", "Objectif initial", "Nombre de captures réalisables", "Taux de réussite (en %)" };

                foreach (var periode in periodes)
                {
                    PdfPCell headerCell = new PdfPCell(new Paragraph(periode));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(headerCell);
                }

                DataRow[] objCapture = MesDatas.DsGlobal.Tables["ObjectifCapture"].Select(filtrePlanete2);

                if (objCapture != null && objCapture.Length > 0)
                {
                    for (int j = 0; j < objCapture.Length; j++)
                    {
                        string idEspece = objCapture[j]["idEspeceEnnemi"].ToString();
                        string filtrenom = $"id = '{idEspece}'";
                        DataRow[] nmEspece = MesDatas.DsGlobal.Tables["Espece"].Select(filtrenom);

                        string nomEspeceAffichage = (nmEspece.Length > 0) ? nmEspece[0]["nom"].ToString() : "Inconnue";
                        PdfPCell rowHeader = new PdfPCell(new Paragraph(nomEspeceAffichage));
                        table.AddCell(rowHeader);

                        int nbCapture = Convert.ToInt32(objCapture[j]["objectif"]);

                        string filtreCaptureEspece = filtrePlanete2 + $" AND idEspeceEnnemi = '{idEspece}'";
                        DataRow[] captureSpecifique = MesDatas.DsGlobal.Tables["Capturer"].Select(filtreCaptureEspece);

                        int nbCaptureRealise = 0;
                        if (captureSpecifique.Length > 0)
                        {
                            nbCaptureRealise = Convert.ToInt32(captureSpecifique[0]["nombre"]);
                        }

                        int pourcentage = nbCapture > 0 ? (nbCaptureRealise * 100 / nbCapture) : 0;

                        PdfPCell dataCell = new PdfPCell(new Paragraph(nbCapture.ToString()));
                        dataCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                        PdfPCell dataCell2 = new PdfPCell(new Paragraph(nbCaptureRealise.ToString()));
                        dataCell2.HorizontalAlignment = Element.ALIGN_RIGHT;

                        PdfPCell dataCell3 = new PdfPCell(new Paragraph(pourcentage.ToString() + "%"));
                        dataCell3.HorizontalAlignment = Element.ALIGN_RIGHT;

                        table.AddCell(dataCell);
                        table.AddCell(dataCell2);
                        table.AddCell(dataCell3);
                    }
                }
                doc.Add(table);

                doc.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
