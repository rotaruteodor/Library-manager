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
    public partial class ChartIntervalVarstaAbonati : Form
    {
        string[] legendaIntervaleVarste = new string[] { "0-15", "16-30", "31-45", "45-60", "60+" };
        int[] numarAbonatiInIntervalVarsta = new int[5];
        Form1 f1;
        public ChartIntervalVarstaAbonati(Form1 F1)
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            f1 = F1;
            for (int i = 0; i < f1.listaAbonati.Count; i++)
            {
                if((DateTime.Today - f1.listaAbonati[i].dataNasterii).Days/365 <= 15)
                {
                    numarAbonatiInIntervalVarsta[0]++;
                }
                else if ((DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 > 15 && (DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 <= 30)
                {
                    numarAbonatiInIntervalVarsta[1]++;
                }
                else if ((DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 > 30 && (DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 <= 45)
                {
                    numarAbonatiInIntervalVarsta[2]++;
                }
                else if ((DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 > 45 && (DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 <= 60)
                {
                    numarAbonatiInIntervalVarsta[3]++;
                }
                else if ((DateTime.Today - f1.listaAbonati[i].dataNasterii).Days / 365 > 60)
                {
                    numarAbonatiInIntervalVarsta[4]++;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle zonaDisponibila = e.ClipRectangle;
            zonaDisponibila.X += 25;
            zonaDisponibila.Y += 25;
            zonaDisponibila.Width -= 50;
            zonaDisponibila.Height -= 50;
            SolidBrush fundal = new SolidBrush(Color.SeaGreen);
            g.FillRectangle(fundal, zonaDisponibila);
            Pen creionAlb = new Pen(Color.White, 1);
            g.DrawRectangle(creionAlb, zonaDisponibila);

            int leftValue = zonaDisponibila.Left;
            int rightValue = zonaDisponibila.Right;
            int bottomValue = zonaDisponibila.Bottom;
            int topValue = zonaDisponibila.Top;
            float distanta_lat = 0.3f, max;
            int latimeDreptunghi, distantaIntreDreptunghiuri;

            SolidBrush[] pensule = new SolidBrush[]
            {
                new SolidBrush(Color.DarkBlue),
                new SolidBrush(Color.DarkViolet),
                new SolidBrush(Color.DarkMagenta),
                new SolidBrush(Color.DarkRed),
                new SolidBrush(Color.DarkOrange)
            };

            SolidBrush pensulaCurenta;
            Pen creionCurent;
            


            latimeDreptunghi = (rightValue - leftValue) / (int)(6 * distanta_lat + 6);
            distantaIntreDreptunghiuri = (int)(latimeDreptunghi * distanta_lat);

            max = numarAbonatiInIntervalVarsta[0];
            for (int i = 0; i < numarAbonatiInIntervalVarsta.Length; i++)
            {
                if(max < numarAbonatiInIntervalVarsta[i])
                {
                    max = numarAbonatiInIntervalVarsta[i];
                }
            }

            creionCurent = new Pen(Color.Firebrick);
            g.DrawLine(creionCurent, leftValue, topValue, leftValue, bottomValue);
            g.DrawLine(creionCurent, leftValue, bottomValue, rightValue, bottomValue);

            for (int i = 0; i < numarAbonatiInIntervalVarsta.Length; i++)
            {
                pensulaCurenta = pensule[i % 6];
                PointF p = new PointF(leftValue+distantaIntreDreptunghiuri+ i * (latimeDreptunghi + distantaIntreDreptunghiuri), bottomValue-numarAbonatiInIntervalVarsta[i]*(bottomValue-topValue)/max);
                SizeF s = new SizeF(latimeDreptunghi, numarAbonatiInIntervalVarsta[i] * (bottomValue - topValue) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(p, s));

                string intervalVarsta = legendaIntervaleVarste[i] + " (" + numarAbonatiInIntervalVarsta[i].ToString() + ")";
                g.DrawString(intervalVarsta, new Font("Arial", 10), pensulaCurenta, leftValue + distantaIntreDreptunghiuri + i * (latimeDreptunghi + distantaIntreDreptunghiuri) + latimeDreptunghi / 3, bottomValue + 5);
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Invalidate();
        }
    }
}
