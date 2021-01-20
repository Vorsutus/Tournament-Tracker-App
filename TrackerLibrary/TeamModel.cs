using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        //property holding one piece of data ("prop" tab tab)
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

    //Pre C# 6 (can initialize with "= List<Person>(); now)
    //    public TeamModel()
    //    {
    //        TeamMembers = new List<PersonModel>();
    //    }
    }
}
