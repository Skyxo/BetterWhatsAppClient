using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace BetterWhatsAppClient.Sender
{
    class UserManager
    {

        public List<User> GetUserList()
        {
            List<User> userList = new List<User>();



            return userList;
        }

        private void SendUserListRequest()
        {
            string serverIp = "";
            int port = 200;
            IPAddress serverIpAddress = IPAddress.Parse(serverIp);
            IPEndPoint endPoint = new IPEndPoint(serverIpAddress, port);

            string message = "Anfrage UserList";

            Socket socket;

            try
            {
                socket = new Socket(serverIpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(endPoint);



                socket.Send(Encoding.ASCII.GetBytes(message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
