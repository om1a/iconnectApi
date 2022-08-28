using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class teacherController : Controller
    {
            public ITeacherInt _teacherService;

            public teacherController(ITeacherInt teacherService)
            {
                _teacherService = teacherService;

            }
            [HttpGet("GetTeacher")]
            public async Task<ActionResult<List<teacher>>> Get()
            {
                return Ok(_teacherService.GetTeacher());
            }

            [HttpGet("GetById/{id}")]
        public async Task<ActionResult<teacher>>GetById(int id)
            {

                return Ok(_teacherService.GetById(id));
            }

            [HttpPost("NewTeacher")]

            public async Task<ActionResult<List<teacher>>> CreateTeacher(teacher newTeacher)
            {

                return Ok(_teacherService.CreateTeacher(newTeacher));
            }

            [HttpPut("Update")]
            public async Task<ActionResult<List<teacher>>> UpdateTeacher(teacher updateTeacher)
            {

                return Ok(_teacherService.UpdateTeacher(updateTeacher));
            }

            [HttpDelete("Delete/{id}")]
            public async Task<ActionResult<List<teacher>>> DeleteTeacher(int id)
            {

                return Ok(_teacherService.DeleteTeacher(id));
            }

        }
    }