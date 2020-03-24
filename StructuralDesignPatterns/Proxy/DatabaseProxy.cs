using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    public class DatabaseProxy
    {
        private Database Database { get; }
        private SemaphoreSlim SemaphoreSlim { get; }


        public DatabaseProxy(Database database)
        {
            Database = database;
            SemaphoreSlim = new SemaphoreSlim(Database.MaxConnections);
        }

        public async Task RequestAsync(int @int)
        {
            await SemaphoreSlim.WaitAsync();
            await Database.RequestAsync(@int);
            SemaphoreSlim.Release();
        }
    }
}
