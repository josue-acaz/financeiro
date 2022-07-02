using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Interfaces.Repository
{
    public interface IStateRepository
    {
        Task Create(State state);
        Task<State> GetById(int id);
        Task Update(State state);
        Task<IEnumerable<State>> GetAll();
        Task Delete(int id);
    }
}