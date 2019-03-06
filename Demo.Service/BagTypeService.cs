using AutoMapper;
using Demo.Core.DTO;
using Demo.Core.Entity;
using Demo.Core.Interface.Repository;
using Demo.Core.Interface.Service;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;

namespace Demo.Service
{
    public class BagTypeService : Service<IBagTypeRepository, BagType, BagTypeDto, int>, IBagTypeService
    {
        public BagTypeService(IUnitOfWork unitOfWork, IBagTypeRepository repository, IMapper _mapper)
            : base(unitOfWork, repository, _mapper)
        {
        }
    }
}
