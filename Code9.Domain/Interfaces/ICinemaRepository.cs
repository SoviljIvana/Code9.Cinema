using Code9.Domain.Models;

namespace Code9.Domain.Interfaces
{
    public interface ICinemaRepository
    {
        public Task<List<Cinema>> GetAllCinemas();

        public Task<Cinema> Add(Cinema Cinema);

        public Task<Cinema> Update(Cinema Cinema);
    }
}
