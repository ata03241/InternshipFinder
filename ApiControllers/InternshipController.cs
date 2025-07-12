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
        public async Task<IActionResult> GetInternships(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                return BadRequest("Location parameter is required.");
            }

            try
            {
                var internships = await _internshipService.GetInternshipsAsync(location);
                return Ok(internships);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error fetching internships: {ex.Message}");
            }
        }
    }
}
