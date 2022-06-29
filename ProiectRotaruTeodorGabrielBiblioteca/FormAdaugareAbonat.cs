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
    public partial class FormAdaugareAbonat : Form
    {
        Form1 f1;
        public FormAdaugareAbonat(Form1 F1)
        {
            InitializeComponent();
            f1 = F1;
        }

        private void btn_adaugaAbonatF3_Click(object sender, EventArgs e)
        {
            int ok = 1;
            foreach (Control child in this.Controls)
            {
                TextBox textBox = child as TextBox;
                if (textBox != null)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        ok = 0;
                    }
                }
            }

            if(ok == 0)
            {
                MessageBox.Show("Casuta nu poate fi goala");
            }

            else if(ok == 1)
            {
                Abonat abonatDeAdaugat = new Abonat(textBox_nume.Text, textBox_CNP.Text,dateTimePicker1.Value , textBox_email.Text, textBox_nrTelefon.Text, null);
                ListViewItem lvi = new ListViewItem(abonatDeAdaugat.numeComplet);
                lvi.SubItems.Add(abonatDeAdaugat.CNP);
                lvi.SubItems.Add(abonatDeAdaugat.dataNasterii.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(abonatDeAdaugat.email);
                lvi.SubItems.Add(abonatDeAdaugat.numarDeTelefon);
                lvi.Tag = abonatDeAdaugat;
                f1.listaAbonati.Add(abonatDeAdaugat);
                f1.listviewAbonatiF1.Items.Add(lvi);
            }
        }
    }
}
