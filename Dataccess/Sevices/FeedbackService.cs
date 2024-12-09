
using API.DTOs;
using Dataccess.Entities;
using Dataccess.Repositories.Feedbacks;

namespace Dataccess.Sevices
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public FeedbackService()
        {
        }

        public async Task<Feedback> SubmitFeedbackAsync(FeedbackDTO feedbackDto)
        {
            var feedback = new Feedback
            {
                ProductId = feedbackDto.ProductId,
                Comment = feedbackDto.Comment,
                Rating = feedbackDto.Rating
            };

            await _feedbackRepository.AddAsync(feedback);
            return feedback;
        }

        public async Task<Feedback?> GetFeedbackByIdAsync(int feedbackId)
        {
            return await _feedbackRepository.GetByIdAsync(feedbackId);
        }

        public async Task<IEnumerable<Feedback>> GetFeedbackByProductIdAsync(int productId)
        {
            return await _feedbackRepository.GetByProductIdAsync(productId);
        }

        public async Task<double> GetAverageRatingAsync(int productId)
        {
            var feedbacks = await _feedbackRepository.GetByProductIdAsync(productId);
            if (!feedbacks.Any())
                return 0;

            return feedbacks.Average(f => f.Rating);
        }
    }
}

