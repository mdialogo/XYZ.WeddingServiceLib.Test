using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYZ.WeddingServiceLib
{
    public abstract class EventServiceDecorator : EventService
    {
        private IEventService eventService;

        public EventServiceDecorator(IEventService eventService)
        {
            this.eventService = eventService;
        }

        public override decimal Cost
        {
            get { return eventService.Cost; }
        }
    }
}
