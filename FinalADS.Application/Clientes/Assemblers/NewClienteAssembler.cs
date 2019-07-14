using AutoMapper;
using FinalADS.Application.Clientes.Dtos;
using FinalADS.Domain.Clientes.Entities;
using System;

namespace FinalADS.Application.Clientes.Assemblers
{
    public class NewClienteAssembler
    {
        private readonly IMapper _mapper;

        public NewClienteAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Articulo ToEntity(NewClienteDto newClienteDto)
        {
            Articulo cliente = _mapper.Map<Articulo>(newClienteDto);
           
            return cliente;
        }
    }
}
