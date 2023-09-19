﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents a place.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents a places name.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents prize (%).
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
