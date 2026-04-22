using static MVP_Agenda.Models.ScheduleStatus;

namespace MVP_Agenda.Models
{
    public class ScheduleItem
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string? Description { get; private set; }
        public DateTimeOffset ScheduleAt { get; private set; }
        public ScheduleStatus Status { get; private set; } = ScheduleStatus.Pending;
        public DateTimeOffset CreatedAt { get; private init; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; private set; } = DateTimeOffset.UtcNow;

        public static ScheduleItem Create(string title, string? description, DateTimeOffset scheduleAt)
        {
            return new ScheduleItem
            {
                Title = title,
                Description = description,
                ScheduleAt = scheduleAt,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow,
                Status = ScheduleStatus.Pending
            };
        }

        public void Update(string? title, string? description, DateTimeOffset? scheduleAt, ScheduleStatus? status)
        {
            if (title is not null)
                Title = title;

            if (description is not null)
                Description = description;

            if (scheduleAt.HasValue)
                ScheduleAt = scheduleAt.Value;

            UpdatedAt = DateTimeOffset.UtcNow;
        }

        public void Complete()
        {
            if (Status == ScheduleStatus.Cancelled)
                throw new InvalidOperationException("Não pode concluir um horário cancelado.");

            Status = ScheduleStatus.Completed;
            UpdatedAt = DateTimeOffset.UtcNow;
        }

        public void Cancel()
        {
            if (Status == ScheduleStatus.Completed)
                throw new InvalidOperationException("Não pode cancelar um horário concluído.");

            Status = ScheduleStatus.Cancelled;
            UpdatedAt = DateTimeOffset.UtcNow;
        }
    }
    public enum ScheduleStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}
