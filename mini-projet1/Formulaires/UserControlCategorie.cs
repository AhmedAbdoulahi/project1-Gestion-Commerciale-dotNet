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
    public partial class UserControlCategorie : UserControl
    {
        private static UserControlCategorie userControlCategorie;
        mp1 db;
        /*
         * La création d'une instance statique d'un UserControl en .NET permet de créer une seule instance 
         * partagée de ce contrôle qui peut être utilisée par différentes parties de notre application.
         * accessibles depuis n'importe quel endroit de votre application.
         * */
        public static UserControlCategorie Instance
        {
            get
            {
                if (userControlCategorie == null)
                {
                    userControlCategorie = new UserControlCategorie();
                }
                return userControlCategorie;
            }
        }
        public UserControlCategorie()
        {
            InitializeComponent();
        }

        private void UserControlCategorie_Load(object sender, EventArgs e)
        {
            gridActualisation();
        }
        public void gridActualisation()
        {
            db = new mp1();
            List<Categorie> cat = db.Categories.ToList();
            dgcategorie.Rows.Clear();
            foreach (var s in cat)
            {
                dgcategorie.Rows.Add(false, s.id_cat, s.libelle, s.description);
            }
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //formulaire de modification
            Ajout_ModifierCategorie frm = new Ajout_ModifierCategorie(this);
            frm.ShowDialog();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dgcategorie.SelectedCells[0];
            // Accédez à la ligne associée à la cellule sélectionnée
            DataGridViewRow selectedRow = selectedCell.OwningRow;
            Ajout_ModifierCategorie frm = new Ajout_ModifierCategorie(this);
            if (selectedRow != null)
            {

                frm.idselected = (int)Convert.ToInt64(selectedRow.Cells[1].Value);
                frm.txtbx1.Text = selectedRow.Cells[2].Value.ToString();
                frm.textBox4.Text = selectedRow.Cells[3].Value.ToString();

                frm.lbltitle.Text = "Modifier Categorie";
                frm.button1.Visible = false;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("selectionner une ligne", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgcategorie.SelectedRows != null)
            {
                // Récupérez la première cellule 
                DataGridViewCell selectedCell = dgcategorie.SelectedCells[0];
                // Accédez à la ligne associée à la cellule sélectionnée
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                int id_cat = Convert.ToInt32(selectedRow.Cells[1].Value);
                //Client cli = db.Clients.Find(Convert.ToInt32(selectedRow.Cells["id_client"].Value));
                Classes.Gestion_Categorie c = new Classes.Gestion_Categorie();
                c.delete_client(id_cat);
                gridActualisation();

            }
        }
    }
}
