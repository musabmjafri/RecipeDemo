using Demo.Core.DTO;
using Demo.Core.Entity;
using Demo.Core.Interface.Repository;
using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Core.Interface.Service
{
    public interface IBagCategoryService : IService<IBagCategoryRepository, BagCategory, BagCategoryDto, int>
    {
    }
}
