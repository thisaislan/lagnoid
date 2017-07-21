using Laganoid.Infrastructure;
using Laganoid.Persistence;
using UnityEngine;

namespace Laganoid.Services
{
    public class Closer
    {     
        public static void CloseGame(/* Data to send if need it */)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            NetworkConnection networkConnection = new NetworkConnection();

            if (databaseHelper.databaseIsOpen())
            {
                databaseHelper.closeDatabase();
            }

            if (networkConnection.serverIsConnected())
            {
                networkConnection.closeServerConnection();
            }

            Application.Quit();            
        }
    }
}
