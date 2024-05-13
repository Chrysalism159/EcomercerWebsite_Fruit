using Microsoft.EntityFrameworkCore;

namespace EcomercerWebsite_Fruit.Models
{
    public class EcomercerDataContext : DbContext
    {
        public EcomercerDataContext()
        {
        }

        public EcomercerDataContext(DbContextOptions<EcomercerDataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Bill> bills { get; set; }
        public virtual DbSet<BillInformation> billInformation { get; set; }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Favorite> favorites { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<ProductType> productTypes { get; set; }
        public virtual DbSet<Provider> providers { get; set; }
        public virtual DbSet<StatementInformation> statementInformation { get; set; }

    }
}
