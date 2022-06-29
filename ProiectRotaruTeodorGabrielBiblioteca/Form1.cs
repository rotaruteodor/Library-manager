using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        string pathForBooksDateBase = @"C:\Users\FOLIO\source\repos\ProiectRotaruTeodorGabrielBiblioteca\BazaDeDateCarti.txt";
        public List<Carte> listaCarti = new List<Carte>();
        string pathForClientsDataBase = @"C:\Users\FOLIO\source\repos\ProiectRotaruTeodorGabrielBiblioteca\BazaDeDateAbonati.txt";
        public List<Abonat> listaAbonati = new List<Abonat>();
        string pathForBorrowingsDataBase = @"C:\Users\FOLIO\source\repos\ProiectRotaruTeodorGabrielBiblioteca\BazaDeDateImprumuturi.txt";
        public List<Imprumut> listaImprumuturi = new List<Imprumut>();
        public bool wasSeeBorrowingsForClientPressed = false;
        public Form1()
        {
            InitializeComponent();
            var carti = File.ReadAllLines(pathForBooksDateBase);
            foreach (var carte in carti)
            {
                var element = carte.Split(',');
                try { listaCarti.Add(new Carte(element[0], element[1], element[2], element[3], int.Parse(element[4]), int.Parse(element[5]))); }
                catch { MessageBox.Show("Eroare. Cartea " + element[1] + " nu a fost adaugata in lista"); }   
            }

            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }

            var abonati = File.ReadAllLines(pathForClientsDataBase);
            foreach(var abonat in abonati)
            {
                List<string> listaIduri = null;
                var element = abonat.Split(',');
                if (5 < element.Length) { listaIduri = element[5].Split('*').ToList(); }
                else listaIduri = null;
                
                try { listaAbonati.Add(new Abonat(element[0], element[1], DateTime.Parse(element[2]), element[3], element[4], listaIduri)); }
                catch { /*MessageBox.Show("Eroare. Clientul " + element[0] + " nu a fost adaugat in lista");*/  }
            }

            foreach(var abonat in listaAbonati)
            {
                ListViewItem lvi = new ListViewItem(abonat.numeComplet);
                lvi.SubItems.Add(abonat.CNP);
                lvi.SubItems.Add(abonat.dataNasterii.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(abonat.email);
                lvi.SubItems.Add(abonat.numarDeTelefon);
                lvi.Tag = abonat;
                listviewAbonatiF1.Items.Add(lvi);
            }

            var imprumuturi = File.ReadAllLines(pathForBorrowingsDataBase);
            foreach(var imprumut in imprumuturi)
            {
                var element = imprumut.Split(',');
                try { listaImprumuturi.Add(new Imprumut(element[0], element[1], element[2], DateTime.Parse(element[3]), int.Parse(element[4]))); }
                catch { MessageBox.Show("Imprumutul n a fost adaugat in lista"); }
            }
        }

        private void dupaCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listviewCartiF1.Items.Clear();
            listaCarti.Sort(new Comparison<Carte>((x,y) => string.Compare(x.categorie, y.categorie)));
           
            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }
        }

        private void dupaAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listviewCartiF1.Items.Clear();
            listaCarti.Sort(new Comparison<Carte>((x, y) => string.Compare(x.autor, y.autor)));

            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }
        }

        private void dupaTitluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listviewCartiF1.Items.Clear();
            listaCarti.Sort(new Comparison<Carte>((x, y) => string.Compare(x.titlu, y.titlu)));

            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }
        }

        private void crescatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listviewCartiF1.Items.Clear();
            listaCarti = listaCarti.OrderBy(x => x.nrPagini).ToList();

            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }
        }

        private void descrescatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listviewCartiF1.Items.Clear();
            listaCarti = listaCarti.OrderByDescending(x => x.nrPagini).ToList();

            foreach (var carte in listaCarti)
            {
                ListViewItem lvi = new ListViewItem(carte.categorie);
                lvi.SubItems.Add(carte.titlu);
                lvi.SubItems.Add(carte.autor);
                lvi.SubItems.Add(carte.nrPagini.ToString());
                lvi.SubItems.Add(carte.stoc.ToString());
                listviewCartiF1.Items.Add(lvi);
                lvi.Tag = carte;
            }
        }

        private void btn_adaugaCarteF1_Click(object sender, EventArgs e)
        {
            FormAdaugareCarte fac = new FormAdaugareCarte(this);
            fac.Show();
        }

        private void button_stergeCarteF1_Click(object sender, EventArgs e)
        {
            while (listviewCartiF1.SelectedItems.Count > 0) {
                listaCarti.Remove((Carte)listviewCartiF1.SelectedItems[0].Tag);
                listviewCartiF1.SelectedItems[0].Remove();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exitF1_Click(object sender, EventArgs e)
        {

            using (StreamWriter outputFile = new StreamWriter(pathForBooksDateBase))
            {
                foreach (var carte in listaCarti)
                    outputFile.WriteLine(carte.ToString());
            }

            using (StreamWriter outputFile2 = new StreamWriter(pathForClientsDataBase))
            {
                foreach (var abonat in listaAbonati)
                    outputFile2.WriteLine(abonat.ToString());
            }

            using (StreamWriter outputFile3 = new StreamWriter(pathForBorrowingsDataBase))
            {
                foreach (var imprumut in listaImprumuturi)
                    outputFile3.WriteLine(imprumut.ToString());
            }
            Application.Exit();
        }

        private void btn_stergeAbonatF1_Click(object sender, EventArgs e) // e de fapt butonul de adaugare, l-am numit gresit
        {
            FormAdaugareAbonat faa = new FormAdaugareAbonat(this);
            faa.Show();
        }

        private void btn_strgAboF1_Click(object sender, EventArgs e)
        {
            while(listviewAbonatiF1.SelectedItems.Count > 0)
            { 
              listaAbonati.Remove((Abonat)listviewAbonatiF1.SelectedItems[0].Tag);
              listviewAbonatiF1.SelectedItems[0].Remove();
            }
        }

        private void veziImprumuturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImprumuturi fi = new FormImprumuturi(this);
            fi.Show();
        }

        private void btn_adaugaImprumutF1_Click(object sender, EventArgs e)
        {
            if (listviewAbonatiF1.SelectedItems.Count == 1 && listviewCartiF1.SelectedItems.Count == 1 && ValidateChildren(ValidationConstraints.Enabled))
            {
                var carteSelectata = (Carte)listviewCartiF1.SelectedItems[0].Tag;
                var abonatSelectat = (Abonat)listviewAbonatiF1.SelectedItems[0].Tag;
                if (carteSelectata.stoc > 0)
                {
                    listaCarti.Find(x => x.id == carteSelectata.id).stoc -= 1;
                    listviewCartiF1.SelectedItems[0].SubItems[4].Text = listaCarti.Find(x => x.id == carteSelectata.id).stoc.ToString();
                    if (listaImprumuturi.Count > 0)
                    {
                        listaImprumuturi.Add(new Imprumut((listaImprumuturi.Select(x => int.Parse(x.idImprumut)).Max() + 1).ToString(),
                            carteSelectata.id, abonatSelectat.CNP, System.DateTime.Now, int.Parse(textbox_zileImprumutateF1.Text)));
                    }
                    else
                    {
                        listaImprumuturi.Add(new Imprumut("1", carteSelectata.id, abonatSelectat.CNP, System.DateTime.Now, int.Parse(textbox_zileImprumutateF1.Text)));
                    }
                    foreach (var abonat in listaAbonati)
                    {
                        if (abonat.CNP == abonatSelectat.CNP)
                        {
                            abonat.Idimprumuturi.Add((listaImprumuturi.Select(x => int.Parse(x.idImprumut)).Max()).ToString());
                        }
                    }
                    MessageBox.Show("Imprumutul a fost adaugat cu succes!", "Operatie finalizata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Aceasta carte nu mai este in stoc. Va rog alegeti alta");
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("Ati facut ceva gresit?", "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Selectati o singura carte si un singur abonat\nIntroduceti numarul de zile, apoi apasati *Adauga imprumut*");
                }
            }
        }

        private void textbox_zileImprumutateF1_Validating(object sender, CancelEventArgs e)
        {
            

            if (string.IsNullOrEmpty(textbox_zileImprumutateF1.Text) || !int.TryParse(textbox_zileImprumutateF1.Text, out int x))
            {
                ErrorProvider errorProvider = new ErrorProvider();
                e.Cancel = true;
                textbox_zileImprumutateF1.Focus();
                errorProvider.SetError(textbox_zileImprumutateF1, "Eroare. Casuta goala sau numar invalid");
            }
            else
            {
                ErrorProvider errorProvider = new ErrorProvider();
                e.Cancel = false;
                errorProvider.SetError(textbox_zileImprumutateF1, null);
            }
        }

        private void veziImprumuturiAbonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listviewAbonatiF1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Va rog selectati un abonat pentru a ii vedea imprumuturile");
            }
            else if(listviewAbonatiF1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Va rog selectati un singur abonat pentru a ii vedea imprumuturile");
            }
            else
            {
                var abonatSelectat = (Abonat)listviewAbonatiF1.SelectedItems[0].Tag;
                var iduriImprumuturi = abonatSelectat.ToString().Split(',').Last();
                if (iduriImprumuturi == "")
                {
                    MessageBox.Show("Acest abonat nu are imprumuturi");
                }
                else
                {
                    wasSeeBorrowingsForClientPressed = true;
                    FormImprumuturi fi = new FormImprumuturi(this);
                    fi.Show();
                }
            }
        }

        private void deschideCharturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PieChartCartiPerLuna(this).Show();
        }

        private void veziAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAngajati().Show();
        }

        private void btn_modificaCarte_Click(object sender, EventArgs e)
        {
            if(listviewCartiF1.SelectedItems.Count == 1)
            {
                new FormModificareCarte(this).Show();
            }

            else { MessageBox.Show("Alegeti o singura carte pentru a o modifica"); }
        }

        private void btn_modificaAbonat_Click(object sender, EventArgs e)
        {
            if(listviewAbonatiF1.SelectedItems.Count == 1)
            {
                new FormModificareAbonat(this).Show();
            }
            else
            {
                MessageBox.Show("Alegeti un singur abonat pentru a il modifica");
            }
        }

        private void deschideChartChartVarsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChartIntervalVarstaAbonati(this).Show();
        }
    }
}
