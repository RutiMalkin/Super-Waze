using MODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProduct
    {
        Task<bool> AddProduct(Product product);
        Task<List<Product>> GetAllProductsByIdShop(int id_shop);
        Task<Product> GetProductById(int id);
        Task<bool> DeleteProduct(int id);
        Task<bool> UpdateCountProducts(int id, int count);
    }
}
