using GenericRepositoryPatternWebAPI.Models;
using GenericRepositoryPatternWebAPI.Repository;
using GenericRepositoryPatternWebAPI.UnitOfWork;
 
namespace GenericRepositoryPatternWebAPI.Repository;
public class CategoryRepository:RepositoryBase<Category>
{
    public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}