using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Application.UseCases.TaskManager.Delete;
using TaskManagerAPI.Application.UseCases.TaskManager.GetAll;
using TaskManagerAPI.Application.UseCases.TaskManager.GetById;
using TaskManagerAPI.Application.UseCases.TaskManager.Register;
using TaskManagerAPI.Application.UseCases.TaskManager.Update;
using TaskManagerAPI.Communication.Requests;
using TaskManagerAPI.Communication.Responses;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredTaskManagerJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)] 
        public IActionResult Register([FromBody] RequestTaskManagerJson request)
        {
            var useCase = new RegisterTaskManagerUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute]int id, [FromBody] RequestTaskManagerJson request )
        {
            var useCase = new UpdateTaskManagerUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTaskManagerJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTaskManagerUseCase();

            var response = useCase.Execute();

            if (response.TaskManager.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskManagerJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            var useCase = new GetTaskManagerByIdUseCase();

            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskManagerGetByIdUseCase();

            useCase.Execute(id);
            return NoContent();
        }
    }


}
