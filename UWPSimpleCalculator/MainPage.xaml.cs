using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWPSimpleCalculator
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static Operations operations = new Operations();
        bool ch;

        public MainPage()
        {
            this.InitializeComponent();
        }


        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (!ch) textBox2.Text = operations.Add(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
            else
            {
                textBox2.Text = operations.PercentageAdd(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                ch = false;
            }
        }

        private void btn_Sub_Click(object sender, RoutedEventArgs e)
        {
            if (!ch) textBox2.Text = operations.Subtract(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
            else
            {
                textBox2.Text = operations.PercentageSub(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                ch = false;
            }
        }

        private void btn_Mult_Click(object sender, RoutedEventArgs e)
        {
            if (!ch) textBox2.Text = operations.Multiply(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
            else
            {
                textBox2.Text = operations.PercentageMult(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                ch = false;
            }
        }



        private void btn_Div_Click(object sender, RoutedEventArgs e)
        {
            if (!ch) textBox2.Text = operations.Division(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
            else
            {
                textBox2.Text = operations.PercentageDiv(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                ch = false;
            }
        }

        private void btn_Percentage_Click(object sender, RoutedEventArgs e)
        {
            ch = true;
        }

        private void btn_Sqrt_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = operations.Sqrt(double.Parse(textBox.Text)).ToString();
        }

        private void btn_Pow_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = operations.Pow(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
        }

        private void btn_Exp_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = operations.Exp(double.Parse(textBox.Text)).ToString();
        }
    }
}
