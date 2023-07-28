using Product.Repository.Interfaces;
using Product.Service.Interfaces;

namespace Product.Service;
public class BaseService : IBaseService
{
    protected readonly IRepositoryWrapper _wrapper;
    //protected readonly IMapper _mapper;

    public BaseService(IRepositoryWrapper wrapper)
    {
        _wrapper = wrapper;
        //_mapper = mapper;
    }
}
