using System;

namespace Heist
{
    public class Member
    {
        //Properties
        public string name { get; set; }
        public int skillLevel { get; set; }
        public double courageFactor { get; set; }

        public void displayMember()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Skill Level: {skillLevel}");
            Console.WriteLine($"Courage Factor: {courageFactor}\n");
        }
    }
}