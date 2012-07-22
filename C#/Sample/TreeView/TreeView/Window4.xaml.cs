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
    /// Window4.xaml の相互作用ロジック
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            // 選択項目のパスをテキストブロックに表示する
            TextBlock1.Text = GetCurrentPath((TreeViewItem)TreeView1.SelectedItem);
        }

        /// <summary>
        /// 指定項目のパスを取得する
        /// </summary>
        /// <param name="item">パスを取得するツリービュー項目</param>
        /// <returns>指定項目のパス</returns>
        private string GetCurrentPath(TreeViewItem item)
        {
            string strPath = item.Header.ToString();

            // 親項目がTreeViewItemか？
            if (((TreeViewItem)item).Parent.GetType().Equals(typeof(TreeViewItem)))
            {
                // 親項目を変数にセット
                TreeViewItem parentItem = (TreeViewItem)item.Parent;

                strPath = GetCurrentPath(parentItem) + " > " + strPath;
            }

            return strPath;
        }
    }
}
