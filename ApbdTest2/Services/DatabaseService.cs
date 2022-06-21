using ApbdTest2.Models;
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
    }
}
