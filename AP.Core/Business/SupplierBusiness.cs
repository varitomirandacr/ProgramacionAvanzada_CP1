using AP.Data;
using AP.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AP.Core.Business
{
    public class SupplierBusiness
    {
        private readonly IRepositorySupplier _repositorySupplier;

        public SupplierBusiness()
        {
            _repositorySupplier = new RepositorySupplier();
        }

        public IEnumerable<Supplier> GetSuppliers(int id = 0)
        {
            if (id == 0)
                return _repositorySupplier.GetAll();
            else
                return new List<Supplier> { _repositorySupplier.GetById(id) };
        }

        public bool SaveOrUpdate(Supplier supplier)
        {
            if (supplier.SupplierID == 0)
                _repositorySupplier.Add(supplier);
            else
                _repositorySupplier.Update(supplier);
            return true;
        }

        public void Delete(int id)
        {
            _repositorySupplier.Delete(id);
        }

        public IEnumerable<Supplier> SearchSuppliers(string criteria, string field)
        {
            var suppliers = GetSuppliers(id: 0);
            switch (field)
            {
                case "SupplierName":
                    return suppliers.Where(s => s.SupplierName != null && s.SupplierName.ToLower().Contains(criteria.ToLower()));
                case "ContactName":
                    return suppliers.Where(s => s.ContactName != null && s.ContactName.ToLower().Contains(criteria.ToLower()));
                case "ContactTitle":
                    return suppliers.Where(s => s.ContactTitle != null && s.ContactTitle.ToLower().Contains(criteria.ToLower()));
                case "City":
                    return suppliers.Where(s => s.City != null && s.City.ToLower().Contains(criteria.ToLower()));
                case "Country":
                    return suppliers.Where(s => s.Country != null && s.Country.ToLower().Contains(criteria.ToLower()));
                case "ModifiedBy":
                    return suppliers.Where(s => s.ModifiedBy != null && s.ModifiedBy.ToLower().Contains(criteria.ToLower()));
                default:
                    return new List<Supplier>();
            }
        }
    }
}
