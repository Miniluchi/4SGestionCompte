using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCompte
{
    public partial class fm_items : Form

    {
        int index = 0;
        public fm_items()
        {
            InitializeComponent();
        }

        private void fm_items_Load(object sender, EventArgs e)
        {

        }

        public void RecupererLesElements(string name, string mdp, string email, bool isBanned, int popo, int formule, int index)
        {
            sTB_nomCompte.Text = name;
            sTB_motDePasse.Text = mdp;
            sTB_email.Text = email;
            sCB_isBanned.Checked = isBanned;
            sTB_potionChance.Text = popo.ToString();
            sTB_formules.Text = formule.ToString();
            this.index = index;
        }



        private void sTB_title_Click(object sender, EventArgs e)
        {

        }

        private void sBT_valider_Click(object sender, EventArgs e)
        {
            string name = sTB_nomCompte.Text;
            string mdp = sTB_motDePasse.Text;
            string email = sTB_email.Text;
            bool isBanned = sCB_isBanned.Checked;
            int popo = int.Parse(sTB_potionChance.Text);
            int formule = int.Parse(sTB_formules.Text);
            int index = this.index;

            if (index == -1)
            {
                FormGestion.Instance.AjouterElement(name, mdp, email, isBanned, popo, formule, index);
            }
            else
            {
                FormGestion.Instance.ModifierElement(name, mdp, email, isBanned, popo, formule, index);
            }


            this.Close();
        }
    }
}
