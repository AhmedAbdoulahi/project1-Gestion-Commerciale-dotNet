using mini_projet1.Formulaires;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            panel1.Size = new Size(190, 581);
            pnlParam.Visible = false;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 190)
            {
                panel1.Size = new Size(58, 581) ;
            }
            else
            {
                panel1.Size = new Size(190, 581);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnClient.Top;
            if (!pnlafficher.Controls.Contains(UserControlClient.Instance))
            {
                pnlafficher.Controls.Add(UserControlClient.Instance);
                UserControlClient.Instance.Dock = DockStyle.Fill;
                UserControlClient.Instance.BringToFront();
            }
            else
            {
                UserControlClient.Instance.BringToFront();
            }
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnProduit.Top;
            if (!pnlafficher.Controls.Contains(UserControlProduit.Instance))
            {
                pnlafficher.Controls.Add(UserControlProduit.Instance);
                UserControlProduit.Instance.Dock = DockStyle.Fill;
                UserControlProduit.Instance.BringToFront();
            }
            else
            {
                UserControlProduit.Instance.BringToFront();
            }
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnCategorie.Top;
            if (!pnlafficher.Controls.Contains(UserControlCategorie.Instance))
            {
                pnlafficher.Controls.Add(UserControlCategorie.Instance);
                UserControlCategorie.Instance.Dock = DockStyle.Fill;
                UserControlCategorie.Instance.BringToFront();
            }
            else
            {
                UserControlCategorie.Instance.BringToFront();
            }
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnCommande.Top;
            if (!pnlafficher.Controls.Contains(UserControlCommande.Instance))
            {
                pnlafficher.Controls.Add(UserControlCommande.Instance);
                UserControlCommande.Instance.Dock = DockStyle.Fill;
                UserControlCommande.Instance.BringToFront();
            }
            else
            {
                UserControlCommande.Instance.BringToFront();
            }
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnUtilisateur.Top;
            if (!pnlafficher.Controls.Contains(UserControlUtilisateur.Instance))
            {
                pnlafficher.Controls.Add(UserControlUtilisateur.Instance);
                UserControlUtilisateur.Instance.Dock = DockStyle.Fill;
                UserControlUtilisateur.Instance.BringToFront();
            }
            else
            {
                UserControlUtilisateur.Instance.BringToFront();
            }
        }
        //desactiver le formulaire dès le debut jusqu'à la reussite de la connexion
        public void desactiverForm()
        {
            btnCategorie.Enabled = false;
            btnCommande.Enabled = false;
            btnProduit.Enabled = false;
            btnUtilisateur.Enabled = false;
            btnClient.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            //laisser button connexion active
            button4.Enabled = true;
        }
        //activer le formulire apres authentification
       public void activerForm()
        {
            btnCategorie.Enabled = true;
            btnCommande.Enabled = true;
            btnProduit.Enabled = true;
            btnUtilisateur.Enabled = true;
            btnClient.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            //une fois connecter il faut le desactiver
            button4.Enabled = false;
            //desactiver la visibilite du param
            pnlParam.Visible = false;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void param_Click(object sender, EventArgs e)
        {
            pnlParam.Size = new Size(363, 199) ;
            //pnlParam.Visible = true ;
            pnlParam.Visible = !pnlParam.Visible ;
            pnlParam.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //formulaire connexion
            authentication auth = new authentication(this) ;
            auth.ShowDialog() ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
