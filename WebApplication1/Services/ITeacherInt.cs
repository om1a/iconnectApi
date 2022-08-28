using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ITeacherInt
    {
        Task<List<teacher>> GetTeacher();
        Task<teacher> GetById(int id);
        Task<List<teacher>> CreateTeacher(teacher newTeacher);
        Task<List<teacher>> UpdateTeacher(teacher updateTeacher1);
        Task<List<teacher>> DeleteTeacher(int id);

    }
}
