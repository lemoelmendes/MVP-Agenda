using MVP_Agenda.Models;

namespace MVP_Agenda.DTOs
{
    public class ResponseScheduleItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset ScheduleAt { get; set; }
        public ScheduleStatus Status { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
