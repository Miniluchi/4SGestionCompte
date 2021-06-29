using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCompte
{
    public partial class FormGestion : Form
    {
        public static FormGestion Instance = null;

        public FormGestion()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargerLesElements();
        }

        private void chargerLesElements()
        {
            try
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

                //ci = NumberFormat.NumberDecimalSeparator = ".";
                string filelocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Gestion des comptes\";
                //filelocation.Replace(@"\\", @"\\");
                string filename = @"Comptes.csv";

                    if (!File.Exists(filelocation + filename))
                    {
                        if (!Directory.Exists(filelocation))
                        {
                            Directory.CreateDirectory(filelocation);
                        }
                        string file = filelocation + filename;
                        FileStream FS = null;
                        using (FS = File.Create(file)) { }
                        FS.Close();
                    }


                    StreamReader fluxLecture = new StreamReader(filelocation + filename, true);
                    for (int i = 1; i <= File.ReadAllLines(filelocation + filename).Length; i++)
                    {
                        string ligne = fluxLecture.ReadLine();
                        string[] element = ligne.Split(',');
                        ListViewItem lvi = new ListViewItem(element[0].ToString());
                        lvi.SubItems.Add(element[1].ToString());
                        lvi.SubItems.Add(element[2].ToString());
                        lvi.SubItems.Add(element[3].ToString());
                        lvi.SubItems.Add(element[4].ToString());
                        lvi.SubItems.Add(element[5].ToString());
                        lv_comptes.Items.Add(lvi);
                    }

                    fluxLecture.Close();
                    fluxLecture.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void FormGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Gestion des comptes\Comptes.csv", "");
                StreamWriter fluxEcriture = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Gestion des comptes\Comptes.csv", true);

                if (lv_comptes.Items.Count > 0)
                {

                    for (int i = 0; i < lv_comptes.Items.Count; i++)
                    {
                        string name = lv_comptes.Items[i].Text;
                        string pass = lv_comptes.Items[i].SubItems[1].Text;
                        string email = lv_comptes.Items[i].SubItems[2].Text;
                        string isBanned = lv_comptes.Items[i].SubItems[3].Text;
                        string popo = lv_comptes.Items[i].SubItems[4].Text;
                        string formules = lv_comptes.Items[i].SubItems[5].Text;

                        fluxEcriture.WriteLine(name + "," + pass + "," + email + "," + isBanned + "," + popo + "," + formules);
                    }
                }

                fluxEcriture.Close();
                fluxEcriture.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public void ModifierElement(string name, string mdp, string email, bool isBanned, int popo, int formule, int index)
        {
            try
            {
                lv_comptes.Items[index].Text = name;
                lv_comptes.Items[index].SubItems[1].Text = mdp;
                lv_comptes.Items[index].SubItems[2].Text = email;
                lv_comptes.Items[index].SubItems[3].Text = isBanned.ToString();
                lv_comptes.Items[index].SubItems[4].Text = popo.ToString();
                lv_comptes.Items[index].SubItems[5].Text = formule.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void AjouterElement(string name, string mdp, string email, bool isBanned, int popo, int formule, int index)
        {
            try
            {
                ListViewItem lvi = new ListViewItem(name);
                lvi.SubItems.Add(mdp);
                lvi.SubItems.Add(email);
                lvi.SubItems.Add(isBanned.ToString());
                lvi.SubItems.Add(popo.ToString());
                lvi.SubItems.Add(formule.ToString());

                lv_comptes.Items.Add(lvi);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void lv_comptes_DoubleClick(object sender, EventArgs e)
        {
            sGB_ajouterModifier_Click(sender, e);
        }

        private void sGB_ajouterModifier_Click(object sender, EventArgs e)
        {
            if (lv_comptes.SelectedItems.Count > 0)
            {
                string name = lv_comptes.SelectedItems[0].Text;
                string mdp = lv_comptes.SelectedItems[0].SubItems[1].Text;
                string email = lv_comptes.SelectedItems[0].SubItems[2].Text;
                bool isBanned = bool.Parse(lv_comptes.SelectedItems[0].SubItems[3].Text);
                int popo = int.Parse(lv_comptes.SelectedItems[0].SubItems[4].Text);
                int formule = int.Parse(lv_comptes.SelectedItems[0].SubItems[5].Text);

                int index = lv_comptes.Items.IndexOf(lv_comptes.SelectedItems[0]);


                fm_items fm_item = new fm_items();
                fm_item.RecupererLesElements(name, mdp, email, isBanned, popo, formule, index);
                fm_item.ShowDialog();
            }
            else
            {
                fm_items fm_item = new fm_items();
                fm_item.RecupererLesElements("", "", "", false, 0, 0, -1);
                fm_item.ShowDialog();
            }

        }

        private void sGB_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                lv_comptes.SelectedItems[0].Remove();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
