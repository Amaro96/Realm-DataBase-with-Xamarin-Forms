using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using SQLiteExemplo.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOS_SQLite))]
namespace SQLiteExemplo.iOS
{
  public  class IOS_SQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "Member.sqlite";
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder  
            string libraryPath = Path.Combine(dbPath, "..", "Library"); // Library folder  
            var path = Path.Combine(libraryPath, dbName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}