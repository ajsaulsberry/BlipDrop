using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlipDrop.ViewModels
{
    public class CustomerDisplayViewModel
    {
        public Guid CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CountryName { get; set; }

        public string RegionName { get; set; }
    }
}