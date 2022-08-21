

namespace CurrencyLib
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dtpCurrencyDate = new System.Windows.Forms.DateTimePicker();
            this.listViewCurrates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(518, 32);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(68, 26);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(233, 37);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(282, 20);
            this.textBoxFilter.TabIndex = 1;
            // 
            // dtpCurrencyDate
            // 
            this.dtpCurrencyDate.Location = new System.Drawing.Point(9, 37);
            this.dtpCurrencyDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCurrencyDate.Name = "dtpCurrencyDate";
            this.dtpCurrencyDate.Size = new System.Drawing.Size(209, 20);
            this.dtpCurrencyDate.TabIndex = 2;
            this.dtpCurrencyDate.ValueChanged += new System.EventHandler(this.dtpCurrencyDate_ValueChanged);
            // 
            // listViewCurrates
            // 
            this.listViewCurrates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCurrates.HideSelection = false;
            this.listViewCurrates.Location = new System.Drawing.Point(9, 74);
            this.listViewCurrates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCurrates.Name = "listViewCurrates";
            this.listViewCurrates.Size = new System.Drawing.Size(578, 283);
            this.listViewCurrates.TabIndex = 3;
            this.listViewCurrates.UseCompatibleStateImageBehavior = false;
            this.listViewCurrates.View = System.Windows.Forms.View.Details;
            this.listViewCurrates.SelectedIndexChanged += new System.EventHandler(this.listViewCurrates_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N Code";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rate";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "C Code";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(231, 20);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.listViewCurrates);
            this.Controls.Add(this.dtpCurrencyDate);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonDownload);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DateTimePicker dtpCurrencyDate;
        private System.Windows.Forms.ListView listViewCurrates;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

