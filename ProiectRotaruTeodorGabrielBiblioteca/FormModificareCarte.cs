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
    public partial class FormModificareCarte : Form
    {
        Form1 f1;
        public FormModificareCarte(Form1 F1)
        {
            InitializeComponent();
            f1 = F1;
            ucModificareCarteSauAbonat1.textBox1.Text = f1.listviewCartiF1.SelectedItems[0].SubItems[0].Text;
            ucModificareCarteSauAbonat1.textBox2.Text = f1.listviewCartiF1.SelectedItems[0].SubItems[1].Text;
            ucModificareCarteSauAbonat1.textBox3.Text = f1.listviewCartiF1.SelectedItems[0].SubItems[2].Text;
            ucModificareCarteSauAbonat1.textBox4.Text = f1.listviewCartiF1.SelectedItems[0].SubItems[3].Text;
            ucModificareCarteSauAbonat1.textBox5.Text = f1.listviewCartiF1.SelectedItems[0].SubItems[4].Text;
            Control[] controale = ucModificareCarteSauAbonat1.Controls.Find("buttonUC_actualizeaza", false);
            Button btn_actualizeaza = (Button)controale[0];
            btn_actualizeaza.Click += btn_actualizeaza_Click;
        }

    

    
        private void btn_actualizeaza_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            try
            {

                Carte carteDeAdaugat = new Carte(f1.listaCarti.Find(x => x == f1.listviewCartiF1.SelectedItems[0].Tag).id,   //f1.listviewCartiF1.SelectedItems[0].SubItems[0].Text,
                    ucModificareCarteSauAbonat1.textBox1.Text,
                    ucModificareCarteSauAbonat1.textBox2.Text,
                    ucModificareCarteSauAbonat1.textBox3.Text,
                int.Parse(ucModificareCarteSauAbonat1.textBox4.Text),
                int.Parse(ucModificareCarteSauAbonat1.textBox5.Text));

                for (int i = 0; i < f1.listaCarti.Count; i++)
                {
                    if(f1.listaCarti[i] == f1.listviewCartiF1.SelectedItems[0].Tag)
                    {
                        f1.listaCarti[i] = carteDeAdaugat;
                        f1.listviewCartiF1.SelectedItems[0].SubItems[0].Text = f1.listaCarti[i].categorie;
                        f1.listviewCartiF1.SelectedItems[0].SubItems[1].Text = f1.listaCarti[i].titlu;
                        f1.listviewCartiF1.SelectedItems[0].SubItems[2].Text = f1.listaCarti[i].autor;
                        f1.listviewCartiF1.SelectedItems[0].SubItems[3].Text = f1.listaCarti[i].nrPagini.ToString();
                        f1.listviewCartiF1.SelectedItems[0].SubItems[4].Text = f1.listaCarti[i].stoc.ToString();
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Datele nu au fost introduse corect", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eroare = true;
            }

            if (!eroare)
            {
                MessageBox.Show("Cartea a fost actualizata");
                this.Close();
            }
        }


    }
}
