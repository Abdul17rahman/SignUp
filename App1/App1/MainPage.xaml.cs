﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            var x = int.Parse(num1.Text);
            var y = int.Parse(num2.Text);

            string operation = (combobx.SelectedItem as ComboBoxItem)?.Content.ToString();

            int answer;
            if (operation == "+")
            {
                answer = x + y;
            }
            else if (operation == "-") 
            { 
                answer = x - y;
            }
            else if (operation == "*")
            {
                answer = x * y;
            }
            else
            {
                answer = x / y;
            }

            answerText.Text = answer.ToString();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            answerText.Text = "";
        }
    }
}
