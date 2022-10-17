using ASM.Share.Interfaces;
using cty.Helpers;
using cty.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Istudent _student;
        public  StudentController(Istudent student)
        {
            _student = student ;
        }

        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentAll()
        {
            var list = await _student.GetAllStudent();
            return list;
        }

        [HttpPost]
        [ActionName("create")]
        public async Task<ActionResult> AddStudent(Student student)
        {
            try
            {
                int id = await _student.AddStudent(student);
                student.ID_Student = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpPost]
        [ActionName("update")]
        public async Task<ActionResult> UpdateStudent(int id, Student student)
        {
            try
            {
                await _student.EditStudent(id, student);
                student.Id = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("deltete")]
        public async Task<ActionResult<int>> DeleteStudent(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _student.DeleteStudent(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }

    }
}
