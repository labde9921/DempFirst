using DempFirst.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DempFirst.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DempFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _Employee;

        public EmployeeController(IEmployee employee)
        {
            _Employee = employee;
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();

                int rowCount = _Employee.Create(employee);

                if (rowCount == 0)
                    return BadRequest("Error in data saving");
                else
                    return Ok("Saved successfully");
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
  public IActionResult Detail(int empid) 
        {
            try
            {
                if (empid == 0)
                    return BadRequest();
             Employee employee=_Employee.Detail(empid);
                if (employee == null)
                    return BadRequest("Employee is not Found");
                
                
                return Ok(employee);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        
        }
    
    
    
    
    
    
    
    }
}
