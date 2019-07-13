using AutoMapper;
using FinalADS.Application.Accounts.Dtos;
using FinalADS.Domain.Accounts.Entities;
using System;

namespace FinalADS.Application.Accounts.Assemblers
{
    public class NewAccountAssembler
    {
        private readonly IMapper _mapper;

        public NewAccountAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Account ToEntity(NewAccountDto newAccountDto)
        {
            Account account = _mapper.Map<Account>(newAccountDto);
            DateTime utcNow = DateTime.UtcNow;
            account.CreatedAt = utcNow;
            account.UpdatedAt = utcNow;
            return account;
        }
        public Articulo ToEntityArticulo(Articulo newArticulo)
        {
            Articulo Articulo = _mapper.Map<Articulo>(newArticulo);
            DateTime utcNow = DateTime.UtcNow;
           // Articulo.Contenido = utcNow;
            //account.UpdatedAt = utcNow;
            return Articulo;
        }



    }
}
