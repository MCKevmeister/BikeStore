using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;

namespace BikeStoreApi.Repositories
{
    public interface IBikeRepository : IRepository
    {
        Task Update(UpdateBike updateBike, CancellationToken cancellationToken);
    }
}