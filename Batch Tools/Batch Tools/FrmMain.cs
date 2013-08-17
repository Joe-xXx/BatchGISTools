using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.DataManagementTools;
using ZHDGIS.Land.Server.SpatialAnalysis;
using ESRI.ArcGIS.Geoprocessing;

namespace BatchTools
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }


        private void ChangeStatus(bool enable)
        {
            this.menuStrip_Main.Enabled = enable;
        }


        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "shape file(*.shp)|*.shp";
                DialogResult dres = ofd.ShowDialog();
                if (dres != DialogResult.OK)
                    return;
                foreach (var item in ofd.FileNames)
                {
                    this.lstBox_Files.Items.Add(item);
                }
            }
        }

        private void ToolStripMenuItem_Clear_Click(object sender, EventArgs e)
        {
            if (this.lstBox_Files.Items.Count > 0)
            {
                this.lstBox_Files.Items.Clear();
            }
        }

        private void ToolStripMenuItem_RepairGeometry_Click(object sender, EventArgs e)
        {
            if (this.lstBox_Files.Items.Count <= 0)
                return;
            Cursor.Current = Cursors.WaitCursor;
            this.ChangeStatus(false);
            try
            {
                string path = string.Empty;
                string logPath = Path.Combine(GlobalVar.LogPath, string.Format("Repair_{0}.txt", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss.ss")));
                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    Geoprocessor gp = new Geoprocessor();
                    gp.OverwriteOutput = true;
                    RepairGeometry rg = new RepairGeometry();
                    foreach (var item in this.lstBox_Files.Items)
                    {
                        if (item == null)
                            continue;
                        path = item.ToString();
                        if (!File.Exists(path))
                            continue;
                        rg.in_features = path;
                        IGeoProcessorResult2 result = SpatialAnalysisHelper.RunGeoProcessor(gp, rg, null);
                        string resStr = SpatialAnalysisHelper.GetMessages(result);
                        sw.WriteLine(resStr);
                        sw.Flush();
                        this.txtbox_log.Text += resStr + "\r\n";
                        this.txtbox_log.SelectionStart = this.txtbox_log.Text.Length;
                        this.txtbox_log.ScrollToCaret();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ChangeStatus(true);
                Cursor.Current = Cursors.Default;
            }
        }

        private void ToolStripMenuItem_ConIndex_Click(object sender, EventArgs e)
        {
            if (this.lstBox_Files.Items.Count <= 0)
                return;
            Cursor.Current = Cursors.WaitCursor;
            this.ChangeStatus(false);
            try
            {
                string path = string.Empty;
                string logPath = Path.Combine(GlobalVar.LogPath, string.Format("SIndex_{0}.txt", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss.ss")));
                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    Geoprocessor gp = new Geoprocessor();
                    gp.OverwriteOutput = true;
                    AddSpatialIndex addIndex = new AddSpatialIndex();
                    foreach (var item in this.lstBox_Files.Items)
                    {
                        if (item == null)
                            continue;
                        path = item.ToString();
                        if (!File.Exists(path))
                            continue;
                        addIndex.in_features = path;
                        IGeoProcessorResult2 result = SpatialAnalysisHelper.RunGeoProcessor(gp, addIndex, null);
                        string resStr = SpatialAnalysisHelper.GetMessages(result);
                        sw.WriteLine(resStr);
                        sw.Flush();
                        this.txtbox_log.Text += resStr + "\r\n";
                        this.txtbox_log.SelectionStart = this.txtbox_log.Text.Length;
                        this.txtbox_log.ScrollToCaret();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ChangeStatus(true);
                Cursor.Current = Cursors.Default;
            }
        }

        private void ToolStripMenuItem_BatchTools_Click(object sender, EventArgs e)
        {
            EventHandler[] ehList = new EventHandler[]
            {
                   ToolStripMenuItem_RepairGeometry_Click,
                   ToolStripMenuItem_ConIndex_Click
            };
            foreach (var item in ehList)
            {
                item(null, null);
            }
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("About：Joe || zwj7107@gmail.com || V{0}",Application.ProductVersion.ToString()));
        }
    }
}
