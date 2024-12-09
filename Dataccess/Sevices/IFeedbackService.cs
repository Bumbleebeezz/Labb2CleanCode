using API.DTOs;
using Dataccess.Entities;

namespace Dataccess.Sevices
{
    public interface IFeedbackService
    {
        Task<Feedback> SubmitFeedbackAsync(FeedbackDTO feedbackDto);
        Task<Feedback?> GetFeedbackByIdAsync(int feedbackId);
        Task<IEnumerable<Feedback>> GetFeedbackByProductIdAsync(int productId);
        Task<double> GetAverageRatingAsync(int productId);
    }
}
