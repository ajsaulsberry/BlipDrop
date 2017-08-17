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
        [MaxLength(3)]
        public string RegionCode { get; set; }

        [MaxLength(3)]
        public string Iso3 { get; set; }

        public string RegionNameEnglish { get; set; }

        public virtual Country Country { get; set; }
    }
}