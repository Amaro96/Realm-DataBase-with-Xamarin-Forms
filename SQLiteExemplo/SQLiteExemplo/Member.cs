using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteExemplo
{
    public class Member
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public Member() {}
       
    }
}
