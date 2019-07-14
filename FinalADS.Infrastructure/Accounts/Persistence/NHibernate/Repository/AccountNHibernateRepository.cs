using FinalADS.Domain.Accounts.Contracts;
using FinalADS.Domain.Accounts.Entities;
using FinalADS.Infrastructure.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Linq;

namespace FinalADS.Infrastructure.Accounts.Persistence.NHibernate.Repository
{
    public class AccountNHibernateRepository : NHibernateRepository<Autor>, IAccountRepository
    {
        public AccountNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }

        public Autor GetByNumber(string accountNumber)
        {
            return _unitOfWork.GetSession()
                .Query<Autor>()
                .SingleOrDefault(x => x.Nombres == accountNumber);
        }

        public Autor GetByNumberWithUpgradeLock(string accountNumber)
        {            
            ICriteria criteria = _unitOfWork.GetSession().CreateCriteria<Autor>();
            criteria.SetLockMode(LockMode.Upgrade);
            criteria.Add(Restrictions.Eq("Number", accountNumber));
            Autor account = (Autor) criteria.UniqueResult();
            return account;
        }
    }
}
