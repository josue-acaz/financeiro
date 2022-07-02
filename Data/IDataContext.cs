using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Api.Models;

namespace Api.Data
{
    public interface IDataContext
    {
        DatabaseFacade Database { get; }
        DbSet<Account> Accounts { get; set; }
        DbSet<Attachment> Attachments { get; set; }
        DbSet<CardOperator> CardOperators { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<ContactAddress> ContactAddresses { get; set; }
        DbSet<ContactInformation> ContactInformations { get; set; }
        DbSet<ContactPf> ContactPfs { get; set; }
        DbSet<ContactPj> ContactPjs { get; set; }
        DbSet<CostCenter> CostCenters { get; set; }
        DbSet<CostCenterType> CostCenterTypes { get; set; }
        DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        DbSet<File> Files { get; set; }
        DbSet<Installment> Installments { get; set; }
        DbSet<PaymentType> PaymentTypes { get; set; }
        DbSet<Permisson> Permissons { get; set; }
        DbSet<State> States { get; set; }
        DbSet<SystemLog> SystemLogs { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<TransactionCategory> TransactionCategories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserSetting> UserSettings { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
