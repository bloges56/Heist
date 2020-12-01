using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt for the bank's difficulty
            int difficultyLevel;
            while(true)
            {
                Console.Write("What is the difficulty of your bank: ");
                try
                {
                    difficultyLevel = Int32.Parse(Console.ReadLine());
                    if(difficultyLevel <= 0)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter an integer greater than 0");
                }
            }
        
            //prompt the user to enter the team members
            Console.WriteLine("Plan Your Heist!");

            //create a list of members to store what the user enters
            List<Member> members = new List<Member>();

            while (true)
            {
                //Declare a member and prompt the user for its name
                Member userMember = new Member();
                Console.Write("Enter a team member's name (leave blank to stop adding members): ");
                userMember.name = Console.ReadLine();

                //if the user name is empty, break out of loop
                if (userMember.name == "")
                {
                    break;
                }

                //prompt the user for the member's skill level
                while (true)
                {
                    Console.Write("Enter a team member's skill level: ");
                    try
                    {
                        userMember.skillLevel = Int32.Parse(Console.ReadLine());
                        if (userMember.skillLevel <= 0)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer greater than 0");
                    }
                }

                //prompt the user for the member's courage factor
                while (true)
                {
                    Console.Write("Enter a team member's courage factor: ");
                    try
                    {
                        userMember.courageFactor = Double.Parse(Console.ReadLine());
                        if (userMember.courageFactor <= 0)
                        {
                            throw new Exception();
                        }
                        //after all the member's information has been gathered, add to the list
                        members.Add(userMember);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a decimal value greater than 0");
                    }
                }
            }

            //prompt for number of trial runs
            int trialRuns;
            while (true)
            {
                Console.WriteLine("How many trial runs: ");
                try
                {
                    trialRuns = Int32.Parse(Console.ReadLine());
                    if (trialRuns <= 0)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter an integer greater than 0");
                }
            }


            //sum the skill levels
            int skillSum = 0;
            foreach (Member member in members)
            {
                skillSum += member.skillLevel;
            }

            //initialize values for successful and failed runs
            int successes = 0;
            int failures = 0;

            //run the heist based on the trial runs entered by the user
            for (int i = 0; i < trialRuns; i++)
            {
                //set the bank's difficulty level
                int luckValue = new Random().Next(-10, 11);
                int totalDifficulty = difficultyLevel + luckValue;

                Console.WriteLine($"\nTeam's Skill: {skillSum}");
                Console.WriteLine($"Bank's Difficulty: {totalDifficulty}");

                //compare the sum of the skills and the bank difficulty and display an appropriate message
                //increment either failures or successes
                if (skillSum >= totalDifficulty)
                {
                    Console.WriteLine("Successful Heist!");
                    successes += 1;
                }
                else
                {
                    Console.WriteLine("You went to jail");
                    failures += 1;
                }
            }
            
            //Display total failures and total success
            Console.WriteLine($"\nSuccesses: {successes}");
            Console.WriteLine($"Failures: {failures}");
        }
    }
}
