using System;
using System.Globalization;

namespace SimpleCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tHello, User");
            Console.WriteLine("\t\tin Simple Calculator App!\n");

            /// source from https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-8.0  the below code with my interventions!!
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "el-GR" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                ///Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("Τοπική ημερομηνία και ώρα : {0}, {1:G}: Ελλάδα",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("Παγκόσμια ημερομηνία και ώρα : {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);

                Console.WriteLine("1. Πρόσθεση...");
                Console.WriteLine("2. Αφαίρεση...");
                Console.WriteLine("3. Πολλαπλασιασμός...");
                Console.WriteLine("4. Διαίρεση...");
                Console.WriteLine("5. Υπόλοιπο Διαίρεσης...");
                Console.Write("\nΔώσε τον αριθμό της πράξης που επιθυμείς:  ");
                int choice;
                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        int plus1; int plus2; int sum;
                        Console.Write("\nΔώσε τον πρώτο προσθετέο αριθμό: ");
                        plus1 = int.Parse(Console.ReadLine()!);
                        Console.Write("Δώσε τον δεύτερο προσθετέο: ");
                        plus2 = int.Parse(Console.ReadLine()!);
                        sum = plus1 + plus2;
                        Console.WriteLine($"Το άθροισμα του {plus1} και του {plus2} είναι {sum}.");
                        break;
                    case 2:
                        int minus1; int minus2; int minus;
                        Console.Write("\nΔώσε τον μειωτέο αριθμό: ");
                        minus1 = int.Parse(Console.ReadLine()!);
                        Console.Write("Δώσε τον αφαιρέτη (πρέπει να είναι μικρότερος απο τον μειωτέο!): ");
                        minus2 = int.Parse(Console.ReadLine()!);
                        minus = minus1 - minus2;
                        Console.WriteLine($"Η διαφορά του {minus1} απο το {minus2} είναι {minus}.");
                        break;
                    case 3:
                        int mul1; int mul2; int mul;
                        Console.Write("\nΔώσε τον πρώτο παράγοντα: ");
                        mul1 = int.Parse(Console.ReadLine()!);
                        Console.Write("Δώσε τον δεύτερο παράγοντα: ");
                        mul2 = int.Parse(Console.ReadLine()!);
                        mul = mul1 * mul2;
                        Console.WriteLine($"Το γινόμενο του {mul1} επι του {mul2} είναι {mul}.");
                        break;
                    case 4:
                        int dia1; int dia2; int dia;
                        Console.Write("\nΔώσε τον διαιρετέο αριθμό: ");
                        dia1 = int.Parse(Console.ReadLine()!);
                        Console.Write("Δώσε τον διαιρέτη (δεν πρέπει να είναι μηδέν (0)!): ");
                        dia2 = int.Parse(Console.ReadLine()!);
                        dia = dia1 / dia2;
                        if (dia2 == 0)
                        {
                            Console.WriteLine("*******Σφάλμα! Δεν μπορείς να διαιρέσεις με το μηδέν.*******");
                        }
                        else
                        {
                            Console.WriteLine($"Το πηλίκο του {dia1} δια του {dia2} είναι {dia}.");
                        }
                        break;
                    case 5:
                        int dia11; int dia22; int dia12;
                        Console.Write("\nΔώσε τον διαιρετέο αριθμό: ");
                        dia11 = int.Parse(Console.ReadLine()!);
                        Console.Write("Δώσε τον διαιρέτη (δεν πρέπει να είναι μηδέν (0)!): ");
                        dia22 = int.Parse(Console.ReadLine()!);
                        if (dia22 == 0)
                        {
                            Console.WriteLine("******Σφάλμα! Δεν μπορείς να διαιρέσεις με το μηδέν.******");
                        }
                        else
                        {
                            dia12 = dia11 % dia22;
                            Console.WriteLine($"Το υπόλοιπο του {dia11} δια του {dia22} είναι {dia12}.");
                        }
                        break;
                    default:
                        Console.WriteLine("Μη έγκυρη επιλογή! Τερματισμός εφαρμογής.");
                        break;
                }

            }
        }

    }
}
