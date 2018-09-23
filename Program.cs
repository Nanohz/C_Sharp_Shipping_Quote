using System;

namespace CsharpShippingQoute
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'The Package Express':Please Follow Instructions Below.");
            Console.ReadLine();
            Console.WriteLine("Please enter your package Weight :");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please enter your package Width :");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please enter your package Height :");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Please enter your package Length :");
            int packageLegnth = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            if (packageWidth + packageHeight + packageLegnth + packageWeight >= 50)
            {

                Console.WriteLine("Package too big to be shipped out via Express!:");
            }

            int sum = packageWidth + packageHeight + packageLegnth + packageWeight;
            int qoute = (sum * packageWeight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is : " + "$" +qoute+".00"+ ",Thank you");

        }
    }
}
