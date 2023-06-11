using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet1.Classes
{
    
    internal class Gestion_client
    {
        private mp1 db = new mp1(); //base de donnees
        private Client C; //table client
        
        //la fonction qui recois les entrees et les ajoutes dans la base de donnees
        public bool ajouter_client(string nom, string prenom, string addr, int tel, string email)
        {
            C = new Client() ;
            C.nom = nom ;
            C.prenom = prenom ;
            C.adresse = addr ;
            C.tel = tel ; 
            C.email = email ;
            Console.WriteLine(C.nom, C.prenom, C.adresse, C.tel, C.email);
           

            db.Clients.Add(C); //ajouter client
            // db.SaveChanges(); //enregistrer dans la bd
            //db.Clients.Add
            //retourne le nbre d'entite entrees ici 1
            if(db.SaveChanges() == 1)
            {
                return true;
            }
            else
            { return false; }
             
        }
        public bool Modifier_client(int id, string nom, string prenom, string addr, decimal tel, string email)
        {
            //Client cli = db.Clients.Find(id);
            Client cli = new Client() ;
            cli= db.Clients.SingleOrDefault(s => s.id_client == id) ;
            if (cli != null)
            {
                //cli.id_client = id ;
                cli.nom = nom; 
                cli.prenom = prenom ; 
                cli.adresse = addr ; 
                cli.tel = tel ; 
                cli.email = email ;
                //enregistrer les changements
                db.SaveChanges();
                return true;
            }
            else {  
                return false; 
            }
        }
        public void delete_client(int id)
        {
            Client C = new Client() ;
            C = db.Clients.SingleOrDefault(c => c.id_client == id);
            if(C != null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }


    }
}
