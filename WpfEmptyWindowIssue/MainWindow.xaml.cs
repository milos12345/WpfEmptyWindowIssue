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

namespace WpfEmptyWindowIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var hotkey1 = new HotKey(Key.O, KeyModifier.Alt | KeyModifier.Win, OnHotKeyHandler1);
            var hotkey2 = new HotKey(Key.P, KeyModifier.Alt | KeyModifier.Win, OnHotKeyHandler2);
        }

        private void OnHotKeyHandler1(HotKey obj)
        {
            OpenTestWindowWithTabControl();
        }
        private void OnHotKeyHandler2(HotKey obj)
        {
            OpenTestWindowWithJustTextBox();
        }

        private void OpenTestWindowWithTabControl()
        {
            TestWindow testWindow = new TestWindow();
            testWindow.Owner = this;
            testWindow.ShowDialog();
        }
        private void OpenTestWindowWithJustTextBox()
        {
            TestWindow2 testWindow2 = new TestWindow2();
            testWindow2.Owner = this;
            testWindow2.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenTestWindowWithTabControl();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F11)
            {
                OpenTestWindowWithTabControl();
            } 
            else if (e.Key == Key.F12)
            {
                OpenTestWindowWithJustTextBox();
            }
        }
    }
}
