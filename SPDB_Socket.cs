using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPDB_Server
{
    public delegate String StrHandler(String str);

    class SPDB_Socket
    {
        public string userName;
        public Socket socket;
        public NetworkStream stream;
        public StreamReader reader;
        public StreamWriter writer;
        public StrHandler inHandler;
        public EndPoint remoteEndPoint;

        public SPDB_Socket(Socket s)
        {
            socket = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            remoteEndPoint = socket.RemoteEndPoint;
        }

        public void send(String line)
        {
            writer.WriteLine(line);
            writer.Flush();
        }

        public static SPDB_Socket connect(String ip)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), 4427);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ipep);
            return new SPDB_Socket(socket);
        }

        public Thread newListener(StrHandler pHandler)
        {
            inHandler = pHandler;

            Thread listenThread = new Thread(new ThreadStart(listen));
            listenThread.Start();
            return listenThread;
        }

        public void listen()
        {
            try
            {
                while (true)
                {
                    String line = reader.ReadLine();
                    inHandler(line);
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}
