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
    public partial class UserControlUtilisateur : UserControl
    {
        private static UserControlUtilisateur userControlUtilisateur;
        //creation d'une instance 
        public static UserControlUtilisateur Instance
        {
            get
            {
                if (userControlUtilisateur == null)
                {
                    userControlUtilisateur = new UserControlUtilisateur();
                }
                return userControlUtilisateur;
            }
        }
        public UserControlUtilisateur()
        {
            InitializeComponent();
        }

        private void UserControlUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
