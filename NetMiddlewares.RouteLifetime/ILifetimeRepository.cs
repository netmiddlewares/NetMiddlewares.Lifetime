using System;
using System.Collections.Generic;

namespace NetMiddlewares.RouteLifetime
{
    public interface ILifetimeRepository
    {
        void AddEntry(string path);
        IDictionary<string, DateTime> GetEntries();
    }
}