using PresidentialEligibility_partA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentialEligibility_PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualEligibility ie = new IndividualEligibility();
            Boolean eligible = false;

            //user passed in arguments to the command line
            if (args.Length >=1)  
            {
                
                if (args[0] == "true")
                {
                    ie.setPlaceBirth(true);
                }
                else
                {
                    ie.setPlaceBirth(false);
                }

                ie.setBirthYear(Int32.Parse(args[1]));
                ie.setYearsResidedInUS(Int32.Parse(args[2]));
                ie.setPriorTermsServed(Int32.Parse(args[3]));
                if (args[4] == "false")
                {
                    ie.setRebelledAgainstUS(false);
                }
                else
                {
                    ie.setRebelledAgainstUS(true);
                }

                 eligible = ie.determineEligibility();
                if(eligible)
                {
                    Console.WriteLine("You are eligible to run for president of the United States!");
                }
                else
                {
                    Console.WriteLine("You are NOT eligible to run for president of the United States.");
                }
                   
    
            }


            //the user passed in no arguments. Prompt them instead:
            else
            {

                Console.WriteLine("\nWere you born in the United States? Enter yes or no.");

                    if (Console.ReadLine() == "yes")
                {
                    ie.setPlaceBirth(true);
                }
                    else
                {
                    ie.setPlaceBirth(false);
                }

                Console.WriteLine("\nWhat is your birth year? (Please enter all 4 digits)");
                ie.setBirthYear(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("\nHow many years have you resided in the United States?");
                ie.setYearsResidedInUS(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("\nHow many prior terms have you served?");
                ie.setPriorTermsServed(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("\nHave you ever rebelled against the United States? Enter yes or no.");
                if (Console.ReadLine()=="no")
                {
                    ie.setRebelledAgainstUS(false);
                }
                else
                {
                    ie.setRebelledAgainstUS(true);
                }

                eligible = ie.determineEligibility();
                if (eligible)
                {
                    Console.WriteLine("You are eligible to run for president of the United States!");
                }
                else
                {
                    Console.WriteLine("You are NOT eligible to run for president of the United States.");
                }


            }

            Console.ReadKey();
        }
    }
}
