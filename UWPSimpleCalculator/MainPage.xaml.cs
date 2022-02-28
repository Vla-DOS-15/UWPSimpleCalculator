using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
        private bool status;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ShowMessage(string str)
        {
            var dialog = new MessageDialog(str);
            await dialog.ShowAsync();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(textBox.Text == string.Empty || textBox.Text == string.Empty)
                {
                    ShowMessage("Please enter data!");
                }
                else if (!status) textBox2.Text = MathOp.Add(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                else
                {
                    textBox2.Text = MathOp.PercentageAdd(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                    status = false;
                }
            }
            catch(Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Sub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox.Text == string.Empty || textBox.Text == string.Empty)
                {
                    ShowMessage("Please enter data!");
                }
                else if (!status) textBox2.Text = MathOp.Subtract(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                else
                {
                    textBox2.Text = MathOp.PercentageSub(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                    status = false;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Mult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox.Text == string.Empty || textBox.Text == string.Empty)
                {
                    ShowMessage("Please enter data!");
                }
                else if (!status) textBox2.Text = MathOp.Multiply(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                else
                {
                    textBox2.Text = MathOp.PercentageMult(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                    status = false;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }



        private void btn_Div_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox.Text == string.Empty || textBox.Text == string.Empty)
                {
                    ShowMessage("Please enter data!");
                }
                else if (!status) textBox2.Text = MathOp.Division(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                else
                {
                    textBox2.Text = MathOp.PercentageDiv(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
                    status = false;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Percentage_Click(object sender, RoutedEventArgs e)
        {
            status = true;
        }

        private void btn_Sqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Sqrt(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Pow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Pow(double.Parse(textBox.Text), double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Exp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Exp(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Fact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Factorial(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Sin(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Cos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Cos(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Tan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox2.Text = MathOp.Tan(double.Parse(textBox.Text)).ToString();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn_Clean_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
