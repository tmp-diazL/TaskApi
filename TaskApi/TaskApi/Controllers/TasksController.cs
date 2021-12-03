using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApi.Data.Entities;

namespace TaskApi.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskApiDbContext _context;

        public TasksController(TaskApiDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetTask()
        {
            try
            {
                var tasks = _context.Tasks
                    .AsNoTracking()
                    .Include(t => t.Category)
                    .ToList();

                return Ok(tasks);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}