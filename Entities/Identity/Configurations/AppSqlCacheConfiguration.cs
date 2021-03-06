using Entities.Identity.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Identity.Configurations
{
    public class AppSqlCacheConfiguration : IEntityTypeConfiguration<AppSqlCache>
    {
        private readonly IdentitySiteSettings _siteSettings;
        
        public AppSqlCacheConfiguration(){}

        public AppSqlCacheConfiguration(IdentitySiteSettings siteSettings)
        {
            _siteSettings = siteSettings;
        }

        public void Configure(EntityTypeBuilder<AppSqlCache> builder)
        {
            // For Microsoft.Extensions.Caching.SqlServer
            //var cacheOptions = _siteSettings.CookieOptions.DistributedSqlServerCacheOptions;
            //builder.ToTable(cacheOptions.TableName, cacheOptions.SchemaName);
            builder.ToTable("AppSqlCache", "dbo");
            builder.HasIndex(e => e.ExpiresAtTime).HasName("Index_ExpiresAtTime");
            builder.Property(e => e.Id).HasMaxLength(449);
            builder.Property(e => e.Value).IsRequired();
        }
    }
}