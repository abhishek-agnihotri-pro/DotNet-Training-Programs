using Microsoft.EntityFrameworkCore;
 
namespace GenericRepositoryPatternWebAPI.UnitOfWork;
public interface IUnitOfWork
{
    DbContext Context {get;}
    public Task SaveChangesAsync();
}