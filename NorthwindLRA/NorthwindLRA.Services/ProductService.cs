using NorthwindLRA.Contracts.Data;
using NorthwindLRA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLRA.Services
{
    public class ProductService : IProductService
    {
        public List<ProductInfo> SearchProducts()
        {
            return new List<ProductInfo>
            {
                new ProductInfo {   Id =1, Name="Product Info 1", UnitPrice=13},                
                new ProductInfo {   Id =2, Name="Product Info 2", UnitPrice=24},                
                new ProductInfo {   Id =3, Name="Product Info 3", UnitPrice=45}
            };
        }
    }
}
