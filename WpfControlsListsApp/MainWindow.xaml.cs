using System;
using System.Collections.Generic;
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

namespace WpfControlsListsApp
{
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public bool Married { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age} Married: {Married}";
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();

            List<string> itemsList = new List<string>() { "Один", "Два", "Три", "Четыре" };

            users = new List<User>()
            {
                new User() { Name = "Bob", Age = 23 },
                new User() { Name = "Tim", Age = 41 },
                new User() { Name = "Sam", Age = 19 },
                new User() { Name = "Joe", Age = 36 },
                new User() { Name = "Tom", Age = 29 },
                new User() { Name = "Ben", Age = 44 }
            };

            TabItem tabNew = new();
            tabNew.Header = "Tab 3";

            ListBox listBox = new();
            listBox.ItemsSource = users;
            tabNew.Content = listBox;

            tabControl.Items.Add(tabNew);

            //listBox.ItemsSource = users;


            //listBox.Items.Add("Item 3");
            //listBox.Items.Insert(1, "Item insert");



        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //User selectUser = (sender as ListBox).SelectedItem as User;
            //MessageBox.Show(selectUser.ToString());
        }

        private void listBox_Selected(object sender, RoutedEventArgs e)
        {
            //if(listBox.SelectedItem is not null)
            //{
            //    string msg = "";
            //    foreach(var item in listBox.SelectedItems) 
            //    {
            //        msg += (item as User).ToString() + "\n";
            //    }
            //    MessageBox.Show(msg);
            //}
            //    //txtUser.Text = (listBox.SelectedItem as User).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
    }
}
