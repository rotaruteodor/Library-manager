using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public partial class Login : Form
    {
        List<Angajat> listaAngajati = new List<Angajat>();
        List<Panel> listaPanels = new List<Panel>();
        public Login()
        {
            InitializeComponent();
            listaAngajati = DataBaseClass.getListaAngajati();
            textBox_password.PasswordChar = '*';
            textBox1.PasswordChar = '^';
            textBox2.PasswordChar = '^';
            listaPanels.Add(panelPrincipal);
            listaPanels.Add(panel1);
            listaPanels.Add(panel2);
            listaPanels[0].BringToFront();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int ok = 0;
            foreach (var angajat in listaAngajati)
            {
                if (textBox_username.Text == angajat.username && textBox_password.Text == angajat.parola)
                {
                    ok = 1;
                    new Form1().Show();
                    this.Close();
                }
                
            }

            if (ok == 0)
            {
                label_username.ForeColor = Color.Red;
                label_parola.ForeColor = Color.Red;
                MessageBox.Show("Wrong credentials, please try again", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_forgotPassword_Click(object sender, EventArgs e)
        {
            listaPanels[1].BringToFront();
        }

        private void button_contFrgt_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach(var angajat in listaAngajati)
            {
                if(textBox_userFrgtPsswrd.Text == angajat.username)
                {
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Nu a fost gasit niciun cont cu acest username. Incercati din nou!");
            }
            else
            {
                listaPanels[2].BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
            {
                foreach(var angajat in listaAngajati)
                {
                    if(angajat.username == textBox_userFrgtPsswrd.Text)
                    {
                        angajat.parola = textBox1.Text;
                        string updatePasswordQuery = "UPDATE ANGAJATI_BIBLIOTECA SET PAROLA = '" + angajat.parola + "' WHERE CNP = '" + angajat.CNP +"'";
                        SqlConnection conn = DataBaseClass.GetConnection();
                        SqlCommand comandaUpdateParolaAngajat = new SqlCommand(updatePasswordQuery, conn);
                        try
                        {
                            conn.Open();
                            comandaUpdateParolaAngajat.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            conn.Close();
                        }

                        MessageBox.Show("Parola a fost modificata cu succes.", "Operatie finalizata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listaPanels[0].BringToFront();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Parolele nu se potrivesc");
            }
        }
    }
}
