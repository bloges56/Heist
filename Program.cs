using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the bank's difficulty level
            int difficultyLevel = 100;
            int luckValue = new Random().Next(-10, 11);
            int totalDifficulty = difficultyLevel + luckValue;


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
                if(userMember.name == "")
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

            //sum the skill levels
            int skillSum = 0;
            foreach(Member member in members)
            {
                skillSum += member.skillLevel;
            }

            Console.WriteLine($"\nTeam's Skill: {skillSum}");
            Console.WriteLine($"Bank's Difficulty: {totalDifficulty}");

            //compare the sum of the skills and the bank difficulty and display an appropriate message
            if(skillSum >= totalDifficulty)
            {
                Console.WriteLine("Successful Heist!");
            }
            else
            {
                Console.WriteLine("You went to jail");
            }
        }
    }
}
