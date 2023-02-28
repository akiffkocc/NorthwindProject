using Northwind.DTO;
using Northwind.DTO.Urun;
using Northwind.Repository;
using NorthWind.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Service
{
    public class UrunService
    {
        ProductRepository repository = new ProductRepository();
        public IList<UrunListeleDTO> Listele()
        {
            return repository.Listele().Select(
                x => new UrunListeleDTO
                {
                    ProductName= x.ProductName,
                    UnitPrice= x.UnitPrice,
                    UnitsInStock= x.UnitsInStock,
                    ProductId= x.ProductId,
                    ReorderLevel= x.ReorderLevel,
                    UnitsOnOrder= x.UnitsOnOrder,
                    CategoryId= x.CategoryId,
                    SupplierId= x.SupplierId,
                    Discontinued= x.Discontinued
                }).ToList();
        }
        public void Ekle(UrunEkleDTO entity)
        {
            Products urn = new Products {
            ProductName = entity.ProductName,
            UnitPrice = entity.UnitPrice,
            UnitsInStock= entity.UnitsInStock,
            CategoryId = entity.CategoryId,
            SupplierId= entity.SupplierId
            }; 

            repository.Ekle(urn);
        }
    }
}
