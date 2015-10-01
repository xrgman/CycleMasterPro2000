﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class Networkconnect
    {
        private NetworkCommunication networkCommunication;
        public string status { get; set; }
        public string power, time, distance;

        public Networkconnect(string ipAdress, int port)
        {
            networkCommunication = new NetworkCommunication(ipAdress, port, this);
            if (networkCommunication.ConnectToServer())
                status = "Connected";
            else
                status = "Can't connect to: " + ipAdress + ":" + port;
        }

        public SslStream getStream()
        {
            return networkCommunication.getStream();
        }

        public void login(string username, string password)
        {
            networkCommunication.SendMessage("LO\tusername\tpassword");
        }

        public void sendBikeValues(string power, string time, string distance)
        {
            networkCommunication.SendMessage("BV\tpower\ttime\tdistance");
        }

        public void sendMeasurement(Measurement measurement)
        {
            //Send object;
        }
    }
}
