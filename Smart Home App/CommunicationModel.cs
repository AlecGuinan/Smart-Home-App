using System.Diagnostics;
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
        static string response;
        IPAddress ipAdress;
        IPEndPoint ipEndPoint;
        static Socket client;

        public CommunicationModel() {

            ipAdress = IPAddress.Parse("127.0.0.1");
            ipEndPoint = new(ipAdress, 48620);
            client = new(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            client.ConnectAsync(ipEndPoint);
        }

        public static void sendTCP(string message)
        {
            var buffer = Encoding.UTF8.GetBytes(message);
            client.SendAsync(buffer);
        }

        public static async void getTCP()
        {
            var buffer = new byte[4096];

            var received = await client.ReceiveAsync(buffer, SocketFlags.None);
            response = Encoding.UTF8.GetString(buffer, 0, received);
        }
    }
}
