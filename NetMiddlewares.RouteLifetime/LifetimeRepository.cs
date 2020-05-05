using System;
using System.Collections.Generic;

namespace NetMiddlewares.RouteLifetime
{
    public class LifetimeRepository : ILifetimeRepository
    {
        private readonly Dictionary<string, DateTime> _entries;

        public LifetimeRepository()
        {
            _entries = new Dictionary<string, DateTime>();
        }

        public void AddEntry(string path)
        {
            _entries[path] = DateTime.Now;
        }

        public IDictionary<string, DateTime> GetEntries()
        {
            return _entries;
        }
    }
}