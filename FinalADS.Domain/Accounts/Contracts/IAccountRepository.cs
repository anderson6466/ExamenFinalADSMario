using FinalADS.Domain.Accounts.Entities;
using Common;

namespace FinalADS.Domain.Accounts.Contracts
{
    public interface IAccountRepository : IRepository<Autor>
    {
        Autor GetByNumber(string accountNumber);
        Autor GetByNumberWithUpgradeLock(string accountNumber);
    }
}
