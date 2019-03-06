using Demo.Core.DbContext;
using Demo.Core.Interface.Repository;
using Demo.Core.Interface.Service;
using Demo.Repository;
using Demo.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using Recipe.NetCore.Infrastructure;

namespace Demo.API
{
    public class DependencyInjection
    {
        public void Map(IServiceCollection services, IConfiguration Configuration)
        {
            #region Base
            services.AddHttpContextAccessor();
            services.AddSingleton<IRequestInfo<FMTContext>, RequestInfo<FMTContext>>();
            services.AddSingleton<IUnitOfWork, UnitOfWork<FMTContext>>();
            services.AddSingleton(typeof(IService), typeof(Recipe.NetCore.Base.Generic.Service));
            #endregion

            #region BagType
            services.AddSingleton(typeof(IBagTypeService), typeof(BagTypeService));
            services.AddSingleton(typeof(IBagTypeRepository), typeof(BagTypeRepository));
            services.AddSingleton(typeof(IBagCategoryService), typeof(BagCategoryService));
            services.AddSingleton(typeof(IBagCategoryRepository), typeof(BagCategoryRepository));
            #endregion

        }
    }
}