﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClickOnceDemo.GcZoomPages
{
    class C1PrintPreviewControlSample : UserControl
    {
            XmlDocument doc;

            public C1PrintPreviewControlSample()
            {
                InitializeComponent();
                Labels_Load();
            }

            private void Labels_Load()
            {
                doc = new XmlDocument();
                doc.LoadXml(Properties.Resources.Reports);
                reportsCombo.SelectedIndex = 0;
            }

            private void LoadReport(string reportName)
            {
                //c1Report1.Load(doc, reportName);
                //c1PrintPreviewControl1.Document = c1Report1.Document;
            }

            private void reportsCombo_SelectedIndexChanged(object sender, EventArgs e)
            {
                LoadReport(reportsCombo.SelectedItem.ToString());
            }


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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.reportsCombo = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.c1Report1 = new C1.C1Report.C1Report();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.reportsCombo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(592, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "Select Report:";
            // 
            // reportsCombo
            // 
            this.reportsCombo.Items.AddRange(new object[] {
            "Customer Labels",
            "Barcode Product Labels",
            "Barcode Shipping Labels"});
            this.reportsCombo.Name = "reportsCombo";
            this.reportsCombo.Size = new System.Drawing.Size(150, 25);
            this.reportsCombo.SelectedIndexChanged += new System.EventHandler(this.reportsCombo_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1PrintPreviewControl1);
            this.splitContainer1.Size = new System.Drawing.Size(592, 421);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 1;
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // c1PrintPreviewControl1.OutlineView
            // 
            this.c1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView";
            this.c1PrintPreviewControl1.PreviewOutlineView.Size = new System.Drawing.Size(165, 427);
            this.c1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0;
            // 
            // c1PrintPreviewControl1.PreviewPane
            // 
            this.c1PrintPreviewControl1.PreviewPane.Document = this.c1Report1;
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            // 
            // c1PrintPreviewControl1.PreviewTextSearchPanel
            // 
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Location = new System.Drawing.Point(530, 0);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 453);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Visible = false;
            // 
            // c1PrintPreviewControl1.ThumbnailView
            // 
            this.c1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView";
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 348);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(592, 421);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = Properties.Resources.Reg;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast";
            this.c1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = Properties.Resources.Accnt;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = Properties.Resources.Referesh;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            this.c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            this.c1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = null;
           
            // 
            // c1Report1
            // 
            //this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // Labels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Labels";
            this.Text = "Labels";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox reportsCombo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.C1Report.C1Report c1Report1;
    }
}