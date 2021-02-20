using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (; ; )
            {
                var intList = new List<int>();
                string sUserInput = "";
                bool validInput = true;
                var sList = new List<string>();
                

                do
                {
                    validInput = true;
                    Console.WriteLine("Please, enter a list of integers from 4 to 8 digits.");
                    Console.WriteLine("Press \"Enter\" after entering the last digit:");
                    sUserInput = Console.ReadLine();
                    sList = sUserInput.Select(x => x.ToString()).ToList();

                    if ((sList.Count < 4) || (sList.Count > 8))
                    {
                        validInput = false;
                        Console.WriteLine("Please, Enter a list from 4 to 8 digits");
                        Console.WriteLine();
                    }
                    else
                    {

                        try
                        {
                            foreach (var item in sList) { intList.Add(int.Parse(item)); }
                        }
                        catch
                        {
                            validInput = false;
                            Console.WriteLine("\nAn error occurred.");
                            Console.WriteLine("Please, make sure you only enter digits without any symbols.\n");
                        }
                    }

                } while (validInput == false);


                int rightHalf = 0;
                int leftHalf = 0;
                
                for (int i = 0; i < intList.Count / 2; i++)
                    leftHalf += intList[i];

                for (int i = intList.Count / 2; i < intList.Count; i++)
                    rightHalf += intList[i];

                if (leftHalf == rightHalf)
                    Console.WriteLine("Congratulations!!! Your ticket is Lucky.\n");
                else
                    Console.WriteLine("Sorry, Try again.\n");
            }
         


        }
        
        
        
    }
}
