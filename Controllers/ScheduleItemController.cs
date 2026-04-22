using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVP_Agenda.DTOs;
using MVP_Agenda.Services;

namespace MVP_Agenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleItemController : ControllerBase
    {
        private readonly IScheduleItemService _service;
        
        public ScheduleItemController(IScheduleItemService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseScheduleItemDto>> Create(CreateScheduleItemDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseScheduleItemDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseScheduleItemDto>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<ResponseScheduleItemDto>> Update(int id, UpdateScheduleItemDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (!updated)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
