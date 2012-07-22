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
    /// Window5.xaml の相互作用ロジック
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }


        /// <summary>
        /// [追加]ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // 選択された項目の取得
            TreeViewItem selectedItem = (TreeViewItem)TreeView1.SelectedItem;
            // 選択された項目に追加する子項目
            TreeViewItem childItem = new TreeViewItem();

            // 「TextBoxに文字が入力されていない」または
            // 「項目が選択されていない場合」は処理を行わない
            if (TextBox1.Text.Length == 0 || selectedItem == null)
                return;

            // 子項目のラベルを設定
            childItem.Header = TextBox1.Text;

            // 選択項目に子項目を追加
            selectedItem.Items.Add(childItem);
        }


    }
}
