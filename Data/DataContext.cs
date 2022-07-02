using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data 
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<CardOperator> CardOperators { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<ContactPf> ContactPfs { get; set; }
        public DbSet<ContactPj> ContactPjs { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<CostCenterType> CostCenterTypes { get; set; }
        public DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Permisson> Permissons { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionCategory> TransactionCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}
