using AP.Data;

namespace AP.Repositories
{
    /// <summary>
    /// Repository interface for Supplier entities.
    /// Defines the contract for Supplier-specific data access operations.
    /// </summary>
    public interface IRepositorySupplier : IRepositoryBase<Supplier>
    {
    }

    /// <summary>
    /// Repository implementation for Supplier entities.
    /// Provides data access operations for Supplier entities using Entity Framework.
    /// </summary>
    public class RepositorySupplier : RepositoryBase<Supplier>, IRepositorySupplier
    {
        /// <summary>
        /// Initializes a new instance of the RepositorySupplier class.
        /// </summary>
        public RepositorySupplier() : base()
        {
        }
    }
}
