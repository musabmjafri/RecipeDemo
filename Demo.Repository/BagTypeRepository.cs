using Demo.Core.DbContext;
using Demo.Core.Entity;
using Demo.Core.Interface.Repository;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;

namespace Demo.Repository
{
    public class BagTypeRepository : AuditableRepository<BagType, int, FMTContext>, IBagTypeRepository
    {
        public BagTypeRepository(IRequestInfo<FMTContext> requestInfo) 
            : base(requestInfo)
        {
        }
    }
}
