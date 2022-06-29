using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public class Carte
    {
        public string id;
        public string categorie;
        public string titlu;
        public string autor;
        public int nrPagini;
        public int stoc;

        public Carte(string _id, string _categorie, string _titlu, string _autor, int _nrPagini, int _stoc)
        {
            id = _id;
            categorie = _categorie;
            titlu = _titlu;
            autor = _autor;
            if(_nrPagini > 0)
            {
                nrPagini = _nrPagini;
            }

            else
            {
                nrPagini = 0;
            }
            if (_stoc > 0)
            {
                stoc = _stoc;
            }
            else
            {
                stoc = 0;
            }
        }

        public Carte()
        {
            id = "Id necunoscut";
            categorie = "Categorie necunoscuta";
            titlu = "Titlu necunoscut";
            autor = "Autor necunoscut";
            nrPagini = 0;
            stoc = 0;
        }

        public string afisareCarte()
        {
            return "Detalii carte:\n Id: " + id + "\nTitlu: " + titlu + "\nCategorie: " + categorie + "\nAutor: " + autor + "\nNumar pagini: " + nrPagini;
        }

        public override string ToString()
        {
            return id+ "," + categorie + "," + titlu + "," + autor + "," + nrPagini + "," + stoc;
        }
    }
}
