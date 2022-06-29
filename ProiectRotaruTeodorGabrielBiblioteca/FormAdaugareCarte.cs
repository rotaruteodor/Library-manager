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
    public partial class FormAdaugareCarte : Form
    {

        Form1 f1 = new Form1();
        public FormAdaugareCarte(Form1 F1)
        {
            InitializeComponent();
            f1 = F1;
        }

        private void button_adaugaCarteF2_Click(object sender, EventArgs e)
        {
            int ok = 1;
            foreach (Control child in this.Controls)
            {
                TextBox textBox = child as TextBox;
                if (textBox != null)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Casuta nu poate fi goala");
                        ok = 0;
                    }
                }
            }

            try
            {
                int.Parse(textBox_nrPagini.Text);
                int.Parse(textBox_stoc.Text);
            }
            catch
            {
                MessageBox.Show("Eroare");
                ok = 0;
            }
            if(ok == 1)
            {
                Carte carteDeAdaugat = new Carte((f1.listaCarti.Select(x => int.Parse(x.id)).ToArray().Max()+1).ToString(),
                    textBox_categorie.Text, textBox_titlu.Text, textBox_autor.Text, int.Parse(textBox_nrPagini.Text), int.Parse(textBox_stoc.Text));
                f1.listaCarti.Add(carteDeAdaugat);
                ListViewItem lvi = new ListViewItem(carteDeAdaugat.categorie);
                lvi.SubItems.Add(carteDeAdaugat.titlu);
                lvi.SubItems.Add(carteDeAdaugat.autor);
                lvi.SubItems.Add(carteDeAdaugat.nrPagini.ToString());
                lvi.SubItems.Add(carteDeAdaugat.stoc.ToString());
                lvi.Tag = carteDeAdaugat;
                f1.listviewCartiF1.Items.Add(lvi);
            }
            
        }
    }
}
