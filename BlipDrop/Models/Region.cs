using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlipDrop.Models
{
    public class Region
    {
        public string Iso3 { get; set; }

        public string PostalCode { get; set; }

        public string RegionName { get; set; }

        public virtual Country Country { get; set; }
    }
}