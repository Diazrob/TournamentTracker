using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
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
        /// <summary>
        /// The Id number of prize.
        /// </summary>
        public int Id { get; set; }

        public PrizeModel() { }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
