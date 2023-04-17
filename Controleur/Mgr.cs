using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;

namespace Connecte.Controler
{

    public class Mgr
    {
        ProfesseurDAO profDAO = new ProfesseurDAO();


        // La liste d'employés qu'on va utiliser dans toutes les méthodes
        List<Professeur> maListeProfesseur;

        public Mgr()
        {
            // Instanciation de la liste
            maListeProfesseur = new List<Professeur>();
        }

        public List<Professeur> chargementProfBD()
        {
            //Appel de la méthode statique getEmployes dela classe EmployeDAO
            maListeProfesseur = ProfesseurDAO.getProf();

            return (maListeProfesseur);
        }

        public void deleteProf(Professeur p)
        {

            ProfesseurDAO.deleteProfesseur(p);

        }


        // Insertion d'un nouvel Employe
        public void insertProf(Professeur p)
        {

            ProfesseurDAO.insertProfesseur(p);

        }

    }
}
