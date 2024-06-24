using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the customer name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("last month's water meter reading: ");
            int lastMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("this month's water meter reading: ");
            int thisMonth = int.Parse(Console.ReadLine());

            double waterConsumption = thisMonth - lastMonth;
            Console.WriteLine("Amount of consumption: " + waterConsumption + " M3");

            Console.WriteLine("The number of people: ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double consumptionPerPerson_1 = waterConsumption / numberOfPeople;

            Console.WriteLine("Customer Type: ");
            string toc_1 = Console.ReadLine();

            double priceM3_1;        
            double totalAmountWithoutTax;
            double vat;
            double environmentFee;
            double totalPrice;

            checkSign(toc_1, out priceM3_1, consumptionPerPerson_1);

            totalAmountWithoutTax = consumptionPerPerson_1 * priceM3_1;

            environmentFee = totalAmountWithoutTax * 0.1;

            vat = totalAmountWithoutTax * 0.1;

            totalPrice = totalAmountWithoutTax + vat + environmentFee;

            Console.WriteLine("\nprofile customer :");
            Console.WriteLine("Name customer: " + customerName);
            Console.WriteLine("Number water last month: " + lastMonth);
            Console.WriteLine("Number water this month: " + thisMonth);
            Console.WriteLine("Amount of consumption: " + waterConsumption + " M3");
            Console.WriteLine($"Total price : " + totalPrice + " VND");

            Console.ReadKey();
        }

        static void checkSign(string toc, out double priceM3, double consumptionPerPerson)
        {
            priceM3 = 0; 

            if (toc == "Household customer")
            {
                if (consumptionPerPerson >= 0 && consumptionPerPerson <= 10)
                {
                    priceM3 = 5.973;
                }
                else if (consumptionPerPerson > 10 && consumptionPerPerson <= 20)
                {
                    priceM3 = 7.052;
                }
                else if (consumptionPerPerson > 20 && consumptionPerPerson <= 30)
                {
                    priceM3 = 8.699;
                }
                else
                {
                    priceM3 = 15.929;
                }
            }
            else if (toc == "Administrative agency, public services")
            {
                priceM3 = 9.955;
            }
            else if (toc == "Production units")
            {
                priceM3 = 11.615;
            }
            else if (toc == "Business services")
            {
                priceM3 = 22.068;
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

    }
       
}
