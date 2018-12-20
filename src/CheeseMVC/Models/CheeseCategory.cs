﻿using System;
using System.Collections.Generic;
using CheeseMVC;


namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Cheese> Cheeses { get; set; }

    }
}
