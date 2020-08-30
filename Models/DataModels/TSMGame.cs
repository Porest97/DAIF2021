using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAIF2021.Models.DataModels
{
    public class TSMGame
    {

        public int Id { get; set; }

        //TSMGame Data !
        [Display(Name = "Speldatum & Tid")]
        [DataType(DataType.DateTime)]
        public DateTime GameDateTime { get; set; }

        [Display(Name = "Veckodag")]
        public string WeekDay { get; set; }

        [Display(Name = "Matchnr")]
        public string GameNumber { get; set; }

        [Display(Name = "Omgång")]
        public string Round { get; set; }

        [Display(Name = "Hemma")]
        public string HomeTeam { get; set; }

        [Display(Name = "Borta")]
        public string AwayTeam { get; set; }

        [Display(Name = "Arena")]
        public string Arena { get; set; }

        [Display(Name = "Serie")]
        public string Series { get; set; }

        [Display(Name = "HD")]
        public string HD1 { get; set; }

        [Display(Name = "HD")]
        public string HD2 { get; set; }

        [Display(Name = "LD")]
        public string LD1 { get; set; }

        [Display(Name = "LD")]
        public string LD2 { get; set; }

        [Display(Name = "Supervisor")]
        public string Supervisor { get; set; }

        [Display(Name = "Ändrat")]
        public DateTime? DateChanged { get; set; }

        [Display(Name = "Ändrat av")]
        public string ChangedBy { get; set; }

        //Settings !
        [Display(Name = "Status")]
        public int? TSMGameStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("TSMGameStatusId")]
        public TSMGameStatus TSMGameStatus { get; set; }
    }

    public class TSMGameStatus
    {
        public int Id { get; set; }

        [Display(Name ="Status")]
        public string TSMGameStatusName { get; set; }
    }
}
