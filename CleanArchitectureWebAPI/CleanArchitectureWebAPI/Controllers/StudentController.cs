using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain.Data;
using CleanArchitecture.Domain.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        #region [- Property -]
        private readonly ICustomService<Student> _customService;
        private readonly ProjectDbContext _applicationDbContext; 
        #endregion

        #region [- Ctor -]
        public StudentsController(ICustomService<Student> customService,
        ProjectDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region [- GetById() -]
        [HttpGet(nameof(GetStudentById))]
        public IActionResult GetStudentById(Guid? Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        #endregion

        #region [- GetAll() -]
        [HttpGet(nameof(GetAllStudent))]
        public IActionResult GetAllStudent()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        #endregion

        #region [- Create() -]
        [HttpPost(nameof(CreateStudent))]
        public IActionResult CreateStudent(Student student)
        {
            if (student != null)
            {
                _customService.Insert(student);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        #endregion

        #region [- Update() -]
        [HttpPost(nameof(UpdateStudent))]
        public IActionResult UpdateStudent(Student student)
        {
            if (student != null)
            {
                _customService.Update(student);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        #endregion

        #region [- Delete() -]
        [HttpDelete(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(Student student)
        {
            if (student != null)
            {
                _customService.Delete(student);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        } 
        #endregion
    }

}
