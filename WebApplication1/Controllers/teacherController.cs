using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class teacherController : Controller
    {
        public static List<teacher> teachers = new List<teacher>
            {
                new teacher
                {
                    Id = 1,
                    FirstName = "Alaa",
                    LastName = "Sawadeh",
                    City = "Ram-Allah"
                },new teacher
                {
                    Id = 2,
                    FirstName = "Omar",
                    LastName = "Nour",
                    City = "Tulkarem"
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<teacher>>> Get()
        {
            return Ok(teachers);

        }
        [HttpPost]
        public async Task<ActionResult<List<teacher>>> AddTeacher(teacher tP)
        {
            teachers.Add(tP);
            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<teacher>> Get(int id)
        {
            var tG = teachers.Find(x => x.Id == id);
            if (tG == null)
                return BadRequest("Teacher Not Found.");
            return Ok(tG);
        }
        [HttpPut]
        public async Task<ActionResult<List<teacher>>> UpdateTeacher(teacher request)
        {
            var tG = teachers.Find(x => x.Id == request.Id);
            if (tG == null)
                return BadRequest("Teacher Not Found.");
            tG.FirstName = request.FirstName;
            tG.LastName = request.LastName;
            tG.City = request.City;
            return Ok(teachers);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<teacher>>> Delete(int id)
        {
            var tG = teachers.Find(x => x.Id == id);
            if (tG == null)
                return BadRequest("Teacher Not Found.");

            teachers.Remove(tG);
            return Ok(teachers);
        }

    }
}
