using System;
using System.IO;
namespace SpremanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciljnaDatoteka = Path.Combine(@"D:\My Documents\testNiop\MendicaDeniSystemNiOP.csv");


            Console.WriteLine("Unesite svoje ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite svoje prezime");
            string prezime = Console.ReadLine();
            Console.WriteLine("Unesite svoju godinu rođenja");
            string godRod = Console.ReadLine();
            Console.WriteLine("Unesite svoj e-mail");
            string email = Console.ReadLine();

            addRecord(ime, prezime, godRod, email);

        }

        public static void addRecord(string ime, string prezime, string godRod, string email)
        {

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\MyDocuments / testNiOP/MendicaDeniSystemNiOP.csv", true))
                {
                    file.WriteLine(ime + "" + prezime + "" + godRod + "" + email);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ponovite!", ex);
            }
        }
    }
}