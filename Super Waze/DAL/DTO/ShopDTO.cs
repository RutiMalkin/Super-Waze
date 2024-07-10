﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    internal class ShopDTO
    {
        public int Id_Shop { get; set; }
        public string Name { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
        public ICollection<CustomerDTO> Customers { get; set; }
        //public int[,] Matrix_Map { get; set; }
    }
}
