using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteExemplo.Teste
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteTest : ContentPage
	{
        private SQLiteConnection _connection;
        private ObservableCollection<Test> _test;
        
        List<Test> testa = new List<Test>();

        public SQLiteTest ()
		{
			InitializeComponent ();
            _connection = DependencyService.Get<ISQLite>().GetConnection();

            _test = new ObservableCollection<Test>(testa);
		}
         protected async override void OnAppearing()
        {
             _connection.CreateTable<Test>();
            var abc =  _connection.Table<Test>().ToList();
            _test = new ObservableCollection<Test>(abc);
           
            mylistview.ItemsSource = _test;

           base.OnAppearing();
        }

        private void Add(object sender, EventArgs e)
        {
            
        }

        private void Adiconar(object sender, EventArgs e)
        {
            var test = new Test { Title = Title.Text, Desc = Description.Text };
            _connection.Insert(test);
            _test.Add(test);
        }
    }
}