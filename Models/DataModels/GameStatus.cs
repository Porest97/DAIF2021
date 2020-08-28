﻿using System.ComponentModel.DataAnnotations;

namespace DAIF2021.Models.DataModels
{
    public class GameStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string GameStatusName { get; set; }
    }
}