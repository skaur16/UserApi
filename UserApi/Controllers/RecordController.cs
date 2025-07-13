using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserApi.Database;
using UserApi.Models;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordContext _context;

        public RecordsController(RecordContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Record>>> GetRecords()
            => await _context.Records.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Record>> GetRecord(int id)
        {
            var record = await _context.Records.FindAsync(id);
            if (record == null) return NotFound();
            return record;
        }

        [HttpPost]
        public async Task<ActionResult<Record>> PostRecord(Record record)
        {
            _context.Records.Add(record);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRecord), new { id = record.Id }, record);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecord(int id, Record record)
        {
            if (id != record.Id) return BadRequest();
            _context.Entry(record).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
