using Product.Repository.BaseWrapper;
using Product.Repository.Interfaces;

namespace Product.Repository;
public class RepositoryWrapper : RepositoryWrapperBase<RepositoryContext>, IRepositoryWrapper
{
    public RepositoryWrapper(RepositoryContext context) : base(context)
    {

    }

    IProductRepository _product { get; set; }

    public IProductRepository Product
    {
        get
        {
            if (_product == null)
            {
                _product = new ProductRepository(_dbContext);
            }

            return _product;
        }
    }
}
