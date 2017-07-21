using Laganoid.GameObjects;
using Laganoid.Infrastructure;

namespace Laganoid.Persistence
{
    public class ScoreDAO : BaseDAO
    {
        public ScoreDAO(Score score)
        {
            // Constructor using the itself
        }

        DatabaseHelper datbaseHelper = new DatabaseHelper();

        public override void save(/* Data to save */)
        {
            datbaseHelper.openDatabase();
            // Persist data

            datbaseHelper.closeDatabase();
        }
        // Others persistences methods
    }
}
