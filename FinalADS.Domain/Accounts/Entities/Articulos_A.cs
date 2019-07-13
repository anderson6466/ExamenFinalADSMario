using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalADS.Domain.Accounts.Entities
{
   public  class Articulos_A : Entity
    {










        public virtual   string Titulo { get; set; }
        public virtual string fecha { get; set; }
        public virtual int id_Autor { get; set; }
        public virtual string stringResumen { get; set; }
        public virtual string Contenido { get; set; }
        public virtual  string Formato { get; set; }




     
        public Articulos_A()
        {
        }

       

     

        public virtual bool HasIdentity()
        {
            return Titulo.Trim() != string.Empty;
        }

       /* public virtual void WithdrawMoney(decimal amount)
        {
            Notification notification = CanWithdrawMoney(amount);
            ThrowExceptionIfAny(notification);
            Balance = Balance - amount;
        }

        public virtual Notification CanWithdrawMoney(decimal amount)
        {
            Notification notification = new Notification();
            if (amount <= 0)
            {
                notification.AddError(AccountConstants.AmountMustBeGreaterThanZero);
            }
            if (!HasIdentity())
            {
                notification.AddError(AccountConstants.AccountHasNoIdentity);
            }
            if (Locked)
            {
                notification.AddError(AccountConstants.AccountIsLocked);
            }
            if (!CanBeWithdrawed(amount))
            {
                notification.AddError(AccountConstants.CannotWithdrawAmountIsGreaterThanBalance);
            }
            return notification;
        }

        public virtual bool CanBeWithdrawed(decimal amount)
        {
            return !Locked && Balance >= amount;
        }

        public virtual void DepositMoney(decimal amount)
        {
            Notification notification = CanDepositMoney(amount);
            ThrowExceptionIfAny(notification);
            Balance = Balance + amount;
        }

        public virtual Notification CanDepositMoney(decimal amount)
        {
            Notification notification = new Notification();
            if (amount <= 0)
            {
                notification.AddError(AccountConstants.AmountMustBeGreaterThanZero);
            }
            if (!HasIdentity())
            {
                notification.AddError(AccountConstants.AccountHasNoIdentity);
            }
            if (Locked)
            {
                notification.AddError(AccountConstants.AccountIsLocked);
            }
            return notification;
        }

    */
    }
}
