using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using FinalADS.Application.Clientes.Contracts;
using FinalADS.Application.Clientes.Dtos;
using FinalADS.Application.Clientes.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalADS.API.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/articulos")]
    [ApiController]
    public class ArticulosController : Controller
    {
        private readonly IClienteApplicationService _clienteApplicationService;
        private readonly IClientesQueries _clientesQueries;

        public ArticulosController(IClienteApplicationService clienteApplicationService, IClientesQueries clientesQueries)
        {
            _clienteApplicationService = clienteApplicationService;
            _clientesQueries = clientesQueries;


        }


        [HttpPost("registra")]
        public IActionResult Register([FromBody] NewClienteDto newClienteDto)
        {
            NewClienteResponseDto response = _clienteApplicationService.Register(newClienteDto);
            return StatusCode(response.HttpStatusCode, response.Response);
        }

        // nuevo

        [HttpGet("lista")]
        public IActionResult GetListPaginated(string formatoID, [FromQuery]int page = 0, [FromQuery]int pageSize = 10)
        {
            try
            {
                List<ClienteDto> clientes = _clientesQueries.GetListPaginated(formatoID, page, pageSize);
                return StatusCode(StatusCodes.Status200OK, clientes);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }

        // nuevo


    }
}