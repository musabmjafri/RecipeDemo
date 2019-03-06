using Demo.Core.Entity;
using Recipe.NetCore.Base.Interface;

namespace Demo.Core.Interface.Repository
{
    public interface IBagCategoryRepository : IAuditableRepository<BagCategory, int>
    {
    }
}
