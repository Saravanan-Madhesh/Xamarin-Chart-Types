//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TopTenChartTypes;
//using Windows.Storage;

//namespace TopTenChartTypes.UWP
//{
//    internal class Class1
//    {
//    }
//}

using TopTenChartTypes;
using TopTenChartTypes.UWP;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace TopTenChartTypes.UWP
{
    public class FileHelper : IFileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            var path = Path.Combine(ApplicationData.
              Current.LocalFolder.Path, dbName);
            return new SQLite.SQLiteConnection(path);
        }
    }
}

