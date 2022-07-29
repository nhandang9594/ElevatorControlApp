using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace PersonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService person)
        {
            _personService = person;
        }

        [HttpGet]
        [Route("next/{nextFloor}")]
        public IActionResult RequestElevator(int nextFloor)
        {
            var data = _personService.RequestElevator(nextFloor);
            if (data == 0)
            {
                return Ok("Elevator is already at that Floor");
            }
            return Ok("Elevator has arrived at floor " + nextFloor + ".");
        }

        [HttpGet]
        [Route("all/{currFloor}/{nextFloor}")]
        public IActionResult RequestFloor(int currFloor, int nextFloor)
        {
            var data = _personService.RequestFloor(currFloor, nextFloor);
            if (data == 0)
            {
                return Ok("Elevator is already at that Floor");
            }
            return Ok("Elevator has arrived at " + nextFloor + ".");
        }
    }
}