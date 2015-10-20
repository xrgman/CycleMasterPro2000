using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Network
{
    [Serializable]
    public class Session 
    {
        public DateTime startedDate { get; private set; }
        public List<Measurement> measurements = new List<Measurement>();

        public Session(DateTime startedDate)
        {
            this.startedDate = startedDate;

            /* Test waarden
            AddMeasurement(new Measurement(10, 10, 10, 10, 10, 10, "0:00", 10));
            AddMeasurement(new Measurement(20, 30, 40, 10, 49, 20, "0:01", 20));
            AddMeasurement(new Measurement(34, 50, 12, 19, 39, 21, "0:02", 30));
            AddMeasurement(new Measurement(30, 19, 28, 39, 27, 12, "0:03", 40));
            AddMeasurement(new Measurement(29, 12, 9, 12, 94, 29,  "0:04", 50));
            */
        }

        //deserialization function
        public Session(SerializationInfo info, StreamingContext ctxt)
        {
            try
            {
                startedDate = (DateTime)info.GetValue("startedDate", typeof(DateTime));
                measurements = (List<Measurement>)info.GetValue("measurements", typeof(List<Measurement>));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void AddMeasurement(Measurement measurement)
        {
            measurements.Add(measurement);
        }

        public List<Measurement> getMeasurement()
        {
            return measurements;
        }

        public Measurement GetLastMeasurement()
        {
            if (measurements.Count > 0)
                return measurements.Last();
            else
                return null;
        }

        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("startedDate", startedDate);
            info.AddValue("measurements", measurements);
        }
    }
}
