using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProiectRotaruTeodorGabrielBiblioteca
{
    public static class DataBaseClass
    {
        public static SqlConnection GetConnection()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBaseProiectPAW;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        public static void adaugaAngajatInBD(Angajat angajatDeAdaugat)
        {
            string insertStr = "INSERT INTO ANGAJATI_BIBLIOTECA " + "VALUES (@angajatDeAdaugat.numeComplet, @angajatDeAdaugat.functie, @angajatDeAdaugat.username, @angajatDeAdaugat.parola, @angajatDeAdaugat.CNP)";
            SqlConnection conn = GetConnection();
            SqlCommand comandaAdaugaAngajat = new SqlCommand(insertStr, conn);
            comandaAdaugaAngajat.Parameters.AddWithValue("@angajatDeAdaugat", angajatDeAdaugat);
            try
            {
                conn.Open();
                comandaAdaugaAngajat.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
    
        public static List<Angajat> getListaAngajati()
        {
            List<Angajat> listaAngajati = new List<Angajat>();
            SqlConnection conn = GetConnection();
            string selectAngajati = "SELECT * FROM ANGAJATI_BIBLIOTECA";
            SqlCommand comandaSelectAngajati = new SqlCommand(selectAngajati, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comandaSelectAngajati.ExecuteReader();
                while (reader.Read())
                {
                    Angajat angajatDeAdaugat = new Angajat(reader["CNP"].ToString().Trim(),
                        reader["NUME_COMPLET"].ToString().Trim(),
                        reader["FUNCTIE"].ToString().Trim(),
                        reader["USERNAME"].ToString().Trim(),
                        reader["PAROLA"].ToString().Trim());

                    listaAngajati.Add(angajatDeAdaugat);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return listaAngajati;
        }
        

    }
}
