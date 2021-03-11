using BasicStudentsDataAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicStudentsDataAPI.Controllers
{
    public class StudentsController : ApiController
    {
        List<Student> students = new List<Student>();

        public StudentsController()
        {
            students.Add(new Student { FirstName = "boSunrise", Lastname = "Maseokoma", Id = 1 });
            students.Add(new Student { FirstName = "Jonathan", Lastname = "Meyer", Id = 2 });
            students.Add(new Student { FirstName = "Andréa", Lastname = "Reid", Id = 3 });
        }

        [Route("api/Students/GetFirstnames")]
        [HttpGet]
        public List<string> GetFirstnames()
        {
            List<string> output = new List<string>();

            foreach (var s in students)
            {
                output.Add(s.FirstName);
            }

            return output;
        }

        // GET: api/Students
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Students/5
        public Student Get(int id)
        {
            return students.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Students
        public void Post(Student val)
        {
            students.Add(val);
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
