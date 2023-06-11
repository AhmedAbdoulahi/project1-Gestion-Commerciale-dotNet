using mini_projet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet1.DC
{
    internal class connexion
    {
        //fonction pour verifier la connexion
        public bool connexion_verif(List<Utilisateur> l,string nom, string mdp)
        {
            Utilisateur u = new Utilisateur();
            u.nom = nom;
            u.mdp = mdp;

            foreach(Utilisateur a in l)
            {
                if(a.nom == u.nom && a.mdp == u.mdp)
                {
                    return true;
                }
            }
            return false ;
        }
    }
}
