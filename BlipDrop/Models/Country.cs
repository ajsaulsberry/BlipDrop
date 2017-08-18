using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlipDrop.Models
{
    public class Country
    {
        [Key]
        [MaxLength(3)]
        public string Iso3 { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryNameEnglish { get; set; }

        public virtual IEnumerable<Region> Regions { get; set; }
    }
}