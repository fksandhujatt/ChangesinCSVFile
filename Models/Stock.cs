using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CSVFILE.Models
{
    //POCO Class Made from EF Core
    public partial class Stock
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public string ProductCode { get; set; }
        public decimal? Price { get; set; }
    }
}
