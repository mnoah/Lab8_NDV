using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stats;

namespace Lab8_NDV
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Batting Average Calculator!");

            string Awn;
            do
            {
                Console.Write("Enter number of at-bats for your player: ");
                int AtBatsNum = int.Parse(Console.ReadLine());
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");


                int[] BattingSheet = new int[AtBatsNum];

                int Result = 1;
                for (int i = 0; i < AtBatsNum; i++)
                {
                    
                    
                        Console.Write("Result for at-bat " + Result + ": ");
                        int resultNum = int.Parse(Console.ReadLine());
                        if (!(resultNum == 0 ||
                        resultNum == 1 || 
                        resultNum == 2 ||
                        resultNum == 3 || 
                        resultNum == 4 ))
                    {
                        do
                        {
                            Console.WriteLine("Invalid response.");
                            Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                            Console.Write("Result for at-bat " + Result + ": ");

                            resultNum = int.Parse(Console.ReadLine());

                        } while (!(resultNum == 0 ||
                        resultNum == 1 ||
                        resultNum == 2 ||
                        resultNum == 3 ||
                        resultNum == 4));
                    }
                    BattingSheet[i] = resultNum;
                        Result++;
                     
                }

                Console.WriteLine("");
                Console.WriteLine("Batting average: " + CalcBattingAve(BattingSheet).ToString("F3"));
                Console.WriteLine("Slugging %: " + CalcSlugAve(BattingSheet).ToString("F3"));

                Console.WriteLine("Would you like to try another batter? (y/n)");
                Awn= Console.ReadLine().ToLower();

                if (Awn != "y" || Awn != "n")
                {
                    do
                    {
                        Console.WriteLine("please enter: y/n");
                        Awn = Console.ReadLine().ToLower();
                    } while (!(Awn == "y" || Awn == "n"));
                }


            } while (Awn == "y");








        }

        public static double CalcBattingAve(int[] BattingSheet)
        {
            int sec = 0;
            for (int i = 0; i < BattingSheet.Length; i++)
            {
                if (BattingSheet[i] > 0)
                {
                    sec += 1;
                }


            }
            return (double)sec / BattingSheet.Length;

        }

        public static double CalcSlugAve(int[] BattingSheet)
        {
            int total = 0;
            for (int i = 0; i < BattingSheet.Length; i++)
            {
                 total = BattingSheet[i]++;  
            }

                return (double) total/BattingSheet.Length ;
        }







    }
}

