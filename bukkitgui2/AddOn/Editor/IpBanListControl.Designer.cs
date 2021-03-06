using MetroFramework.Controls;
using Net.Bertware.Bukkitgui2.Core;

namespace Net.Bertware.Bukkitgui2.AddOn.Editor
{
    using System.Windows.Forms;

	partial class IpBanListControl : MetroUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAdd = new MetroFramework.Controls.MetroButton();
			this.slvList = new Net.Bertware.Bukkitgui2.Controls.SortableListView.SortableListView();
			this.ColIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColExpires = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRemove = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(682, 374);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = Locale.Tr("&Add");
			this.btnAdd.UseSelectable = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// slvList
			// 
			this.slvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.slvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColIp,
            this.ColCreated,
            this.ColSource,
            this.ColExpires});
			this.slvList.FullRowSelect = true;
			this.slvList.Location = new System.Drawing.Point(3, 3);
			this.slvList.Name = "slvList";
			this.slvList.Size = new System.Drawing.Size(754, 365);
			this.slvList.TabIndex = 5;
			this.slvList.UseCompatibleStateImageBehavior = false;
			this.slvList.View = System.Windows.Forms.View.Details;
			// 
			// ColIp
			// 
			this.ColIp.Text = Locale.Tr("Ip");
			this.ColIp.Width = 120;
			// 
			// ColCreated
			// 
			this.ColCreated.Text = Locale.Tr("Created");
			this.ColCreated.Width = 120;
			// 
			// ColSource
			// 
			this.ColSource.Text = Locale.Tr("Source");
			this.ColSource.Width = 120;
			// 
			// ColExpires
			// 
			this.ColExpires.Text = Locale.Tr("Expires");
			this.ColExpires.Width = 120;
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(601, 374);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 8;
			this.btnRemove.Text = Locale.Tr("&Remove");
			this.btnRemove.UseSelectable = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// IpBanListControl
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.slvList);
			this.Name = "IpBanListControl";
			this.Size = new System.Drawing.Size(760, 400);
			this.Load += new System.EventHandler(this.WhitelistControl_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnAdd;
		private Controls.SortableListView.SortableListView slvList;
		private ColumnHeader ColIp;
		private MetroFramework.Controls.MetroButton btnRemove;
		private ColumnHeader ColCreated;
		private ColumnHeader ColSource;
		private ColumnHeader ColExpires;


	}
}
