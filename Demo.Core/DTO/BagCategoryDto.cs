using Demo.Core.Entity;
using Recipe.NetCore.Base.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Demo.Core.DTO
{
    public class BagCategoryDto : Dto<BagCategory, int>
    {
        [MaxLength(50)]
        public string CategoryDescription { get; set; }
    }
}
