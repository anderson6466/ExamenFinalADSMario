using FinalADS.Application.Accounts.Contracts;
using FinalADS.Application.Accounts.Dtos;
using FinalADS.Application.Accounts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common;
using System;
using System.Collections.Generic;
using FinalADS.Application.Accounts.Constants;

namespace Banking.API.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/")]
    [ApiController]
    
    public class AccountsController : ControllerBase
    {
        private readonly IAccountApplicationService _accountApplicationService;
        private readonly IAccountQueries _accountQueries;

        public AccountsController(IAccountApplicationService accountApplicationService, IAccountQueries accountQueries)
        {
            _accountApplicationService = accountApplicationService;
            _accountQueries = accountQueries;
        }
        
        [HttpDelete("delete")]
        public IActionResult Delete(long accountId)
        {
            try
            {
                _accountQueries.DeleteAccount(accountId);
                return StatusCode(StatusCodes.Status200OK,  AccountAppConstants.AccountDelete);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }

        [HttpPost]
        public IActionResult Register(long accountId, [FromBody] NewAccountDto newAccountDto)
        { 
            NewAccountResponseDto response = _accountApplicationService.Register(newAccountDto);
            return StatusCode(response.HttpStatusCode, response.Response);
        }

        [HttpPost("RegistrarArticulo")]
        public IActionResult RegisterArticulo( [FromBody] Articulo newArticulo)
        {
            NewAccountResponseDto response = _accountApplicationService.RegisterArticulo(newArticulo);
            return StatusCode(response.HttpStatusCode, response.Response);
        }





        [HttpGet]
        public IActionResult GetListPaginated(long accountId, [FromQuery]int page = 0, [FromQuery]int pageSize = 10)
        {
            try
            {
                List<AccountDto> accounts = _accountQueries.GetListPaginated(accountId, page, pageSize);
                return StatusCode(StatusCodes.Status200OK, accounts);
            }
            catch (Exception ex)
            {
                //TODO: Log exception async, for now write exception in the console
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }


        [HttpGet("ListarArticulos")]
        public IActionResult GetListPaginatArticulos(long Formato, [FromQuery]int page = 0, [FromQuery]int pageSize = 10)
        {
            try
            {
                List<AccountDto> accounts = _accountQueries.GetListPaginated(Formato, page, pageSize);
                return StatusCode(StatusCodes.Status200OK, accounts);
            }
            catch (Exception ex)
            {
                //TODO: Log exception async, for now write exception in the console
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }


        [HttpGet("ListarAutores")]
        public IActionResult GetListPaginaAutores( [FromQuery]int page = 0, [FromQuery]int pageSize = 10)
        {
            try
            {
                List<AccountDto> accounts = _accountQueries.GetListPaginated(  page, pageSize);
                return StatusCode(StatusCodes.Status200OK, accounts);
            }
            catch (Exception ex)
            {
                //TODO: Log exception async, for now write exception in the console
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }



    }
}
