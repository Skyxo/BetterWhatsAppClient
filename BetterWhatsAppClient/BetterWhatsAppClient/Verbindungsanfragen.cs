using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace BetterWhatsAppClient
{
    class Verbindungsanfragen
    {
        private Socket servSock = null;
        public void annehmen()
        {
            try
            {
                servSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                servSock.Bind(new IPEndPoint(IPAddress.Any, 8080));
                servSock.Listen(3);
            }
            catch (SocketException se)
            {
                Environment.Exit(se.ErrorCode);
            }
        }
        public string receiveMessage()
        {
          
            byte[] rcvBuffer = new byte[8192];
            string Nachricht = "";
            Socket Client = null;
            try
            {
                Client = servSock.Accept();
                Client.Receive(rcvBuffer, rcvBuffer.Length, SocketFlags.None);
                Nachricht = ASCIIEncoding.ASCII.GetString(rcvBuffer);
            }
            catch (Exception)
            {
               
            }
            finally { Client.Shutdown(SocketShutdown.Both); Client.Close();}
            return Nachricht;
        
        }


    }
}
