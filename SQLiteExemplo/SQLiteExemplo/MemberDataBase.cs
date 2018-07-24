using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SQLiteExemplo
{

    public class MemberDataBase
    {
        private SQLiteConnection conn;


        public MemberDataBase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Member>();
        }

        public IEnumerable<Member> GetMembers()
        {
            var members = (from men in conn.Table<Member>() select men);
            return members.ToList();
        }
        public  string AddMember(Member member)
        {
            conn.Insert(member);
            return "Success";
        }
        public string DeleteMember(int id)
        {
            conn.Delete<Member>(id);
            return "success";
        }
        
    }
}