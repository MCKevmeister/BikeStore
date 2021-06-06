using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;

namespace BikeStoreApi.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private static IUnitOfWork _unitOfWork;
        private static IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository,IUnitOfWork unitOfWork)
        {
            _manufacturerRepository = manufacturerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            var manufacturers = await _manufacturerRepository.GetAll();
            return manufacturers;
        }
        public async Task<Manufacturer> Get(Manufacturer manufacturerIn)
        {
            var manufacturer = await _manufacturerRepository.Get(manufacturerIn.Name);
            return manufacturer;
        }
        public async Task<Manufacturer> Create(Manufacturer manufacturer)
        {
            await _manufacturerRepository.Create(manufacturer);
            return manufacturer;
        }
        public async Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer)
        {
            return await _manufacturerRepository.Update(updateManufacturer);
        }
        public async Task Remove(Manufacturer manufacturer)
        {
            await _manufacturerRepository.Delete(manufacturer);
        }
    }
}
