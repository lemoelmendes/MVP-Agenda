using MVP_Agenda.Models;

namespace MVP_Agenda.DTOs
{
    public class UpdateScheduleItemDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? ScheduleAt { get; set; }
        public ScheduleStatus? Status { get; set; }
    }
}
