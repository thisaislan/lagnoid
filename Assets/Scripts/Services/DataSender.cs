using Laganoid.Infrastructure;

namespace Laganoid.Services
{
    class DataSender
    {
        NetworkConnection networkConnection = new NetworkConnection();

        public void SendDataToServer(string data)
        {
            // Process data if need

            networkConnection.openServerConnection();

            // Send data to network Server

            networkConnection.closeServerConnection();
        }
    }
}
