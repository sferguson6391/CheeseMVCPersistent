using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        [Display(Name ="Cheese")]
        public int cheeseID { get; set; }
        public int menuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses  { get; set; }
    }
}
