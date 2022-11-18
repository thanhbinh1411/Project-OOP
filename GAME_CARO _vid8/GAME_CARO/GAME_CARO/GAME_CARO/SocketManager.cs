using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GAME_CARO
{
    public class SocketManager
    {
        #region Client
        Socket client;
        public bool ConnectSever()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Sever
        Socket sever;
        public void CreateSever()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sever.Bind(iep);
            sever.Listen(10);

            Thread accepClient = new Thread(() =>
            {
                client = sever.Accept();
            });
            accepClient.IsBackground = true;
            accepClient.Start();
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public const int BUFFER = 1024;
        public bool isServer = true;

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
            return SendData(client, sendData);
        }
        public object Receive()
        {
            byte[] receiveData = new byte[BUFFER];
            bool isOk = ReceiveData(client, receiveData);
            return DeserializeData(receiveData);
        }
        private bool SendData(Socket taget, byte[] data)
        {
            return taget.Send(data) == 1 ? true : false;
        }
        private bool ReceiveData(Socket taget, byte[] data)
        {
            return taget.Receive(data) == 1 ? true : false;

        }

        // Nen doi tuong thanh mang byte
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        //Giai nen 1 mang byte thanhf 1 doi tuong (object)
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        //Lay ra IP v4 cua card mang dang dung
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    foreach(UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        if (ip.Address.AddressFamily==AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();

                        }
            return output;
        }
        #endregion

    }
}
