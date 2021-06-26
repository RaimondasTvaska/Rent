using System;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rentable house = new Rentable();
            Console.WriteLine(house.Available);

            /* Rentable
             * Available (is,has,should signalizuoja, kad tai bus boolean funkcijose) true false
             * beds int
             * kitchen true false
             * shower true false
             * floor int
             * name
             * price
             * */
        }
    }
}
