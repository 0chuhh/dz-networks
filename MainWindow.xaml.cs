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
            string lengthLine = LengthTextBox?.Text;
            if (selectedType?.Text.ToString() == "Витая пара" && typeLine?.SelectedItem != null && speed != null  && lengthLine != "")
            {
                if(typeLine?.SelectedItem.ToString() == "4 Жилы")
                {
                    if(speed.Text.ToString() == "10 мбит/c")
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
                    else if(speed.Text.ToString() == "100 мбит/c")
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
                    else if (speed.Text.ToString() == "1 гбит/c")
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
                    else
                    {
                        MessageBox.Show("Failed");

                    }
                }
                if(typeLine?.SelectedItem.ToString() == "8 Жил")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
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
                    else if (speed.Text.ToString() == "100 мбит/c")
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
                    else if (speed.Text.ToString() == "1 гбит/c")
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
                    else if (speed.Text.ToString() == "10 гбит/c")
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
                    else
                    {
                        MessageBox.Show("Succes, but 10 гбит/c");


                    }
                }
            }
            if(selectedType?.Text.ToString() == "Оптоволокно" && typeLine?.SelectedItem != null && speed != null  && lengthLine != "")
            {
                if(typeLine?.SelectedItem.ToString() == "Ом 1")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                            if (Int32.Parse(lengthLine) < 2000)
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
                            if (Int32.Parse(lengthLine) < 2000)
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
                            if (Int32.Parse(lengthLine) < 275)
                            {
                                MessageBox.Show("Succes");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                    }
                    if (speed.Text.ToString() == "10 гбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 33)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "40 гбит/c")
                    {
                        MessageBox.Show("Failed");

                    }
                    if (speed.Text.ToString() == "100 гбит/c")
                    {
                        MessageBox.Show("Failed");

                    }
                }
                if(typeLine?.SelectedItem.ToString() == "Ом 2")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 550)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "10 гбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 82)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "40 гбит/c")
                    {
                        MessageBox.Show("Failed");

                    }
                    if (speed.Text.ToString() == "100 гбит/c")
                    {
                        MessageBox.Show("Failed");

                    }
                }
                if(typeLine?.SelectedItem.ToString() == "Ом 3")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 550)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "10 гбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 300)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "40 гбит/c")
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
                    if (speed.Text.ToString() == "100 гбит/c")
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
                if(typeLine?.SelectedItem.ToString() == "Ом 4")
                {
                    if (speed.Text.ToString() == "10 мбит/c")
                    {
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 2000)
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
                        if (Int32.Parse(lengthLine) < 1000)
                        {
                            MessageBox.Show("Succes");
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    if (speed.Text.ToString() == "10 гбит/c")
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
                    if (speed.Text.ToString() == "40 гбит/c")
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
                    if (speed.Text.ToString() == "100 гбит/c")
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
            if (selectedType?.Text.ToString() == "WI-FI" && typeLine?.SelectedItem != null && speed != null && lengthLine != "")
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
                    else if (speed.Text.ToString() == "100 мбит/c")
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
                    else if (speed.Text.ToString() == "1 гбит/c")
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
                    else
                    {
                        MessageBox.Show("Succes, but 100 mb/s");

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
                    else if (speed.Text.ToString() == "100 мбит/c")
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
                    else if (speed.Text.ToString() == "1 гбит/c")
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
                    else
                    {
                        MessageBox.Show("Succes, but 7 гбит/c");

                    }
                }
            }
            


        }

        private void typeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> list = new List<string>();
            TextBlock selectedType = (TextBlock)typeComboBox.SelectedItem;
            if (selectedType.Text.ToString() == "Витая пара")
            {
              
                list.Clear();
                list.Add("4 Жилы");
                list.Add("8 Жил");
            }
            if(selectedType.Text.ToString() == "Оптоволокно")
            {
                list.Clear();
                list.Add("Ом 1");
                list.Add("Ом 2");
                list.Add("Ом 3");
                list.Add("Ом 4");
            }
            if(selectedType.Text.ToString() == "WI-FI")
            {
                list.Clear();
                list.Add("2.4 ГГц");
                list.Add("5 ГГц");
            }
            ComboBox typeLine = TypeLine;
            typeLine.ItemsSource = list;
        }
    }
}
