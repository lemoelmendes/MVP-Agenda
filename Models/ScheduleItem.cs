namespace MVP_Agenda.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTimeOffset ScheduleAt { get; set; }
        public ScheduleStatus Status { get; set; } = ScheduleStatus.Pending;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    }

    public enum ScheduleStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}
