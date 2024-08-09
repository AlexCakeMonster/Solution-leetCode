namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerStats
    {
        public int Id { get; set; }

        public int? MatcId { get; set; }

        public int? PlayerId { get; set; }

        public bool? Win { get; set; }

        public short? Aces { get; set; }

        public virtual Matches Matches { get; set; }

        public virtual Players Players { get; set; }
    }
}
