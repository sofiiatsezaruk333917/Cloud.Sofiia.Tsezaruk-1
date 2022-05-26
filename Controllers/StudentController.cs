using HostelNaUOA.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelNaUOA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_studentServices.GetStudent());
        }
        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent(string id)
        {
            return Ok(_studentServices.GetStudent(id));
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentServices.AddStudent(student);
            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(string id)
        {
            _studentServices.DeleteStudent(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            return Ok(_studentServices.UpdateStudent(student));
        }

    }
}
/* 


        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent(string id)
        {
            return Ok(_studentServices.GetStudent(id));
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentServices.AddStudent(student);
            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(string id)
        {
            _studentServices.DeleteStudent(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            return Ok(_studentServices.UpdateStudent(student));
        }
    }*/