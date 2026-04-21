namespace MVP_Agenda.DTOs
{
    public class CreateScheduleItemDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTimeOffset ScheduleAt { get; set; }
    }
}
