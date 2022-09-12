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
 * 
 * Lista konton
 * Lista saldon
 * Lista konton och saldon
 * 
 * Ta ut pengar/ sätta in pengar
 * 
 * Räkna på lån/ränta
 * 
 * Avsluta program
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
                Console.WriteLine("\n1. Skapa ett bank konto\n2. Ta bort konto\n3. Lista alla kontonummer\n4. Lista totalsaldo\n5. Lista alla kontonummer och saldo\n6. Sätt in/ Ta ut\n7. Räkna lån/räntebetalning\n8. Quit");
                Console.Write("Ange menyval: ");
                string menyVal = Console.ReadLine();

                Console.Clear();
                switch (menyVal)
                {
                    case "1":
                        string kontonummer = "";
                        int pengar = 0;

                        bool runSkapa = true;
                        while (runSkapa)
                        {
                            Console.Clear();

                            Console.WriteLine("Vill du skapa ett konto?\nY/N");
                            char answer = char.Parse(Console.ReadLine());

                            switch (answer)
                            {                                                        // FRÅGA STEFAN!!!!!!!!!!!!!!!!!!
                                case 'Y':

                                    dict = new Dictionary<string, int>();

                                    Console.Write("Namnge kontot du vill skapa\n");
                                    if (!dict.ContainsKey(kontonummer))
                                    {
                                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                        Console.Write("\nSkapa ett bank konto\nKonto namn/ nummer: ");
                                        kontonummer = Console.ReadLine();
                                        dict[kontonummer] = pengar;

                                        if (dict.ContainsKey(kontonummer))
                                        {
                                            Console.WriteLine($"\nEtt konto med namnet {kontonummer} har skapats\n");
                                        }
                                        runSkapa = false;
                                    }
                                    else if (dict.ContainsKey(kontonummer))
                                    {
                                        Console.WriteLine("\nDu kan inte skapa flera konton med samma namn\nVar god börja om och välj ett nytt namn\n");

                                        runSkapa = false;
                                    }

                                    break;

                                case 'N':

                                    runSkapa = false;

                                    break;
                            }
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;

                    case "2":

                        bool runDelete = true;

                        while (runDelete)
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\nAnge bank kontot du vill radera");

                            if (dict.ContainsKey(Console.ReadLine()))
                            {
                                Console.WriteLine("Ange kontot igen OM du vill radera det");
                                dict.Remove(Console.ReadLine());
                                runDelete = false;
                            }
                            else
                            {
                                Console.WriteLine("Kontot du angivit exixsterar inte\nFörsök med ett annat");
                            }
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;

                    case "3":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nHär är dina konton:\n");
                        foreach (var key in dict.Keys)
                        {
                            Console.WriteLine(key + "\n");
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;

                    case "4":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nHär är dina saldon\n");
                        foreach (var key in dict.Keys)
                        {

                            Console.WriteLine(dict[key] + "\n");
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
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
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;

                    case "6":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Här kan du hantera saldon på dina konton\n");
                        Console.WriteLine("1.Sätt in\n2Ta ut: ");
                        string hanteraKonto = Console.ReadLine();

                        bool runManage = true;

                        while (runManage)
                        {
                            switch (hanteraKonto)
                            {
                                case "1":

                                    Console.Write("Ange konto du vill sätta in pengar på: ");
                                    kontonummer = Console.ReadLine();
                                    Console.Write("Ange kontot igen: ");

                                    if (dict.ContainsKey(Console.ReadLine()))
                                    {
                                        Console.Write("Sätt in pengar: ");
                                        pengar = int.Parse(Console.ReadLine());
                                        dict[kontonummer] += pengar;

                                        runManage = false;
                                    }
                                    else
                                        Console.WriteLine("Kontot du angivit existerar inte, försök med ett annat");

                                    break;

                                case "2":

                                    Console.Write("Ange konto du vill ta ut pengar ifrån: ");
                                    kontonummer = Console.ReadLine();

                                    if (dict.ContainsKey(Console.ReadLine()))
                                    {
                                        Console.Write("Ange summa du vill ta ut: ");
                                        int taUtPengar = int.Parse(Console.ReadLine());
                                        dict[kontonummer] -= taUtPengar;

                                        runManage = false;
                                    }
                                    else
                                        Console.WriteLine("Kontot du angivit existerar inte, försök med ett annat");

                                    if (dict[kontonummer] < 0)
                                    {
                                        Console.WriteLine("Ditt saldo är för lågt för att ta ut den angivna summan\n\nAnge nytt menyval");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                                    break;
                            }

                            break;
                        }
                        break;

                    case "7":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Här kan du räkna på dina lån och räntebetalningar\n");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");




                        break;

                    case "8":

                        run = false;
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n---------------------Tack för att du använt vårt program---------------------\n");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.ReadKey();

                        break;
                }
            }



        }
    }
}