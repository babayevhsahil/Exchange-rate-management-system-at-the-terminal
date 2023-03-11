namespace Exchange_rate_management_system_at_the_terminal
{
    internal class Program
    {
        static void Main()
        {
            var currencyRates = new Dictionary<string, double>()
            {
              {"USD", 1.7},
              {"EUR", 2.0},
              {"GBP", 2.3},
              {"RUB", 0.023},
              {"TRY", 0.20}
            };

            Console.WriteLine("Zehmet olmasa bir komanda secin: ");
            Console.WriteLine("1) Son valyuta mezennelerini gösterin");
            Console.WriteLine("2) Valyuta mezennesini kodla tapin");
            Console.WriteLine("3) Valyuta ile meblegi hesablayin");
            Console.WriteLine("4) Exit");

            string comand = Console.ReadLine();

            while (comand != "4) Exit")
            {
                if (comand == "1) Son valyuta mezennelerini gösterin")
                {
                    Console.WriteLine("Mezenne kodlari ve kurs qiymetleri:");
                    foreach (string currencyCode in currencyRates.Keys)
                    {
                        Console.WriteLine("{0}   {1}", currencyCode, currencyRates[currencyCode]);
                    }
                }
                else if (comand == "2) Valyuta mezennesini kodla tapin")
                {
                    Console.WriteLine("Mezenne hansi valyuta kodu ile hesablansin? USD, EUR, GBP, RUB, TRY: ");
                    string currencyCode = Console.ReadLine();

                    if (currencyRates.ContainsKey(currencyCode))
                    {
                        Console.WriteLine("{0}   {1}", currencyCode, currencyRates[currencyCode]);
                    }
                    else
                    {
                        Console.WriteLine("Sistemde mezenne tapilmadi.");
                    }
                }
                else if (comand == "3) Valyuta ile meblegi hesablayin")
                {
                    Console.WriteLine("Zehmet olmasa meblegi daxil edin: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Mezenne hansi valyuta kodu ile hesablansin? USD, EUR, GBP, RUB, TRY: ");
                    string currencyCode = Console.ReadLine();

                    if (currencyRates.ContainsKey(currencyCode))
                    {
                        double rate = currencyRates[currencyCode];
                        double convertedAmount = amount * rate;
                        Console.WriteLine("{0} {1} meblegi {2} AZN dir.", amount, currencyCode, convertedAmount);
                    }
                    else
                    {
                        Console.WriteLine("Sistemde mezenne tapilmadi.");
                    }
                }
                else
                {
                    Console.WriteLine("Düzgün bir komanda daxil edin.");
                }

                Console.WriteLine();
                Console.WriteLine("Zehmet olmasa bir komanda secin: ");
                Console.WriteLine("1) Son valyuta mezennelerini gösterin");
                Console.WriteLine("2) Valyuta mezennesini kodla tapin");
                Console.WriteLine("3) Valyuta ile meblegi hesablayin");
                Console.WriteLine("4) Exit");
                comand = Console.ReadLine();
            }
        }
    }

}