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
    /// Window6.xaml の相互作用ロジック
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        // 選択項目格納用変数
        private TreeViewItem selectedItem;

        /// <summary>
        /// 選択項目をテキストブロックに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            // 選択された項目を取得する
            selectedItem = (TreeViewItem)TreeView1.SelectedItem;

            if (selectedItem == null) return;

            // 選択項目のラベルをテキストブロックに表示する
            TextBlock1.Text = "選択項目名: " + selectedItem.Header;
        }

        /// <summary>
        /// [削除]ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // 項目が選択されているか？
            if (selectedItem != null)
            {
                // 選択された項目がルート項目か？
                if (TreeView1.Items.IndexOf(selectedItem) > -1)
                    // ルート項目を削除
                    TreeView1.Items.RemoveAt(TreeView1.Items.IndexOf(selectedItem));
                else
                {
                    // 選択項目の親項目を取得
                    TreeViewItem parentItem = (TreeViewItem)selectedItem.Parent;
                    // 親項目から選択されている項目を削除する
                    parentItem.Items.Remove(selectedItem);
                }
            }
        }
    }
}
