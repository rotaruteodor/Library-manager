using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public class Angajat
    {
        public string CNP;
        public string numeComplet;
        public string functie;
        public string username;
        public string parola;

        public Angajat(string cNP, string numeComplet, string functie, string username, string parola)
        {
            CNP = cNP;
            this.numeComplet = numeComplet;
            this.functie = functie;
            this.username = username;
            this.parola = parola;
        }

        public override string ToString()
        {
            return numeComplet + ", " + CNP + ", " + functie + ", " + username;
        }
    }
}
