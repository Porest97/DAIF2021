using System.ComponentModel.DataAnnotations;

namespace DAIF2021.Models.DataModels
{
    public class SeriesStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string SeriesStatusName { get; set; }
    }
}