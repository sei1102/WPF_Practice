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

namespace list_cotain_trainning
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TestList> testList;
        TestList test;

        public MainWindow()
        {
            InitializeComponent();
            test = new TestList();
            testList = new List<TestList>();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            test.Id = int.Parse(Id_Buttton.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {            
            test.Pass = int.Parse(Pass_Button.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            test.Memo = Memo_Button.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!testList.Contains(test))
            {
                testList.Add(test);
            }
            
        }
    }
}
