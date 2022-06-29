using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public partial class FormImprumuturi : Form
    {
        Form1 f1 = new Form1();
        public FormImprumuturi(Form1 F1)
        {
            InitializeComponent();
            f1 = F1;
            if (f1.wasSeeBorrowingsForClientPressed == true)
            {
                f1.wasSeeBorrowingsForClientPressed = false;
                var abonatSelectat = (Abonat)f1.listviewAbonatiF1.SelectedItems[0].Tag;
                var iduriImprumuturi = abonatSelectat.ToString().Split(',').Last();

                    foreach (var imprumut in f1.listaImprumuturi)
                    {
                        var id = iduriImprumuturi.Split('*');
                        if (id.Contains(imprumut.idImprumut)){
                            ListViewItem lvi = new ListViewItem(imprumut.idCarteImprumutata);
                            lvi.SubItems.Add(imprumut.cnpAbonat);
                            lvi.SubItems.Add(imprumut.dataImprumut.ToString("dd/MM/yyyy"));
                            lvi.SubItems.Add(imprumut.zileImprumutate.ToString());
                            lvi.Tag = imprumut;
                            listview_imprumuturi.Items.Add(lvi);
                        }
                }
            }
            else
            {
                foreach (var imprumut in f1.listaImprumuturi)
                {
                    ListViewItem lvi = new ListViewItem(imprumut.idCarteImprumutata);
                    lvi.SubItems.Add(imprumut.cnpAbonat);
                    lvi.SubItems.Add(imprumut.dataImprumut.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(imprumut.zileImprumutate.ToString());
                    lvi.Tag = imprumut;
                    listview_imprumuturi.Items.Add(lvi);
                }
            }
        }

        private void btn_detaliiImprumut_Click(object sender, EventArgs e)
        {
            if(listview_imprumuturi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Va rog alegeti un imprumut pentru care doriti detaliile");
            }
            else if(listview_imprumuturi.SelectedItems.Count > 1)
            {
                MessageBox.Show("Va rog alegeti un singur imprumut pentru care doriti detaliile");
            }
            else
            {
                foreach(var abonat in f1.listaAbonati)
                {
                    if(listview_imprumuturi.SelectedItems[0].SubItems[1].Text == abonat.CNP)
                    {
                        MessageBox.Show("Id imprumut: "+((Imprumut)listview_imprumuturi.SelectedItems[0].Tag).idImprumut +"\n\n"+
                            abonat.afisareAbonat() + 
                            "\n\n" + 
                            (f1.listaCarti.Find(x => x.id == listview_imprumuturi.SelectedItems[0].SubItems[0].Text)).afisareCarte(),
                            "Detalii imprumut");
                    }
                }
            }
        }

        private void btn_stergeImprumut_Click(object sender, EventArgs e)
        {
            while(listview_imprumuturi.SelectedItems.Count > 0)
            {
                foreach(var abonat in f1.listaAbonati)
                {
                  
                    foreach(var idImprumut in abonat.Idimprumuturi)
                    {

                        if(idImprumut == ((Imprumut)listview_imprumuturi.SelectedItems[0].Tag).idImprumut)
                        {
                            abonat.Idimprumuturi.Remove(idImprumut);
                            break;
                        }
                    }
                }
                f1.listaImprumuturi.Remove((Imprumut)listview_imprumuturi.SelectedItems[0].Tag);
                listview_imprumuturi.SelectedItems[0].Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listview_imprumuturi.SelectedItems.Count < 1)
            {
                MessageBox.Show("Va rog selectati un imprumut pentru a il modifica");
            }
            else if(listview_imprumuturi.SelectedItems.Count > 1)
            {
                MessageBox.Show("Va rog selectati un singur imprumut pentru a il modifica");
            }
            else
            {
                textBox_IDCarte.Text = listview_imprumuturi.SelectedItems[0].SubItems[0].Text;
                textBox_CNPAbonat.Text = listview_imprumuturi.SelectedItems[0].SubItems[1].Text;
                textBoxDataImprumut.Text = listview_imprumuturi.SelectedItems[0].SubItems[2].Text;
                textBoxZileImprumutate.Text = listview_imprumuturi.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btn_salveazaModificarile_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                for (int i = 0; i < f1.listaImprumuturi.Count; i++)
                {
                    if (f1.listaImprumuturi[i].idImprumut == ((Imprumut)listview_imprumuturi.SelectedItems[0].Tag).idImprumut)
                    {
                        f1.listaImprumuturi[i] = new Imprumut(f1.listaImprumuturi[i].idImprumut, textBox_IDCarte.Text, textBox_CNPAbonat.Text, DateTime.Parse(textBoxDataImprumut.Text), int.Parse(textBoxZileImprumutate.Text));
                        listview_imprumuturi.SelectedItems[0].SubItems[0].Text = f1.listaImprumuturi[i].idCarteImprumutata;
                        listview_imprumuturi.SelectedItems[0].SubItems[1].Text = f1.listaImprumuturi[i].cnpAbonat;
                        listview_imprumuturi.SelectedItems[0].SubItems[2].Text = f1.listaImprumuturi[i].dataImprumut.ToString("dd/MM/yyyy");
                        listview_imprumuturi.SelectedItems[0].SubItems[3].Text = f1.listaImprumuturi[i].zileImprumutate.ToString();
                        listview_imprumuturi.SelectedItems[0].Tag = f1.listaImprumuturi[i];
                        break;
                    }
                }
            }

            textBoxDataImprumut.Text = "";
            textBoxZileImprumutate.Text = "";
            textBox_CNPAbonat.Text = "";
            textBox_IDCarte.Text = "";
        }

        private void textBox_IDCarte_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(textBox_IDCarte.Text))
            {
                e.Cancel = true;
                textBox_IDCarte.Focus();
                errorProvider.SetError(textBox_IDCarte, "Eroare.Casuta goala");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_IDCarte, null);
            }
        }

        private void textBox_CNPAbonat_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(textBox_CNPAbonat.Text))
            {
                e.Cancel = true;
                textBox_IDCarte.Focus();
                errorProvider.SetError(textBox_CNPAbonat, "Eroare.Casuta goala");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_CNPAbonat, null);
            }
        }

        private void textBoxDataImprumut_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(textBoxDataImprumut.Text) || !DateTime.TryParse(textBoxDataImprumut.Text, out DateTime x))
            {
                e.Cancel = true;
                textBox_IDCarte.Focus();
                errorProvider.SetError(textBoxDataImprumut, "Eroare.Casuta goala sau data invalida");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxDataImprumut, null);
            }
        }

        private void textBoxZileImprumutate_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(textBoxZileImprumutate.Text) || !int.TryParse(textBoxZileImprumutate.Text, out int x))
            {
                e.Cancel = true;
                textBox_IDCarte.Focus();
                errorProvider.SetError(textBoxZileImprumutate, "Eroare.Casuta goala sau numar invalid");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxZileImprumutate, null);
            }
        }

        int currentPrintPos;

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            currentPrintPos = -1;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            currentPrintPos++;
            if (listview_imprumuturi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Va rog alegeti un imprumut pentru care doriti detaliile");
            }
            else
            {
                Font font = new Font("Times New Roman", 14, FontStyle.Regular);
                e.PageSettings.PaperSize = new PaperSize("A4", 850, 1100);
                float fontHeight = font.GetHeight();
                int startX = 40;
                int startY = 30;
                int offsetY = 40;

               
                float pageWidth = e.PageSettings.PrintableArea.Width;
                float pageHeight = e.PageSettings.PrintableArea.Height;

                while(currentPrintPos < listview_imprumuturi.SelectedItems.Count)
                {
                    foreach (var abonat in f1.listaAbonati)
                    {    
                        if (listview_imprumuturi.SelectedItems[currentPrintPos].SubItems[1].Text == abonat.CNP)
                        {
                            e.Graphics.DrawString("****************************************\nId imprumut: " + ((Imprumut)listview_imprumuturi.SelectedItems[currentPrintPos].Tag).idImprumut +
                                "\nData imprumut: " + listview_imprumuturi.SelectedItems[currentPrintPos].SubItems[2].Text +
                                "\nZile imprumutate: " + listview_imprumuturi.SelectedItems[currentPrintPos].SubItems[3].Text + "\n\n" +
                                abonat.afisareAbonat() +
                                "\n\n" +
                                (f1.listaCarti.Find(x => x.id == listview_imprumuturi.SelectedItems[currentPrintPos].SubItems[0].Text)).afisareCarte(),
                                font,
                                Brushes.Black,
                                startX, startY+offsetY);
               
                                                        
                            offsetY += 500;

                            if (offsetY+500 >= pageHeight)
                            {
                                e.HasMorePages = true;
                                offsetY = 0;
                                return; // you need to return, then it will go into this function again
                            }
                            else
                            {
                                e.HasMorePages = false;
                            }

                            break;
                        }
                        
                        
                    }
                    currentPrintPos++;
                }
            }   
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
        
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                
            }    
        }
    }
}