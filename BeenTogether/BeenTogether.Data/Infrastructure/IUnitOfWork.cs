using BeenTogether.Data.Infrastructure.Repositories;
using BeenTogether.Models;

namespace BeenTogether.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        BeenTogetherContext BeenTogetherContext { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        ICoreRepository<T> CoreRepository<T>() where T : class;

        #region Master Data

        ICoreRepository<Love> LoveRepository { get; }

        ICoreRepository<Hobby> HobbyRepository { get; }

        ICoreRepository<ImageMemory> ImageMemoryRepository { get; }

        ICoreRepository<Story> StoryRepository { get; }

        ICoreRepository<Comment> CommentRepository { get; }

        #endregion
    }
}
