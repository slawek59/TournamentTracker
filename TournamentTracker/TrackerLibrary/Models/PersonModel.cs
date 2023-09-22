using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents persons first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents persons last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents persons email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents persons cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
