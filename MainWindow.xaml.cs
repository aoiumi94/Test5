using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Test5
{
    public class Info
    {
        public string Title { get; set; } = "";
        public string Name { get; set; } = "";
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Info> infos = new ObservableCollection<Info>();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;


            infos.Add(new Info { Title = "title1", Name = "name1" });
            infos.Add(new Info { Title = "title2", Name = "name2" });

            listBox.ItemsSource = infos;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = infos[0].Title;
        }
    }
}