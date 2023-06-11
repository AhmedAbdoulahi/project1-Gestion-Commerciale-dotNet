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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mini_projet1.Formulaires
{
    public partial class UserControlProduit : UserControl
    {
        mp1 db ;
        private static UserControlProduit userControlProduit;
        //creation d'une instance 
        public static UserControlProduit Instance
        {
            get
            {
                if (userControlProduit == null)
                {
                    userControlProduit = new UserControlProduit();
                }
                return userControlProduit;
            }
        }
        public UserControlProduit()
        {
            InitializeComponent();
            //db = new mp1 ();
        }

        private void UserControlProduit_Load(object sender, EventArgs e)
        {
            gridActualisation();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if(txtRechercher.Text == "Recherche")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = Color.Black;
            }
        }
        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //formulaire d'ajout
            Ajout_ModifierProduit frm = new Ajout_ModifierProduit(this);
            frm.remplir();
            frm.ShowDialog();
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            //formulaire de modification
            Ajout_ModifierProduit frm = new Ajout_ModifierProduit(this);
            frm.lbltitle.Text = "Modifier Produit";
            frm.button1.Visible = false;
            frm.ShowDialog();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgproduit.SelectedRows != null)
            {
                // Récupérez la première cellule 
                DataGridViewCell selectedCell = dgproduit.SelectedCells[0];
                // Accédez à la ligne associée à la cellule sélectionnée
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                int id_prod = Convert.ToInt32(selectedRow.Cells[1].Value);
                Classes.Gestion_produit c = new Classes.Gestion_produit();
                c.delete_produit(id_prod);
                gridActualisation();

            }
        }

        internal void gridActualisation()
        {
            db = new mp1();
            List<Produit> prods = db.Produits.ToList();
            dgproduit.Rows.Clear();
            foreach (var s in prods)
            {
                Categorie c = db.Categories.SingleOrDefault(k => k.id_cat == s.id_cat);
                string lib = c.libelle;
                dgproduit.Rows.Add(false, s.id_prod, s.libelle,s.prix, lib, s.qte);
            }
        }
    }
}
