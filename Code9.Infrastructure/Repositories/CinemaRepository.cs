using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

        public void addCinema(string? name, string? city, string? street, int numSeats)
        {
            Cinema newCinema = new;
            
            newCinema.Name = name;
            newCinema.City = city;
            newCinema.Street = street;
            newCinema.NumberOfAuditoriums = numSeats;

            _dbContext.Cinemas.Add(newCinema);
        }

        public Cinema updateCinema(Guid ID, string? name, string? city, string? street, int numSeats)
        {
            Cinema updatedCinema = _dbContext.Find<Cinema>(ID);

            if(updatedCinema != null)
            {
                updatedCinema.Name = name;
                updatedCinema.City = city;
                updatedCinema.Street = street;
                updatedCinema.NumberOfAuditoriums = numSeats;
            }

            return updatedCinema;
        }
    }
}