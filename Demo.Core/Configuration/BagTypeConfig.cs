using Demo.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Core.Configuration
{
    public class BagTypeConfig : IEntityTypeConfiguration<BagType>
    {
        public void Configure(EntityTypeBuilder<BagType> builder)
        {
        }
    }
}
