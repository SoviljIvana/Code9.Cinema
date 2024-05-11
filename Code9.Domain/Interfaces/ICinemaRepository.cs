using Code9.Domain.Models;

namespace Code9.Domain.Interfaces
{
    public interface ICinemaRepository
    {
        public Task<List<Cinema>> GetAllCinemas();

        public void addCinema(Cinema c);

        public Cinema updateCinema(Guid ID, string? name, string? city, string? street, int numseats);
    }
}
