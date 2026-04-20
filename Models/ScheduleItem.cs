namespace MVP_Agenda.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Descrition { get; set; }
        public DateTimeOffset ScheduleAt { get; set; }
        public SchedulingStatus Status { get; set; } = SchedulingStatus.Pending;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    }

    public enum SchedulingStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}
