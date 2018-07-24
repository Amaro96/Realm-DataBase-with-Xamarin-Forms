using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteExemplo
{
   public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
   
    }
}
