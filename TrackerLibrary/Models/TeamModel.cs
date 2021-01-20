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
        /// <summary>
        /// Represents a list of team members comprised of people from the PersonModel Library.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the Team.
        /// </summary>
        public string TeamName { get; set; }


    //Pre C# 6 this is how you initialized TeamMembers. 
    //(can now initialize with "= List<Person>();)
    //    public TeamModel()
    //    {
    //        TeamMembers = new List<PersonModel>();
    //    }
    }
}
