using MVP_Agenda.Data;
using MVP_Agenda.DTOs;
using Microsoft.EntityFrameworkCore;

namespace MVP_Agenda.Services
{
    public class ScheduleItemService : IScheduleItemService
    {
        private readonly AppDbContext _context;

        public ScheduleItemService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseScheduleItemDto> CreateAsync(CreateScheduleItemDto dto)
        {
            var entity = ScheduleItemMapper.ToEntity(dto);
            
            _context.ScheduleItems.Add(entity);
            await _context.SaveChangesAsync();
            
            return ScheduleItemMapper.ToResponse(entity);
        }

        public async Task<IEnumerable<ResponseScheduleItemDto>> GetAllAsync()
        {
            var entities = await _context.ScheduleItems.ToListAsync();
            
            return entities.Select(ScheduleItemMapper.ToResponse);
        }

        public async Task<ResponseScheduleItemDto?> GetByIdAsync(int id)
        {
            var entity = await _context.ScheduleItems.FindAsync(id);
            
            if (entity is null)
                return null;
            
            return ScheduleItemMapper.ToResponse(entity);
        }

        public async Task<bool> UpdateAsync(int id, UpdateScheduleItemDto dto)
        {
            var entity = await _context.ScheduleItems.FindAsync(id);
            
            if (entity is null)
                return false;

            ScheduleItemMapper.UpdateEntity(entity, dto);
            
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.ScheduleItems.FindAsync(id);
            
            if (entity is null)
                return false;

            _context.ScheduleItems.Remove(entity);
            await _context.SaveChangesAsync();
            
            return true;
        }
    }
}