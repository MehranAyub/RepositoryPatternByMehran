using Core.Application;
using Microsoft.AspNetCore.Mvc;
using Core.Data.Entities;

namespace WebApi.Controllers
{
    [Route("api/student/")]
    [ApiController]
    public class Student : ControllerBase

    {
        private IRepositoryWrapper _repository;
      
        public Student(IRepositoryWrapper repositoryWrapper)
        {
            _repository = repositoryWrapper;
          
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            try
            {
                var owners = _repository.Student.GetAllStudents();

                return Ok(owners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error"+ex);
            }
        }

        [HttpGet("{id}", Name = "StudentById")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var student = _repository.Student.GetStudentById(id);
                if (student == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(student);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error "+ex);
            }
        }

        [HttpGet("{id}/address")]
        public IActionResult GetStudentWithDetails(int id)
        {
            try
            {
                var student = _repository.Student.GetStudentWithDetails(id);
                if (student == null)
                {
                    return NotFound();
                }

                return new JsonResult(student);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error "+ex);
            }
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Core.Data.Entities.Student student)
        {
            try
            {
                if (student == null)
                {
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                

                _repository.Student.CreateStudent(student);
                _repository.Save();


                return CreatedAtRoute("StudentById", new { id = student.Id }, student);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Core.Data.Entities.Student student)
        {
            try
            {
                if (student == null)
                {
                    return BadRequest("student object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

             

                _repository.Student.UpdateStudent(student);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error "+ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var student = _repository.Student.GetStudentById(id);
                
                if (student == null)
                {
                    return NotFound();
                }

                _repository.Student.DeleteStudent(student);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error "+ex);
            }
        }
    }
}
