using System.ComponentModel.DataAnnotations;

namespace DAIF2021.Models.DataModels
{
    public class SeriesType
    {
        
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string SeriesTypeName { get; set; }
    }
}