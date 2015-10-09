﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace Network
{
    [Serializable]
    public class UserClient : User, ISerializable
    {
        public List<Session> sessions { get; }
        

        public UserClient(string username, string userPassword): base(username,userPassword)
        {
            sessions =  new List<Session>();
        }

        //deserialize method
        public UserClient(SerializationInfo info, StreamingContext ctxt)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (string)info.GetValue("password", typeof(string));
            //sessions = (List<Session>)info.GetValue("sessions", typeof(List<>));

        }


        public void addSession(DateTime startedDate)
        {
            Session s = new Session(startedDate);
        }

        public void addMeasurement(Measurement measurement)
        {
            Session s = sessions.Last();
            addMeasurement(s, measurement);
        }


        public void addMeasurement(Session session, Measurement measurement)
        {
            session.AddMeasurement(measurement);
        }

        public List<Session> getSessions()
        {
            return sessions;
        }

        public Session getLastSession()
        {
            if (sessions.Count > 0)
                return sessions.Last();
            else
                return null;
        }
         
        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
            //info.AddValue("sessions", sessions);
        }



    }
}
