using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    internal class CustomerDTO
    {
        public string Name { get; set; }
        public int Id_Customer { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
        public ICollection<ShopDTO> Shops { get; set; }
    }
}
