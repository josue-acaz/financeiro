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
    public class CityRepository : ICityRepository
    {
        private readonly IDataContext _context;

        public CityRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task Create(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var city = await _context.Cities.FindAsync(id);

            if(city == null)
            {
                throw new NullReferenceException();
            }

            city.deleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetById(int id)
        {
            var cityId = new NpgsqlParameter("id", id);
            string query = "SELECT * FROM cities AS city WHERE city.id=@id AND city.deleted=false";

            return await _context.Cities.FromSqlRaw(query, cityId).SingleAsync();
        }

        public async Task Update(City city)
        {
            var update_city = await _context.Cities.FindAsync(city.id);

            if(update_city == null)
            {
                throw new NullReferenceException();
            }

            update_city.name = city.name;
            update_city.state_id = city.state_id;

            await _context.SaveChangesAsync();
        }
    }
}