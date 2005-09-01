/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Summary description for DockableWindow1.
	/// </summary>
	public class FinderDock : TD.SandDock.UserDockableWindow, SimPe.Interfaces.IDockableTool
	{
		SimPe.ThemeManager tm;
		SimPe.ColumnSorter sorter;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Panel panel1;
		private TD.SandBar.FlatComboBox cbTask;
		private System.Windows.Forms.Label label1;
		private Ambertation.Windows.Forms.XPTaskBoxSimple tbResult;
		private Ambertation.Windows.Forms.XPTaskBoxSimple tbNmap;
		private TD.SandBar.FlatComboBox cbNmapMatch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNmapName;
		private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;
		private System.Windows.Forms.Button button1;
		private SteepValley.Windows.Forms.XPListView lv;
		private TD.SandBar.SandBarManager sandBarManager1;
		private TD.SandBar.ToolBarContainer leftSandBarDock;
		private TD.SandBar.ToolBarContainer rightSandBarDock;
		private TD.SandBar.ToolBarContainer bottomSandBarDock;
		private TD.SandBar.ToolBarContainer topSandBarDock;
		private TD.SandBar.StatusBar statusBar1;
		private TD.SandBar.ToolBar toolBar1;
		private TD.SandBar.ButtonItem biList;
		private TD.SandBar.ButtonItem biTile;
		private TD.SandBar.ButtonItem biDetail;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.IContainer components;

		public FinderDock()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.tbNmap);
			tm.AddControl(this.tbResult);
			tm.AddControl(this.toolBar1);
			this.Guid = new System.Guid("9eea4f6c-b7fd-4a94-9dc5-200eb8531f68");

			this.cbTask.SelectedIndex = 0;
			this.cbNmapMatch.SelectedIndex = 0;		
	
			sorter = new ColumnSorter();
			sorter.CurrentColumn = 0;
			lv.ListViewItemSorter = sorter;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				tm.Clear();
				tm = null;
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FinderDock));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.tbResult = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.lv = new SteepValley.Windows.Forms.XPListView(this.components);
			this.tbNmap = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.button1 = new System.Windows.Forms.Button();
			this.tbNmapName = new System.Windows.Forms.TextBox();
			this.cbNmapMatch = new TD.SandBar.FlatComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbTask = new TD.SandBar.FlatComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biList = new TD.SandBar.ButtonItem();
			this.biTile = new TD.SandBar.ButtonItem();
			this.biDetail = new TD.SandBar.ButtonItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
			this.sandBarManager1 = new TD.SandBar.SandBarManager();
			this.leftSandBarDock = new TD.SandBar.ToolBarContainer();
			this.rightSandBarDock = new TD.SandBar.ToolBarContainer();
			this.bottomSandBarDock = new TD.SandBar.ToolBarContainer();
			this.topSandBarDock = new TD.SandBar.ToolBarContainer();
			this.statusBar1 = new TD.SandBar.StatusBar();
			this.xpGradientPanel1.SuspendLayout();
			this.tbResult.SuspendLayout();
			this.tbNmap.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.tbResult);
			this.xpGradientPanel1.Controls.Add(this.tbNmap);
			this.xpGradientPanel1.Controls.Add(this.panel1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.DockPadding.All = 8;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 24);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(304, 398);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// tbResult
			// 
			this.tbResult.BackColor = System.Drawing.Color.Transparent;
			this.tbResult.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbResult.BorderColor = System.Drawing.SystemColors.Window;
			this.tbResult.Controls.Add(this.lv);
			this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbResult.DockPadding.Bottom = 4;
			this.tbResult.DockPadding.Left = 4;
			this.tbResult.DockPadding.Right = 4;
			this.tbResult.DockPadding.Top = 44;
			this.tbResult.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.tbResult.HeaderText = "Results";
			this.tbResult.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tbResult.Icon = ((System.Drawing.Image)(resources.GetObject("tbResult.Icon")));
			this.tbResult.IconLocation = new System.Drawing.Point(4, 12);
			this.tbResult.IconSize = new System.Drawing.Size(32, 32);
			this.tbResult.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbResult.Location = new System.Drawing.Point(8, 176);
			this.tbResult.Name = "tbResult";
			this.tbResult.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.tbResult.Size = new System.Drawing.Size(288, 214);
			this.tbResult.TabIndex = 4;
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 48);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(272, 158);
			this.lv.TabIndex = 0;
			this.lv.TileColumns = new int[] {
												1};
			this.lv.TileSize = new System.Drawing.Size(350, 90);
			this.lv.View = SteepValley.Windows.Forms.ExtendedView.Details;
			this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
			this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_ColumnClick);
			// 
			// tbNmap
			// 
			this.tbNmap.BackColor = System.Drawing.Color.Transparent;
			this.tbNmap.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbNmap.BorderColor = System.Drawing.SystemColors.Window;
			this.tbNmap.Controls.Add(this.button1);
			this.tbNmap.Controls.Add(this.tbNmapName);
			this.tbNmap.Controls.Add(this.cbNmapMatch);
			this.tbNmap.Controls.Add(this.label2);
			this.tbNmap.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbNmap.DockPadding.Bottom = 4;
			this.tbNmap.DockPadding.Left = 4;
			this.tbNmap.DockPadding.Right = 4;
			this.tbNmap.DockPadding.Top = 44;
			this.tbNmap.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.tbNmap.HeaderText = "Namemaps";
			this.tbNmap.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tbNmap.Icon = ((System.Drawing.Image)(resources.GetObject("tbNmap.Icon")));
			this.tbNmap.IconLocation = new System.Drawing.Point(4, 12);
			this.tbNmap.IconSize = new System.Drawing.Size(32, 32);
			this.tbNmap.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbNmap.Location = new System.Drawing.Point(8, 32);
			this.tbNmap.Name = "tbNmap";
			this.tbNmap.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.tbNmap.Size = new System.Drawing.Size(288, 144);
			this.tbNmap.TabIndex = 2;
			this.tbNmap.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(205, 112);
			this.button1.Name = "button1";
			this.button1.TabIndex = 7;
			this.button1.Text = "Start";
			this.button1.Click += new System.EventHandler(this.FindByNmap);
			// 
			// tbNmapName
			// 
			this.tbNmapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbNmapName, "ResourceName");
			this.tbNmapName.Location = new System.Drawing.Point(16, 72);
			this.tbNmapName.Name = "tbNmapName";
			this.tbNmapName.Size = new System.Drawing.Size(264, 21);
			this.tbNmapName.TabIndex = 6;
			this.tbNmapName.Text = "";
			// 
			// cbNmapMatch
			// 
			this.cbNmapMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpCueBannerExtender1.SetCueBannerText(this.cbNmapMatch, "");
			this.cbNmapMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNmapMatch.Items.AddRange(new object[] {
															 "Exact",
															 "Begins with",
															 "Ends with",
															 "Contains",
															 "Regular Expression"});
			this.cbNmapMatch.Location = new System.Drawing.Point(64, 48);
			this.cbNmapMatch.Name = "cbNmapMatch";
			this.cbNmapMatch.Size = new System.Drawing.Size(216, 21);
			this.cbNmapMatch.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Match:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cbTask);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(288, 24);
			this.panel1.TabIndex = 3;
			// 
			// cbTask
			// 
			this.cbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpCueBannerExtender1.SetCueBannerText(this.cbTask, "");
			this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTask.Items.AddRange(new object[] {
														"in Namemaps"});
			this.cbTask.Location = new System.Drawing.Point(48, 0);
			this.cbTask.Name = "cbTask";
			this.cbTask.Size = new System.Drawing.Size(240, 21);
			this.cbTask.TabIndex = 3;
			this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Find:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// toolBar1
			// 
			this.toolBar1.DockLine = 1;
			this.toolBar1.Guid = new System.Guid("4df823d3-7098-4b86-ac37-7293656eab84");
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biList,
																			  this.biTile,
																			  this.biDetail});
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(304, 24);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.Text = "toolBar1";
			// 
			// biList
			// 
			this.biList.Image = ((System.Drawing.Image)(resources.GetObject("biList.Image")));
			this.biList.ToolTipText = "List View";
			this.biList.Activate += new System.EventHandler(this.Activate_biList);
			// 
			// biTile
			// 
			this.biTile.Image = ((System.Drawing.Image)(resources.GetObject("biTile.Image")));
			this.biTile.ToolTipText = "Tiled View";
			this.biTile.Activate += new System.EventHandler(this.Activate_biTile);
			// 
			// biDetail
			// 
			this.biDetail.Checked = true;
			this.biDetail.Image = ((System.Drawing.Image)(resources.GetObject("biDetail.Image")));
			this.biDetail.ToolTipText = "Detailed View";
			this.biDetail.Activate += new System.EventHandler(this.Activate_biDetails);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(304, 402);
			this.panel2.TabIndex = 5;
			// 
			// sandBarManager1
			// 
			this.sandBarManager1.OwnerForm = null;
			// 
			// leftSandBarDock
			// 
			this.leftSandBarDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSandBarDock.Guid = new System.Guid("18ae1cf3-ab84-4def-9f69-2812ceb99ffc");
			this.leftSandBarDock.Location = new System.Drawing.Point(0, 24);
			this.leftSandBarDock.Manager = this.sandBarManager1;
			this.leftSandBarDock.Name = "leftSandBarDock";
			this.leftSandBarDock.Size = new System.Drawing.Size(0, 398);
			this.leftSandBarDock.TabIndex = 1;
			// 
			// rightSandBarDock
			// 
			this.rightSandBarDock.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSandBarDock.Guid = new System.Guid("c830e6a6-9eb2-47af-b95f-ef909f7a43b9");
			this.rightSandBarDock.Location = new System.Drawing.Point(304, 24);
			this.rightSandBarDock.Manager = this.sandBarManager1;
			this.rightSandBarDock.Name = "rightSandBarDock";
			this.rightSandBarDock.Size = new System.Drawing.Size(0, 398);
			this.rightSandBarDock.TabIndex = 2;
			// 
			// bottomSandBarDock
			// 
			this.bottomSandBarDock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomSandBarDock.Guid = new System.Guid("c6574d1f-e21f-4a4c-8dac-d81198ed5444");
			this.bottomSandBarDock.Location = new System.Drawing.Point(0, 422);
			this.bottomSandBarDock.Manager = this.sandBarManager1;
			this.bottomSandBarDock.Name = "bottomSandBarDock";
			this.bottomSandBarDock.Size = new System.Drawing.Size(304, 0);
			this.bottomSandBarDock.TabIndex = 3;
			// 
			// topSandBarDock
			// 
			this.topSandBarDock.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSandBarDock.Guid = new System.Guid("f5717d06-5f0b-4265-84ec-7473fdba2afc");
			this.topSandBarDock.Location = new System.Drawing.Point(0, 24);
			this.topSandBarDock.Manager = this.sandBarManager1;
			this.topSandBarDock.Name = "topSandBarDock";
			this.topSandBarDock.Size = new System.Drawing.Size(304, 0);
			this.topSandBarDock.TabIndex = 4;
			// 
			// statusBar1
			// 
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Guid = new System.Guid("41cfcea0-69c0-4086-bf93-80431afe48de");
			this.statusBar1.Location = new System.Drawing.Point(0, 422);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.OwnerForm = null;
			this.statusBar1.Size = new System.Drawing.Size(304, 18);
			this.statusBar1.TabIndex = 5;
			this.statusBar1.Text = "statusBar1";
			// 
			// FinderDock
			// 
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(208, 288);
			this.Controls.Add(this.xpGradientPanel1);
			this.Controls.Add(this.leftSandBarDock);
			this.Controls.Add(this.rightSandBarDock);
			this.Controls.Add(this.bottomSandBarDock);
			this.Controls.Add(this.topSandBarDock);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.toolBar1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "FinderDock";
			this.Size = new System.Drawing.Size(304, 440);
			this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
			this.TabText = "Finder";
			this.Text = "Resource Finder";
			this.xpGradientPanel1.ResumeLayout(false);
			this.tbResult.ResumeLayout(false);
			this.tbNmap.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public TD.SandDock.DockControl GetDockableControl()
		{
			return this;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			//code here	
		}


		#region IToolPlugin Member

		public override string ToString()
		{
			return this.Text;
		}

		#endregion

		void Show(Ambertation.Windows.Forms.XPTaskBoxSimple ctrl)
		{
			this.tbNmap.Visible = (ctrl==tbNmap);
		}

		private void cbTask_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbTask.SelectedIndex==0) Show(tbNmap);
		}

		public void ClearResults()
		{
			lv.DoubleBuffering = false;
			lv.Items.Clear();
			lv.ShowGroups = false;
			lv.Groups.Clear();
			lv.TileColumns = new int[0];
			lv.Columns.Clear();
		}

		protected void CreateDefaultColumns()
		{
			ArrayList a = new ArrayList();
			a.AddRange( new string[]{"Resourcename", "Type", "Group", "Instance", "Offset", "Size", "Filename"});
			ArrayList b = new ArrayList();
			b.AddRange( new int[]{350, 80, 80, 140, 80, 80, 200});
			CreateColums(a, b);
		}

		protected void CreateColums(System.Collections.ArrayList strings, System.Collections.ArrayList widths)
		{
			for (int i=0; i<strings.Count; i++)			
			{

				ColumnHeader ch = new ColumnHeader();
				ch.Text = (string)strings[i];				
				ch.Width = (int)widths[i];
				lv.Columns.Add(ch);
			}
		}


		protected int AddResultGroup(string name)
		{
			string cname = name.Trim().ToLower();
			foreach (SteepValley.Windows.Forms.XPListViewGroup lvg in lv.Groups)
				if (lvg.GroupText.Trim().ToLower()==cname)
					return lvg.GroupIndex;

			SteepValley.Windows.Forms.XPListViewGroup g = new SteepValley.Windows.Forms.XPListViewGroup(name);
			g.GroupIndex = lv.Groups.Count;
			lv.Groups.Add(g);
			return g.GroupIndex;
		}

		private void FindByNmap(object sender, System.EventArgs e)
		{
			FileTable.FileIndex.Load();
			ClearResults();
			lv.BeginUpdate();
			CreateDefaultColumns();		
			
			ArrayList items = new ArrayList();
			System.Text.RegularExpressions.Regex reg = null;
			
			string name = this.tbNmapName.Text.Trim().ToLower();
			try 
			{
				reg = new System.Text.RegularExpressions.Regex(this.tbNmapName.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			} 
			catch (Exception ex)			
			{
				if (this.cbNmapMatch.SelectedIndex==4) 			
					Helper.ExceptionMessage(ex);				
			}

				//get all known NMaps
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] nmaps = FileTable.FileIndex.FindFile(Data.MetaData.NAME_MAP, true);

			SimPe.Wait.SubStart(nmaps.Length);
			Wait.Message = SimPe.Localization.GetString("Searching - Please Wait");
			try {
				int ct = 0;
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in nmaps)
				{
					SimPe.Plugin.Nmap nmap = new Nmap(FileTable.ProviderRegistry);
					nmap.ProcessData(fii);

					//check all stored nMap entries for a match
					foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in nmap.Items)
					{
						bool found = false;
						string n = pfd.Filename.Trim().ToLower();
						if (this.cbNmapMatch.SelectedIndex==0) 
						{
							found = n==name;
						} 
						else if (this.cbNmapMatch.SelectedIndex==1)  
						{
							found = n.StartsWith(name);
						}
						else if (this.cbNmapMatch.SelectedIndex==2)  
						{
							found = n.EndsWith(name);
						}
						else if (this.cbNmapMatch.SelectedIndex==3)  
						{
							found = n.IndexOf(name)>-1;
						}
						else if (this.cbNmapMatch.SelectedIndex==4 && reg!=null)  
						{
							found = reg.IsMatch(n);
						}

						//we have a match, so add the result item
						if (found)
						{
							SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] rfiis = 
								FileTable.FileIndex.FindFileDiscardingHighInstance(
								fii.FileDescriptor.Instance,
								pfd.Group,
								pfd.Instance,
								null);

							foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem rfii in rfiis) 
							{
								ScenegraphResultItem sri = new ScenegraphResultItem(rfii);

								sri.GroupIndex = this.AddResultGroup(rfii.Package.SaveFileName);
								lv.Items.Add(sri);
							}
						}
					}		
		
				
					Wait.Progress = ++ct;
				}

				//do the actual add
				foreach (ScenegraphResultItem sri in items) 
				{
					sri.GroupIndex = (int)sri.Tag;
					lv.Items.Add(sri);
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}

			lv.TileColumns = new int[] {1, 2, 3, 4, 5};
			lv.ShowGroups = true;
			
			lv.Sort();
			lv.EndUpdate();	
			lv.DoubleBuffering = true;	
			Wait.SubStop();
		}

		private void lv_DoubleClick(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;

			IFinderResultItem fri = (IFinderResultItem)lv.SelectedItems[0];
			fri.OpenResource();
		}

		private void Activate_biList(object sender, System.EventArgs e)
		{
			lv.View = SteepValley.Windows.Forms.ExtendedView.List;
			biList.Checked = true;
			biTile.Checked = false;
			biDetail.Checked = false;
		}

		private void Activate_biTile(object sender, System.EventArgs e)
		{
			lv.View = SteepValley.Windows.Forms.ExtendedView.Tile;
			biList.Checked = false;
			biTile.Checked = true;
			biDetail.Checked = false;
		}

		private void Activate_biDetails(object sender, System.EventArgs e)
		{
			lv.View = SteepValley.Windows.Forms.ExtendedView.Details;
			biList.Checked = false;
			biTile.Checked = false;
			biDetail.Checked = true;
		}

		private void lv_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			((ColumnSorter)((ListView)sender).ListViewItemSorter).CurrentColumn = e.Column;
			((ListView)sender).Sort();
		}

		#region IToolExt Member

		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return this.TabImage;
			}
		}	

		public new bool Visible 
		{
			get { return this.IsDocked ||  this.IsFloating; }
		}

		#endregion
	}
}