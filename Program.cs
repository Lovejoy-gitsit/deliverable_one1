using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mc
    {
        class Program
        {
            static void Main(string[] args)
            {

                var n1 = "0";
                var n2 = "0";

                Console.WriteLine("Enter a number: ");
                n1 = Console.ReadLine();

                Console.WriteLine("Enter a number: ");
                n2 = Console.ReadLine();

                //these will be used once the indexes are converted
                var digits = 0;
                var digits2 = 0;
                //counts how many times loop has gone
                int counter = 1;

                //for loop to iterate through the string
                for (int i = 0; i < n1.Length; i++)
                {
                    //look at each index and add them together while converting to ints
                    //must convert each index separately while using ToString method
                    digits = Convert.ToInt32(n1[i].ToString()) + Convert.ToInt32(n2[i].ToString());
                    digits2 = Convert.ToInt32(n1[i + 1].ToString()) + Convert.ToInt32(n2[i + 1].ToString());

                

                    //check if numbers are equal and counter equals 2
                    if (digits == digits2 && counter == 2)
                    {
                        Console.WriteLine("true");
                        //Console.WriteLine("Sum: " + digits);
                        Console.ReadLine();
                        break;
                    }
                    //if counter is less then 1 and digits are equal, then increment counter and loop again
                    else if (digits == digits2)
                        counter++;
                    //if digits are not equal, let user know and break from loop
                    else
                    {
                        Console.WriteLine("False");
                        Console.ReadLine();
                        
                        break;
                    }
                        
                    
                }



            }
        }
    }
