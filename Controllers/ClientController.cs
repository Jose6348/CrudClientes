using CrudClient.Application.UseCases.Expanses.Get;
using CrudClient.Application.UseCases.Expanses.Register;
using CrudClient.Comunication.Request;
using CrudClient.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace CrudClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpPost]

        public IActionResult Register(
            [FromServices] RegisterExpansesUseCase useCase,
            [FromBody] RequestRegisterClient request)
        {

            try
            {
                var response = useCase.Execute(request);

                return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
            }
            catch (ValidacaoException ex) { 
            return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id) => Ok();

        [HttpGet]

        public IActionResult GetAll([FromServices] GetAllExpansesUseCase useCase)
        {
            var response = useCase.Execute();

            return Ok(response);
        }
    }
}
