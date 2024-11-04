using System;
using System.Data.Common;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //"Red", "Yellow", "Orange", "White", "Green", "Blue"
            Random randomColor = new Random();
            int colorNumber;
       
            string color01 = "";
            string color02 = "";
            string color03 = "";
            string color04 = "";
            for (int i = 1; i < 5; i++)
            {
                colorNumber = randomColor.Next(1, 7);
                switch (colorNumber)
                {
                    case 1:
                        switch (i)
                        {

                            case 1:
                                color01 = "Red";
                                // Red
                                break;
                            case 2:
                                color02 = "Red";
                                // Red
                                break;
                            case 3:
                                color03 = "Red";
                                // Red
                                break;
                            case 4:
                                color04 = "Red";
                                // Red
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    case 2:
                        switch (i)
                        {

                            case 1:
                                color01 = "Yellow";
                                // Yellow
                                break;
                            case 2:
                                color02 = "Yellow";
                                // Yellow
                                break;
                            case 3:
                                color03 = "Yellow";
                                // Yellow
                                break;
                            case 4:
                                color04 = "Yellow";
                                // Yellow
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    case 3:
                        switch (i)
                        {

                            case 1:
                                color01 = "Orange";
                                // Orange
                                break;
                            case 2:
                                color02 = "Orange";
                                // Orange
                                break;
                            case 3:
                                color03 = "Orange";
                                // Orange
                                break;
                            case 4:
                                color04 = "Orange";
                                // Orange
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    case 4:
                        switch (i)
                        {

                            case 1:
                                color01 = "White";
                                // White
                                break;
                            case 2:
                                color02 = "White";
                                // White
                                break;
                            case 3:
                                color03 = "White";
                                // White
                                break;
                            case 4:
                                color04 = "White";
                                // White
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    case 5:
                        switch (i)
                        {

                            case 1:
                                color01 = "Green";
                                // Green
                                break;
                            case 2:
                                color02 = "Green";
                                // Green
                                break;
                            case 3:
                                color03 = "Green";
                                // Green
                                break;
                            case 4:
                                color04 = "Green";
                                // Green
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    case 6:
                        switch (i)
                        {

                            case 1:
                                color01 = "Blue";
                                // Blue
                                break;
                            case 2:
                                color02 = "Blue";
                                // Blue
                                break;
                            case 3:
                                color03 = "Blue";
                                // Blue
                                break;
                            case 4:
                                color04 = "Blue";
                                // Blue
                                break;
                            default:
                                // nothing
                                break;
                        }
                        break;
                    default:
                        // nothing
                        break;

                }

            }

           Title = $"{color01}, {color02}, {color03} and {color04}";

        }
    }
}