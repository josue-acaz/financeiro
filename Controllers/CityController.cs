using System;
using Microsoft.AspNetCore.Mvc;
using Api.Interfaces.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;
using Api.Models;
using Api.Controllers.Models;
using Api.Data;

namespace Api.Controllers
{
    [ApiController]
    [Route("/v1/cities")]
    public class CityController : ControllerBase
    {
        private readonly IDataContext _context;
        private readonly ICityRepository _cityRepository;

        public CityController(IDataContext context, ICityRepository cityRepository)
        {
            _context = context;
            _cityRepository = cityRepository;
        }

        [HttpPost("")]
        public async Task<ActionResult> Store(StoreCity storeCity)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var city = new City
                {
                    name = storeCity.name,
                    state_id = storeCity.state_id
                };

                await _cityRepository.Create(city);

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();

                return Ok();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                return BadRequest(exception);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateCity updateCity)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var city = new City
                {
                    id = id,
                    name = updateCity.name,
                    state_id = updateCity.state_id
                };

                await _cityRepository.Update(city);

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();

                return Ok();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                return BadRequest(exception);
            }
        }
    
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<City>>> Index()
        {
            var cities = await _cityRepository.GetAll();
            return Ok(cities);
        }
    }
}
