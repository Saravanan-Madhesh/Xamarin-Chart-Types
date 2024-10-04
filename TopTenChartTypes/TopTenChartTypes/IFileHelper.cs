using SQLite;

namespace TopTenChartTypes
{
    public interface IFileHelper
    {
        SQLiteConnection DbConnection();
    }
}
