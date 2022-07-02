using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Interfaces.Repository;
using Api.Data;
using Api.Models;
using Npgsql;
using System.Linq;

namespace Api.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly IDataContext _context;

        public StateRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task Create(State state)
        {
            _context.States.Add(state);
            await _context.SaveChangesAsync();
        }

        public async Task<State> GetById(int id)
        {
            // USING METHOD
            // await _context.States.FindAsync(id);

            // USING RAW QUERY
            var stateId = new NpgsqlParameter("id", id);
            string query = "SELECT * FROM states AS state WHERE state.id=@id AND state.deleted=false";

            return await _context.States.FromSqlRaw(query, stateId).SingleAsync();
        }

        public async Task Update(State state)
        {
            var update_state = await _context.States.FindAsync(state.id);

            if(update_state == null)
            {
                throw new NullReferenceException();
            }

            update_state.prefix = state.prefix;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<State>> GetAll()
        {
            return await _context.States.ToListAsync();
        }

        public async Task Delete(int id)
        {
            var state = await _context.States.FindAsync(id);

            if(state == null)
            {
                throw new NullReferenceException();
            }

            state.deleted = true;
            await _context.SaveChangesAsync();
        }
    }
}