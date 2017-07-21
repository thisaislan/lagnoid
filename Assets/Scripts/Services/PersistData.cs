using Laganoid.Infrastructure;

namespace Laganoid.Services
{
    class PersistData
    {
        public void PersistScore(BaseDAO baseDAO)
        {
            baseDAO.save(/* Data to save */);
        }
    }
}
