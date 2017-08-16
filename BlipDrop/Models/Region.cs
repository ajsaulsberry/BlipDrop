using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlipDrop.Models
{
    public class Region
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(3)]
        public string Iso3 { get; set; }

        [Key]
        [Column(Order = 2)]
        public string RegionCode { get; set; }

        public string RegionNameEnglish { get; set; }

        public virtual Country Country { get; set; }
    }
}