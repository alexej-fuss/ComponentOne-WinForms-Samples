﻿namespace FlexGridExplorer.Samples.AdvancedFilters
{
    partial class InheritedFilterEditor
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
            this._weekdayFilterEditor = new WeekdayFilterEditor();
            this._btnWeekdayFilter = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // ValueFilterEditor
            // 
            this.ValueFilterEditor.Size = new System.Drawing.Size(428, 213);
            // 
            // _weekdayFilterEditor
            // 
            this._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._weekdayFilterEditor.Location = new System.Drawing.Point(0, 0);
            this._weekdayFilterEditor.Margin = new System.Windows.Forms.Padding(2);
            this._weekdayFilterEditor.Name = "_weekdayFilterEditor";
            this._weekdayFilterEditor.Size = new System.Drawing.Size(428, 213);
            this._weekdayFilterEditor.TabIndex = 0;
            // 
            // _btnWeekdayFilter
            // 
            this._btnWeekdayFilter.Name = "_btnWeekdayFilter";
            this._btnWeekdayFilter.Size = new System.Drawing.Size(23, 23);
            this._btnWeekdayFilter.Text = "&Weekday Filter";
            this._btnWeekdayFilter.Click += new System.EventHandler(this._btnWeekdayFilter_Click);
            // 
            // InheritedFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this._weekdayFilterEditor);
            this.Name = "InheritedFilterEditor";
            this.Size = new System.Drawing.Size(428, 238);
            this.Controls.SetChildIndex(this._weekdayFilterEditor, 0);
            this.Controls.SetChildIndex(this.ValueFilterEditor, 0);
            this.Controls.SetChildIndex(this.ConditionFilterEditor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeekdayFilterEditor _weekdayFilterEditor;
        private System.Windows.Forms.ToolStripButton _btnWeekdayFilter;
    }
}