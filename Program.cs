using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            //Declare a member and prompt the user for its properties
            Member userMember = new Member();
            Console.Write("Enter a team member's name: ");
            userMember.name = Console.ReadLine();
            while(true)
            {
                Console.Write("Enter a team member's skill level: ");
                try
                {
                    userMember.skillLevel = Int32.Parse(Console.ReadLine());
                    if(userMember.skillLevel <= 0)
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
        }
    }
}
