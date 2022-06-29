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
    public partial class FormAngajati : Form
    {
        List<Angajat> listaAngajati = new List<Angajat>();
        public FormAngajati()
        {
            InitializeComponent();
            try
            {
                listaAngajati = DataBaseClass.getListaAngajati();
                foreach (var angajat in listaAngajati) {
                    listBox_angajati.Items.Add(angajat.ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Eroare");
            }
        }

        private void listBox_angajati_MouseDown(object sender, MouseEventArgs e)
        {
            Point myPoint = new Point(e.X, e.Y);
            int index = listBox_angajati.IndexFromPoint(myPoint);
            if(e.Button == MouseButtons.Left)
            {
                listBox_angajati.DoDragDrop(listBox_angajati.Items[index], DragDropEffects.All);
            }
        }

        private void listBox_droppedIn_DragOver(object sender, DragEventArgs e)
        {
            if(e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

 
        private void listBox_droppedIn_DragDrop(object sender, DragEventArgs e)
        {
            listBox_droppedIn.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void btn_stergeAngajati_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox_droppedIn.Items.Count; i++)
            {
                var elementeAngajat = listBox_droppedIn.Items[i].ToString().Split(',');
                string cnpAngajatDeSters = elementeAngajat[1].Trim();
                foreach(var angajat in listaAngajati)
                {
                    if(angajat.CNP == cnpAngajatDeSters)
                    {
                        listaAngajati.Remove(angajat);
                        break;
                    }
                }

                string deleteQuery = "DELETE FROM ANGAJATI_BIBLIOTECA WHERE CNP = '" + cnpAngajatDeSters + "';";
                SqlConnection conn = DataBaseClass.GetConnection();
                SqlCommand comandaStergereAngajat = new SqlCommand(deleteQuery, conn);
                try {
                    conn.Open();
                    comandaStergereAngajat.ExecuteNonQuery(); 
                }
                catch(SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            listBox_angajati.Items.Clear();
            listBox_droppedIn.Items.Clear();
            foreach (var angajat in listaAngajati)
            {
                listBox_angajati.Items.Add(angajat.ToString());
            }
            
        }
    }
}
