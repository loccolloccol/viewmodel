using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using viewmodel.Domain;

namespace viewmodel.ViewModel
{
    public class OrderDetailsViewModel
    {
        public Orders Orders{ get; set; }
        public List<Order_Details> OrderDetails { get; set; }

    }
}