using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYZ.WeddingServiceLib
{
    public class SeminarService : EventService
    {
        public override decimal Cost
        {
            get { return 5000; }
        }
    }
}
