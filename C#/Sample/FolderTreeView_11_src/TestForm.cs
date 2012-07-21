using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Furty.Windows.Forms
{
	/// <summary>
	/// Summary description for TestForm.
	/// </summary>
	public class TestForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private Furty.Windows.Forms.FolderTreeView treeView1;
		private System.ComponentModel.IContainer components;

		public TestForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TestForm());
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new Furty.Windows.Forms.FolderTreeView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.treeView1,
																				 this.panel2});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(304, 310);
			this.panel1.TabIndex = 1;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HideSelection = false;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Desktop", 0, 0, new System.Windows.Forms.TreeNode[] {
																																											 new System.Windows.Forms.TreeNode("My Computer", 2, 3, new System.Windows.Forms.TreeNode[] {
																																																																			new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("My Network Places", 4, 5),
																																											 new System.Windows.Forms.TreeNode("My Documents", 6, 7, new System.Windows.Forms.TreeNode[] {
																																																																			 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("Recycle Bin", 8, 9),
																																											 new System.Windows.Forms.TreeNode("C-sharp Corner", 10, 11, new System.Windows.Forms.TreeNode[] {
																																																																				 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("New Folder", 12, 13),
																																											 new System.Windows.Forms.TreeNode("Release", 14, 15),
																																											 new System.Windows.Forms.TreeNode("Unsorted", 16, 17, new System.Windows.Forms.TreeNode[] {
																																																																		   new System.Windows.Forms.TreeNode("")})}),
																				  new System.Windows.Forms.TreeNode("Desktop", 0, 0, new System.Windows.Forms.TreeNode[] {
																																											 new System.Windows.Forms.TreeNode("My Computer", 2, 3, new System.Windows.Forms.TreeNode[] {
																																																																			new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("My Network Places", 4, 5),
																																											 new System.Windows.Forms.TreeNode("My Documents", 6, 7, new System.Windows.Forms.TreeNode[] {
																																																																			 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("Recycle Bin", 8, 9),
																																											 new System.Windows.Forms.TreeNode("C-sharp Corner", 10, 11, new System.Windows.Forms.TreeNode[] {
																																																																				 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("New Folder", 12, 13),
																																											 new System.Windows.Forms.TreeNode("Release", 14, 15),
																																											 new System.Windows.Forms.TreeNode("Unsorted", 16, 17, new System.Windows.Forms.TreeNode[] {
																																																																		   new System.Windows.Forms.TreeNode("")})}),
																				  new System.Windows.Forms.TreeNode("Desktop", 0, 0, new System.Windows.Forms.TreeNode[] {
																																											 new System.Windows.Forms.TreeNode("My Computer", 2, 3, new System.Windows.Forms.TreeNode[] {
																																																																			new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("My Network Places", 4, 5),
																																											 new System.Windows.Forms.TreeNode("My Documents", 6, 7, new System.Windows.Forms.TreeNode[] {
																																																																			 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("Recycle Bin", 8, 9),
																																											 new System.Windows.Forms.TreeNode("C-sharp Corner", 10, 11, new System.Windows.Forms.TreeNode[] {
																																																																				 new System.Windows.Forms.TreeNode("")}),
																																											 new System.Windows.Forms.TreeNode("New Folder", 12, 13),
																																											 new System.Windows.Forms.TreeNode("Release", 14, 15),
																																											 new System.Windows.Forms.TreeNode("Unsorted", 16, 17, new System.Windows.Forms.TreeNode[] {
																																																																		   new System.Windows.Forms.TreeNode("")})})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(304, 238);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button1,
																				 this.textBox1,
																				 this.label1,
																				 this.textBox2,
																				 this.label2});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 238);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(304, 72);
			this.panel2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(224, 40);
			this.button1.Name = "button1";
			this.button1.TabIndex = 6;
			this.button1.Text = "Drill Tree";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.Location = new System.Drawing.Point(56, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "C:\\";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Drill To:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox2.Location = new System.Drawing.Point(128, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Selected folder path";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TestForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 310);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1});
			this.Name = "TestForm";
			this.Text = "FolderTreeView V1.11";
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.textBox2.Text = this.treeView1.GetSelectedNodePath();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{ 
			if(this.textBox1.Text.Length > 0)
			{
				bool folderFound = treeView1.DrillToFolder(this.textBox1.Text);
				this.Text = "Found Folder: "+ this.treeView1.SelectedNode.Text +" = "+ folderFound.ToString();
			}
		}

		private void TestForm_Load(object sender, System.EventArgs e)
		{
			this.treeView1.InitFolderTreeView();
		}
	}
}
