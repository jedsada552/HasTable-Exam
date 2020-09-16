using System;
using System.Collections;
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

namespace _16._Hastable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hastable;
        public MainWindow()
        {
            InitializeComponent();
            hastable = new Hashtable();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            hastable.Add(KeyBox.Text.ToString(),Value_Box.Text.ToString());
            MessageBox.Show("Key: " +KeyBox.Text+" "+Value_Box.Text);
           

        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            hastable.Remove(KeyBox);
            MessageBox.Show("Remove Key : " + KeyBox.Text);

        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hastable.Keys;
            foreach (string key in icollection)
            {
                MessageBox.Show("Value : " + hastable[key].ToString());
            }
        }
    }
}
