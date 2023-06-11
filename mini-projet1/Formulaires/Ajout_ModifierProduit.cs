using mini_projet1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projet1.Formulaires
{
    public partial class Ajout_ModifierProduit : Form
    {
        Gestion_produit gp;
        UserControlProduit userControlProduit;
        mp1 db;
        public Ajout_ModifierProduit(UserControlProduit userControlProduit)
        {
            InitializeComponent();
            db = new mp1();
            userControlProduit = new UserControlProduit();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbx1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        public int idselected;
        public void remplir()
        {
            List<Categorie> list = new List<Categorie>();
            list = db.Categories.ToList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Libelle";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gp = new Gestion_produit();
            //pour l'ajout d'une categorie
            if (lbltitle.Text == "Ajouter Produit")
            {
                string libelle = txtbx1.Text;
                float qte = float.Parse(textBox1.Text);
                int prix = int.Parse(textBox3.Text);
                string lib = comboBox1.Text;
                

                if (gp.AjouterProduit(libelle, qte, prix, lib) == true)
                {
                    MessageBox.Show("produit ajouter avec succes", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    userControlProduit.gridActualisation();
                    this.Close();
                }
            }
            //pour la modification d'une categorie
            /*else
            {
                gp.Modifier_Categorie(idselected, txtbx1.Text, textBox4.Text);

                MessageBox.Show("categorie modifier avec succes", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                userControlProduit.gridActualisation();
                this.Close();
            }*/
        }
    }
}
