using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public partial class FormModificareAbonat : Form
    {
        Form1 f1;
        public FormModificareAbonat(Form1 F1)
        {
            InitializeComponent();
            f1 = F1;
            ucModificareCarteSauAbonat1.textBox1.Text = f1.listviewAbonatiF1.SelectedItems[0].SubItems[0].Text;
            ucModificareCarteSauAbonat1.textBox2.Text = f1.listviewAbonatiF1.SelectedItems[0].SubItems[1].Text;
            ucModificareCarteSauAbonat1.textBox3.Text = f1.listviewAbonatiF1.SelectedItems[0].SubItems[2].Text;
            ucModificareCarteSauAbonat1.textBox4.Text = f1.listviewAbonatiF1.SelectedItems[0].SubItems[3].Text;
            ucModificareCarteSauAbonat1.textBox5.Text = f1.listviewAbonatiF1.SelectedItems[0].SubItems[4].Text;
            Control[] controale = ucModificareCarteSauAbonat1.Controls.Find("buttonUC_actualizeaza", false);
            Button btn_actualizeaza = (Button)controale[0];
            btn_actualizeaza.Click += btn_actualizeaza_Click;
        }

        private void btn_actualizeaza_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            try
            {
                for (int i = 0; i < f1.listaAbonati.Count ; i++)
                {
                    if(f1.listaAbonati[i] == f1.listviewAbonatiF1.SelectedItems[0].Tag)
                    {
                        Abonat abonatDeAdaugat = new Abonat(ucModificareCarteSauAbonat1.textBox1.Text,
                                                            ucModificareCarteSauAbonat1.textBox2.Text,
                                                            DateTime.Parse(ucModificareCarteSauAbonat1.textBox3.Text),
                                                            ucModificareCarteSauAbonat1.textBox4.Text,
                                                            ucModificareCarteSauAbonat1.textBox5.Text,
                                                            f1.listaAbonati[i].Idimprumuturi);
                        f1.listaAbonati[i] = abonatDeAdaugat;
                        f1.listviewAbonatiF1.SelectedItems[0].SubItems[0].Text = f1.listaAbonati[i].numeComplet;
                        f1.listviewAbonatiF1.SelectedItems[0].SubItems[1].Text = f1.listaAbonati[i].CNP;
                        f1.listviewAbonatiF1.SelectedItems[0].SubItems[2].Text = f1.listaAbonati[i].dataNasterii.ToString("dd/MM/yyyy");
                        f1.listviewAbonatiF1.SelectedItems[0].SubItems[3].Text = f1.listaAbonati[i].email;
                        f1.listviewAbonatiF1.SelectedItems[0].SubItems[4].Text = f1.listaAbonati[i].numarDeTelefon;
                        break;

                    }
                }
            }
            catch 
            {
                MessageBox.Show("Datele nu au fost introduse corect");
                eroare = true;
            }

            if (!eroare)
            {
                MessageBox.Show("Abonatul a fost modificat");
                this.Close();
            }
        }
    }
}
