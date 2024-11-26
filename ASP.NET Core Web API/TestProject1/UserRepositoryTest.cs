namespace TestProject1;

using Microsoft.EntityFrameworkCore;
using WebApplication2.Controllers;
using WebApplication2.Models;
using WebApplication2.repository;

public class UserRepositoryTest
{
    private readonly UserRepository _userRepository;
    private readonly AppDbContext _context;

    public UserRepositoryTest(){
        var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
        _context = new AppDbContext(options);
        _userRepository = new UserRepository(_context);
    }
    
    [Fact]
    public async Task GetUserAsync_ReturnsUser_WhenUserExists()
    {
        int userId = 1;
        var user = new User { Id = userId};
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        
        //act
        var result = await _userRepository.GetUserAsync(userId);

        //assert
        Assert.Equal(user,result);
    }
}