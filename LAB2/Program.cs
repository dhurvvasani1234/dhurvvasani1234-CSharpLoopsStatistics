using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Enter an integer: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    int max = numbersList.Max();
                    int min = numbersList.Min();
                    int odd = 0, even = 0, oddSum = 0, evenSum = 0;
                    double oddAverage = 0.0;
                    double evenAverage = 0.0;

                    // determine odd integers
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] % 2 == 0)
                        {
                            even++;
                            evenSum += numbersList[i];
                        }
                        else
                        {
                            odd++;
                            oddSum += numbersList[i];
                        }
                    }

                    // find out averages
                    evenAverage = ((double)evenSum / (double)even);
                    oddAverage = ((double)oddSum / (double)odd);

                    /*program.DisplayResults(max, minimum, oddCount, oddSum, oddAverage, evenCount, evenSum, evenAverage);*/
                    Console.WriteLine("The maximum integer you entered is: " + max);
                    Console.WriteLine("The minimum integer you entered is: " + min + " \n");

                    Console.WriteLine("The number of odd integer(s) you entered is: " + odd);
                    Console.WriteLine("The sum of all odd integer(s) you entered is: " + oddSum);
                    Console.WriteLine("The average of all odd integer(s) you entered is: {0}", oddAverage + "\n");

                    Console.WriteLine("The number of even integer(s) you entered is: " + even);
                    Console.WriteLine("The sum of all even integer(s) you entered is: " + evenSum);
                    Console.WriteLine("The average of all even integer(s) you entered is: {0}", evenAverage + "\n");

                    Console.WriteLine("Play again (Y) ?");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "y" || tryAgain == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for playing! Press 'Enter' to finish");
                        Console.ReadLine();
                        break;
                    }

                }
                else
                {
                    // parse integer and add it to the list
                    try
                    {
                        int number = int.Parse(userInput);
                        numbersList.Add(number);
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid input! Enter an integer value : " + ex.Message + "\n");
                    }
                }
            }
        }
    }
}
