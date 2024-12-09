using Dataccess.Entities;

namespace Dataccess.Repositories.Feedbacks
{
    // Gränssnitt för feedbackrepositoryt enligt Repository Pattern
    public interface IFeedbackRepository
    {
        Task AddAsync(Feedback feedback);
        Task<Feedback?> GetByIdAsync(int feedbackId);
        Task<IEnumerable<Feedback>> GetByProductIdAsync(int productId);
    }
}
