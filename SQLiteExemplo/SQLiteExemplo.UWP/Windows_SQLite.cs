using SQLite;
using SQLiteExemplo.UWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Windows_SQLite))]
namespace SQLiteExemplo.UWP
{
    public class Windows_SQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Member.sqlite";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}