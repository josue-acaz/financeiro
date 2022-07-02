using System;
using Microsoft.AspNetCore.Mvc;
using Api.Interfaces.Repository;
using System.Threading.Tasks;
using Api.Models;
using System.Collections.Generic;
using Api.Controllers.Models;
using Api.Data;

namespace Api.Controllers
{
    [ApiController]
    [Route("/v1/states")]
    public class StateController : ControllerBase
    {
        private readonly IDataContext _context;
        private readonly IStateRepository _stateRepository;

        public StateController(IDataContext context, IStateRepository stateRepository)
        {
            _context = context;
            _stateRepository = stateRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<State>> Show(int id)
        {
            var state = await _stateRepository.GetById(id);

            if(state == null)
            {
                return NotFound();
            }

            return Ok(state);
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<State>>> Index()
        {
            var states = await _stateRepository.GetAll();
            return Ok(states);
        }

        [HttpPost("")]
        public async Task<ActionResult> Store(StoreState storeState)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var state = new State
                {
                    prefix = storeState.prefix,
                };

                await _stateRepository.Create(state);

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
    }
}
