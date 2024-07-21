﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using MODELS.Models;

namespace DAL.Data
{
    public class ProductData:IProduct
    {
        private readonly ProjectContext _context;
        public ProductData(ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsByIdShop(int id_shop)
        {
            List<Product> products = await _context.Products.Where(x => x.Id_Shop == id_shop).ToListAsync();
            return products;
        }
        public async Task<Product> GetProductById(int id)
        {
            Product product = await _context.Products.SingleOrDefaultAsync(x=>x.Id_Product==id);
            return product;
        }

        public async Task<bool> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var idProduct=_context.Products.FirstOrDefault(x=>x.Id_Product==id);
            if (idProduct == null)
            {
                return false;
            }
            _context.Products.Remove(idProduct);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }
        
        public async Task<bool> UpdateCountProducts(int id, int count)
        {
            var idProduct = _context.Products.FirstOrDefault(x => x.Id_Product == id);
            if (idProduct == null)
            {
                return false;
            }
            idProduct.Count_Products= count;
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }
    }
}
