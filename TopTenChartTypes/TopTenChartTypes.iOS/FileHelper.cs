﻿using System;
using SQLite;
using System.IO;
 
[assembly: Xamarin.Forms.Dependency(typeof(TopTenChartTypes.iOS.FileHelper))]
 
namespace TopTenChartTypes.iOS
{
    public class FileHelper : IFileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }

}
