using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElevatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly IElevatorService _elevatorService;
        public ElevatorController(IElevatorService elev)
        {
            _elevatorService = elev;
        }

        [HttpGet]
        [Route("next")]
        public IActionResult GetNextFloor()
        {
            var data = _elevatorService.RequestNextFloor();
            if (data == null)
            {
                return NotFound("No Next Floor Available");
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllFloor()
        {
            var data = _elevatorService.RequestAllFloors();
            if (data == null)
            {
                return NotFound("No Floors Available");
            }
            return Ok(data);
        }
    }
}