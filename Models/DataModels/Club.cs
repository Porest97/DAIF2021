using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAIF2021.Models.DataModels
{
    public class Club
    {
        public int Id { get; set; }

        // Club props !
        [Display(Name = "#")]
        public string ClubNumber { get; set; }

        [Display(Name = "Club")]
        public string ClubName { get; set; }

        [Display(Name = "Short name")]
        public string ShortName { get; set; }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }
    }
}
