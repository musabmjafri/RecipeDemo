
using Recipe.NetCore.Base.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Core.Entity
{
    public class BagType : EntityBase<int>
    {
        [MaxLength(50)]
        public string BagName { get; set; }

        public string BagDesc { get; set; }

        public Int16 BagCategoryNo { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal TareWeight { get; set; }
    }
}
