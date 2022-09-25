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
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace networks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock selectedType = (TextBlock)typeComboBox?.SelectedItem;
            ComboBox typeLine = TypeLine;
            TextBlock speed = (TextBlock)Speed?.SelectedItem;
            TextBlock ethernetType = (TextBlock)EthernetType?.SelectedItem;
            string lengthLine = LengthTextBox?.Text;
            if (selectedType?.Text.ToString() == "Витая пара" && typeLine?.SelectedItem != null && speed != null && ethernetType != null && lengthLine != "")
            {
                if(typeLine?.SelectedItem.ToString() == "4 Жилы")
                {
                    if(speed.Text.ToString() == "10 мбит/c")
                    {
                        if(ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if(Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if(ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if(speed.Text.ToString() == "100 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succesб, but 100 mb/s");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes, but 100 mb/s");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                }
                if(typeLine?.SelectedItem.ToString() == "8 Жил")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "100 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes, but 100 mb/s");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                }
            }
            if(selectedType?.Text.ToString() == "Оптоволокно" && typeLine?.SelectedItem != null && speed != null && ethernetType != null && lengthLine != "")
            {
                if(typeLine?.SelectedItem.ToString() == "Одномодовое")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "100 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 100000)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                }
                if(typeLine?.SelectedItem.ToString() == "Многомодовое")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 550)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 550)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "100 мбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 550)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 550)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (ethernetType.Text.ToString() == "Fast Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 250)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        if (ethernetType.Text.ToString() == "Gigabit Ethernet")
                        {
                            if (Int32.Parse(lengthLine) < 250)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                }
            }
            if (selectedType?.Text.ToString() == "WI-FI" && typeLine?.SelectedItem != null && speed != null && ethernetType == null && lengthLine != "")
            {
                if (typeLine?.SelectedItem.ToString() == "2.4 ГГц")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "100 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes, but 100 mb/s");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                }
                if (typeLine?.SelectedItem.ToString() == "5 ГГц")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "100 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "1 гбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 150)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }


        }

        private void typeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> list = new List<string>();
            TextBlock selectedType = (TextBlock)typeComboBox.SelectedItem;
            ComboBox eth = EthernetType;
            ColumnDefinition gr = GridChange;
            if (selectedType.Text.ToString() == "Витая пара")
            {
                eth.Visibility = Visibility.Visible;
                gr.Width = new GridLength(150);

                list.Clear();
                list.Add("4 Жилы");
                list.Add("8 Жил");
            }
            if(selectedType.Text.ToString() == "Оптоволокно")
            {
                eth.Visibility = Visibility.Visible;
                gr.Width = new GridLength(150);

                list.Clear();
                list.Add("Одномодовое");
                list.Add("Многомодовое");
            }
            if(selectedType.Text.ToString() == "WI-FI")
            {
                eth.Visibility = Visibility.Collapsed;
                gr.Width = new GridLength(0);
                list.Clear();
                list.Add("2.4 ГГц");
                list.Add("5 ГГц");
            }
            ComboBox typeLine = TypeLine;
            typeLine.ItemsSource = list;
        }
    }
}
