using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace BlipDrop.Models
{
    public class Customer
    {
        [Key]
        [Column(Order = 1)]
        public Guid CustomerID { get; set; }

        [MaxLength(3)]
        public string CountryIso3 { get; set; }    

        public string RegionCode { get; set; }
    }
}