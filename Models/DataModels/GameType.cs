using System.ComponentModel.DataAnnotations;

namespace DAIF2021.Models.DataModels
{
    public class GameType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string GameTypeName { get; set; }
    }
}