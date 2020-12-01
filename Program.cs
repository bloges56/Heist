using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            //Declare a member and prompt the user for its name
            Member userMember = new Member();
            Console.Write("Enter a team member's name: ");
            userMember.name = Console.ReadLine();

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
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a decimal value greater than 0");
                }
            }
            
            //display the member information
            Console.WriteLine($"Name: {userMember.name}");
            Console.WriteLine($"Skill Level: {userMember.skillLevel}");
            Console.WriteLine($"Courage Factor: {userMember.courageFactor}");
        }
    }
}
