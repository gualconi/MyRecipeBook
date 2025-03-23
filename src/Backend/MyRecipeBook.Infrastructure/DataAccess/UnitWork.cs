using MyRecipeBook.Domain.Repositories;

namespace MyRecipeBook.Infrastructure.DataAccess;

public class UnitWork : IUnitWork
{
    private readonly MyRecipeBookDbContext _dbContext;

    public UnitWork(MyRecipeBookDbContext dbContext) => _dbContext = dbContext;

    public async Task Commit() => await _dbContext.SaveChangesAsync();
}
