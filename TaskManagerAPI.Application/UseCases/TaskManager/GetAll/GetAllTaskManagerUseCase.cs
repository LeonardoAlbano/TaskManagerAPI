using TaskManagerAPI.Communication.Responses;

namespace TaskManagerAPI.Application.UseCases.TaskManager.GetAll
{
    public class GetAllTaskManagerUseCase
    {
        public ResponseAllTaskManagerJson Execute()
        {
            return new ResponseAllTaskManagerJson
            {
               /* TaskManager = new List<ResponseShortTaskManagerJson>
                {
                    new ResponseShortTaskManagerJson
                    {
                        Id = 1,
                        Name = "Correr",
                        Description = "Segunda a sexta as 14h00",
                        Priority = Communication.Enums.TaskManagerPriorityLevel.Alta
                    }
                }*/
            };
        }
    }
}
