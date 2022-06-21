using ApbdTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Services
{
    public interface IDatabaseService
    {
        Task<ICollection<FireTruck>> GetFireTrucksAsync(int fireTruckId);
        Task<bool> CheckIfFireTruckExists(int fireTruckId);
        Task<bool> UpdateActionEndTime(int actionId, DateTime endTime);
        Task<bool> checkIfActionExists(int actionId);
        Task<bool> checkIfEndTimeValid(DateTime endTime);
        Task<bool> checkIfEndTimeExists(DateTime endTime);
    }
}
