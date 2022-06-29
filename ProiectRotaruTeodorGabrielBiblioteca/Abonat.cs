using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public class Abonat
    {
        public string numeComplet;
        public string CNP;
        public DateTime dataNasterii;
        public string email;
        public string numarDeTelefon;
        public List<string> Idimprumuturi = new List<string>();

        public Abonat(string numeComplet, string CNP, DateTime dataNasterii, string email, string numarDeTelefon, List<string> _Idimprumuturi)
        {
            this.numeComplet = numeComplet;
            this.CNP = CNP;
            this.dataNasterii = dataNasterii;
            this.email = email;
            this.numarDeTelefon = numarDeTelefon;
            if (_Idimprumuturi != null)
            {
                foreach (var Idimprumut in _Idimprumuturi)
                {
                    Idimprumuturi.Add(Idimprumut);
                }
            }
        }

        public Abonat()
        {
            numeComplet = "Nume necunoscut";
            CNP = "CNP necunoscut";
            dataNasterii = System.DateTime.Now;
            email = "Email necunoscut";
            numarDeTelefon = "Numar de telefon necunoscut";
            Idimprumuturi = null;
        }
        public string afisareAbonat()
        {

            return "Detalii abonat:\nNume: " + numeComplet + "\n CNP: " + CNP + "\n Data nasterii: " + dataNasterii.ToString("dd/MM/yyyy") + "\n Email: " + email + "\n Telefon: " + numarDeTelefon;
        }
        public override string ToString()
        {
            if(Idimprumuturi != null)
            {
                string iduri = string.Join("*", Idimprumuturi);
                return numeComplet + "," + CNP + "," + dataNasterii + "," + email + "," + numarDeTelefon + "," + iduri;
            }
            return numeComplet + "," + CNP + "," + dataNasterii + "," + email + "," + numarDeTelefon;
        }
    }
}
