﻿using System;

namespace ConsoleApp1
{
    class Program
    {
       






        static void Main(string[] args)
        {
           


            
       
            int position = 0;
            int count = 0;


            while (position <= 100 )
             
            {

                Random opt = new Random();
                int ChoseOption = opt.Next(1, 4);
                int dice = opt.Next(1, 7);
                if (ChoseOption == 1)
                {
                    
                    Console.WriteLine($"No Play , position value is :{position}");

                    continue;

                }
                else if (ChoseOption == 2)
                {
                    position = position + dice;

                    Console.WriteLine($"Ladder dice is {dice} and position value is :{position}");
                    count++;

                }
                else
                {
                    position = position - dice;
                    count++;
                    Console.WriteLine($"Snake dice is {dice} and position value is :{position}");
                }
                if (position < 0)
                {
                    position = 0;
                }
            }

            Console.WriteLine($"dice is played {count} times");
            if (position>=100)
            Console.WriteLine("Its win , Your Position is :  " + position);
            else
            {
                Console.WriteLine("you loss , Your Position is :  " + position);

            }
        }

    }
}
