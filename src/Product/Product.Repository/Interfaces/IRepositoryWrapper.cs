using Product.Repository.BaseWrapper.Interfaces;

namespace Product.Repository.Interfaces;
public interface IRepositoryWrapper : IRepositoryWrapperBase
{
    IProductRepository Product { get; }
}