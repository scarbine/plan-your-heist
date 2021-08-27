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
            int BankDifficulty = 0;
            int BankLuck = new Random().Next(-11,11);
            int TrialRuns = 1;
            int SuccessfulRuns = 0;
            int FailedRuns = 0;
            int BankLuckDifficulty = 0;
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("How many trial runs would you like to make?");
            TrialRuns = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the banks diffiuclty. 1-100");
            BankDifficulty = int.Parse(Console.ReadLine());
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

            for ( int i = 0; i < TrialRuns ; i++)
            {
                BankLuck = new Random().Next(-11,11);
                BankLuckDifficulty = BankLuck + BankDifficulty;
                UserTeam.TeamPower =0;
                Game();
           
            }

            void Game()
            {

            foreach (TeamMember member in UserTeam.TeamMembers)
            {
                UserTeam.TeamPower += member.SkillLevel;
            }
            Console.WriteLine($"There are {UserTeam.TeamMembers.Count} members on your team with a total skill level of {UserTeam.TeamPower}");
            Console.WriteLine("And the hiest begins!");
            Console.WriteLine($"The teams total power is: {UserTeam.TeamPower}");
            Console.WriteLine($"The Banks breach strength is: {BankLuckDifficulty}");

            if (UserTeam.TeamPower >= BankLuckDifficulty)
            {
                Console.WriteLine("Success!!! Make it Rain!");
                SuccessfulRuns++;
            }
            else
            {
                Console.WriteLine("You failed. Your powers are too weak for this bank!");
                FailedRuns--;
            }
            } 

            Console.WriteLine($"You had {SuccessfulRuns} Successful Runs");
            Console.WriteLine($"You had {FailedRuns} Failed Runs");




        }
    }
}
