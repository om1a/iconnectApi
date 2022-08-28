using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class teacherS: ITeacherInt
    {
        private static List<teacher> teachers = new List<teacher>
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
        public async Task<List<teacher>> CreateTeacher(teacher newTeacher)
        {
            teachers.Add(newTeacher);
            return (teachers);
        }

        public async Task<List<teacher>> DeleteTeacher(int id)
        {
            teacher tG = teachers.First(x => x.Id == id);
            teachers.Remove(tG);
            return (teachers);
        }

        public async Task<List<teacher>> GetTeacher()
        {
            return teachers;
        }

        public async Task<teacher> GetById(int id)
        {
            return (teachers.First(x => x.Id == id));
        }

        /**/
        /**/

        public async Task<List<teacher>> UpdateTeacher(teacher updateTeacher1)
        {
            teacher tG = teachers.First(x => x.Id == updateTeacher1.Id);
            tG.FirstName = updateTeacher1.FirstName;
            tG.LastName = updateTeacher1.LastName;
            tG.Id = updateTeacher1.Id;

            return teachers;
        }
    }
}
