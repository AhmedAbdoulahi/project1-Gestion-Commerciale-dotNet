using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet1.Classes
{
    internal class Gestion_Categorie
    {
        mp1 db = new mp1();
        internal bool ajouterCategorie(string cat, string desc)
        {
            Categorie c = new Categorie();
            c.libelle = cat;
            c.description = desc;
            db.Categories.Add(c);
            if (db.SaveChanges() == 1)
            {
                return true;
            }
            else { 
                return false; 
            }
        }

        internal void delete_client(int id_cat)
        {
            Categorie c = new Categorie();
            c = db.Categories.SingleOrDefault(s=> s.id_cat == id_cat);
            if(c != null)
            {
                db.Categories.Remove(c);
                db.SaveChanges();
            }
        }

        internal bool Modifier_Categorie(int idselected, string text1, string text2)
        {
            //Client cli = db.Clients.Find(id);
            Categorie c = new Categorie();
            c = db.Categories.SingleOrDefault(s => s.id_cat == idselected);
            if (c != null)
            {
                //cli.id_client = id ;
                c.libelle = text1;
                c.description = text2;
                //enregistrer les changements
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
