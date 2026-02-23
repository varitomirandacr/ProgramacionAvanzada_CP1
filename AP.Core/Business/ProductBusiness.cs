using AP.Core.Validations;
using AP.Data;
using AP.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AP.Core.Business
{
    public class ProductBusiness
    {
        private readonly IRepositoryProduct _repositoryProduct;

        public ProductBusiness()
        {
            _repositoryProduct = new RepositoryProduct();
        }

        public IEnumerable<Product> GetProducts(int id = 0)
        {
            if (id == 0)
                return _repositoryProduct.GetAll();
            else
                return new List<Product> { _repositoryProduct.GetById(id) };
        }

        public bool SaveOrUpdate(Product product)
        {
            if (product.ProductID == 0)
                if (ProductValidations.IsWithinTimeRange())
                    _repositoryProduct.Add(product);
                else 
                    throw new System.Exception("Products cannot be added outside of the allowed time range.");
            else
                    _repositoryProduct.Update(product);
            return true;
        }

        public void Delete(int id) 
        {
            _repositoryProduct.Delete(id);
        }

        public IEnumerable<Product> SearchProducts(string criteria, string field)
        {
            // language integrated query (LINQ) to filter products based on the specified field and criteria
            var products = GetProducts(id: 0);
            switch (field)
            {
                case "ProductName":
                    return products.Where(p => p.ProductName.ToLower().Contains(criteria.ToLower()));
                case "Description":
                    return products.Where(p => p.Description.ToLower().Contains(criteria.ToLower()));
                case "ModifiedBy":
                    return products.Where(p => p.ModifiedBy.ToLower() != criteria.ToLower());
                case "Rating":
                    decimal toDecimal = decimal.Parse(criteria);
                    return products.Where(p => p.Rating >= toDecimal);
                default:
                    return new List<Product>();
            }
        }        
    }
}
