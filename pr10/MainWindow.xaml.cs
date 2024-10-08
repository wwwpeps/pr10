using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using calcc;

namespace pr10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        new int l = 0;
        new int a = 0;
        new int b = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bf_Click(object sender, RoutedEventArgs e)
        {
            ta.Clear();
        }

        private void bh_Click(object sender, RoutedEventArgs e)
        {
            resilt();
        }

        private void bg_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "0";
        }

        private void bq_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "+";
        }

        private void bp_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "1";
        }

        public void resilt() 
        {
            string op;
            int iOp = 0;
            if (ta.Text.Contains("+"))
            {
                iOp = ta.Text.IndexOf("+");
            }
            else if (ta.Text.Contains("-"))
            {
                iOp = (ta.Text.IndexOf("-"));
            }
            else if (ta.Text.Contains("*"))
            {
                iOp = ta.Text.IndexOf("*");
            }
            else if (ta.Text.Contains("/"))
            {
                iOp = (ta.Text.IndexOf("/"));
            }
            else 
            {
                ta.Text = "smt gone wrong you stupid";
            }
            op = ta.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(ta.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(ta.Text.Substring(iOp+1,ta.Text.Length-iOp-1));
            if (op == "+") 
            {
                ta.Text = calcc.math.Sum(op1, op2).ToString();
            }
            else if (op == "-")
            {
                ta.Text = calcc.math.Vich(op1, op2).ToString();
            }
            else if (op == "*") 
            {
                ta.Text = calcc.math.Mult(op1, op2).ToString();
            }
            else if (op == "/")
            {
                if (op2 == 0)
                {
                    ta.Text = "smt gone wrong you stupid";
                }
                else
                {
                    ta.Text = calcc.math.Del(op1, op2).ToString();
                }
            }
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "2";
        }

        private void bs_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "3";
        }

        private void by_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "4";
        }

        private void bu_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "5";
        }

        private void bi_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "6";
        }

        private void bw_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "7";
        }

        private void be_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "8";
        }

        private void br_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "9";
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "-";
        }

        private void bo_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "*";
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            ta.Text += "/";
        }
    }
}
