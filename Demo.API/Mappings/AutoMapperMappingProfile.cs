using AutoMapper;
using Demo.Core.DTO;
using Demo.Core.Entity;

namespace Demo.API.Mappings
{
    public class AutoMapperMappingProfile : Profile
    {
        public AutoMapperMappingProfile()
        {
            this.CreateMap<BagTypeDto, BagType>()
                .ForMember(x => x.CreatedBy, i => i.Ignore())
                .ForMember(x => x.CreatedOn, i => i.Ignore())
                .ForMember(x => x.LastModifiedBy, i => i.Ignore())
                .ForMember(x => x.LastModifiedOn, i => i.Ignore())
                .ReverseMap();

            this.CreateMap<BagCategoryDto, BagCategory>()
                .ForMember(x => x.CreatedBy, i => i.Ignore())
                .ForMember(x => x.CreatedOn, i => i.Ignore())
                .ForMember(x => x.LastModifiedBy, i => i.Ignore())
                .ForMember(x => x.LastModifiedOn, i => i.Ignore())
                .ReverseMap();

        }
    }
}
