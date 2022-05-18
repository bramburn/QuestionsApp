using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public partial class ApplicationDbContext:DbContext
{
    private readonly DbContextOptions<ApplicationDbContext> _options;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    {
        _options = options;
    }
}