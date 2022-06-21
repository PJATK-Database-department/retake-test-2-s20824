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

        public async Task<bool> UpdateActionEndTime(int actionId, DateTime endTime)
        {
            var updateEndTime = new Models.Action
            {
                IdAction = actionId,
                EndTime = endTime
            };

            _context.Actions.Attach(updateEndTime);
            _context.Entry(updateEndTime).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public async Task<bool> checkIfActionExists(int actionId)
        {
            var checkIfActionExists = await _context.Actions
                                        .AnyAsync(x => x.IdAction == actionId);

            if (checkIfActionExists == false)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> checkIfEndTimeValid(DateTime endTime)
        {
            var checkIfEndTimeValid = await _context.Actions
                                            .AnyAsync(x => x.StartTime <= endTime);

            if (checkIfEndTimeValid == false)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> checkIfEndTimeExists(DateTime endTime)
        {
            var checkIfEndTimeExists = await _context.Actions
                                                .AnyAsync(x => x.EndTime == null);

            if (checkIfEndTimeExists == false)
            {
                return false;
            }
            return true;
        }
    }
}
