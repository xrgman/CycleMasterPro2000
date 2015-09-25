﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server_application
{
    class Session
    {
        public DateTime startedDate
        { get; private set; }

        public List<Measurement> measurements = new List<Measurement>();



        public Session(DateTime startedDate)
        {
            this.startedDate = startedDate;
        }

        public void AddMeasurement(Measurement measurement)
        {
            measurements.Add(measurement);
        }


        public List<Measurement> getMeasurement()
        {
            return measurements;
        }


    }
}
