using System;
using System.Collections.Generic;
using System.Linq;

namespace plan_your_heist
{
    public class Team
    {
        public string Name {get; set;}

        public List<TeamMember> TeamMembers {get; set;}

        public Team(string name)
        {
            Name = name;
            TeamMembers = new List<TeamMember>();
        }

        public void AddTeamMember( TeamMember _newTeamate)
        {
            TeamMembers.Add(_newTeamate);
        }
    }
}