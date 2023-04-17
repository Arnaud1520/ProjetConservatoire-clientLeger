using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;
using Connecte.Modele;
using Connecte.Controler;

namespace Connecte.Vue
{
    public partial class Form1 : Form
    {

        Mgr monManager;

        List<Professeur> lEmp = new List<Professeur>();

      
        
        public Form1()
        {
            InitializeComponent();
// On crée un objet monManager de type Mgr

            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // On appelle le Manager avec la méthode ChargementEmpBD()
            lEmp = monManager.chargementProfBD();

        // méthode qui affiche les employes
        affiche();

            listBoxEleve.Hide();
        }

        public void affiche()

        {


            try
            {

                // Initialisation de la listbox
                listBoxProf.DataSource = null;

             //   lier la listbox avec la collection
                listBoxProf.DataSource = lEmp;

                // Affichage des employes en utilisant la Propriété Description de la classe Employe
                listBoxProf.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            }


        





        private void button1_Click(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            //vide
        }

        private void listBoxEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           listBoxEleve.Show();
        }
    }


            }

           
            
            
        
            
           
        
    

