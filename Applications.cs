using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*
 * Skapa konto
 * Logga in
 * 
 * Skapa Bank konto
 * Lägg in pengar på konto                   <<<<<<<<<<<<<<<<< Gör separat från case, lägg in pengar på specifika konton
 * 
 * Lista konton
 * Lista saldon
 * Lista konton och saldon
 * 
 * Ta ut pengar
 * 
 * Räkna på lån/ränta
 * 
 * 
 */





namespace BankSimulatorAdvanced
{
    internal class Applications
    {
        public void Run()
        {
            var dict = new Dictionary<string, int>();

            bool run = true;

            while (run)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\n1. Skapa ett bank konto\n2. Ta bort konto\n3. Lista alla kontonummer\n4. Lista totalsaldo\n5. Lista alla kontonummer och saldo\n6. Ta ut pengar\n7. Räkna lån/räntebetalning\n8. Quit");
                Console.Write("Ange menyval: ");
                string menyVal = Console.ReadLine();

                switch (menyVal)
                {

                    //case "C":

                    //    Console.Write("Ange konto du vill lägga in pengar på: ");
                    //    string pengarTillKontonummer = Console.ReadLine();



                    //    break;

                    case "1":
                        string kontonummer = "";
                        int pengar;

                        bool runSkapa = true;

                        while (runSkapa)
                        {
                            bool keyExists = dict.ContainsKey(kontonummer);
                            if (keyExists)
                            {
                                Console.WriteLine("Du kan inte skapa flera konton med samma namn\nVar god börja om och välj ett nytt namn");
                                
                                runSkapa = false;
                            }
                            else
                            {
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.Write("\nSkapa ett konto\nKonto nummer: ");
                                kontonummer = Console.ReadLine();

                                Console.Write("Sätt in pengar: ");
                                pengar = int.Parse(Console.ReadLine());
                                dict[kontonummer] = pengar;
                            }

                        }

                        break;

                    case "2":



                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nAnge bank kontot du vill radera");
                        dict.Remove(Console.ReadLine());

                        break;

                    case "3":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nHär är dina konton:\n");
                        foreach (var key in dict.Keys)
                        {
                            Console.WriteLine(key + "\n");
                        }

                        break;

                    case "4":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nHär är dina saldon\n");
                        foreach (var key in dict.Keys)
                        {

                            Console.WriteLine(dict[key] + "\n");
                        }

                        break;

                    case "5":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nHär är dina konton respektive saldon\n");

                        foreach (var key in dict.Keys)
                        {
                            Console.WriteLine($"Bank konto: {key}");
                            Console.WriteLine($"Saldo: {dict[key]}");
                            Console.WriteLine("-----------------------\n");
                        }

                        break;

                    case "6":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Här kan du ta ut pengar från dina konton");

                        Console.Write("Ange konto du vill ta ut pengar ifrån: ");
                        kontonummer = Console.ReadLine();

                        Console.Write("Ange summa du vill ta ut: ");
                        int taUtPengar = int.Parse(Console.ReadLine());
                        dict[kontonummer] -= taUtPengar;

                        break;

                    case "7":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Här kan du räkna på dina lån och räntebetalningar\n");





                        break;

                    case "8":

                        run = false;
                        Console.WriteLine("\n---------------------Tack för att du använt vårt program---------------------");
                        Console.ReadKey();

                        break;
                }
            }



        }
    }
}