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

namespace SitaMessageFileParser.Presentation.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindow()
        {
            InitializeComponent();
        }

        public double VirtualScreenWidth => SystemParameters.VirtualScreenWidth;

        public double VirtualScreenHeight => SystemParameters.VirtualScreenHeight;

        public bool IsMaximized
        {
            get { return WindowState == WindowState.Maximized; }
            set
            {
                if(value)
                {
                    WindowState = WindowState.Maximized;
                }
                else if(WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }
    }
}
