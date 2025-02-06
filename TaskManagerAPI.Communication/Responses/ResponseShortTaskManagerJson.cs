using TaskManagerAPI.Communication.Enums;

namespace TaskManagerAPI.Communication.Responses
{
    public class ResponseShortTaskManagerJson
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public TaskManagerPriorityLevel Priority { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }

        public TaskManagerStatus Status { get; set; }


    }
}
