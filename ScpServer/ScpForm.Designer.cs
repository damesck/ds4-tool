﻿namespace ScpServer
{
    partial class ScpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScpForm));
            this.lvDebug = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.gpPads = new System.Windows.Forms.GroupBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.rbPad_4 = new System.Windows.Forms.RadioButton();
            this.rbPad_3 = new System.Windows.Forms.RadioButton();
            this.rbPad_2 = new System.Windows.Forms.RadioButton();
            this.rbPad_1 = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rootHub = new ScpControl.BusDevice(this.components);
            this.hotkeysButton = new System.Windows.Forms.Button();
            this.pnlButton.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.gpPads.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDebug
            // 
            this.lvDebug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chData});
            this.lvDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDebug.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDebug.FullRowSelect = true;
            this.lvDebug.Location = new System.Drawing.Point(0, 0);
            this.lvDebug.Name = "lvDebug";
            this.lvDebug.Size = new System.Drawing.Size(766, 352);
            this.lvDebug.TabIndex = 0;
            this.lvDebug.UseCompatibleStateImageBehavior = false;
            this.lvDebug.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 200;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 563;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label1);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnStop);
            this.pnlButton.Controls.Add(this.btnStart);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 476);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(766, 35);
            this.pnlButton.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created by InhexSTER,  based on open source by Scarlet.Crush ";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(517, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(679, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(598, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.lvDebug);
            this.pnlDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDebug.Location = new System.Drawing.Point(0, 124);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(766, 352);
            this.pnlDebug.TabIndex = 11;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.gpPads);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(766, 124);
            this.pnlStatus.TabIndex = 9;
            // 
            // gpPads
            // 
            this.gpPads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPads.Controls.Add(this.hotkeysButton);
            this.gpPads.Controls.Add(this.optionsButton);
            this.gpPads.Controls.Add(this.rbPad_4);
            this.gpPads.Controls.Add(this.rbPad_3);
            this.gpPads.Controls.Add(this.rbPad_2);
            this.gpPads.Controls.Add(this.rbPad_1);
            this.gpPads.Location = new System.Drawing.Point(3, 3);
            this.gpPads.Name = "gpPads";
            this.gpPads.Size = new System.Drawing.Size(763, 117);
            this.gpPads.TabIndex = 1;
            this.gpPads.TabStop = false;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(676, 10);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 11;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // rbPad_4
            // 
            this.rbPad_4.AutoSize = true;
            this.rbPad_4.Enabled = false;
            this.rbPad_4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_4.Location = new System.Drawing.Point(6, 79);
            this.rbPad_4.Name = "rbPad_4";
            this.rbPad_4.Size = new System.Drawing.Size(185, 17);
            this.rbPad_4.TabIndex = 3;
            this.rbPad_4.TabStop = true;
            this.rbPad_4.Text = "Pad 4 : Disconnected";
            this.rbPad_4.UseVisualStyleBackColor = true;
            // 
            // rbPad_3
            // 
            this.rbPad_3.AutoSize = true;
            this.rbPad_3.Enabled = false;
            this.rbPad_3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_3.Location = new System.Drawing.Point(6, 56);
            this.rbPad_3.Name = "rbPad_3";
            this.rbPad_3.Size = new System.Drawing.Size(185, 17);
            this.rbPad_3.TabIndex = 2;
            this.rbPad_3.TabStop = true;
            this.rbPad_3.Text = "Pad 3 : Disconnected";
            this.rbPad_3.UseVisualStyleBackColor = true;
            // 
            // rbPad_2
            // 
            this.rbPad_2.AutoSize = true;
            this.rbPad_2.Enabled = false;
            this.rbPad_2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_2.Location = new System.Drawing.Point(6, 33);
            this.rbPad_2.Name = "rbPad_2";
            this.rbPad_2.Size = new System.Drawing.Size(185, 17);
            this.rbPad_2.TabIndex = 1;
            this.rbPad_2.TabStop = true;
            this.rbPad_2.Text = "Pad 2 : Disconnected";
            this.rbPad_2.UseVisualStyleBackColor = true;
            // 
            // rbPad_1
            // 
            this.rbPad_1.AutoSize = true;
            this.rbPad_1.Enabled = false;
            this.rbPad_1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_1.Location = new System.Drawing.Point(6, 10);
            this.rbPad_1.Name = "rbPad_1";
            this.rbPad_1.Size = new System.Drawing.Size(185, 17);
            this.rbPad_1.TabIndex = 0;
            this.rbPad_1.TabStop = true;
            this.rbPad_1.Text = "Pad 1 : Disconnected";
            this.rbPad_1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Scp server";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DS4 Xinput Tool";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // rootHub
            // 
            this.rootHub.Debug += new System.EventHandler<ScpControl.DebugEventArgs>(this.On_Debug);
            // 
            // hotkeysButton
            // 
            this.hotkeysButton.Location = new System.Drawing.Point(676, 50);
            this.hotkeysButton.Name = "hotkeysButton";
            this.hotkeysButton.Size = new System.Drawing.Size(75, 23);
            this.hotkeysButton.TabIndex = 12;
            this.hotkeysButton.Text = "Hotkeys";
            this.hotkeysButton.UseVisualStyleBackColor = true;
            this.hotkeysButton.Click += new System.EventHandler(this.hotkeysButton_Click);
            // 
            // ScpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.pnlDebug);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlStatus);
            this.MinimumSize = new System.Drawing.Size(775, 550);
            this.Name = "ScpForm";
            this.Text = "DS4 to XInput Mapper 1.1 Beta 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Close);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlDebug.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.gpPads.ResumeLayout(false);
            this.gpPads.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDebug;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.GroupBox gpPads;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.RadioButton rbPad_4;
        private System.Windows.Forms.RadioButton rbPad_3;
        private System.Windows.Forms.RadioButton rbPad_2;
        private System.Windows.Forms.RadioButton rbPad_1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ScpControl.BusDevice rootHub;
        private System.Windows.Forms.Button hotkeysButton;
    }
}

