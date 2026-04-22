using MVP_Agenda.DTOs;

namespace MVP_Agenda.Services
{
    public interface IScheduleItemService
    {
        Task<ResponseScheduleItemDto> CreateAsync(CreateScheduleItemDto dto);
        Task<IEnumerable<ResponseScheduleItemDto>> GetAllAsync();
        Task<ResponseScheduleItemDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateScheduleItemDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
