using TaskManagerAPI.Communication.Responses;

namespace TaskManagerAPI.Application.UseCases.TaskManager.GetById;

    public class GetTaskManagerByIdUseCase
    {
        public ResponseTaskManagerJson Execute(int id)
        {
            return new ResponseTaskManagerJson 
            { 
                Id = id, Name = "anderson", 
                Description = "Salve rapadiaza", 
                Status = Communication.Enums.TaskManagerStatus.EmAndamento, 
                DueDate = new DateTime(year:2020, month: 10, day:10), 
                Priority = Communication.Enums.TaskManagerPriorityLevel.Baixa 
            
             };
        
         }
     }
