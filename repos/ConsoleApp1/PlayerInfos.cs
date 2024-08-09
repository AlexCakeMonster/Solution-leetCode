namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerInfos
    {
        public int Id { get; set; }

        public int? PlayerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public short? Weight { get; set; }

        public short? Height { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string BirthPlace { get; set; }

        [StringLength(50)]
        public string Residence { get; set; }

        public virtual Players Players { get; set; }
    }
}
