using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GenericRepositoryPatternWebAPI.UnitOfWork;
 
namespace GenericRepositoryPatternWebAPI.Repository;
public abstract class RepositoryBase<T> : ControllerBase, IRepository<T> where T : class
{
    protected readonly DbContext _context;
    protected DbSet<T> dbSet;
    private readonly IUnitOfWork _unitOfWork;
    public RepositoryBase(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        dbSet = _unitOfWork.Context.Set<T>();
    }
    //Get Request
    public async Task<ActionResult<IEnumerable<T>>> Get()
    {
        var data = await dbSet.ToListAsync();
        return Ok(data);
    }
 
    public async Task<ActionResult<T>> Create(T entity)
    {
        dbSet.Add(entity);
        await _unitOfWork.SaveChangesAsync();
        return entity;
    }
 
    public async Task<ActionResult<T>> Update(int id, T entity)
    {
 
        var existingrecord = await dbSet.FindAsync(id);
        if (existingrecord == null)
        {
            return NotFound();
        }
 
        _unitOfWork.Context.Entry(existingrecord).CurrentValues.SetValues(entity);
 
        try
        {
            await _unitOfWork.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            throw;
        }
 
        return NoContent();
    }
 
    public async Task<ActionResult<T>> Delete(int id)
    {
        var data = await dbSet.FindAsync(id);
        if (data == null)
        {
            return NotFound();
        }
 
        dbSet.Remove(data);
        await _unitOfWork.SaveChangesAsync();
        return NoContent();
    }
}