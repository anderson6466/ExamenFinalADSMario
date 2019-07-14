﻿using FinalADS.Domain.Clientes.Entities;
using Common;

namespace FinalADS.Domain.Clientes.Contracts
{
    public interface IClienteRepository : IRepository<Articulo>
    {
        //Cliente GetByNumber(string accountNumber);
        //Cliente GetByNumberWithUpgradeLock(string accountNumber);
    }
}
