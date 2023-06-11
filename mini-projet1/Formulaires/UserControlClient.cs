using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace mini_projet1.DF
{
    public partial class UserControlClient : UserControl
    {
        private mp1 db ;
        private Client client;
        private static UserControlClient userControlClient;
        //creation d'une instance 
        public static UserControlClient Instance { 
            get { 
                if (userControlClient == null) {
                    userControlClient = new UserControlClient();
                }
                return userControlClient; 
            } 
        }
        public UserControlClient()
        {
            InitializeComponent();
            db = new mp1();
            //client = new Client();
            //client = null;
            txtRechercher.Enabled = false;
        }
        public void gridActualisation()
        {
            db = new mp1();
            List<Client> clients = db.Clients.ToList();
            dgclient.Rows.Clear();
            foreach (var s in clients)
            {
                dgclient.Rows.Add(false, s.id_client, s.nom, s.prenom, s.tel, s.email, s.adresse);
            }
        }
        public bool SelectVerification()
        {
            /*for(int i=0; i< dgclient.Rows.Count; i++)
            {
                if ((bool)dgclient.Rows[i].Cells[0].Value == true)
                {
                    nbreLigneSelect++;
                }
            }*/
            // Récupérez la première cellule 
            DataGridViewCell selectedCell = dgclient.SelectedCells[0];
            // Accédez à la ligne associée à la cellule sélectionnée
            DataGridViewRow selectedRow = selectedCell.OwningRow;
            if (selectedRow != null )
            {

                //int IDSELECT = (int)Convert.ToInt64(selectedRow.Cells[1].Value);

                return true;
            }
            return false;
        }
            public void UserControlClient_Load(object sender, EventArgs e)
        {
            gridActualisation();
            //dgclient.DataSource = db.Clients.ToList();
        }
        
        private void textRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher") { 
                txtRechercher.Text = string.Empty;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //formulaire d'ajout
            Ajout_Modifer_client frm = new Ajout_Modifer_client(this);
            frm.ShowDialog();
        }
        
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgclient.SelectedCells[0];
            // Accédez à la ligne associée à la cellule sélectionnée
            DataGridViewRow selectedRow = selectedCell.OwningRow;
            Ajout_Modifer_client frm = new Ajout_Modifer_client(this);
            if (selectedRow != null)
            {

                frm.idselected = (int)Convert.ToInt64(selectedRow.Cells[1].Value);
                frm.txtbx1.Text = selectedRow.Cells[2].Value.ToString();
                frm.textBox1.Text = selectedRow.Cells[3].Value.ToString();
                frm.textBox2.Text = selectedRow.Cells[4].Value.ToString();
                frm.textBox3.Text = selectedRow.Cells[6].Value.ToString();
                frm.textBox4.Text = selectedRow.Cells[5].Value.ToString();
                
                frm.lbltitle.Text = "Modifier Client";
                frm.button1.Visible = false;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("selectionner une ligne","Modification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            
            if (dgclient.SelectedRows != null )
            {
                // Récupérez la première cellule 
                DataGridViewCell selectedCell = dgclient.SelectedCells[0];
                // Accédez à la ligne associée à la cellule sélectionnée
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                int id_client = Convert.ToInt32(selectedRow.Cells[1].Value);
                //Client cli = db.Clients.Find(Convert.ToInt32(selectedRow.Cells["id_client"].Value));
                Classes.Gestion_client c = new Classes.Gestion_client();
                c.delete_client(id_client);
                gridActualisation();
                
            }
            


        }

        private void cmbxRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRechercher.Enabled = true ;
            txtRechercher.Text = "";
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new mp1();
            var liste = db.Clients.ToList();
            if(txtRechercher.Text != "")
            {
                switch (cmbxRecherche.Text)
                {
                    case "Nom":
                        //CurrentCultureIgnoreCase : indique que que ce soit minuscule ou majiscule, ignore la casse
                        // !=-1 indique que ca existe dans la base de donnees
                        liste = liste.Where(s => s.nom.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Prenom":
                        liste = liste.Where(s => s.prenom.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        liste = liste.Where(s => s.email.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        liste = liste.Where(s => s.adresse.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    default:
                        MessageBox.Show("Selectionner une recherche par nom, prenom, email ou adresse", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            //vider
            dgclient.Rows.Clear();
            //charger
            foreach (var l in liste)
            {
                dgclient.Rows.Add(false, l.id_client, l.nom, l.prenom,l.tel, l.email, l.adresse);
            }
        }
    }
}
