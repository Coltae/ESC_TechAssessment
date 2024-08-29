using ColtEavesESCTechAssessment.DTO;
using ColtEavesESCTechAssessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ColtEavesESCTechAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CoreDbContext _dbContext;
        public EmployeeController(CoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*
         * Endpoints
         */
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            if (_dbContext.Employees == null)
            {
                return NotFound();
            }
            else
            {
                var employee = await _dbContext.Employees.ToListAsync();
                return Ok(await _dbContext.Employees.ToListAsync());
                //return Ok (output = _dbContext.Employees.Select(x => new EmployeeInformtionDTO { 
                //    EmployeeId = x.EmployeeId,
                //    Dependents = x.Dependents.Select(dep => new DependentDTO { DependentId = dep.DependentId }).ToList(),
                //    Job = new JobDTO { JobId = x.Job.JobId, JobTitle = x.Job.JobTitle, MaxSalary = x.Job.MaxSalary, MinSalary = x.Job.MinSalary},
                //    Department = new DepartmentDTO { DepartmentId = x.Department.DepartmentId, DepartmentName = x.Department.DepartmentName, LocationId = x.Department.LocationId},
                //}).ToList());
            }
        } //EmployeeResultDataDTO

        [HttpGet("{EmployeeId}")]
        [Produces("application/json")]
        public async Task<ActionResult<Employee>> GetEmployee(int EmployeeId)
        {
            if (_dbContext.Employees == null)
            {
                return NotFound();
            }
            var employee = await _dbContext.Employees.FindAsync(EmployeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

    }
}
