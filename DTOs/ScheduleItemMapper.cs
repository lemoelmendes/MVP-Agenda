using MVP_Agenda.Models;
using System.Reflection.Metadata.Ecma335;

namespace MVP_Agenda.DTOs
{
    public static class ScheduleItemMapper
    {
        public static ScheduleItem ToEntity(CreateScheduleItemDto dto)
        {
            return ScheduleItem.Create(dto.Title, dto.Description, dto.ScheduleAt);
        }

        public static void UpdateEntity(ScheduleItem entity, UpdateScheduleItemDto dto)
        {
            entity.Update(dto.Title, dto.Description, dto.ScheduleAt, dto.Status);

            if (dto.Status.HasValue)
            {
                switch (dto.Status.Value)
                {
                    case ScheduleStatus.Completed:
                        entity.Complete();
                        break;

                    case ScheduleStatus.Cancelled:
                        entity.Cancel();
                        break;
                }
            }
        }

        public static ResponseScheduleItemDto ToResponse(ScheduleItem entity)
        {
            return new ResponseScheduleItemDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                ScheduleAt = entity.ScheduleAt,
                Status = entity.Status,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
