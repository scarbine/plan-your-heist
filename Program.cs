using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string teamName = "newTeam";
            int skillLevel = 0;
            double courageFactor = 0.0;

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is your team name?");
            teamName = Console.ReadLine();
            Team UserTeam = new Team(teamName);

            while (true)
            {
                name = "";
                Console.WriteLine("Please enter you team memebers name.");
                name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                Console.WriteLine($"Please enter {name}'s skill level. Choose any number 1-10.");
                string skillLevelAsString = Console.ReadLine();
                skillLevel = int.Parse(skillLevelAsString);
                Console.WriteLine($"Please enter {name}'s courage factor. Choose a number between 0.0 - 2.0");
                string courgeFactorAsString = Console.ReadLine();
                courageFactor = Double.Parse(courgeFactorAsString);
                TeamMember NewMember = new TeamMember(name, skillLevel, courageFactor);
                UserTeam.AddTeamMember(NewMember);

                Console.WriteLine($"Team Name: {UserTeam.Name}");
                Console.WriteLine($"Name: {NewMember.Name}");
                Console.WriteLine($"Skill Level: {NewMember.SkillLevel}");
                Console.WriteLine($"Courage Factor: {NewMember.CourageFactor}");
            }

            foreach (TeamMember member in UserTeam.TeamMembers)
            {
                Console.WriteLine(member.Name, member.SkillLevel, member.CourageFactor);
            }

            Console.WriteLine("Are you ready to begin your hiest?");



        }
    }
}
