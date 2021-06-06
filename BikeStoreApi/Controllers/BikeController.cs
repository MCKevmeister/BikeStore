/*
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeRepository _bikeRepository;

        public BikeController(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        [HttpGet("{name}", Name = "GetBikeAsync")]
        public async Task<IActionResult> GetBikeAsync(string name, CancellationToken cancellationToken = default)
        {
            var matchedBike = await _bikeRepository.GetByName(name);
            if (matchedBike == null)
                return BadRequest(new ArgumentException($"Can not find {name}"));
            return Ok(new BikeResponse(matchedBike));
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Bike>> GetAll(CancellationToken cancellationToken = default) =>
            await _bikeRepository.GetAll();

        [HttpPost("Create")]
        public async Task<ActionResult<Bike>> Create(string name, CancellationToken cancellationToken = default)
        {
            var bike = await _bikeRepository.GetByName(name);

            if (bike != null)
                return BadRequest(new BikeResponse(false, $"{bike.Name} already exists"));
            
            var newBike = await _bikeRepository.Create(name, cancellationToken);

            return Ok(new BikeResponse(true,$"{newBike.Name} created", newBike));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBikeAsync(UpdateBike updateBike, CancellationToken cancellationToken = default)
        {
            var oldBikeName = updateBike.OldBike.Name;
            
            var oldBikeCheck = await _bikeRepository.GetByName(oldBikeName);
            
            if (oldBikeCheck == null)
                return NotFound();

            var newBikeCheck = await _bikeRepository.GetByName(oldBikeName);

            if (newBikeCheck != null)
            {
                return BadRequest(new BikeResponse(false, updateBike.NewBike.Name + " already exists"));
            }
            
            var response = await _bikeRepository.Update(updateBike , cancellationToken);
            
            if (response.ErrorMessage != null)
                return BadRequest(new BikeResponse(false, response.ErrorMessage));
            
            var updatedBike = await _bikeRepository.GetByName(updateBike.NewBike.Name);
            
            return Ok(new BikeResponse(updatedBike));
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string name, CancellationToken cancellationToken = default)
        {
            var bike = await _bikeRepository.GetByName(name);

            if (bike == null) 
                return NotFound();
            await _bikeRepository.Delete(bike);

            var deletedBike = await _bikeRepository.GetByName(name);
            if (deletedBike == null)
            {
                return Ok(new BikeResponse(true, $"{name} has been deleted"));
            }

            return BadRequest(new BikeResponse(false, $"{name} was not deleted"));
        }
    }
}
*/

