using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;//c'est pour la verification du format d'email

namespace mini_projet1.DF
{
    public partial class Ajout_Modifer_client : Form
    {
        private UserControl userclient;
        private UserControlClient userControlClient;
        Client C ;
        public Ajout_Modifer_client(UserControl u)
        {
            InitializeComponent();
            this.userclient = u;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbx1_Enter(object sender, EventArgs e)
        {
            if (C != null)
            {
                txtbx1.Text = C.nom; txtbx1.ForeColor = Color.White;
            }
            else if (txtbx1.Text=="Nom du client") {
                txtbx1.Text = "";
                txtbx1.ForeColor = Color.White;
            }
        }

        private void txtbx1_Leave(object sender, EventArgs e)
        {
            
            if (txtbx1.Text == "")
            {
                if (C != null)
                {
                    txtbx1.Text = C.nom; txtbx1.ForeColor = Color.White;

                }
                else
                {
                    txtbx1.Text = "Nom du client";
                    txtbx1.ForeColor = Color.Silver;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Prenom du client")
            {
                if (C != null)
                {

                    textBox1.Text = C.prenom; textBox1.ForeColor = Color.White;

                }
                else
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.White;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                if (C != null)
                {
                    textBox1.Text = C.prenom; textBox1.ForeColor = Color.White;

                }
                else
                {
                    textBox1.Text = "Prenom du client";
                    textBox1.ForeColor = Color.Silver;
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Telephone client")
            {
                if (C != null)
                {
                    textBox2.Text = C.tel.ToString(); textBox2.ForeColor = Color.White;
                }
                else
                {
                    textBox2.Text = "";
                    textBox2.ForeColor = Color.White;
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                if (C != null)
                {
                    textBox2.Text = C.tel.ToString(); textBox2.ForeColor = Color.White;
                }
                else
                {
                    textBox2.Text = "Telephone client";
                    textBox2.ForeColor = Color.Silver;
                }
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Adresse 1 client")
            {
                if (C != null)
                {
                    textBox3.Text = C.adresse; textBox3.ForeColor = Color.White;
                }
                else
                {
                    textBox3.Text = "";
                    textBox3.ForeColor = Color.White;
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                if (C != null)
                {
                    textBox3.Text = C.adresse; textBox3.ForeColor = Color.White;
                }
                else
                {
                    textBox3.Text = "Adresse 1 client";
                    textBox3.ForeColor = Color.Silver;
                }
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Adresse 2 client")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.White;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Adresse 2 client";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Email client")
            {
                if (C != null)
                {
                    textBox4.Text = C.email; textBox4.ForeColor = Color.White;
                }
                else
                {
                    textBox4.Text = "";
                    textBox4.ForeColor = Color.White;
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (C != null)
                {
                    textBox4.Text = C.email; textBox4.ForeColor = Color.White;
                }
                else
                {
                    textBox4.Text = "Email client";
                    textBox4.ForeColor = Color.Silver;
                }
            }
        }

        

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox en numerique, ici l'intervalle de code ascii des number pour le numero de telephone
            if(e.KeyChar<48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        //les champs obligatoires
        string champObligatoire()
        {
            if (txtbx1.Text == "" || txtbx1.Text == "Nom de client")
            {
                return "entrer le nom du client";
            }
            if (textBox1.Text == "" || textBox1.Text == "Prenom de client")
            {
                return "entrer prenom de client";
            }
            if (textBox2.Text == "" || textBox2.Text == "Telephone client")
            {
                return "entrer numero de telephone";
            }
            if (textBox3.Text == "" || textBox3.Text == "Adresse 1 client")
            {
                return "entrer l'adresse ";
            }
            if (textBox4.Text == "" || textBox4.Text == "Email client")
            {
                return "entrer email";
            }
            //verification format mail
            if (textBox4.Text != "" || textBox4.Text != "Email client")
            {
                try
                {
                    new MailAddress(textBox4.Text);//permet de verifier le format et non veracite
                }
                catch
                {
                    return "email invalide";
                }
            }

            return null ;
        }
        public int idselected ;
        //pour rappeler que le champs est obligatoire
        private void button2_Click(object sender, EventArgs e)
        {
            if(champObligatoire() != null)
            {
                MessageBox.Show(champObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                Classes.Gestion_client c = new Classes.Gestion_client();
                UserControlClient userclient = new UserControlClient();
                //ajout
                if(lbltitle.Text=="Ajouter Client")
                {
                    if (c.ajouter_client(txtbx1.Text, textBox1.Text, textBox3.Text, int.Parse(textBox2.Text), textBox4.Text) == true)
                    {
                        MessageBox.Show("client ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userclient as UserControlClient).gridActualisation();
                    }
                    else
                    {
                        MessageBox.Show("client existe deja", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                //modification
                else
                {

                  c.Modifier_client(idselected, txtbx1.Text, textBox1.Text, textBox3.Text, int.Parse(textBox2.Text), textBox4.Text) ;
                    
                  MessageBox.Show("client modifier avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  (userclient as UserControlClient).gridActualisation();
                }
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbx1.Text = "Nom de client"; txtbx1.ForeColor = Color.Silver;
            textBox1.Text = "Prenom de client"; textBox1.ForeColor = Color.Silver;
            textBox2.Text = "Telephone client"; textBox2.ForeColor = Color.Silver;
            textBox3.Text = "Adresse 1 client"; textBox3.ForeColor = Color.Silver;
            textBox4.Text = "Email client"; textBox4.ForeColor = Color.Silver;
            textBox5.Text = "Adresse 2 client"; textBox5.ForeColor = Color.Silver;
            
        }

        private void Ajout_Modifer_client_Load(object sender, EventArgs e)
        {

        }
    }
}
