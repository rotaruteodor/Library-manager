using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class PieChartCartiPerLuna : Form
    {
        Form1 f1;
        public PieChartCartiPerLuna(Form1 F1)
        {
            f1 = F1;
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        private void btn_afiseazaPieChart_Click(object sender, EventArgs e)
        {   if (int.TryParse(textBox1.Text, out int x))
            {
                int anIntrodus = int.Parse(textBox1.Text);
                int[] numarCarti = new int[12];

                foreach (var imprumut in f1.listaImprumuturi)
                {
                    if (imprumut.dataImprumut.Year == anIntrodus)
                    {
                        numarCarti[imprumut.dataImprumut.Month - 1]++;
                    }
                }


                pieChart1.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Ianuarie",
                        Values = new ChartValues<double> {numarCarti[0]},
                        //PushOut = 15
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Februarie",
                        Values = new ChartValues<double> {numarCarti[1]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Martie",
                        Values = new ChartValues<double> {numarCarti[2]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Aprilie",
                        Values = new ChartValues<double> {numarCarti[3]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Mai",
                        Values = new ChartValues<double> {numarCarti[4]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Iunie",
                        Values = new ChartValues<double> {numarCarti[5]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Iulie",
                        Values = new ChartValues<double> {numarCarti[6]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "August",
                        Values = new ChartValues<double> {numarCarti[7]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Septembrie",
                        Values = new ChartValues<double> {numarCarti[8]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Octombrie",
                        Values = new ChartValues<double> {numarCarti[9]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Noiembrie",
                        Values = new ChartValues<double> {numarCarti[10]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Decembrie",
                        Values = new ChartValues<double> {numarCarti[11]},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                };

                pieChart1.LegendLocation = LegendLocation.Right;
            }
            else
            {
                MessageBox.Show("Anul introdus nu este corect");
            }
         }
    }
}

