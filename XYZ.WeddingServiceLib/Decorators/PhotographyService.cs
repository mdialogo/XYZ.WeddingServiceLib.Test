using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYZ.WeddingServiceLib
{
    public class PhotographyService : EventServiceDecorator
    {
        public PhotographyService(IEventService eventService) : base(eventService) { }

        public override decimal Cost
        {
            get { return base.Cost + 15000; }
        }
    }
}
