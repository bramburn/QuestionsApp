using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Model;

public partial class ApplicationDbContext:DbContext,IApplicationDbContext
{
    private readonly DbContextOptions<ApplicationDbContext> _options;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    {
        _options = options;
    }
}