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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.ComponentModel;

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Process[] process = Process.GetProcesses();
        public int Id;

        private int counterpage = 1;

        public MainWindow()
        {
            InitializeComponent();
            ViewControls.Page1 page1 = new ViewControls.Page1();
            pages.NavigationService.Navigate(page1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Id = Process.GetCurrentProcess().Id;

            foreach (Process prs in process)
            {
                if (prs.Id == Id)
                {
                    prs.Kill();
                    break;
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            counterpage++;

            switch (counterpage)
            {
                case 2:
                    ViewControls.Page2 page2 = new ViewControls.Page2();
                    pages.NavigationService.Navigate(page2);
                break;

                case 3:
                    ViewControls.Page3 page3 = new ViewControls.Page3();
                    pages.NavigationService.Navigate(page3);
                break;

                case 4:
                    counterpage--;
                break;

                default:
                break;

            }

            //ViewControls.Page1 page1 = new ViewControls.Page1();
            //this.Content = page1;

            //ViewControls.Page2 page2 = new ViewControls.Page2();
            //pages.NavigationService.Navigate(page2);
        }
    }
}