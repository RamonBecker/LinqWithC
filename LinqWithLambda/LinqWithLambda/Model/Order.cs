﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Model {
    public class Order {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalValue { get; set; }


    }
}
