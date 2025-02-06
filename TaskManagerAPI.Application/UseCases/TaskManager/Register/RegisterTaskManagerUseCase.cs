using TaskManagerAPI.Communication.Requests;
using TaskManagerAPI.Communication.Responses;

namespace TaskManagerAPI.Application.UseCases.TaskManager.Register
{
    public class RegisterTaskManagerUseCase
    {
        public ResponseRegisteredTaskManagerJson Execute(RequestTaskManagerJson request)
        {
            return new ResponseRegisteredTaskManagerJson
            {
                Id = 7,
                Name = request.Name,
            };
        }
    }
}
