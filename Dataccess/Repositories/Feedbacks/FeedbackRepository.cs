using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Feedbacks
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly FeedbackDbContext _dbContext;

        public FeedbackRepository(FeedbackDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Feedback feedback)
        {
            await _dbContext.Feedbacks.AddAsync(feedback);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Feedback?> GetByIdAsync(int feedbackId)
        {
            return await _dbContext.Feedbacks.FindAsync(feedbackId);
        }

        public async Task<IEnumerable<Feedback>> GetByProductIdAsync(int productId)
        {
            return await _dbContext.Feedbacks
                .Where(f => f.ProductId == productId)
                .ToListAsync();
        }
    }
}
