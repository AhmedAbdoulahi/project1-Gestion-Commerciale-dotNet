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
    public partial class UserControlCommande : UserControl
    {
        private static UserControlCommande userControlCommande;
        //creation d'une instance 
        public static UserControlCommande Instance
        {
            get
            {
                if (userControlCommande == null)
                {
                    userControlCommande = new UserControlCommande();
                }
                return userControlCommande;
            }
        }
        public UserControlCommande()
        {
            InitializeComponent();
        }

        private void UserControlCommande_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

        }
    }
}
