using ApbdTest2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly s20824Context _context;
        public DatabaseService(s20824Context context)
        {
            _context = context;
        }

        public async Task<ICollection<FireTruck>> GetFireTrucksAsync(int fireTruckId)
        {
            var fireTrucks = await _context.FireTrucks
                                            .Where(x => x.IdFireTruck == fireTruckId)
                                            .Include(x => x.FireTruckActions)
                                                .ThenInclude(x => x.IdActionNavigation)
                                                .ThenInclude(x => x.FireTruckActions)
                                            .ToListAsync();

            return fireTrucks;
        }

        public async Task<bool> CheckIfFireTruckExists(int fireTruckId)
        {
            var checkTruckId = await _context.FireTrucks
                                            .AnyAsync(x => x.IdFireTruck == fireTruckId);

            if (checkTruckId == false)
            {
                return false;
            }

            return true;
        }

        public Task<bool> UpdateActionEndTime(int actionId)
        {
            throw new NotImplementedException();
        }
    }
}
