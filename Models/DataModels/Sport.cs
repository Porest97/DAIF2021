using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAIF2021.Models.DataModels
{
    public class Sport
    {
        public int Id { get; set; }

        [Display(Name = "Sport")]
        public string SportName { get; set; }
    }
}
