﻿namespace BSU.Prototype
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SyncUrlBox = new System.Windows.Forms.TextBox();
            this.LocalPathBox = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDirectorySelect = new System.Windows.Forms.Button();
            this.appProgress = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sync URL";
            this.toolTip1.SetToolTip(this.label1, "Server sync file, check the wiki");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mod Path";
            this.toolTip1.SetToolTip(this.label2, "The place where you wish to install your mods.");
            // 
            // SyncUrlBox
            // 
            this.SyncUrlBox.Location = new System.Drawing.Point(75, 10);
            this.SyncUrlBox.Name = "SyncUrlBox";
            this.SyncUrlBox.Size = new System.Drawing.Size(271, 20);
            this.SyncUrlBox.TabIndex = 1;
            this.SyncUrlBox.Leave += new System.EventHandler(this.SyncUrlBox_Leave);
            // 
            // LocalPathBox
            // 
            this.LocalPathBox.Location = new System.Drawing.Point(75, 36);
            this.LocalPathBox.Name = "LocalPathBox";
            this.LocalPathBox.Size = new System.Drawing.Size(271, 20);
            this.LocalPathBox.TabIndex = 2;
            this.LocalPathBox.Leave += new System.EventHandler(this.LocalPathBox_Leave);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 110);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Repo";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSync
            // 
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(270, 110);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 5;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 168);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(350, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDirectorySelect
            // 
            this.btnDirectorySelect.Location = new System.Drawing.Point(75, 59);
            this.btnDirectorySelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDirectorySelect.Name = "btnDirectorySelect";
            this.btnDirectorySelect.Size = new System.Drawing.Size(85, 23);
            this.btnDirectorySelect.TabIndex = 3;
            this.btnDirectorySelect.Text = "Select Folder";
            this.btnDirectorySelect.UseVisualStyleBackColor = true;
            this.btnDirectorySelect.Click += new System.EventHandler(this.btnDirectorySelect_Click);
            // 
            // appProgress
            // 
            this.appProgress.Location = new System.Drawing.Point(12, 139);
            this.appProgress.MarqueeAnimationSpeed = 1;
            this.appProgress.Name = "appProgress";
            this.appProgress.Size = new System.Drawing.Size(333, 23);
            this.appProgress.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 190);
            this.Controls.Add(this.appProgress);
            this.Controls.Add(this.btnDirectorySelect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.LocalPathBox);
            this.Controls.Add(this.SyncUrlBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beowulf Sync Prototype";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SyncUrlBox;
        private System.Windows.Forms.TextBox LocalPathBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDirectorySelect;
        private System.Windows.Forms.ProgressBar appProgress;
    }
}

