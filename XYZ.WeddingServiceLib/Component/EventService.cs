using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYZ.WeddingServiceLib
{
    public abstract class EventService : IEventService
    {
        public abstract decimal Cost { get; }
    }
}
