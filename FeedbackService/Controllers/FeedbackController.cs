
using FeedbackService.DTOs;
using FeedbackService.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetAllFeedbacksOnProduct(int id)
        {
            var feedback = await _feedbackService.GetFeedbackByProductIdAsync(id);
            if (feedback == null)
                return NotFound();

            return Ok(feedback);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedback(int id)
        {
            var feedback = await _feedbackService.GetFeedbackByIdAsync(id);
            if (feedback == null)
                return NotFound();

            return Ok(feedback);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback([FromBody] FeedbackDTO feedbackDto)
        {
            var feedback = await _feedbackService.SubmitFeedbackAsync(feedbackDto);
            return CreatedAtAction(nameof(GetFeedback), new { id = feedback.Id }, feedback);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFeedback(int id)
        {
            var feedback = await _feedbackService.GetFeedbackByIdAsync(id);
            if (feedback == null)
                return NotFound();


            return Ok(feedback);
        }
    }
}
