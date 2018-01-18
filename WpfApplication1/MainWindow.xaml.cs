using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = VML.MainViewModel;
            Update();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            VML.MainViewModel.AddEntry();
            Update();
        }
        private void Update()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\WpfApplication1\WpfApplication1\Database1.mdf");
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * From [TEST]", con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            con.Close();

            TestingListView.Items.Clear();
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                ENTRY newEntry = new ENTRY();

                newEntry.Id = Convert.ToInt16(dt.Rows[x]["Id"]);
                newEntry.Name = dt.Rows[x]["Name"].ToString();
                newEntry.Age = dt.Rows[x]["Age"].ToString();
                newEntry.Address = dt.Rows[x]["Address"].ToString();
                TestingListView.Items.Add(newEntry);
            }
            con.Close();
        }
    }
}
