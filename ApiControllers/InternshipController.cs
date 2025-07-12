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
            [FromQuery] string category = null,
            [FromQuery] string keyword = null,
            [FromQuery] DateTime? applicationDeadlineBefore = null,
            [FromQuery] bool? experienceRequired = null,
            [FromQuery] DateTime? publishedDate = null,
            [FromQuery] int? page = 1,
            [FromQuery] int? pageSize = 20)
        {
            if (string.IsNullOrEmpty(location))
            {
                return BadRequest("Location parameter is required.");
            }

            try
            {
                var internships = await _internshipService.GetInternshipsAsync(
                    location, number, category, keyword, applicationDeadlineBefore, experienceRequired,
                    publishedDate, page, pageSize);

                return Ok(internships);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error fetching internships: {ex.Message}");
            }
        }
    }
}