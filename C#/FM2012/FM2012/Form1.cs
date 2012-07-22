using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace FM2012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 変数宣言リスト

        // ファイルのコピー元のファイル名
        string filename = "";
        //　コピーのときに使うパス
        string pass = "";

        // ファイル名を格納
        string name = "";

        // ディレクトリまでのパス
        string dirpass = "";

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            treeView1.ImageList = imageList1;
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode tn = new TreeNode(drive);

                #region ImageList用

                if (drive == "A:\\") //ドライブに対しImageListの画像を指定
                {
                    tn.ImageIndex = 0;
                    tn.SelectedImageIndex = 0;
                }
                else
                {
                    tn.ImageIndex = 1;
                    tn.SelectedImageIndex = 1;
                }


                #endregion

                treeView1.Nodes.Add(tn);
                tn.Nodes.Add("falcon");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNode = e.Node;         //引数のイベント発生ノードに対し追加・削除・複製
            selectedNode.Nodes.Clear();                     //ダミーノードをクリアするので必要

            DirectoryInfo selectedDir = new DirectoryInfo(selectedNode.FullPath);//using System.IO

            #region ディレクトリが存在すればノードに追加

            if (selectedDir.Exists) //ディレクトリが存在すればノードに追加
            {
                DirectoryInfo[] subDirInfo = selectedDir.GetDirectories();

                foreach (DirectoryInfo di in subDirInfo)
                {
                    try
                    {
                        TreeNode nd = selectedNode.Nodes.Add(di.Name);//サブディレクトリをノードに追加
                        nd.ImageIndex = 2;                      //閉じたフォルダアイコン指定
                        nd.SelectedImageIndex = 2;      //開いたフォルダアイコン指定

                        DirectoryInfo[] subSubInfo = di.GetDirectories();
                        if (subSubInfo.Length > 0)       //下位にディレクトリがあれば
                        {
                            nd.Nodes.Add("dummy");  //＋を表示するためにダミーノード（フォルダ）追加
                        }
                    }
                    catch (Exception exc)
                    {
                        string s = exc.Message.ToString();
                        statusStrip1.Text = s;            //statusBarにエラーを表示
                    }
                }
            }

            else
            {
                MessageBox.Show(selectedDir.Root.Name + "にディスクを挿入してください。",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            #endregion
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //ListViewにファイル一覧を表示

            listView1.Clear();//これがないとファイル表示が累積
            DirectoryInfo di = new DirectoryInfo(e.Node.FullPath);

            #region ＋マークによるノード展開でデフォルトのA:\アクセス回避
            if (e.Node.Text != "A:\\")//＋マークによるノード展開でデフォルトのA:\アクセス回避
            {
                if (di.Exists)
                {
                    try
                    {
                        foreach (FileInfo file in di.GetFiles())
                        {
                            listView1.Items.Add(file.Name);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            #endregion

            #region ディレクトリまでのパスを取得

            string s1, s2;

            if (e.Node.FullPath.Length <= 3)
            {
                s1 = e.Node.FullPath.Substring(0, 3);
                s2 = e.Node.FullPath.Substring(3, (e.Node.FullPath.Length - 3));
                //s2は、s2 = ""; のことです。
            }
            else
            {
                s1 = e.Node.FullPath.Substring(0, 3);
                s2 = e.Node.FullPath.Substring(4, (e.Node.FullPath.Length - 4));
            }

            //statusBar1.Text = s1 + s2;
            // ディレクトリまでのパス
            dirpass = s1 + s2;
            statusStrip1.Text = dirpass;

            #endregion
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            #region statusStripにファイル名までのFullPathを表示(Fullパスを獲得)

            string s1, s2;

            if (treeView1.SelectedNode.FullPath.Length <= 3)
            {
                s1 = treeView1.SelectedNode.FullPath.Substring(0, 3);
                s2 = treeView1.SelectedNode.FullPath.Substring(3, (treeView1.SelectedNode.FullPath.Length - 3));
                //s2は、s2 = ""; のことです。
            }
            else
            {
                s1 = treeView1.SelectedNode.FullPath.Substring(0, 3);
                s2 = treeView1.SelectedNode.FullPath.Substring(4, (treeView1.SelectedNode.FullPath.Length - 4));
            }

            name = "\\" + listView1.SelectedItems[0].Text;

            statusStrip1.Text = s1 + s2 + name;

            #endregion
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            // Windowsで関連付けられているプログラムで起動
            Process.Start(statusStrip1.Text);
        }

        #region 右クリックでコンテキストメニューを表示

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
        }

        #endregion

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filename = listView1.SelectedItems[0].Text;

            pass = statusStrip1.Text;
            MessageBox.Show(pass);

            #region 貼り付け表示

            // 貼り付けを表示させるようにする。
            貼り付けToolStripMenuItem.Enabled = true;
            貼り付けToolStripMenuItem.Visible = true;

            #endregion
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            #region 「コピー」が押されてない場合は使えないようにする

            if (pass == "")
            {
                貼り付けToolStripMenuItem.Enabled = false;
                貼り付けToolStripMenuItem.Visible = false;
            }

            #endregion
        }

        private void 貼り付けToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 貼り付け先のパスを取得
            string pastpass = dirpass + name;

            if (System.IO.Directory.Exists(pastpass))
            {
                System.IO.Directory.CreateDirectory(pastpass);
            }

            // ファイル単体でのコピーは成功
            System.IO.File.Copy(pass, pastpass, true);
        }

        public static void CopyDirectory(string sourceDirName, string destDirName)
        {
            #region コピー先のディレクトリがないときは作る
            
            if (!System.IO.Directory.Exists(destDirName))
            {
                System.IO.Directory.CreateDirectory(destDirName);
                //属性もコピー
                System.IO.File.SetAttributes(destDirName,
                    System.IO.File.GetAttributes(sourceDirName));
            }

            # endregion

            #region コピー先のディレクトリ名の末尾に"\"をつける

            if (destDirName[destDirName.Length - 1] !=
                    System.IO.Path.DirectorySeparatorChar)
                destDirName = destDirName + System.IO.Path.DirectorySeparatorChar;

            #endregion

            #region コピー元のディレクトリにあるファイルをコピー

            string[] files = System.IO.Directory.GetFiles(sourceDirName);
            foreach (string file in files)
                System.IO.File.Copy(file,
                    destDirName + System.IO.Path.GetFileName(file), true);

            #endregion

            #region コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す

            string[] dirs = System.IO.Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
                CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir));

            #endregion

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
