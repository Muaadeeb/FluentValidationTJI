using FluentValidationTJI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationTJI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        // Code First:
        // 1). add-migration initialCommitAnyMessage
        // 2). update-database

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Alpha> Alphas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alpha>().HasData(new Alpha
            {
                Id = 1,
                ModelName = "Sample model 1",
                ModelType = "Sample model type",
                IsActive = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "Sample create user",
                EditedDate = DateTime.Now,
                EditedBy = "Sample create user",
                OriginModelId = 1,
                LastRebalanced = null,
                ChangeReason = "Change Reason 1",
                LastChangeReason = DateTime.Now.AddMinutes(1),
                ModelLevel = 1,
                UseRestrictions = false,
                IsDynamic = false,
                DynamicEffectiveDate = null
            });

            modelBuilder.Entity<Alpha>().HasData(new Alpha
            {
                Id = 2,
                ModelName = "Sample model 2",
                ModelType = "Sample model type",
                IsActive = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "Sample create user",
                EditedDate = DateTime.Now,
                EditedBy = "Sample create user",
                OriginModelId = 2,
                LastRebalanced = null,
                ChangeReason = "Change Reason 1",
                LastChangeReason = DateTime.Now.AddMinutes(1),
                ModelLevel = 2,
                UseRestrictions = false,
                IsDynamic = false,
                DynamicEffectiveDate = null
            });

            modelBuilder.Entity<Alpha>().HasData(new Alpha
            {
                Id = 3,
                ModelName = "Sample model 3",
                ModelType = "Sample model type",
                IsActive = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "Sample create user",
                EditedDate = DateTime.Now,
                EditedBy = "Sample create user",
                OriginModelId = 3,
                LastRebalanced = null,
                ChangeReason = "Change Reason 3",
                LastChangeReason = DateTime.Now.AddMinutes(1),
                ModelLevel = 3,
                UseRestrictions = false,
                IsDynamic = false,
                DynamicEffectiveDate = null
            });
        }
    }
}
