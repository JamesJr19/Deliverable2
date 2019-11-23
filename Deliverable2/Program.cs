using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverable2
{
    class MainClass
    {
        public static void Main(string[] args)
        { Start:
            Console.Write("Enter your message: ");
            string input = Console.ReadLine();

            // convert to upper case
            string word = (input.ToUpper());


            Console.Write("Your encoded message is: ");


            // convert to ACSII value
            int sum;
            List<int> checksum = new List<int>();
            //int checksum = 0;
            foreach (char letter in word)
            {
                sum = (int)letter;
                //checksum *= 5;
                Console.Write(sum + "-");

                checksum.Add(sum);
                             
            }
            Console.WriteLine();
            Console.WriteLine("Message checksum is " + checksum.Sum(x => Convert.ToInt32(x)));
            // find checksum
            

            Console.ReadLine();

            goto Start;

        }

    }
}
 
    
            
         //Console.Write(input[i] + Char.ConvertToUtf32 (input, i) + "-");
