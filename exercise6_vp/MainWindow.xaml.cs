using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exercise6_vp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>();
            users.Add(new User() { ID = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User() { ID = 2, Name = "Katy Doe", Birthday = new DateTime(1973, 1, 27) });
            users.Add(new User() { ID = 3, Name = "Emma Doe", Birthday = new DateTime(1997, 10, 12) });

            dgUsers.ItemsSource = users;
        }

        public class User
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime Birthday { get; set; }

            public string Details
            {
                get
                {
                    return String.Format("{0} народився/народилась {1}", this.Name, this.Birthday.ToLongDateString());
                }
            }
        }
    }
}