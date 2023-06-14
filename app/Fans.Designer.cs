﻿using CustomControls;
using System.Windows.Forms.DataVisualization.Charting;

namespace GHelper
{
    partial class Fans
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
            ChartArea chartArea1 = new ChartArea();
            Title title1 = new Title();
            ChartArea chartArea2 = new ChartArea();
            Title title2 = new Title();
            ChartArea chartArea3 = new ChartArea();
            Title title3 = new Title();
            ChartArea chartArea4 = new ChartArea();
            Title title4 = new Title();
            panelFans = new Panel();
            labelTip = new Label();
            tableFanCharts = new TableLayoutPanel();
            chartGPU = new Chart();
            chartCPU = new Chart();
            chartXGM = new Chart();
            chartMid = new Chart();
            panelTitleFans = new Panel();
            buttonRename = new RButton();
            buttonRemove = new RButton();
            buttonAdd = new RButton();
            comboModes = new RComboBox();
            picturePerf = new PictureBox();
            labelFans = new Label();
            panelApplyFans = new Panel();
            labelFansResult = new Label();
            checkApplyFans = new RCheckBox();
            buttonReset = new RButton();
            labelBoost = new Label();
            comboBoost = new RComboBox();
            panelSliders = new Panel();
            panelPower = new Panel();
            panelApplyPower = new Panel();
            checkApplyPower = new RCheckBox();
            labelInfo = new Label();
            panelB0 = new Panel();
            labelB0 = new Label();
            labelLeftB0 = new Label();
            trackB0 = new TrackBar();
            panelC1 = new Panel();
            labelC1 = new Label();
            labelLeftC1 = new Label();
            trackC1 = new TrackBar();
            panelA0 = new Panel();
            labelA0 = new Label();
            labelLeftA0 = new Label();
            trackA0 = new TrackBar();
            panelBoost = new Panel();
            panelTitleCPU = new Panel();
            pictureBox1 = new PictureBox();
            labelPowerLimits = new Label();
            panelGPU = new Panel();
            panelGPUTemp = new Panel();
            labelGPUTemp = new Label();
            labelGPUTempTitle = new Label();
            trackGPUTemp = new TrackBar();
            panelGPUBoost = new Panel();
            labelGPUBoost = new Label();
            labelGPUBoostTitle = new Label();
            trackGPUBoost = new TrackBar();
            panelGPUMemory = new Panel();
            labelGPUMemory = new Label();
            labelGPUMemoryTitle = new Label();
            trackGPUMemory = new TrackBar();
            panelGPUCore = new Panel();
            labelGPUCore = new Label();
            trackGPUCore = new TrackBar();
            labelGPUCoreTitle = new Label();
            panelTitleGPU = new Panel();
            pictureGPU = new PictureBox();
            labelGPU = new Label();
            panelFans.SuspendLayout();
            tableFanCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).BeginInit();
            panelTitleFans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).BeginInit();
            panelApplyFans.SuspendLayout();
            panelSliders.SuspendLayout();
            panelPower.SuspendLayout();
            panelApplyPower.SuspendLayout();
            panelB0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackB0).BeginInit();
            panelC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackC1).BeginInit();
            panelA0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackA0).BeginInit();
            panelBoost.SuspendLayout();
            panelTitleCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGPU.SuspendLayout();
            panelGPUTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).BeginInit();
            panelGPUBoost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).BeginInit();
            panelGPUMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).BeginInit();
            panelGPUCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).BeginInit();
            panelTitleGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).BeginInit();
            SuspendLayout();
            // 
            // panelFans
            // 
            panelFans.AutoSize = true;
            panelFans.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFans.Controls.Add(labelTip);
            panelFans.Controls.Add(tableFanCharts);
            panelFans.Controls.Add(panelTitleFans);
            panelFans.Controls.Add(panelApplyFans);
            panelFans.Dock = DockStyle.Left;
            panelFans.Location = new Point(266, 0);
            panelFans.Margin = new Padding(0);
            panelFans.MaximumSize = new Size(408, 0);
            panelFans.MinimumSize = new Size(408, 0);
            panelFans.Name = "panelFans";
            panelFans.Padding = new Padding(0, 0, 5, 0);
            panelFans.Size = new Size(408, 655);
            panelFans.TabIndex = 12;
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.BackColor = SystemColors.ControlLightLight;
            labelTip.Location = new Point(342, 46);
            labelTip.Margin = new Padding(2, 0, 2, 0);
            labelTip.Name = "labelTip";
            labelTip.Padding = new Padding(2, 2, 2, 2);
            labelTip.Size = new Size(50, 19);
            labelTip.TabIndex = 40;
            labelTip.Text = "500,300";
            // 
            // tableFanCharts
            // 
            tableFanCharts.AutoSize = true;
            tableFanCharts.ColumnCount = 1;
            tableFanCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableFanCharts.Controls.Add(chartGPU, 0, 1);
            tableFanCharts.Controls.Add(chartCPU, 0, 0);
            tableFanCharts.Controls.Add(chartXGM, 0, 2);
            tableFanCharts.Controls.Add(chartMid, 0, 2);
            tableFanCharts.Dock = DockStyle.Fill;
            tableFanCharts.Location = new Point(0, 33);
            tableFanCharts.Margin = new Padding(2, 2, 2, 2);
            tableFanCharts.Name = "tableFanCharts";
            tableFanCharts.Padding = new Padding(5, 0, 5, 5);
            tableFanCharts.RowCount = 2;
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.Size = new Size(403, 564);
            tableFanCharts.TabIndex = 36;
            // 
            // chartGPU
            // 
            chartArea1.Name = "ChartArea1";
            chartGPU.ChartAreas.Add(chartArea1);
            chartGPU.Dock = DockStyle.Fill;
            chartGPU.Location = new Point(6, 144);
            chartGPU.Margin = new Padding(1, 5, 1, 5);
            chartGPU.Name = "chartGPU";
            chartGPU.Size = new Size(391, 129);
            chartGPU.TabIndex = 17;
            chartGPU.Text = "chartGPU";
            title1.Name = "Title1";
            chartGPU.Titles.Add(title1);
            // 
            // chartCPU
            // 
            chartArea2.Name = "ChartArea1";
            chartCPU.ChartAreas.Add(chartArea2);
            chartCPU.Dock = DockStyle.Fill;
            chartCPU.Location = new Point(6, 5);
            chartCPU.Margin = new Padding(1, 5, 1, 5);
            chartCPU.Name = "chartCPU";
            chartCPU.Size = new Size(391, 129);
            chartCPU.TabIndex = 14;
            chartCPU.Text = "chartCPU";
            title2.Name = "Title1";
            chartCPU.Titles.Add(title2);
            // 
            // chartXGM
            // 
            chartArea3.Name = "ChartAreaXGM";
            chartXGM.ChartAreas.Add(chartArea3);
            chartXGM.Dock = DockStyle.Fill;
            chartXGM.Location = new Point(6, 422);
            chartXGM.Margin = new Padding(1, 5, 1, 5);
            chartXGM.Name = "chartXGM";
            chartXGM.Size = new Size(391, 132);
            chartXGM.TabIndex = 14;
            chartXGM.Text = "chartXGM";
            title3.Name = "Title4";
            chartXGM.Titles.Add(title3);
            chartXGM.Visible = false;
            // 
            // chartMid
            // 
            chartArea4.Name = "ChartArea3";
            chartMid.ChartAreas.Add(chartArea4);
            chartMid.Dock = DockStyle.Fill;
            chartMid.Location = new Point(6, 283);
            chartMid.Margin = new Padding(1, 5, 1, 5);
            chartMid.Name = "chartMid";
            chartMid.Size = new Size(391, 129);
            chartMid.TabIndex = 14;
            chartMid.Text = "chartMid";
            title4.Name = "Title3";
            chartMid.Titles.Add(title4);
            chartMid.Visible = false;
            // 
            // panelTitleFans
            // 
            panelTitleFans.Controls.Add(buttonRename);
            panelTitleFans.Controls.Add(buttonRemove);
            panelTitleFans.Controls.Add(buttonAdd);
            panelTitleFans.Controls.Add(comboModes);
            panelTitleFans.Controls.Add(picturePerf);
            panelTitleFans.Controls.Add(labelFans);
            panelTitleFans.Dock = DockStyle.Top;
            panelTitleFans.Location = new Point(0, 0);
            panelTitleFans.Margin = new Padding(2, 2, 2, 2);
            panelTitleFans.Name = "panelTitleFans";
            panelTitleFans.Size = new Size(403, 33);
            panelTitleFans.TabIndex = 42;
            // 
            // buttonRename
            // 
            buttonRename.Activated = false;
            buttonRename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRename.BackColor = SystemColors.ControlLight;
            buttonRename.BorderColor = Color.Transparent;
            buttonRename.BorderRadius = 2;
            buttonRename.FlatStyle = FlatStyle.Flat;
            buttonRename.Image = Properties.Resources.icons8_edit_32;
            buttonRename.Location = new Point(188, 5);
            buttonRename.Margin = new Padding(2, 1, 2, 1);
            buttonRename.Name = "buttonRename";
            buttonRename.Secondary = true;
            buttonRename.Size = new Size(26, 23);
            buttonRename.TabIndex = 45;
            buttonRename.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.Activated = false;
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.BackColor = SystemColors.ControlLight;
            buttonRemove.BorderColor = Color.Transparent;
            buttonRemove.BorderRadius = 2;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Image = Properties.Resources.icons8_remove_64;
            buttonRemove.Location = new Point(161, 5);
            buttonRemove.Margin = new Padding(2, 1, 2, 1);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Secondary = true;
            buttonRemove.Size = new Size(26, 23);
            buttonRemove.TabIndex = 44;
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Activated = false;
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.BorderColor = Color.Transparent;
            buttonAdd.BorderRadius = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Image = Properties.Resources.icons8_add_64;
            buttonAdd.Location = new Point(372, 5);
            buttonAdd.Margin = new Padding(2, 1, 2, 1);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Secondary = true;
            buttonAdd.Size = new Size(26, 23);
            buttonAdd.TabIndex = 43;
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // comboModes
            // 
            comboModes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboModes.BorderColor = Color.White;
            comboModes.ButtonColor = Color.FromArgb(255, 255, 255);
            comboModes.FlatStyle = FlatStyle.Flat;
            comboModes.FormattingEnabled = true;
            comboModes.Location = new Point(218, 7);
            comboModes.Margin = new Padding(0);
            comboModes.Name = "comboModes";
            comboModes.Size = new Size(153, 23);
            comboModes.TabIndex = 42;
            // 
            // picturePerf
            // 
            picturePerf.BackgroundImage = Properties.Resources.icons8_fan_head_96;
            picturePerf.BackgroundImageLayout = ImageLayout.Zoom;
            picturePerf.InitialImage = null;
            picturePerf.Location = new Point(9, 9);
            picturePerf.Margin = new Padding(2, 1, 2, 1);
            picturePerf.Name = "picturePerf";
            picturePerf.Size = new Size(18, 19);
            picturePerf.TabIndex = 41;
            picturePerf.TabStop = false;
            // 
            // labelFans
            // 
            labelFans.AutoSize = true;
            labelFans.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFans.Location = new Point(26, 10);
            labelFans.Margin = new Padding(2, 0, 2, 0);
            labelFans.Name = "labelFans";
            labelFans.Size = new Size(44, 15);
            labelFans.TabIndex = 40;
            labelFans.Text = "Profile";
            // 
            // panelApplyFans
            // 
            panelApplyFans.Controls.Add(labelFansResult);
            panelApplyFans.Controls.Add(checkApplyFans);
            panelApplyFans.Controls.Add(buttonReset);
            panelApplyFans.Dock = DockStyle.Bottom;
            panelApplyFans.Location = new Point(0, 597);
            panelApplyFans.Margin = new Padding(2, 2, 2, 2);
            panelApplyFans.Name = "panelApplyFans";
            panelApplyFans.Size = new Size(403, 58);
            panelApplyFans.TabIndex = 43;
            // 
            // labelFansResult
            // 
            labelFansResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFansResult.ForeColor = Color.Red;
            labelFansResult.Location = new Point(12, 2);
            labelFansResult.Margin = new Padding(2, 0, 2, 0);
            labelFansResult.Name = "labelFansResult";
            labelFansResult.Size = new Size(381, 16);
            labelFansResult.TabIndex = 42;
            labelFansResult.TextAlign = ContentAlignment.TopRight;
            labelFansResult.Visible = false;
            // 
            // checkApplyFans
            // 
            checkApplyFans.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkApplyFans.AutoSize = true;
            checkApplyFans.BackColor = SystemColors.ControlLight;
            checkApplyFans.Location = new Point(223, 23);
            checkApplyFans.Margin = new Padding(2, 1, 2, 1);
            checkApplyFans.Name = "checkApplyFans";
            checkApplyFans.Padding = new Padding(8, 2, 8, 2);
            checkApplyFans.Size = new Size(174, 23);
            checkApplyFans.TabIndex = 19;
            checkApplyFans.Text = Properties.Strings.ApplyFanCurve;
            checkApplyFans.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            buttonReset.Activated = false;
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.BorderColor = Color.Transparent;
            buttonReset.BorderRadius = 2;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(6, 19);
            buttonReset.Margin = new Padding(2, 1, 2, 1);
            buttonReset.Name = "buttonReset";
            buttonReset.Secondary = true;
            buttonReset.Size = new Size(137, 27);
            buttonReset.TabIndex = 18;
            buttonReset.Text = Properties.Strings.FactoryDefaults;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // labelBoost
            // 
            labelBoost.Location = new Point(5, 5);
            labelBoost.Margin = new Padding(2, 0, 2, 0);
            labelBoost.Name = "labelBoost";
            labelBoost.Size = new Size(100, 20);
            labelBoost.TabIndex = 43;
            labelBoost.Text = "CPU Boost";
            labelBoost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoost
            // 
            comboBoost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoost.BorderColor = Color.White;
            comboBoost.ButtonColor = Color.FromArgb(255, 255, 255);
            comboBoost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoost.FormattingEnabled = true;
            comboBoost.Items.AddRange(new object[] { "Disabled", "Enabled", "Aggressive", "Efficient Enabled", "Efficient Aggressive", "Aggressive at Guaranteed", "Efficient at Guaranteed" });
            comboBoost.Location = new Point(113, 5);
            comboBoost.Margin = new Padding(2, 2, 2, 2);
            comboBoost.Name = "comboBoost";
            comboBoost.Size = new Size(145, 23);
            comboBoost.TabIndex = 42;
            // 
            // panelSliders
            // 
            panelSliders.Controls.Add(panelPower);
            panelSliders.Controls.Add(panelGPU);
            panelSliders.Dock = DockStyle.Left;
            panelSliders.Location = new Point(0, 0);
            panelSliders.Margin = new Padding(0);
            panelSliders.Name = "panelSliders";
            panelSliders.Padding = new Padding(5, 0, 0, 0);
            panelSliders.Size = new Size(266, 655);
            panelSliders.TabIndex = 13;
            // 
            // panelPower
            // 
            panelPower.AutoSize = true;
            panelPower.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPower.Controls.Add(panelApplyPower);
            panelPower.Controls.Add(labelInfo);
            panelPower.Controls.Add(panelB0);
            panelPower.Controls.Add(panelC1);
            panelPower.Controls.Add(panelA0);
            panelPower.Controls.Add(panelBoost);
            panelPower.Controls.Add(panelTitleCPU);
            panelPower.Dock = DockStyle.Fill;
            panelPower.Location = new Point(5, 290);
            panelPower.Margin = new Padding(2, 2, 2, 2);
            panelPower.Name = "panelPower";
            panelPower.Size = new Size(261, 365);
            panelPower.TabIndex = 43;
            // 
            // panelApplyPower
            // 
            panelApplyPower.Controls.Add(checkApplyPower);
            panelApplyPower.Dock = DockStyle.Bottom;
            panelApplyPower.Location = new Point(0, 320);
            panelApplyPower.Margin = new Padding(2, 2, 2, 2);
            panelApplyPower.Name = "panelApplyPower";
            panelApplyPower.Padding = new Padding(5, 5, 5, 5);
            panelApplyPower.Size = new Size(261, 45);
            panelApplyPower.TabIndex = 44;
            // 
            // checkApplyPower
            // 
            checkApplyPower.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkApplyPower.AutoSize = true;
            checkApplyPower.BackColor = SystemColors.ControlLight;
            checkApplyPower.Location = new Point(9, 9);
            checkApplyPower.Margin = new Padding(5, 5, 5, 5);
            checkApplyPower.Name = "checkApplyPower";
            checkApplyPower.Padding = new Padding(8, 2, 8, 2);
            checkApplyPower.Size = new Size(144, 23);
            checkApplyPower.TabIndex = 45;
            checkApplyPower.Text = Properties.Strings.ApplyPowerLimits;
            checkApplyPower.UseVisualStyleBackColor = false;
            // 
            // labelInfo
            // 
            labelInfo.Dock = DockStyle.Top;
            labelInfo.Location = new Point(0, 251);
            labelInfo.Margin = new Padding(2, 0, 2, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Padding = new Padding(2, 2, 2, 2);
            labelInfo.Size = new Size(261, 50);
            labelInfo.TabIndex = 43;
            labelInfo.Text = "Experimental Feature";
            // 
            // panelB0
            // 
            panelB0.AutoSize = true;
            panelB0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelB0.Controls.Add(labelB0);
            panelB0.Controls.Add(labelLeftB0);
            panelB0.Controls.Add(trackB0);
            panelB0.Dock = DockStyle.Top;
            panelB0.Location = new Point(0, 189);
            panelB0.Margin = new Padding(2, 2, 2, 2);
            panelB0.MaximumSize = new Size(0, 62);
            panelB0.Name = "panelB0";
            panelB0.Size = new Size(261, 62);
            panelB0.TabIndex = 41;
            // 
            // labelB0
            // 
            labelB0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelB0.Location = new Point(199, 4);
            labelB0.Margin = new Padding(2, 0, 2, 0);
            labelB0.Name = "labelB0";
            labelB0.Size = new Size(58, 16);
            labelB0.TabIndex = 13;
            labelB0.Text = "CPU";
            labelB0.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftB0
            // 
            labelLeftB0.AutoSize = true;
            labelLeftB0.Location = new Point(5, 4);
            labelLeftB0.Margin = new Padding(2, 0, 2, 0);
            labelLeftB0.Name = "labelLeftB0";
            labelLeftB0.Size = new Size(30, 15);
            labelLeftB0.TabIndex = 12;
            labelLeftB0.Text = "CPU";
            // 
            // trackB0
            // 
            trackB0.Location = new Point(3, 22);
            trackB0.Margin = new Padding(2, 1, 2, 1);
            trackB0.Maximum = 85;
            trackB0.Minimum = 5;
            trackB0.Name = "trackB0";
            trackB0.Size = new Size(254, 45);
            trackB0.TabIndex = 11;
            trackB0.TickFrequency = 5;
            trackB0.TickStyle = TickStyle.TopLeft;
            trackB0.Value = 80;
            // 
            // panelC1
            // 
            panelC1.AutoSize = true;
            panelC1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelC1.Controls.Add(labelC1);
            panelC1.Controls.Add(labelLeftC1);
            panelC1.Controls.Add(trackC1);
            panelC1.Dock = DockStyle.Top;
            panelC1.Location = new Point(0, 127);
            panelC1.Margin = new Padding(2, 2, 2, 2);
            panelC1.MaximumSize = new Size(0, 62);
            panelC1.Name = "panelC1";
            panelC1.Size = new Size(261, 62);
            panelC1.TabIndex = 45;
            // 
            // labelC1
            // 
            labelC1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelC1.Location = new Point(198, 4);
            labelC1.Margin = new Padding(2, 0, 2, 0);
            labelC1.Name = "labelC1";
            labelC1.Size = new Size(57, 16);
            labelC1.TabIndex = 13;
            labelC1.Text = "C1";
            labelC1.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftC1
            // 
            labelLeftC1.AutoSize = true;
            labelLeftC1.Location = new Point(5, 4);
            labelLeftC1.Margin = new Padding(2, 0, 2, 0);
            labelLeftC1.Name = "labelLeftC1";
            labelLeftC1.Size = new Size(21, 15);
            labelLeftC1.TabIndex = 12;
            labelLeftC1.Text = "C1";
            // 
            // trackC1
            // 
            trackC1.Location = new Point(3, 24);
            trackC1.Margin = new Padding(2, 1, 2, 1);
            trackC1.Maximum = 85;
            trackC1.Minimum = 5;
            trackC1.Name = "trackC1";
            trackC1.Size = new Size(254, 45);
            trackC1.TabIndex = 11;
            trackC1.TickFrequency = 5;
            trackC1.TickStyle = TickStyle.TopLeft;
            trackC1.Value = 80;
            // 
            // panelA0
            // 
            panelA0.AutoSize = true;
            panelA0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelA0.Controls.Add(labelA0);
            panelA0.Controls.Add(labelLeftA0);
            panelA0.Controls.Add(trackA0);
            panelA0.Dock = DockStyle.Top;
            panelA0.Location = new Point(0, 65);
            panelA0.Margin = new Padding(2, 2, 2, 2);
            panelA0.MaximumSize = new Size(0, 62);
            panelA0.Name = "panelA0";
            panelA0.Size = new Size(261, 62);
            panelA0.TabIndex = 40;
            // 
            // labelA0
            // 
            labelA0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelA0.Location = new Point(198, 5);
            labelA0.Margin = new Padding(2, 0, 2, 0);
            labelA0.Name = "labelA0";
            labelA0.Size = new Size(58, 16);
            labelA0.TabIndex = 12;
            labelA0.Text = "Platform";
            labelA0.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftA0
            // 
            labelLeftA0.AutoSize = true;
            labelLeftA0.Location = new Point(5, 5);
            labelLeftA0.Margin = new Padding(2, 0, 2, 0);
            labelLeftA0.Name = "labelLeftA0";
            labelLeftA0.Size = new Size(53, 15);
            labelLeftA0.TabIndex = 11;
            labelLeftA0.Text = "Platform";
            // 
            // trackA0
            // 
            trackA0.Location = new Point(3, 24);
            trackA0.Margin = new Padding(2, 1, 2, 1);
            trackA0.Maximum = 180;
            trackA0.Minimum = 10;
            trackA0.Name = "trackA0";
            trackA0.Size = new Size(254, 45);
            trackA0.TabIndex = 10;
            trackA0.TickFrequency = 5;
            trackA0.TickStyle = TickStyle.TopLeft;
            trackA0.Value = 125;
            // 
            // panelBoost
            // 
            panelBoost.Controls.Add(comboBoost);
            panelBoost.Controls.Add(labelBoost);
            panelBoost.Dock = DockStyle.Top;
            panelBoost.Location = new Point(0, 33);
            panelBoost.Margin = new Padding(2, 2, 2, 2);
            panelBoost.Name = "panelBoost";
            panelBoost.Size = new Size(261, 32);
            panelBoost.TabIndex = 13;
            // 
            // panelTitleCPU
            // 
            panelTitleCPU.AutoSize = true;
            panelTitleCPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleCPU.Controls.Add(pictureBox1);
            panelTitleCPU.Controls.Add(labelPowerLimits);
            panelTitleCPU.Dock = DockStyle.Top;
            panelTitleCPU.Location = new Point(0, 0);
            panelTitleCPU.Margin = new Padding(2, 2, 2, 2);
            panelTitleCPU.Name = "panelTitleCPU";
            panelTitleCPU.Size = new Size(261, 33);
            panelTitleCPU.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_processor_96;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(5, 9);
            pictureBox1.Margin = new Padding(2, 1, 2, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 19);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // labelPowerLimits
            // 
            labelPowerLimits.AutoSize = true;
            labelPowerLimits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPowerLimits.Location = new Point(24, 10);
            labelPowerLimits.Margin = new Padding(2, 0, 2, 0);
            labelPowerLimits.Name = "labelPowerLimits";
            labelPowerLimits.Size = new Size(79, 15);
            labelPowerLimits.TabIndex = 39;
            labelPowerLimits.Text = "Power Limits";
            // 
            // panelGPU
            // 
            panelGPU.AutoSize = true;
            panelGPU.Controls.Add(panelGPUTemp);
            panelGPU.Controls.Add(panelGPUBoost);
            panelGPU.Controls.Add(panelGPUMemory);
            panelGPU.Controls.Add(panelGPUCore);
            panelGPU.Controls.Add(panelTitleGPU);
            panelGPU.Dock = DockStyle.Top;
            panelGPU.Location = new Point(5, 0);
            panelGPU.Margin = new Padding(2, 2, 2, 2);
            panelGPU.Name = "panelGPU";
            panelGPU.Padding = new Padding(0, 0, 0, 9);
            panelGPU.Size = new Size(261, 290);
            panelGPU.TabIndex = 44;
            // 
            // panelGPUTemp
            // 
            panelGPUTemp.AutoSize = true;
            panelGPUTemp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUTemp.Controls.Add(labelGPUTemp);
            panelGPUTemp.Controls.Add(labelGPUTempTitle);
            panelGPUTemp.Controls.Add(trackGPUTemp);
            panelGPUTemp.Dock = DockStyle.Top;
            panelGPUTemp.Location = new Point(0, 219);
            panelGPUTemp.Margin = new Padding(2, 2, 2, 2);
            panelGPUTemp.MaximumSize = new Size(0, 62);
            panelGPUTemp.Name = "panelGPUTemp";
            panelGPUTemp.Size = new Size(261, 62);
            panelGPUTemp.TabIndex = 47;
            // 
            // labelGPUTemp
            // 
            labelGPUTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUTemp.Location = new Point(189, 7);
            labelGPUTemp.Margin = new Padding(2, 0, 2, 0);
            labelGPUTemp.Name = "labelGPUTemp";
            labelGPUTemp.Size = new Size(62, 16);
            labelGPUTemp.TabIndex = 44;
            labelGPUTemp.Text = "87C";
            labelGPUTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUTempTitle
            // 
            labelGPUTempTitle.AutoSize = true;
            labelGPUTempTitle.Location = new Point(5, 7);
            labelGPUTempTitle.Margin = new Padding(2, 0, 2, 0);
            labelGPUTempTitle.Name = "labelGPUTempTitle";
            labelGPUTempTitle.Size = new Size(85, 15);
            labelGPUTempTitle.TabIndex = 43;
            labelGPUTempTitle.Text = "Thermal Target";
            // 
            // trackGPUTemp
            // 
            trackGPUTemp.Location = new Point(3, 28);
            trackGPUTemp.Margin = new Padding(2, 1, 2, 1);
            trackGPUTemp.Maximum = 87;
            trackGPUTemp.Minimum = 75;
            trackGPUTemp.Name = "trackGPUTemp";
            trackGPUTemp.Size = new Size(248, 45);
            trackGPUTemp.TabIndex = 42;
            trackGPUTemp.TickFrequency = 5;
            trackGPUTemp.TickStyle = TickStyle.TopLeft;
            trackGPUTemp.Value = 87;
            // 
            // panelGPUBoost
            // 
            panelGPUBoost.AutoSize = true;
            panelGPUBoost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUBoost.Controls.Add(labelGPUBoost);
            panelGPUBoost.Controls.Add(labelGPUBoostTitle);
            panelGPUBoost.Controls.Add(trackGPUBoost);
            panelGPUBoost.Dock = DockStyle.Top;
            panelGPUBoost.Location = new Point(0, 157);
            panelGPUBoost.Margin = new Padding(2, 2, 2, 2);
            panelGPUBoost.MaximumSize = new Size(0, 62);
            panelGPUBoost.Name = "panelGPUBoost";
            panelGPUBoost.Size = new Size(261, 62);
            panelGPUBoost.TabIndex = 46;
            // 
            // labelGPUBoost
            // 
            labelGPUBoost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUBoost.Location = new Point(187, 7);
            labelGPUBoost.Margin = new Padding(2, 0, 2, 0);
            labelGPUBoost.Name = "labelGPUBoost";
            labelGPUBoost.Size = new Size(62, 16);
            labelGPUBoost.TabIndex = 44;
            labelGPUBoost.Text = "25W";
            labelGPUBoost.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUBoostTitle
            // 
            labelGPUBoostTitle.AutoSize = true;
            labelGPUBoostTitle.Location = new Point(5, 7);
            labelGPUBoostTitle.Margin = new Padding(2, 0, 2, 0);
            labelGPUBoostTitle.Name = "labelGPUBoostTitle";
            labelGPUBoostTitle.Size = new Size(87, 15);
            labelGPUBoostTitle.TabIndex = 43;
            labelGPUBoostTitle.Text = "Dynamic Boost";
            // 
            // trackGPUBoost
            // 
            trackGPUBoost.Location = new Point(3, 24);
            trackGPUBoost.Margin = new Padding(2, 1, 2, 1);
            trackGPUBoost.Maximum = 25;
            trackGPUBoost.Minimum = 5;
            trackGPUBoost.Name = "trackGPUBoost";
            trackGPUBoost.Size = new Size(248, 45);
            trackGPUBoost.TabIndex = 42;
            trackGPUBoost.TickFrequency = 5;
            trackGPUBoost.TickStyle = TickStyle.TopLeft;
            trackGPUBoost.Value = 25;
            // 
            // panelGPUMemory
            // 
            panelGPUMemory.AutoSize = true;
            panelGPUMemory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUMemory.Controls.Add(labelGPUMemory);
            panelGPUMemory.Controls.Add(labelGPUMemoryTitle);
            panelGPUMemory.Controls.Add(trackGPUMemory);
            panelGPUMemory.Dock = DockStyle.Top;
            panelGPUMemory.Location = new Point(0, 95);
            panelGPUMemory.Margin = new Padding(2, 2, 2, 2);
            panelGPUMemory.MaximumSize = new Size(0, 62);
            panelGPUMemory.Name = "panelGPUMemory";
            panelGPUMemory.Size = new Size(261, 62);
            panelGPUMemory.TabIndex = 45;
            // 
            // labelGPUMemory
            // 
            labelGPUMemory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUMemory.Location = new Point(172, 7);
            labelGPUMemory.Margin = new Padding(2, 0, 2, 0);
            labelGPUMemory.Name = "labelGPUMemory";
            labelGPUMemory.Size = new Size(80, 16);
            labelGPUMemory.TabIndex = 44;
            labelGPUMemory.Text = "2000 MHz";
            labelGPUMemory.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUMemoryTitle
            // 
            labelGPUMemoryTitle.AutoSize = true;
            labelGPUMemoryTitle.Location = new Point(5, 7);
            labelGPUMemoryTitle.Margin = new Padding(2, 0, 2, 0);
            labelGPUMemoryTitle.Name = "labelGPUMemoryTitle";
            labelGPUMemoryTitle.Size = new Size(120, 15);
            labelGPUMemoryTitle.TabIndex = 43;
            labelGPUMemoryTitle.Text = "Memory Clock Offset";
            // 
            // trackGPUMemory
            // 
            trackGPUMemory.LargeChange = 100;
            trackGPUMemory.Location = new Point(3, 24);
            trackGPUMemory.Margin = new Padding(2, 1, 2, 1);
            trackGPUMemory.Maximum = 300;
            trackGPUMemory.Name = "trackGPUMemory";
            trackGPUMemory.Size = new Size(248, 45);
            trackGPUMemory.SmallChange = 10;
            trackGPUMemory.TabIndex = 42;
            trackGPUMemory.TickFrequency = 50;
            trackGPUMemory.TickStyle = TickStyle.TopLeft;
            // 
            // panelGPUCore
            // 
            panelGPUCore.AutoSize = true;
            panelGPUCore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUCore.Controls.Add(labelGPUCore);
            panelGPUCore.Controls.Add(trackGPUCore);
            panelGPUCore.Controls.Add(labelGPUCoreTitle);
            panelGPUCore.Dock = DockStyle.Top;
            panelGPUCore.Location = new Point(0, 33);
            panelGPUCore.Margin = new Padding(2, 2, 2, 2);
            panelGPUCore.MaximumSize = new Size(0, 62);
            panelGPUCore.Name = "panelGPUCore";
            panelGPUCore.Size = new Size(261, 62);
            panelGPUCore.TabIndex = 44;
            // 
            // labelGPUCore
            // 
            labelGPUCore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUCore.Location = new Point(163, 8);
            labelGPUCore.Margin = new Padding(2, 0, 2, 0);
            labelGPUCore.Name = "labelGPUCore";
            labelGPUCore.Size = new Size(88, 16);
            labelGPUCore.TabIndex = 29;
            labelGPUCore.Text = "1500 MHz";
            labelGPUCore.TextAlign = ContentAlignment.TopRight;
            // 
            // trackGPUCore
            // 
            trackGPUCore.LargeChange = 100;
            trackGPUCore.Location = new Point(3, 24);
            trackGPUCore.Margin = new Padding(2, 1, 2, 1);
            trackGPUCore.Maximum = 300;
            trackGPUCore.Name = "trackGPUCore";
            trackGPUCore.RightToLeft = RightToLeft.No;
            trackGPUCore.Size = new Size(248, 45);
            trackGPUCore.SmallChange = 10;
            trackGPUCore.TabIndex = 18;
            trackGPUCore.TickFrequency = 50;
            trackGPUCore.TickStyle = TickStyle.TopLeft;
            // 
            // labelGPUCoreTitle
            // 
            labelGPUCoreTitle.AutoSize = true;
            labelGPUCoreTitle.Location = new Point(5, 8);
            labelGPUCoreTitle.Margin = new Padding(2, 0, 2, 0);
            labelGPUCoreTitle.Name = "labelGPUCoreTitle";
            labelGPUCoreTitle.Size = new Size(100, 15);
            labelGPUCoreTitle.TabIndex = 17;
            labelGPUCoreTitle.Text = "Core Clock Offset";
            // 
            // panelTitleGPU
            // 
            panelTitleGPU.AutoSize = true;
            panelTitleGPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleGPU.Controls.Add(pictureGPU);
            panelTitleGPU.Controls.Add(labelGPU);
            panelTitleGPU.Dock = DockStyle.Top;
            panelTitleGPU.Location = new Point(0, 0);
            panelTitleGPU.Margin = new Padding(2, 2, 2, 2);
            panelTitleGPU.Name = "panelTitleGPU";
            panelTitleGPU.Size = new Size(261, 33);
            panelTitleGPU.TabIndex = 43;
            // 
            // pictureGPU
            // 
            pictureGPU.BackgroundImage = Properties.Resources.icons8_video_card_48;
            pictureGPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureGPU.ErrorImage = null;
            pictureGPU.InitialImage = null;
            pictureGPU.Location = new Point(5, 9);
            pictureGPU.Margin = new Padding(2, 1, 2, 5);
            pictureGPU.Name = "pictureGPU";
            pictureGPU.Size = new Size(18, 19);
            pictureGPU.TabIndex = 41;
            pictureGPU.TabStop = false;
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPU.Location = new Point(24, 10);
            labelGPU.Margin = new Padding(2, 0, 2, 0);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(81, 15);
            labelGPU.TabIndex = 40;
            labelGPU.Text = "GPU Settings";
            // 
            // Fans
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(670, 655);
            Controls.Add(panelFans);
            Controls.Add(panelSliders);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(22, 606);
            Name = "Fans";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Fans and Power";
            panelFans.ResumeLayout(false);
            panelFans.PerformLayout();
            tableFanCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).EndInit();
            panelTitleFans.ResumeLayout(false);
            panelTitleFans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).EndInit();
            panelApplyFans.ResumeLayout(false);
            panelApplyFans.PerformLayout();
            panelSliders.ResumeLayout(false);
            panelSliders.PerformLayout();
            panelPower.ResumeLayout(false);
            panelPower.PerformLayout();
            panelApplyPower.ResumeLayout(false);
            panelApplyPower.PerformLayout();
            panelB0.ResumeLayout(false);
            panelB0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackB0).EndInit();
            panelC1.ResumeLayout(false);
            panelC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackC1).EndInit();
            panelA0.ResumeLayout(false);
            panelA0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackA0).EndInit();
            panelBoost.ResumeLayout(false);
            panelTitleCPU.ResumeLayout(false);
            panelTitleCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGPU.ResumeLayout(false);
            panelGPU.PerformLayout();
            panelGPUTemp.ResumeLayout(false);
            panelGPUTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).EndInit();
            panelGPUBoost.ResumeLayout(false);
            panelGPUBoost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).EndInit();
            panelGPUMemory.ResumeLayout(false);
            panelGPUMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).EndInit();
            panelGPUCore.ResumeLayout(false);
            panelGPUCore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).EndInit();
            panelTitleGPU.ResumeLayout(false);
            panelTitleGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelFans;
        private Panel panelSliders;
        private TableLayoutPanel tableFanCharts;
        private Chart chartGPU;
        private Chart chartCPU;
        private Chart chartMid;
        private Chart chartXGM;
        private Label labelTip;
        private Panel panelPower;
        private Label labelInfo;
        private Panel panelB0;
        private Label labelB0;
        private Label labelLeftB0;
        private TrackBar trackB0;
        private Panel panelA0;
        private Label labelA0;
        private Label labelLeftA0;
        private TrackBar trackA0;
        private Panel panelTitleCPU;
        private PictureBox pictureBox1;
        private Label labelPowerLimits;
        private Panel panelGPU;
        private Panel panelGPUMemory;
        private Label labelGPUMemory;
        private Label labelGPUMemoryTitle;
        private TrackBar trackGPUMemory;
        private Panel panelGPUCore;
        private Label labelGPUCore;
        private TrackBar trackGPUCore;
        private Label labelGPUCoreTitle;
        private Panel panelTitleGPU;
        private PictureBox pictureGPU;
        private Label labelGPU;
        private Panel panelApplyPower;
        private RCheckBox checkApplyPower;
        private Panel panelGPUBoost;
        private Label labelGPUBoost;
        private Label labelGPUBoostTitle;
        private TrackBar trackGPUBoost;
        private Panel panelGPUTemp;
        private Label labelGPUTemp;
        private Label labelGPUTempTitle;
        private TrackBar trackGPUTemp;
        private Panel panelTitleFans;
        private Panel panelApplyFans;
        private Label labelFansResult;
        private RCheckBox checkApplyFans;
        private RButton buttonReset;
        private Label labelBoost;
        private RComboBox comboBoost;
        private PictureBox picturePerf;
        private Label labelFans;
        private Panel panelC1;
        private Label labelC1;
        private Label labelLeftC1;
        private TrackBar trackC1;
        private Panel panelBoost;
        private RComboBox comboModes;
        private RButton buttonAdd;
        private RButton buttonRemove;
        private RButton buttonRename;
    }
}