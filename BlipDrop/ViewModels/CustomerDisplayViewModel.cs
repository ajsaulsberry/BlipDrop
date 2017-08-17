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
        [Display(Name = "Customer Number")]
        public Guid CustomerID { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }

        [Display(Name = "State/Provence/Region")]
        public string RegionName { get; set; }
    }
}