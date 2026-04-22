using System.ComponentModel.DataAnnotations;

namespace MVP_Agenda.DTOs
{
    public class CreateScheduleItemDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        [Required]
        public DateTimeOffset ScheduleAt { get; set; }
    }
}
