﻿namespace Sdl.Community.TMBackup
{
	partial class TMBackupTasksForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMBackupTasksForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewBackupAction = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_RunTasks = new System.Windows.Forms.Button();
            this.toolTip_RunDisableTasks = new System.Windows.Forms.ToolTip(this.components);
            this.btn_RunManuallyTasks = new System.Windows.Forms.Button();
            this.TaskNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskRunType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRunCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextRunCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.readMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewBackupAction});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewBackupAction
            // 
            this.createNewBackupAction.Name = "createNewBackupAction";
            this.createNewBackupAction.Size = new System.Drawing.Size(175, 22);
            this.createNewBackupAction.Text = "Create new backup";
            this.createNewBackupAction.Click += new System.EventHandler(this.createNewBackupAction_Click);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.readMeToolStripMenuItem.Text = "Read me";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskNameCol,
            this.TaskRunType,
            this.Status,
            this.LastRunCol,
            this.NextRunCol,
            this.IntervalCol});
            this.dataGridView1.Location = new System.Drawing.Point(2, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 349);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.Location = new System.Drawing.Point(756, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(60, 22);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_RunTasks
            // 
            this.btn_RunTasks.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RunTasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_RunTasks.Image")));
            this.btn_RunTasks.Location = new System.Drawing.Point(717, 0);
            this.btn_RunTasks.Name = "btn_RunTasks";
            this.btn_RunTasks.Size = new System.Drawing.Size(33, 27);
            this.btn_RunTasks.TabIndex = 3;
            this.toolTip_RunDisableTasks.SetToolTip(this.btn_RunTasks, "Run all tasks");
            this.btn_RunTasks.UseVisualStyleBackColor = false;
            this.btn_RunTasks.Click += new System.EventHandler(this.btn_RunTasks_Click);
            // 
            // btn_RunManuallyTasks
            // 
            this.btn_RunManuallyTasks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_RunManuallyTasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_RunManuallyTasks.Image")));
            this.btn_RunManuallyTasks.Location = new System.Drawing.Point(678, 0);
            this.btn_RunManuallyTasks.Name = "btn_RunManuallyTasks";
            this.btn_RunManuallyTasks.Size = new System.Drawing.Size(33, 27);
            this.btn_RunManuallyTasks.TabIndex = 4;
            this.toolTip_RunDisableTasks.SetToolTip(this.btn_RunManuallyTasks, "Start tasks manually");
            this.btn_RunManuallyTasks.UseVisualStyleBackColor = false;
            this.btn_RunManuallyTasks.Click += new System.EventHandler(this.btn_RunManuallyTasks_Click);
            // 
            // TaskNameCol
            // 
            this.TaskNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TaskNameCol.DataPropertyName = "TaskName";
            this.TaskNameCol.HeaderText = "Task name";
            this.TaskNameCol.Name = "TaskNameCol";
            this.TaskNameCol.ReadOnly = true;
            this.TaskNameCol.Width = 85;
            // 
            // TaskRunType
            // 
            this.TaskRunType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TaskRunType.DataPropertyName = "TaskRunType";
            this.TaskRunType.HeaderText = "Task run type";
            this.TaskRunType.Name = "TaskRunType";
            this.TaskRunType.ReadOnly = true;
            this.TaskRunType.Width = 97;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LastRunCol
            // 
            this.LastRunCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastRunCol.DataPropertyName = "LastRun";
            this.LastRunCol.HeaderText = "Last run";
            this.LastRunCol.Name = "LastRunCol";
            this.LastRunCol.ReadOnly = true;
            this.LastRunCol.Width = 70;
            // 
            // NextRunCol
            // 
            this.NextRunCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NextRunCol.DataPropertyName = "NextRun";
            this.NextRunCol.HeaderText = "Next run";
            this.NextRunCol.Name = "NextRunCol";
            this.NextRunCol.ReadOnly = true;
            this.NextRunCol.Width = 72;
            // 
            // IntervalCol
            // 
            this.IntervalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IntervalCol.DataPropertyName = "Interval";
            this.IntervalCol.HeaderText = "Interval";
            this.IntervalCol.Name = "IntervalCol";
            this.IntervalCol.ReadOnly = true;
            // 
            // TMBackupTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 377);
            this.Controls.Add(this.btn_RunManuallyTasks);
            this.Controls.Add(this.btn_RunTasks);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TMBackupTasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM Backup Tasks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createNewBackupAction;
		private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Button btn_RunTasks;
		private System.Windows.Forms.ToolTip toolTip_RunDisableTasks;
		private System.Windows.Forms.Button btn_RunManuallyTasks;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaskNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaskRunType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastRunCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn NextRunCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn IntervalCol;
	}
}