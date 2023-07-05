using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Indicates placenumber of team.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of the placenumber i.e. Champion, First runner-up.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Specific amount won by teams.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of prizeamount from the total.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
