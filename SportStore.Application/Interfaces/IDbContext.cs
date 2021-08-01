using Microsoft.EntityFrameworkCore;
using SportStore.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SportStore.Application.Interfaces
{
    public interface IDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
