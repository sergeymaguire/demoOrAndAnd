using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOrAndAnd
{
    class Program
    {
        const int ZONE1 = 1, ZONE2 = 2;
        const int LOW_QUANTITY = 10;
        static void Main(string[] args)
        {


            string inputString;
            double fee = 25.75;
            int quantity;
            int deliveryZone;
            Console.WriteLine("Delivery is free for zone {0} and zone {1} when the quanity ordered is less then {2} ", ZONE1, ZONE2, LOW_QUANTITY);
            Console.Write("Please enter the delivery zone: ");
            inputString = Console.ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Console.Write("Please enter the quantity: ");
            inputString = Console.ReadLine();
            quantity = Convert.ToInt32(inputString);
            if (freeDelivery(deliveryZone, quantity))
            {
                Console.WriteLine("The delivery is free");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There will be a charge of {0} ", fee);
                Console.ReadLine();
            }
        }

        private static bool freeDelivery(int deliveryZone, int quantity)
        {
            return ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && (quantity < LOW_QUANTITY));  
        }
    }
}
