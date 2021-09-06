namespace Mahdi_Abd_Asali.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CommodityRoots
    {
        public int Id { get; set; }

        public int CommodityChapterId { get; set; }

        [Required]
        [StringLength(30)]
        public string Code { get; set; }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public virtual CommodityChapters CommodityChapters { get; set; }
    }
}
