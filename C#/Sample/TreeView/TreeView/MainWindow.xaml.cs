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

namespace TreeView
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

        /// <summary>
        /// 01.ツリービューを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

        /// <summary>
        /// 02.動的に項目を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }

        /// <summary>
        /// 03.選択された項目を取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.ShowDialog();
        }

        /// <summary>
        /// 04.選択された項目のパスを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.ShowDialog();
        }

        /// <summary>
        /// 05.選択した項目に子項目を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Window5 w5 = new Window5();
            w5.ShowDialog();
        }

        /// <summary>
        /// 06.選択された項目を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Window6 w6 = new Window6();
            w6.ShowDialog();
        }

        /// <summary>
        /// 07.項目を展開する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Window7 w7 = new Window7();
            w7.ShowDialog();
        }

        /// <summary>
        /// 08.項目に画像とテキストを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Window8 w8 = new Window8();
            w8.ShowDialog();
        }

        /// <summary>
        /// 09.項目にチェックボックスやラジオボタンを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Window9 w9 = new Window9();
            w9.ShowDialog();
        }
    }
}
