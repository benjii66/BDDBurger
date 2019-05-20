using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BDDBurger
{
    public static class Data
    {
        #region Attributs sous forme de propriétés: syntaxe contractée

        public static string UneChaineConnexionBdd { get; set; }

        public static MySqlConnection UneConnexionMySQL { get; set; }

        public static string UneReqSql { get; set; }

        public static MySqlCommand UneCommandeMySql { get; set; }

        public static MySqlDataReader UnMySQLDataReader { get; set; }


        /// <summary>
        /// La c'est les classes liées aux tables de la bdd
        /// </summary>

        public static Burger UnBurger { get; set; }

        public static List<Burger> LesBurgers { get; set; }

        public static Categorie UneCategorie { get; set; }

        public static List<Categorie> LesCategories { get; set; }

        public static Commande UneCommande { get; set; }

        public static List<Commande> LesCommandes { get; set; }

        #endregion

        #region Méthode SQL
        /// <summary>
        /// Définit et ouvre la connexion à la base de données
        /// </summary>
        public static void ConnexionMySQL()
        {
            // affecter la valeur à la chaine de connexion
            UneChaineConnexionBdd = "Server=127.0.0.1;Database=magic;Uid=root;Pwd=;";
            // instancier l'objet connexion
            UneConnexionMySQL = new MySqlConnection(UneChaineConnexionBdd);
            try
            {
                // essaie d'ouvrir la connexion
                UneConnexionMySQL.Open();
                // message de réussite
                MessageBox.Show("Tu es connecté Benji !", "Connexion Bdd MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException uneExceptionMySQL)
            {
                // message d'erreur
                MessageBox.Show("Erreur = " + uneExceptionMySQL.Message, "Connexion à la BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Méthode Catégorie



        /// <summary>
        /// Insère une nouvelle catégorie dans la base de données
        /// </summary>
        /// <param name="pCategorie"></param>
        /// <returns></returns>
        public static bool CreateCategorie(Categorie pCategorie)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
            {
                ConnexionMySQL();
            }
            // prépare la requête SQL
            UneReqSql = "insert into categorie (libelle, description, image) values ("
                        + "'" + pCategorie.Libelle + "',"
                        + "'" + pCategorie.Description + "', "
                        + "'" + pCategorie.Image + "')";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Sélectionne toutes les catégories de la base de données
        /// et les charge dans la collection LesBurgers
        /// </summary>
        public static void SelectAllCategories()
        {
            //
            LesCategories = new List<Categorie>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "select id,libelle,description,image from categorie";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UneCategorie = new Categorie();
                    UneCategorie.Id = UnMySQLDataReader.GetInt32(0);
                    UneCategorie.Libelle = UnMySQLDataReader.GetString(1);
                    UneCategorie.Description = UnMySQLDataReader.GetString(2);
                    UneCategorie.Image = UnMySQLDataReader.GetString(3);

                    LesCategories.Add(UneCategorie);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        /// <summary>
        /// Modifie la catégorie passé en paramètre
        /// </summary>
        /// <param name="pCategorie"></param>
        /// <returns></returns>
        public static bool UpdateCategorie(Categorie pCategorie)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "update categorie set libelle ='" + pCategorie.Libelle + "', description ='" + pCategorie.Description + "', image ='" + pCategorie.Image + "' where id='" + pCategorie.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Supprime une catégorie
        /// </summary>
        /// <param name="pCategorie"></param>
        public static bool DeleteCategorie(Categorie pCategorie)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "delete from categorie where id ='" + pCategorie.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        #endregion

        
        #region Méthode Burger

        /// <summary>
        /// Insère un nouveau burger dans la base de données
        /// </summary>
        /// <param name="pBurger"></param>
        /// <returns></returns>
        public static bool CreateBurger(Burger pBurger)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "insert into produit (id, libelle, description_court, description_long, image_principale, image_secondaire1, image_secondaire2, prix) values ("
                        + "'" + pBurger.Id + "', "
                        + "'" + pBurger.Libelle + "', "
                        + "'" + pBurger.DescriptionCourte + "', "
                        + "'" + pBurger.DescriptionLongue + "',"
                        + "'" + pBurger.ImagePrincipale + "',"
                        + "'" + pBurger.ImageSecondaire + "',"
                        + "'" + pBurger.ImageSecondaire2 + "',"
                        + "'" + pBurger.Prix + "')";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Sélectionne tous les burgers de la base de données
        /// et les charge dans la collection LesBurgers
        /// </summary>
        public static void SelectAllBurger()
        {
            //
            LesBurgers = new List<Burger>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, libelle, description_court, description_long, image_principale, image_secondaire1, image_secondaire2, prix from produit";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UnBurger = new Burger();
                    UnBurger.Id = UnMySQLDataReader.GetInt32(0);
                    UnBurger.Libelle = UnMySQLDataReader.GetString(1);
                    UnBurger.DescriptionCourte = UnMySQLDataReader.GetString(2);
                    UnBurger.DescriptionLongue = UnMySQLDataReader.GetString(3);
                    UnBurger.ImagePrincipale = UnMySQLDataReader.GetString(4);
                    UnBurger.ImageSecondaire = UnMySQLDataReader.GetString(5);
                    UnBurger.ImageSecondaire2 = UnMySQLDataReader.GetString(6);
                    UnBurger.Prix = UnMySQLDataReader.GetString(7);

                    LesBurgers.Add(UnBurger);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }
  

        /// <summary>
        /// Modifie le burger passé en paramètre
        /// </summary>
        /// <param name="pBurger"></param>
        /// <returns></returns>
        public static bool UpdateBurger(Burger pBurger)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "update produit set id ='" + pBurger.Id + "', libelle ='" + pBurger.Libelle + "', description_court ='" + pBurger.DescriptionCourte + "', description_long ='" + pBurger.DescriptionLongue + "', image_principale ='" + pBurger.ImagePrincipale + "', image_secondaire1 ='" + pBurger.ImageSecondaire + "', image_secondaire2 ='" + pBurger.ImageSecondaire2 + "', prix ='" + pBurger.Prix + "' where id ='" + pBurger.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Supprime un burger
        /// </summary>
        /// <param name="pBurger"></param>
        public static bool DeleteBurger(Burger pBurger)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "delete from produit where id ='" + pBurger.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }




        #endregion


        #region Méthode Commande 

        /// <summary>
        /// Insère une nouvelle commande dans la base de données
        /// </summary>
        /// <param name="pCommande"></param>
        /// <returns></returns>
        public static bool CreateCommande(Commande pCommande)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "insert into commande (id, full_name, email, address, city, zip_code, telephone, created_at) values ("
                        + "'" + pCommande.NomComplet + "',"
                        + "'" + pCommande.Email + "', "
                        + "'" + pCommande.Adresse + "',"
                        + "'" + pCommande.Ville + "',"
                        + "'" + pCommande.CodePostal + "',"    
                        + "'" + pCommande.Telephone + "',"
                        + "'" + pCommande.CreeLe + "')";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Sélectionne toutes les commandes de la base de données
        /// et les charge dans la collection LesCommandes
        /// </summary>
        public static void SelectAllCommande()
        {
            //
            LesCommandes = new List<Commande>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, full_name, email, address, city, zip_code, telephone, created_at from commande";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UneCommande = new Commande();
                    UneCommande.Id = UnMySQLDataReader.GetInt32(0);
                    UneCommande.NomComplet = UnMySQLDataReader.GetString(1);
                    UneCommande.Email = UnMySQLDataReader.GetString(2);
                    UneCommande.Adresse = UnMySQLDataReader.GetString(3);
                    UneCommande.Ville = UnMySQLDataReader.GetString(4);
                    UneCommande.CodePostal = UnMySQLDataReader.GetString(5);
                    UneCommande.Telephone = UnMySQLDataReader.GetString(6);
                    UneCommande.CreeLe = UnMySQLDataReader.GetString(7);

                    LesCommandes.Add(UneCommande);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        /// <summary>
        /// Modifie la commande passée en paramètre
        /// </summary>
        /// <param name="pCommande"></param>
        /// <returns></returns>
        public static bool UpdateCommande(Commande pCommande)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "update commande set id ='" + pCommande.Id + "', full_name ='" + pCommande.NomComplet + "', email ='" + pCommande.Email + "', address ='" + pCommande.Adresse + "', city ='" + pCommande.Ville + "', zip_code ='" + pCommande.CodePostal + "', telephone ='" + pCommande.Telephone + "' where id='" + pCommande.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Supprime une commande
        /// </summary>
        /// <param name="pCommande"></param>
        public static bool DeleteCommande(Commande pCommande)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "delete from commande where id ='" + pCommande.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }





        #endregion

        #region  Méthode Utilisateur 

        /// <summary>
        /// Insère une nouvelle commande dans la base de données
        /// </summary>
        /// <param name="pUtilisateur"></param>
        /// <returns></returns>
        public static bool CreateUtilisateur(Commande pUtilisateur)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "insert into commande (full_name, email, address, city, zip_code, telephone, created_at) values ("
                        + "'" + pUtilisateur.NomComplet + "',"
                        + "'" + pUtilisateur.Email + "', "
                        + "'" + pUtilisateur.Adresse + "',"
                        + "'" + pUtilisateur.Ville + "',"
                        + "'" + pUtilisateur.CodePostal + "',"
                        + "'" + pUtilisateur.Telephone + "',"
                        + "'" + pUtilisateur.CreeLe + "')";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Sélectionne toutes les commandes de la base de données
        /// et les charge dans la collection LesCommandes
        /// </summary>
        public static void SelectAllUtilsateur  ()
        {
            //
            LesCommandes = new List<Commande>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, full_name, email, address, city, zip_code, telephone, created_at from commande";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UneCommande = new Commande();
                    UneCommande.Id = UnMySQLDataReader.GetInt32(0);
                    UneCommande.NomComplet = UnMySQLDataReader.GetString(1);
                    UneCommande.Email = UnMySQLDataReader.GetString(2);
                    UneCommande.Adresse = UnMySQLDataReader.GetString(3);
                    UneCommande.Ville = UnMySQLDataReader.GetString(4);
                    UneCommande.CodePostal = UnMySQLDataReader.GetString(5);
                    UneCommande.Telephone = UnMySQLDataReader.GetString(6);
                    UneCommande.CreeLe = UnMySQLDataReader.GetString(7);

                    LesCommandes.Add(UneCommande);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        /// <summary>
        /// Modifie la commande passée en paramètre
        /// </summary>
        /// <param name="pUtilisateur"></param>
        /// <returns></returns>
        public static bool UpdateUtilisateur(Commande pUtilisateur)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "update commande set full_name ='" + pUtilisateur.NomComplet + "', email ='" + pUtilisateur.Email + "', address ='" + pUtilisateur.Adresse + "', city'" + pUtilisateur.Ville + "', zip_code'" + pUtilisateur.CodePostal + "', telephone'" + pUtilisateur.Telephone + "' where id='" + pUtilisateur.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Supprime une commande
        /// </summary>
        /// <param name="pUtilisateur"></param>
        public static bool DeleteUtilisateur(Commande pUtilisateur)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnexionMySQL();

            // prépare la requête SQL
            UneReqSql = "delete from commande where id ='" + pUtilisateur.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }



        #endregion

    }
}