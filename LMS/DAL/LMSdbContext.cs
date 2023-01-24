using LMS.Models;
using LMS.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LMS.DAL
{
    public class LMSdbContext : DbContext
    {
        public LMSdbContext() { }

        public LMSdbContext(DbContextOptions<LMSdbContext> options) : base(options) { }

       // public DbSet<LeaveTypeMaster> LeaveTypeMasters { get; set; }

        public DbSet<Employee>? Employee { get; set; }  

        public DbSet<UserMaster> UserMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning        To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=GF1KDYYL9P6P;Database=LMS;User Id=sa; Password=!Morning1;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }


       



        //public DbSet<EmpLeaveRegister> empLeaveRegister { get; set; }

        //public DbSet<EmpLeaveApplication> empLeaveApplication { get; set; } 

        //public DbSet<EmpComp_offRequest> empComp_offRequest { get;set; }

        //protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        //{

        //    builder.Properties<DateOnly>()
        //        .HaveConversion<DateOnlyConverter>()
        //        .HaveColumnType("date");

        //    base.ConfigureConventions(builder);

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var propertyNames = typeof(IModelBase).GetProperties()
        //    .Select(p => p.Name)
        //     .ToList();
        //    var entityTypes = modelBuilder.Model.GetEntityTypes()
        //        .Where(t => typeof(IModelBase).IsAssignableFrom(t.ClrType));
        //    foreach (var entityType in entityTypes)
        //    {
        //        var entityTypeBuilder = modelBuilder.Entity(entityType.ClrType);
        //        foreach (var propertyName in propertyNames)
        //            entityTypeBuilder.Ignore(propertyName);
        //    }

        //}


    }
}
