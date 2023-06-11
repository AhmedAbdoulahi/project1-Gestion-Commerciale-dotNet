using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet1.Classes
{
    internal class Gestion_produit
    {
        mp1 db = new mp1();

        internal bool AjouterProduit(string libelle, float qte, int prix, string lib)
        {
            Produit p = new Produit();
            p.libelle = libelle;
            p.qte = qte;
            p.prix = prix;

            List<Categorie> list = new List<Categorie>();
            list = db.Categories.ToList();
            Categorie cat = new Categorie();
            foreach (Categorie c in list)
            {
                if (c.libelle == lib)
                {
                    cat = c;
                    break;
                }
            }
            p.id_cat = cat.id_cat;

            db.Produits.Add(p);
            try
            {
                // Votre code pour enregistrer les entités dans la base de données

                
                if(db.SaveChanges() == 1)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (DbEntityValidationException ex)
            {
                // Parcourir les erreurs de validation pour chaque entité
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    var entity = entityValidationError.Entry.Entity;
                    var validationErrors = entityValidationError.ValidationErrors;

                    // Parcourir les erreurs de validation pour l'entité en cours
                    foreach (var validationError in validationErrors)
                    {
                        var propertyName = validationError.PropertyName;
                        var errorMessage = validationError.ErrorMessage;

                        // Faire quelque chose avec les détails de l'erreur de validation
                        Console.WriteLine("Erreur de validation pour l'entité : " + entity.GetType().Name);
                        Console.WriteLine("Propriété : " + propertyName);
                        Console.WriteLine("Message d'erreur : " + errorMessage);
                    }
                }
            }
            return true;
        }

        internal void delete_produit(int id_prod)
        {
            Produit p = new Produit();
            p = db.Produits.SingleOrDefault(s => p.id_prod == id_prod);
            if (p != null)
            {
                db.Produits.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
