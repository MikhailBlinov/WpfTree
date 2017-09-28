using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace PersonObject
{


public partial class MainWindow : Window
      {

        ObservableCollection<Node> nodes = new ObservableCollection<Node>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            nodes = new ObservableCollection<Node>
        {
            new Node
            {
                Name ="Европа",
                Nodes = new ObservableCollection<Node>
                {
                    new Node {Name="Германия" },
                    new Node {Name="Франция" },
                    new Node
                    {
                        Name ="Великобритания",
                        Nodes = new ObservableCollection<Node>
                        {
                            new Node {Name="Англия" },
                            new Node {Name="Шотландия" },
                            new Node {Name="Уэльс" },
                            new Node {Name="Сев. Ирландия" },
                        }
                    }
                }
            },
            new Node
            {
                Name ="Азия",
                Nodes = new ObservableCollection<Node>
                {
                    new Node {Name="Китай" },
                    new Node {Name="Япония" },
                    new Node { Name ="Индия" }
                }
            },
            new Node { Name="Африка" },
            new Node { Name="Америка" },
            new Node { Name="Австралия" }
        };

            TreeView.ItemsSource = nodes;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            foreach (Node node in TreeView.Items)
            {
                MessageBox.Show(node.Name, node.Name);
            }
        }
    }

    public class Node
    {
        public string Name { get; set; }

        public ObservableCollection<Node> Nodes { get; set; }
    }
}
