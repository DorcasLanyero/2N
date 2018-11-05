using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TWON
{
	class ServerManager
	{
		const int Port = 6000;

		private TcpListener listener;

		//Waits for incoming clients
		void WaitForClients()
		{

		}

		//deals with any clients
		public Task HandleClientAsync(TcpClient tcpClient)
		{
			return Task.Run(() => {
				try
				{
					using (tcpClient)
					{
						string clientEndPoint = tcpClient.Client.RemoteEndPoint.ToString();

						NetworkStream networkStream = tcpClient.GetStream();
						StreamReader reader = new StreamReader(networkStream);
						StreamWriter writer = new StreamWriter(networkStream);
					}
				}
				catch (Exception)
				{
				}
			});
		}
	}
}
