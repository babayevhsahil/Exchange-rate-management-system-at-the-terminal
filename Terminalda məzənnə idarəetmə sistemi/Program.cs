namespace Exchange_rate_management_system_at_the_terminal
{
    internal class Program
    {
        static void Main()
        {
            double[] currencyRates = { 1.7, 2.0, 2.3, 0.023, 0.20 };
            string[] currencyCodes = { "USD", "EUR", "GBP", "RUB", "TRY" };

            string comand = "";

            while (comand != "4) Exit")
            {
                Console.WriteLine("Zehmet olmasa bir komanda secin: ");
                Console.WriteLine("1) Son valyuta mezennelerini gösterin");
                Console.WriteLine("2) Valyuta mezennesini kodla tapin");
                Console.WriteLine("3) Valyuta ile meblegi hesablayin");
                Console.WriteLine("4) Exit");
                Console.WriteLine("-----------------------------------------------------------------");

                comand = Console.ReadLine();

                if (comand == "1) Son valyuta mezennelerini gösterin")
                {
                    Console.WriteLine("Mezenne kodlari ve kurs qiymetleri:");
                    Console.WriteLine("-----------------------------------------------------------------");
                    for (int i = 0; i < currencyCodes.Length; i++)
                    {
                        Console.WriteLine("{0}   {1}", currencyCodes[i], currencyRates[i]);
                    }
                }
                else if (comand == "2) Valyuta mezennesini kodla tapin")
                {
                    Console.WriteLine("Mezenne hansi valyuta kodu ile hesablansin? USD, EUR, GBP, RUB, TRY: ");
                    string currencyCode = Console.ReadLine();

                    int index = Array.IndexOf(currencyCodes, currencyCode);

                    if (index != -1)
                    {
                        Console.WriteLine("{0}   {1}", currencyCode, currencyRates[index]);
                    }
                    else
                    {
                        Console.WriteLine("Sistemde mezenne tapilmadi.");
                    }
                }
                else if (comand == "3) Valyuta ile meblegi hesablayin")
                {
                    Console.WriteLine("Zehmet olmasa meblegi daxil edin: ");
                    Console.WriteLine("-----------------------------------------------------------------");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Mezenne hansi valyuta kodu ile hesablansin? USD, EUR, GBP, RUB, TRY: ");
                    Console.WriteLine("-----------------------------------------------------------------");
                    string currencyCode1 = Console.ReadLine();

                    int index1 = Array.IndexOf(currencyCodes, currencyCode1);

                    if (index1 != -1)
                    {
                        double rate = currencyRates[index1];
                        double convertedAmount = amount * rate;
                        Console.WriteLine("{0} {1} meblegi {2} AZN dir.", amount, currencyCode1, convertedAmount);
                    }
                    else
                    {
                        Console.WriteLine("Sistemde mezenne tapilmadi.");
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                }
                else if (comand != "4) Exit")
                {
                    Console.WriteLine("Düzgün bir komanda daxil edin.");
                    Console.WriteLine("-----------------------------------------------------------------");
                }

                Console.WriteLine();
            }
        }
    }
}
