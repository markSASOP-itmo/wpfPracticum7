using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace wpfPracticum7
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
        private void fontFamilies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FontFamily fontFamily = ((sender as ComboBox).SelectedItem as Label).FontFamily;
            if (textBox0 != null)
                textBox0.FontFamily = fontFamily;
        }

        private void fontSizes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox0 != null)
            {
                textBox0.FontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //жирный шрифт
        {
            if (textBox0 != null)
            {
                if (textBox0.FontWeight == normalSettings.FontWeight)
                    textBox0.FontWeight = (sender as Button).FontWeight;
                else
                {
                    textBox0.FontWeight = normalSettings.FontWeight;
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //курсив шрифт
        {
            if (textBox0 != null)
            {
                if (textBox0.FontStyle == normalSettings.FontStyle)
                    textBox0.FontStyle = (sender as Button).FontStyle;
                else
                {
                    textBox0.FontStyle = normalSettings.FontStyle;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)  //подчёркнутый шрифт
        {
            if (textBox0 != null)
            {
                if (textBox0.TextDecorations != normalSettings.TextDecorations)
                    textBox0.TextDecorations = normalSettings.TextDecorations;
                else
                {
                    textBox0.TextDecorations = normalSettings1.TextDecorations;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox0 != null)
            {
                textBox0.Foreground = (sender as RadioButton).Foreground;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox0 != null)
            {
                textBox0.Foreground = (sender as RadioButton).Foreground;
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (textBox0 != null)
            {
                textBox0.Foreground = (sender as RadioButton).Foreground;
            }
        }

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        //    if (dialog.ShowDialog() == true)
        //    {
        //        textBox0.Text = File.ReadAllText(dialog.FileName);
        //    }
        //}

        //private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog() == true)
        //    {
        //        File.WriteAllText(saveFileDialog.FileName, textBox0.Text);
        //    }
        //}

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void exExit(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void exOpen(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                textBox0.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void exSave(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox0.Text);
            }
        }
    }
}
