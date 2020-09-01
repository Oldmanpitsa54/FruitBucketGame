using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string input;
            var rand = new Random();
            var bucketWeight = rand.Next(40, 140);
            Console.WriteLine("Bucket weight: " + bucketWeight);
            do
            {
                Console.Write("1) Play \n2) Exit \n\nYour choice: ");
                input = Console.ReadLine();
                int cases;
                DL.Validation.Int_Digits_check(input, out cases);
                switch (cases)
                {
                    case 1:
                        Console.WriteLine("Starting");
                        Console.WriteLine("Enter the amount of players");
                        input = Console.ReadLine();
                        DL.Validation.Borders(2, 8, input, out size);
                        break;
                   
                    case 2:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Error. Choose the menu item again.");
                        break;
                }
            } while (true);
        }
    }
}
