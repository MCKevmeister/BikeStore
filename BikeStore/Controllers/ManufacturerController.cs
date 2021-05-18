using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BikeStore.Server.Controllers
{
    public class ManufacturerController
    {
        [Microsoft.AspNetCore.Components.Route("api/manufacturer")]
        [ApiController]
        public class BookController : ControllerBase
        {
            private readonly ManufacturerRepository _manufacturerRepository;

            public BookController(ManufacturerRepository manufacturerRepository)
            {
                _manufacturerRepository = manufacturerRepository;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Manufacturer>>> Get()
            {
                var manufacturers = await _manufacturerRepository.GetByID();
                return Ok(manufacturers);
            }
 
            [HttpGet("{id}")]
            public async Task<ActionResult<Manufacturer>> Get(string id)
            {
                var manufacturer = await _manufacturerRepository.GetByID(id);
                return Ok(manufacturer);
            }
        }
    }
}