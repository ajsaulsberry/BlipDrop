using System.ComponentModel.DataAnnotations;

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