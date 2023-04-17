using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;
using System.Data;
using Connecte.DAL;

namespace Connecte.DAL
{
    public class ProfesseurDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;

        private static DataTable dt;



        public static void deleteProfesseur(Professeur p)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from prof where id = " + p.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static void insertProfesseur(Professeur p)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "insert into prof values (" + p.Id + ",'" + p.Nom + "','" + p.Prenom + "','" + p.Tel + "'," + p.Mail + "','" + p.Adresse + "','" + p.Instrument + "'," + p.Salaire + ")";



                Ocom = maConnexionSql.reqExec(req);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        public static List<Professeur> getProf()
        {

            List<Professeur> lc = new List<Professeur>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'objer Command
                Ocom = maConnexionSql.reqExec("Select id, nom, prenom, tel, mail, adresse, instrument, salaire from personne join prof on personne.id = prof.idprof");

                // lire les données ligne par ligne avec le reader

                MySqlDataReader reader = Ocom.ExecuteReader();

                Professeur p;



                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération de la ligne
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string mail = (string)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);
                    string instrument = (string)reader.GetValue(6);
                    float salaire = (float)reader.GetValue(7);

                    //Instanciation d'un Professeur
                    p = new Professeur(id, nom, prenom, tel, mail, adresse, instrument, salaire);

                    // Ajout de ce professeur à la liste 
                    lc.Add(p);


                }


                // fermeture du reader
                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


    }
}

