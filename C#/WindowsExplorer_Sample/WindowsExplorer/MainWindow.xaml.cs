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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsExplorer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region ボタンクリック関係

        // 「整理」のボタンをクリック
        private void textBlock1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ファイルを整理します");
        }

        // 「開く」のボタンをクリック
        private void textBlock2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ファイルを開く");
        }

        // 「印刷ボタン」
        private void textBlock3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ファイルを印刷");
        }

        // 「書き込む」ボタン
        private void textBlock4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ファイルを書き込む");
        }

        // 「新しいフォルダーを作成」ボタン
        private void textBlock5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("新しいフォルダーを作成");
        }

        #endregion

    }
}
