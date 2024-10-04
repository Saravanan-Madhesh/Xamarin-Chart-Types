//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TopTenChartTypes.Droid
//{
//    internal class FileHelper
//    {
//    }
//}

using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(TopTenChartTypes.Droid.FileHelper))]

namespace TopTenChartTypes.Droid
{
    public class FileHelper : TopTenChartTypes.IFileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}