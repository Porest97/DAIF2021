using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAIF2021.Models.DataModels
{
    public class Series
    {
        public int Id { get; set; }


        [Display(Name = "Series")]
        public string SeriesName { get; set; }

        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Status")]
        public int? SeriesStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("SeriesStatusId")]
        public SeriesStatus SeriesStatus { get; set; }

        [Display(Name = "Type")]
        public int? SeriesTypeId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("SeriesTypeId")]
        public SeriesType SeriesType { get; set; }

        [Display(Name = "Series ADMIN")]
        public int? PersonId { get; set; }
        [Display(Name = "Series ADMIN")]
        [ForeignKey("PersonId")]
        public Person Admin { get; set; }
    }
}