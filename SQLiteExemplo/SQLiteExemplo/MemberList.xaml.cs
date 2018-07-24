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
	public partial class MemberList : ContentPage
	{
        public MemberDataBase memberDataBase;
        public MemberList ()
		{
			InitializeComponent ();
            memberDataBase = new MemberDataBase();
            var members = memberDataBase.GetMembers();
            listMembers.ItemsSource = members;
		}

        private async void OnSelect(object sender, ItemTappedEventArgs e)
        {
            var member = e.Item as Member;
            await DisplayAlert("You select", member.Name + " " +member.Age ,"OK");
        }
    }
}