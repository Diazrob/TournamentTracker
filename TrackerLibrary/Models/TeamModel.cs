using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of participating team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of team members per team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        


    }
}
