namespace BatchTools
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lstBox_Files = new System.Windows.Forms.ListBox();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Handle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepairGeometry = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ConIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_BatchTools = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbox_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBox_Files
            // 
            this.lstBox_Files.FormattingEnabled = true;
            this.lstBox_Files.ItemHeight = 12;
            this.lstBox_Files.Location = new System.Drawing.Point(12, 52);
            this.lstBox_Files.Name = "lstBox_Files";
            this.lstBox_Files.ScrollAlwaysVisible = true;
            this.lstBox_Files.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBox_Files.Size = new System.Drawing.Size(589, 208);
            this.lstBox_Files.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(623, 38);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 4;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Data,
            this.ToolStripMenuItem_Handle,
            this.帮助ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(616, 25);
            this.menuStrip_Main.TabIndex = 5;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // ToolStripMenuItem_Data
            // 
            this.ToolStripMenuItem_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Clear});
            this.ToolStripMenuItem_Data.Name = "ToolStripMenuItem_Data";
            this.ToolStripMenuItem_Data.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Data.Text = "数据";
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Add.Text = "添加";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // ToolStripMenuItem_Clear
            // 
            this.ToolStripMenuItem_Clear.Name = "ToolStripMenuItem_Clear";
            this.ToolStripMenuItem_Clear.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Clear.Text = "清空";
            this.ToolStripMenuItem_Clear.Click += new System.EventHandler(this.ToolStripMenuItem_Clear_Click);
            // 
            // ToolStripMenuItem_Handle
            // 
            this.ToolStripMenuItem_Handle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_RepairGeometry,
            this.ToolStripMenuItem_ConIndex,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_BatchTools});
            this.ToolStripMenuItem_Handle.Name = "ToolStripMenuItem_Handle";
            this.ToolStripMenuItem_Handle.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Handle.Text = "处理";
            // 
            // ToolStripMenuItem_RepairGeometry
            // 
            this.ToolStripMenuItem_RepairGeometry.Name = "ToolStripMenuItem_RepairGeometry";
            this.ToolStripMenuItem_RepairGeometry.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_RepairGeometry.Text = "修复几何";
            this.ToolStripMenuItem_RepairGeometry.Click += new System.EventHandler(this.ToolStripMenuItem_RepairGeometry_Click);
            // 
            // ToolStripMenuItem_ConIndex
            // 
            this.ToolStripMenuItem_ConIndex.Name = "ToolStripMenuItem_ConIndex";
            this.ToolStripMenuItem_ConIndex.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_ConIndex.Text = "添加索引";
            this.ToolStripMenuItem_ConIndex.Click += new System.EventHandler(this.ToolStripMenuItem_ConIndex_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // ToolStripMenuItem_BatchTools
            // 
            this.ToolStripMenuItem_BatchTools.Name = "ToolStripMenuItem_BatchTools";
            this.ToolStripMenuItem_BatchTools.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_BatchTools.Text = "批处理";
            this.ToolStripMenuItem_BatchTools.Click += new System.EventHandler(this.ToolStripMenuItem_BatchTools_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_About});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_About.Text = "关于";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // txtbox_log
            // 
            this.txtbox_log.Location = new System.Drawing.Point(13, 297);
            this.txtbox_log.Multiline = true;
            this.txtbox_log.Name = "txtbox_log";
            this.txtbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_log.Size = new System.Drawing.Size(589, 187);
            this.txtbox_log.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "数据：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "日志：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_log);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.lstBox_Files);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "批处理工具";
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Files;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Data;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Handle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepairGeometry;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ConIndex;
        private System.Windows.Forms.TextBox txtbox_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BatchTools;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
    }
}

