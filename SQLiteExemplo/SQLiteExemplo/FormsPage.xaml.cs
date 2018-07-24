using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteExemplo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsPage : ContentPage
	{
        public Member member;
        public MemberDataBase memberData;
		public FormsPage ()
		{
			InitializeComponent ();
		}

        private void InsertMember(object sender, EventArgs e)
        {
            member = new Member()
            {
                Name = memberName.Text,
                Age= memberAge.Text
            
            };
            memberData = new MemberDataBase();
            memberData.AddMember(member);
            DisplayAlert("Membro", "Adicionado com Sucesso", "OK");
        }

        private void ShowMembers(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MemberList());
        }
    }
}