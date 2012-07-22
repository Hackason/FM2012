using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TreeView
{
    /// <summary>
    /// Window8.xaml の相互作用ロジック
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();

            // XAMLからツリービュー項目（イメージとテキスト）を追加するには下記のようにします

            //TreeViewItem item1 = new TreeViewItem();
            //TreeViewItem item2 = new TreeViewItem();
            //StackPanel stackPanel1 = new StackPanel();
            //StackPanel stackPanel2 = new StackPanel();
            //Image image1 = new Image();
            //Image image2 = new Image();
            //TextBlock textBlock1 = new TextBlock();
            //TextBlock textBlock2 = new TextBlock();

            //stackPanel1.Orientation = Orientation.Horizontal;
            //stackPanel1.Margin = new Thickness(2);
            ////イメージの作成
            //image1.Source = new BitmapImage(new Uri("Images/Chrysanthemum.jpg", UriKind.Relative));
            //image1.Width = 102;
            //image1.Height = 76;
            //stackPanel1.Children.Add(image1);
            ////テキストの作成
            //textBlock1.Text = "菊";
            //textBlock1.FontSize = 32;
            //stackPanel1.Children.Add(textBlock1);
            ////ツリービュー項目にスタックパネルをセット
            //item1.Header = stackPanel1;
            ////ツリービューに項目を追加
            //TreeViewItem1.Items.Add(item1);

            //stackPanel2.Orientation = Orientation.Horizontal;
            //stackPanel2.Margin = new Thickness(2);
            ////イメージの作成
            //image2.Source = new BitmapImage(new Uri("Images/Tulips.jpg", UriKind.Relative));
            //image2.Width = 102;
            //image2.Height = 76;
            //stackPanel2.Children.Add(image2);
            ////テキストの作成
            //textBlock2.Text = "チューリップ";
            //textBlock2.FontSize = 32;
            //stackPanel2.Children.Add(textBlock2);
            ////ツリービュー項目にスタックパネルをセット
            //item2.Header = stackPanel2;
            ////ツリービューに項目を追加
            //TreeViewItem1.Items.Add(item2);
        }
    }
}
