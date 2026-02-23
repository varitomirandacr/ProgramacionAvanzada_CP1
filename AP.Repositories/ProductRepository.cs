using AP.Data;

namespace AP.Repositories
{
    /// <summary>
    /// Repository interface for Product entities.
    /// Defines the contract for Product-specific data access operations.
    /// </summary>
    public interface IRepositoryProduct : IRepositoryBase<Product>
    {
    }

    /// <summary>
    /// Repository implementation for Product entities.
    /// Provides data access operations for Product entities using Entity Framework.
    /// </summary>
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        /// <summary>
        /// Initializes a new instance of the RepositoryProduct class.
        /// </summary>
        public RepositoryProduct() : base()
        {
        }
    }
}
