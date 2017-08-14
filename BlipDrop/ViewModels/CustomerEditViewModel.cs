using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlipDrop.ViewModels
{
    public class CustomerEditViewModel
    {
        [Display(Name = "Customer Number")]
        public string CustomerID { get; set; }

        [Display(Name = "Customer Name")]
        [MaxLength(75)]
        public string CustomerName { get; set; }

        public string SelectedCountryIso3 { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }

        [Display(Name = "State / Region")]
        public string SelectedRegion { get; set; }
        public IEnumerable<SelectListItem> Regions { get; set; }

    }
}