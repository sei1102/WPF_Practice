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

namespace Practice6
{
    /// <summary>
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        private static Page3 page3 = null;

        public Page2(string title)
        {
            InitializeComponent();
            this.Text.Text = title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (page3 == null)
            {
                // 次に表示するページ（ページ3）を生成、以後使いまわし
                page3 = new Page3();
            }

            // ページ3へ移動
            this.NavigationService.Navigate(page3);
        }
    }
}
