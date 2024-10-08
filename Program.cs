
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main()
    {
        while(true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("[1] Registrera Utryckning");
                Console.WriteLine("[2] Skriv Rapport");
                Console.WriteLine("[3] Registrera Personal");
                Console.WriteLine("[4] Informationssammanställning");
                Console.WriteLine("[5] Avsluta");
                Console.Write("\nMenyval: ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        CrimeInfo.RegCallout();
                        break;
                    case 2:
                        CrimeInfo.Report();
                        break;
                    case 3:
                        EmployeeInfo.RegEmployee();
                        break;
                    case 4:
                        CrimeInfo.Info();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }   
            catch(Exception)
            {
                Console.WriteLine("Du har valt en felaktig input");
                Thread.Sleep(2000);
            }
        }
    }
}
