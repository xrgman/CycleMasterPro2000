namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TChatView = new System.Windows.Forms.TextBox();
            this.TChatSend = new System.Windows.Forms.TextBox();
            this.BSend = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LCurrentPower = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.LHeartBeat = new System.Windows.Forms.Label();
            this.LRoundPerMin = new System.Windows.Forms.Label();
            this.LSpeed = new System.Windows.Forms.Label();
            this.LDistance = new System.Windows.Forms.Label();
            this.LEnergy = new System.Windows.Forms.Label();
            this.BComConnect = new System.Windows.Forms.Button();
            this.BReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.quickSaveToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "save file";
            // 
            // quickSaveToolStripMenuItem
            // 
            this.quickSaveToolStripMenuItem.Name = "quickSaveToolStripMenuItem";
            this.quickSaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickSaveToolStripMenuItem.Text = "quick save";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFileToolStripMenuItem.Text = "load file";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "quit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setComPortToolStripMenuItem,
            this.connectToServerToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setComPortToolStripMenuItem
            // 
            this.setComPortToolStripMenuItem.Name = "setComPortToolStripMenuItem";
            this.setComPortToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setComPortToolStripMenuItem.Text = "set ComPort";
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.connectToServerToolStripMenuItem.Text = "connect to Server";
            // 
            // TChatView
            // 
            this.TChatView.Enabled = false;
            this.TChatView.ForeColor = System.Drawing.SystemColors.Menu;
            this.TChatView.Location = new System.Drawing.Point(15, 380);
            this.TChatView.Multiline = true;
            this.TChatView.Name = "TChatView";
            this.TChatView.ReadOnly = true;
            this.TChatView.Size = new System.Drawing.Size(977, 373);
            this.TChatView.TabIndex = 0;
            // 
            // TChatSend
            // 
            this.TChatSend.Location = new System.Drawing.Point(15, 759);
            this.TChatSend.Name = "TChatSend";
            this.TChatSend.Size = new System.Drawing.Size(897, 20);
            this.TChatSend.TabIndex = 2;
            // 
            // BSend
            // 
            this.BSend.Location = new System.Drawing.Point(918, 759);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 23);
            this.BSend.TabIndex = 3;
            this.BSend.Text = "send";
            this.BSend.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(484, 35);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(508, 339);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "chart1";
            this.Chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // LCurrentPower
            // 
            this.LCurrentPower.AutoSize = true;
            this.LCurrentPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LCurrentPower.Location = new System.Drawing.Point(12, 35);
            this.LCurrentPower.Name = "LCurrentPower";
            this.LCurrentPower.Size = new System.Drawing.Size(108, 18);
            this.LCurrentPower.TabIndex = 6;
            this.LCurrentPower.Text = "Current Power:";
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LTime.Location = new System.Drawing.Point(12, 58);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(45, 18);
            this.LTime.TabIndex = 7;
            this.LTime.Text = "Time:";
            // 
            // LHeartBeat
            // 
            this.LHeartBeat.AutoSize = true;
            this.LHeartBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LHeartBeat.Location = new System.Drawing.Point(12, 83);
            this.LHeartBeat.Name = "LHeartBeat";
            this.LHeartBeat.Size = new System.Drawing.Size(78, 18);
            this.LHeartBeat.TabIndex = 8;
            this.LHeartBeat.Text = "HeartBeat:";
            this.LHeartBeat.Click += new System.EventHandler(this.label4_Click);
            // 
            // LRoundPerMin
            // 
            this.LRoundPerMin.AutoSize = true;
            this.LRoundPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LRoundPerMin.Location = new System.Drawing.Point(12, 105);
            this.LRoundPerMin.Name = "LRoundPerMin";
            this.LRoundPerMin.Size = new System.Drawing.Size(119, 18);
            this.LRoundPerMin.TabIndex = 9;
            this.LRoundPerMin.Text = "Rounds Per Min:";
            // 
            // LSpeed
            // 
            this.LSpeed.AutoSize = true;
            this.LSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LSpeed.Location = new System.Drawing.Point(12, 130);
            this.LSpeed.Name = "LSpeed";
            this.LSpeed.Size = new System.Drawing.Size(54, 18);
            this.LSpeed.TabIndex = 10;
            this.LSpeed.Text = "Speed:";
            // 
            // LDistance
            // 
            this.LDistance.AutoSize = true;
            this.LDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LDistance.Location = new System.Drawing.Point(12, 155);
            this.LDistance.Name = "LDistance";
            this.LDistance.Size = new System.Drawing.Size(70, 18);
            this.LDistance.TabIndex = 11;
            this.LDistance.Text = "Distance:";
            // 
            // LEnergy
            // 
            this.LEnergy.AutoSize = true;
            this.LEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LEnergy.Location = new System.Drawing.Point(12, 180);
            this.LEnergy.Name = "LEnergy";
            this.LEnergy.Size = new System.Drawing.Size(58, 18);
            this.LEnergy.TabIndex = 12;
            this.LEnergy.Text = "Energy:";
            this.LEnergy.Click += new System.EventHandler(this.label8_Click);
            // 
            // BComConnect
            // 
            this.BComConnect.Location = new System.Drawing.Point(15, 336);
            this.BComConnect.Name = "BComConnect";
            this.BComConnect.Size = new System.Drawing.Size(110, 38);
            this.BComConnect.TabIndex = 13;
            this.BComConnect.Text = "Com Connect";
            this.BComConnect.UseVisualStyleBackColor = true;
            // 
            // BReset
            // 
            this.BReset.Location = new System.Drawing.Point(131, 336);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(105, 38);
            this.BReset.TabIndex = 14;
            this.BReset.Text = "Reset";
            this.BReset.UseVisualStyleBackColor = true;
            this.BReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1019, 790);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.TChatSend);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TChatView);
            this.Controls.Add(this.BComConnect);
            this.Controls.Add(this.LEnergy);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.LDistance);
            this.Controls.Add(this.LCurrentPower);
            this.Controls.Add(this.LSpeed);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.LRoundPerMin);
            this.Controls.Add(this.LHeartBeat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "server app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.TextBox TChatView;
        private System.Windows.Forms.TextBox TChatSend;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label LCurrentPower;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Label LHeartBeat;
        private System.Windows.Forms.Label LRoundPerMin;
        private System.Windows.Forms.Label LSpeed;
        private System.Windows.Forms.Label LDistance;
        private System.Windows.Forms.Label LEnergy;
        private System.Windows.Forms.Button BComConnect;
        private System.Windows.Forms.Button BReset;
    }
}

