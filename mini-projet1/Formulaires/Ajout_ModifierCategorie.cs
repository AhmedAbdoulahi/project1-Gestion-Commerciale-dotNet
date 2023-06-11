using mini_projet1.Classes;
using mini_projet1.DF;
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
    public partial class Ajout_ModifierCategorie : Form
    {
        private UserControlCategorie userControlCategorie;
        Gestion_Categorie gc ;
        public Ajout_ModifierCategorie(UserControlCategorie userControlCategorie)
        {
            InitializeComponent();
            this.userControlCategorie = userControlCategorie;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int idselected;
        private void button2_Click(object sender, EventArgs e)
        {
            gc = new Gestion_Categorie();
            //pour l'ajout d'une categorie
            if (lbltitle.Text == "Ajouter Categorie")
            {
                string cat = txtbx1.Text;
                string desc = textBox4.Text;
                
                if (gc.ajouterCategorie(cat, desc) == true)
                {
                    MessageBox.Show("Categorie ajouter avec succes", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    userControlCategorie.gridActualisation();
                    this.Close();
                }
            }
            //pour la modification d'une categorie
            else
            {
                gc.Modifier_Categorie(idselected, txtbx1.Text, textBox4.Text);

                MessageBox.Show("categorie modifier avec succes", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                userControlCategorie.gridActualisation();
                this.Close();
            }
            
        }

        private void Ajout_ModifierCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}

