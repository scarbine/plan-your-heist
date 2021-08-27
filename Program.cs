using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int skillLevel = 0;
            double courageFactor = 0.0;

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Please enter you team memebers name.");
            name = Console.ReadLine();
            Console.WriteLine($"Please enter {name}'s skill level. Choose any number 1-10.");
            string skillLevelAsString = Console.ReadLine();
            skillLevel = int.Parse(skillLevelAsString);
            Console.WriteLine($"Please enter {name}'s courage factor. Choose a number between 0.0 - 2.0");
            string courgeFactorAsString = Console.ReadLine();
            courageFactor = Double.Parse(courgeFactorAsString);

            TeamMember Member1 = new TeamMember(name, skillLevel, courageFactor);

            Console.WriteLine($"Name: {Member1.Name}");
            Console.WriteLine($"Skill Level: {Member1.SkillLevel}");
            Console.WriteLine($"Courage Factor: {Member1.CourageFactor}");

        }
    }
}
