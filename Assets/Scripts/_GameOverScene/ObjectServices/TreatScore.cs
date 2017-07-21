using Laganoid.GameObjects;
using Laganoid.Persistence;
using Laganoid.Services;

namespace Laganoid.ObjectServices
{
    public class TreatScore
    {
        private PersistData persistData;
        private DataSender dataSender;

        public void SaveScore(Score score)
        {
            persistData = new PersistData();
            persistData.PersistScore(new ScoreDAO(score));
        }

        public void SendScore(Score score)
        {
            // Get data to send with score or another data
            string data = score.GetScore().ToString(); // + "Data to send";
            dataSender = new DataSender();
            dataSender.SendDataToServer(data);
        }
    }
}
