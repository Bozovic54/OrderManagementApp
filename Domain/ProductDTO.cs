﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductDTO
    {
        private int productID;
        private string productName;
        private string quantityPerUnit;
        private decimal unitPrice;
        private short unitsInStock;
        private short unitsOnOrder;
        private short reorderLeverl;
        private bool discontiuned;

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public System.Nullable<decimal> UnitPrice { get; set; }
        public System.Nullable<short> UnitsInStock { get; set; }
        public System.Nullable<short> UnitsOnOrder { get; set; }
        public System.Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
