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
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            // XAMLではなくコードでツリービューを作成するには下記のようにします

            ////=== 親1のツリーを作成 ここから ===
            //System.Windows.Controls.TreeView treeView1 = new System.Windows.Controls.TreeView();
            //TreeViewItem item1 = new TreeViewItem();
            //TreeViewItem item2 = new TreeViewItem();
            //TreeViewItem item3 = new TreeViewItem();
            //TreeViewItem item4 = new TreeViewItem();
            //TreeViewItem item5 = new TreeViewItem();
            //TreeViewItem item6 = new TreeViewItem();
            //TreeViewItem item7 = new TreeViewItem();
            //TreeViewItem item8 = new TreeViewItem();

            //item1.Header = "親1";
            //item2.Header = "子1";
            //item3.Header = "孫1";
            //item4.Header = "孫2";

            //// 子1に孫1を追加
            //item2.Items.Add(item3);
            //// 子1に孫2を追加
            //item2.Items.Add(item4);
            //// 親1に子1を追加
            //item1.Items.Add(item2);

            //item5.Header = "子2";
            //item6.Header = "孫1";
            //item7.Header = "孫2";
            //item8.Header = "孫3";

            //// 子2に孫1を追加
            //item5.Items.Add(item6);
            //// 子2に孫2を追加
            //item5.Items.Add(item7);
            //// 子2に孫3を追加
            //item5.Items.Add(item8);
            //// 親1に子2を追加
            //item1.Items.Add(item5);
            //// ツリービューに親1を追加
            //treeView1.Items.Add(item1);
            ////=== 親1のツリーを作成 ここまで ===

            ////=== 親2のツリーを作成 ここから ===
            //TreeViewItem item9 = new TreeViewItem();
            //TreeViewItem item10 = new TreeViewItem();
            //TreeViewItem item11 = new TreeViewItem();

            //item9.Header = "親2";
            //item10.Header = "子1";
            //item11.Header = "子2";

            //// 親2に子1を追加
            //item9.Items.Add(item10);
            //// 親2に子2を追加
            //item9.Items.Add(item11);
            //// ツリービューに親2を追加
            //treeView1.Items.Add(item9);
            ////=== 親2のツリーを作成 ここまで ===

            //// DockPanelにツリービューを追加
            //DockPanel1.LastChildFill = true;
            //DockPanel1.Children.Add(treeView1);
        }
    }
}
