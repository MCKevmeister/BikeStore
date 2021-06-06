using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;

namespace BikeStoreApi.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private static IUnitOfWork _unitOfWork;

        public ManufacturerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Manufacturer>> GetAll()
        {
            var manufacturers = await _unitOfWork.ManufacturerRepository.GetAll();
            return manufacturers;
        }
        public async Task<Manufacturer> Get(Manufacturer manufacturer)
        {
            return await _unitOfWork.ManufacturerRepository.GetByName(manufacturer.Name);
        }
        public async Task<Manufacturer> Create(Manufacturer manufacturer)
        {
            await _unitOfWork.ManufacturerRepository.Create(manufacturer);
            return manufacturer;
        }
        public async Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer)
        {
            return await _unitOfWork.ManufacturerRepository.Update(updateManufacturer);
        }
        public async Task Remove(Manufacturer manufacturer)
        {
            await _unitOfWork.ManufacturerRepository.Delete(manufacturer);
        }
    }
}
