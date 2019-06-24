/*
Name: Oscar Gonzalez
Date: 11/25/2018

Homework #7

This program ask the user to pick how many drawers they want, also what type of wood they want.
form there the program needs to add the price and return it.
*/
using System;

namespace Homework__7
{
    class Program
    {
        static void Main(string[] args)
        {
                                  
            int numOfDr = numberOfDrawers();
            //calls for the drawers method


            string Wood = typeOfWood();
            //calls for the wood method

            Cost(Wood, numOfDr);
            //calls the cost method and it seends what the user enter for drawers, also for the wood.
            
            Console.ReadLine();


        }

        static public int numberOfDrawers()
        {
            
            int drawers = 0;
            Console.WriteLine("How many drawers would you like?");
            drawers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you pick " + drawers+ " drawers");
            //this is the method for drawers. it ask them how many they want and converts it to an int,
            return drawers;
        }

        public static string typeOfWood()
        {
            //this is the wood method
            Console.WriteLine("What type of wood would you like? Press m for mahogany, o for oak, or p for pine.");
            string wood = Console.ReadLine();
            //it seends what the user type to wood string 
            //in this if statments it returns what they pick for wood and also seends what they pick back to the main method.
            if (wood == "m")
            {
                Console.WriteLine("you pick mahogany");
                return wood;
            }
            else if (wood == "o")
            {
                Console.WriteLine("you pick oak");
                return wood;
            }
            else if (wood == "p")
            {
                Console.WriteLine("you pick pine");
                return wood;

            }
            else
            {
                Console.WriteLine("sorry wrong input");
            }

            return wood;

        }

        static public double Cost(string Wood, int numOfDr)
        {
            //this is the cost method 
            //here it already have the string wood and the int drawers.
            double totalCost = 0;
            double surcharge = 30;
                       

            //here is the math for adding the prices of different wood and also the cost of the drawers.
            if (Wood == "p")
            {
                // calculcate the cost of the number of drawers for mahogani

                totalCost = 100 + (numOfDr * surcharge); 
            }
            else if (Wood == "o")
            {
                // calculcate the cost of the number of drawers for pinie
                totalCost = 140 + (numOfDr * surcharge);
            }
            // esle if for the other types of wood
            else
            {
                totalCost = 180 + (numOfDr * surcharge);
            }
            Console.WriteLine("Your total will be " + totalCost );


            return totalCost;
        }

    }
}
