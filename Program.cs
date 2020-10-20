using System;

namespace BookInterfaceExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFileWriter fileWriter;

            Console.Write("Namnge filen:");
            string filNamn = Console.ReadLine();

            Console.WriteLine("Vill du spara filen i .txt, .xml, .sln, eller .cs?");

            Console.Write("Skriv in filformatet du vill använda:");
            string inMatning = Console.ReadLine();

            if (inMatning == ".txt")
            {
                fileWriter = new TextFileWriter();
            }
            else if (inMatning == ".xml")
            {
                fileWriter = new XmlFileWriter();
            }
            else
            {
                Console.WriteLine("Formatet hittas ej, försök igen!");
                return;
            }

            Console.WriteLine(fileWriter.WriteToFile($"{filNamn}"));

            Console.ReadLine();
        }
    }
}
