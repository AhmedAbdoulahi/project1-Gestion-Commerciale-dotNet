using mini_projet1.DC;
using mini_projet1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projet1.DF
{
    public partial class authentication : Form
    {
        public Form frm;
        private mp1 mp1 = new mp1();
        connexion conn = new connexion();
        List<Utilisateur> users = new List<Utilisateur>() ;
        public authentication(Form Menu)
        {
            InitializeComponent();
            this.frm = Menu ;
            users = new List<Utilisateur>().ToList();
            //lire les utilisateurs a partir de la base de donnees
            //dans la base de donnees on a deux utilisateurs " user1 et user2 " tous avec le mdp est '1234' avec les griffe
            users = mp1.Utilisateurs.ToList();
        }

        private void authentication_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //pour la verification des champs
        public string verification()
        {
            if(txtNom.Text == "" || txtNom.Text == "Nom d'utilisateur")
            {
                return "entrer votre nom ";
            }
            else if(txtMotdepasse.Text == "" || txtMotdepasse.Text == "Mot de passe")
            {
                return "entrer votre mot de passe ";
            }
            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //quitter le formulaire
            this.Close() ;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "" ;
                txtNom.ForeColor = Color.WhiteSmoke ;
            }
        }

        private void txtMotdepasse_Enter(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == "Mot de passe")
            {
                txtMotdepasse.Text = "";
                txtMotdepasse.UseSystemPasswordChar = false;
                txtMotdepasse.PasswordChar = '*';
                txtMotdepasse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtMotdepasse_Leave(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == "")
            {
                txtMotdepasse.Text = "Mot de passe";
                txtMotdepasse.UseSystemPasswordChar = true ;
                txtMotdepasse.ForeColor = Color.Silver ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(verification() == null)
            {
                if (conn.connexion_verif(users, txtNom.Text, txtMotdepasse.Text) == false)
                {
                    //si tout est correcte
                    MessageBox.Show("connexion reussi","connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (frm as menu).activerForm();
                    this.Close();
                }
                else
                {
                    //sinon
                    MessageBox.Show("connexion echoué", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(verification(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
