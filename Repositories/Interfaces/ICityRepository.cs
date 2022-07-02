using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Interfaces.Repository
{
    public interface ICityRepository
    {
        Task Create(City city);
        Task<City> GetById(int id);
        Task Update(City city);
        Task<IEnumerable<City>> GetAll();
        Task Delete(int id);
    }
}