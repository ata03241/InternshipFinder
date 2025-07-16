using InternshipFinder.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipFinder.ApiControllers
{
    [Route("internship")]
    [ApiController]
    public class InternshipController : ControllerBase
    {
        private readonly InternshipService _internshipService;

        public InternshipController(InternshipService internshipService)
        {
            _internshipService = internshipService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInternships(
            [FromQuery] string location = null,
            [FromQuery] int? number = null,
            [FromQuery] string headline = null,
            [FromQuery] string keyword = null,
            [FromQuery] bool? experienceRequired = null,
            [FromQuery] bool? drivingLicenseRequired = null,
            [FromQuery] int? page = 1,
            [FromQuery] int? pageSize = 20)
        {
            try
            {
                var internships = await _internshipService.GetInternshipsAsync(
                    location, number, headline, keyword, experienceRequired, drivingLicenseRequired
                    , page, pageSize);

                return Ok(internships);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error fetching internships: {ex.Message}");
            }
        }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetInternshipById(int id)
        // {
        //     try
        //     {
        //         var internship = await _internshipService.GetInternshipByIdAsync(id);
        //         if (internship == null)
        //         {
        //             return NotFound();
        //         }
        //         return Ok(internship);
        //     }
        //     catch (Exception ex)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError, $"Error fetching internship: {ex.Message}");
        //     }
        // }
        
    }
}