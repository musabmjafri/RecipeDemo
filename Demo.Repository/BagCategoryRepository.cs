using Demo.Core.DbContext;
using Demo.Core.Entity;
using Demo.Core.Interface.Repository;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;

namespace Demo.Repository
{
    public class BagCategoryRepository : AuditableRepository<BagCategory, int, FMTContext>, IBagCategoryRepository
    {
        public BagCategoryRepository(IRequestInfo<FMTContext> requestInfo)
            : base(requestInfo)
        {
        }
    }
}
