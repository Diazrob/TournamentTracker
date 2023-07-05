using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public  class PersonModel
    {
        /// <summary>
        /// Given name of team members.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Surname of team members.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email addresses of team members.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Contact information of team members.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
