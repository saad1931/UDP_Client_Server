using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace UDP_Client_Server
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("This is UDP server");

            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress ip = host.AddressList[0];
            //IPEndPoint ipe = new IPEndPoint(ip, 12000);

            //Socket handler = new Socket(ip.AddressFamily, SocketType.Dgram, ProtocolType.Udp);

            //handler.ExclusiveAddressUse = false;
            //handler.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //byte[] buffer = new byte[1024];
            //handler.Bind(ipe);

            //EndPoint sender = (EndPoint)ipe;
            //while (true)
            //{
            //    string data = "";

            //    handler.ReceiveFrom(buffer, ref sender);

            //    data = Encoding.ASCII.GetString(buffer);
            //    Console.WriteLine(data);


            //}
            //handler.Shutdown(SocketShutdown.Both);
            //handler.Close();

            //Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////




            //UDP Client//

            //Console.WriteLine("This is UDP client");

            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress ip = host.AddressList[0];
            //IPEndPoint ipe = new IPEndPoint(ip, 12000);

            //Socket handler = new Socket(ip.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            //handler.ExclusiveAddressUse = false;
            //handler.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //byte[] buffer = new byte[1024];
            //handler.Bind(ipe);

            //EndPoint sender = (EndPoint)ipe;
            //while (true)
            //{
            //    string data = "hi";
            //    buffer = Encoding.ASCII.GetBytes(data);
            //    handler.SendTo(buffer, sender);
            //}


            //handler.Shutdown(SocketShutdown.Both);
            //handler.Close();


            //Console.ReadLine();
        }
    }
}
