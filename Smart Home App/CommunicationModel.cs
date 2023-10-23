using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Smart_Home_App
{
    class CommunicationModel
    {   
        IPAddress ipAdress;
        IPEndPoint ipEndPoint;
        Socket client;

        public CommunicationModel() {

            ipAdress = IPAddress.Parse("127.0.0.1");
            ipEndPoint = new(ipAdress, 0);
            Socket client = new(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
