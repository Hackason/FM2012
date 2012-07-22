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
    /// Window7.xaml の相互作用ロジック
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        // 選択項目格納用変数
        private TreeViewItem selectedItem;

        /// <summary>
        /// ツリービュー項目が選択された場合の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            // 選択された項目を取得する
            selectedItem = (TreeViewItem)TreeView1.SelectedItem;

            if (selectedItem == null ) return;

            // 選択項目のラベルをテキストブロックに表示する
            TextBlock1.Text = "選択項目名: " + selectedItem.Header;

            // ボタンのテキストを更新する
            UpdateContent();
        }

        /// <summary>
        /// ツリービュー項目の展開/折りたたみを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpand_Click(object sender, RoutedEventArgs e)
        {
            if (selectedItem == null) return;

            // 展開と折りたたみを切り替える
            selectedItem.IsExpanded = !selectedItem.IsExpanded;

            // ボタンのテキストを更新する
            UpdateContent();
        }

        /// <summary>
        /// 項目の展開状況に合わせてボタンのテキストを更新する
        /// </summary>
        private void UpdateContent()
        {
            if (selectedItem.IsExpanded)
                btnExpand.Content = "折りたたむ";
            else
                btnExpand.Content = "展開する";        
        }
    }
}
