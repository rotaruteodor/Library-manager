using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public class Imprumut
    {
        public string idImprumut;
        public string idCarteImprumutata;
        public string cnpAbonat;
        public DateTime dataImprumut;
        public int zileImprumutate;

        public Imprumut(string idImprumut, string idCarteImprumutata, string cnpAbonat, DateTime dataImprumut, int zileImprumutate)
        {
            this.idImprumut = idImprumut;
            this.idCarteImprumutata = idCarteImprumutata;
            this.cnpAbonat = cnpAbonat;
            this.dataImprumut = dataImprumut;
            this.zileImprumutate = zileImprumutate;
        }

        public Imprumut()
        {
            idImprumut = "Necunoscut";
            idCarteImprumutata = "Necunoscut";
            cnpAbonat = "Necunoscut";
            dataImprumut = System.DateTime.Now;
            zileImprumutate = 0;
        }

        public override string ToString()
        {
            return idImprumut + "," + idCarteImprumutata + "," + cnpAbonat + "," + dataImprumut + "," + zileImprumutate;
        }
    }
}
