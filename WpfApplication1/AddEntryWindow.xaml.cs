using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for AddEntryWindow.xaml
    /// </summary>
    public partial class AddEntryWindow : Window
    {
        public AddEntryWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\WpfApplication1\WpfApplication1\Database1.mdf");
            con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command = new SqlCommand("INSERT INTO [TEST] (Name, Age, Address) VALUES (@Name, @Age, @Address)", con);
            command.Parameters.AddWithValue("@Name", EntryNameTbx.Text);
            command.Parameters.AddWithValue("@Age", EntryAgeTbx.Text);
            command.Parameters.AddWithValue("@Address", EntryAddressTbx.Text);
            command.ExecuteNonQuery();
            con.Close();
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
