using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Code9.Infrastructure.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaDbContext _dbContext;

        public CinemaRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Cinema>> GetAllCinemas()
        {
            return await _dbContext.Cinemas.ToListAsync();
        }
        public async Task<Cinema> Add(Cinema Cinema)
        {
             
              var cinema=  await _dbContext.Cinemas.AddAsync(Cinema);
            return cinema.Entity;
        }
        public async Task<Cinema> Update(Cinema Cinema) {
             return await _dbContext.Cinemas.FindAsync(Cinema);
           
           
        }
    }
}