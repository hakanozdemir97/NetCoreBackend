using Core.Utilities.Results;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAll();       
        IDataResult<List<Product>> GetByProductName(string productName);
        IDataResult<List<Product>> GetByCategory(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();       
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);

        //RESTFUL --> HTTP -->     
    }
}
