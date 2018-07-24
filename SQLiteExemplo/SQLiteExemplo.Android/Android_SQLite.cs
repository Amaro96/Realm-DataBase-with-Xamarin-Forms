using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLiteExemplo.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Android_SQLite))]
namespace SQLiteExemplo.Droid
{
   public class Android_SQLite: ISQLite
    {
        public SQLite.SQLiteConnection GetConnection()
        {
            var dbName = "Members.sqlite";
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = System.IO.Path.Combine(dbpath, dbName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}