using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Core.Entity
{
    public class BagCategory : EntityBase<int>
    {
        public string CategoryDescription { get; set; }
    }
}
