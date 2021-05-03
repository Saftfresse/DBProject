namespace DBProject_App
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateText = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_toggleRange = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // date_from
            // 
            this.date_from.Location = new System.Drawing.Point(85, 8);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(200, 20);
            this.date_from.TabIndex = 2;
            this.date_from.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date_from.ValueChanged += new System.EventHandler(this.date_from_ValueChanged);
            // 
            // date_to
            // 
            this.date_to.Location = new System.Drawing.Point(317, 8);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(200, 20);
            this.date_to.TabIndex = 3;
            this.date_to.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date_to.ValueChanged += new System.EventHandler(this.date_from_ValueChanged);
            // 
            // lbl_dateText
            // 
            this.lbl_dateText.AutoSize = true;
            this.lbl_dateText.Location = new System.Drawing.Point(291, 12);
            this.lbl_dateText.Name = "lbl_dateText";
            this.lbl_dateText.Size = new System.Drawing.Size(20, 13);
            this.lbl_dateText.TabIndex = 4;
            this.lbl_dateText.Text = "bis";
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 38);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1044, 646);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_toggleRange);
            this.panel1.Controls.Add(this.date_from);
            this.panel1.Controls.Add(this.lbl_dateText);
            this.panel1.Controls.Add(this.date_to);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 38);
            this.panel1.TabIndex = 6;
            // 
            // cb_toggleRange
            // 
            this.cb_toggleRange.AutoSize = true;
            this.cb_toggleRange.Location = new System.Drawing.Point(12, 10);
            this.cb_toggleRange.Name = "cb_toggleRange";
            this.cb_toggleRange.Size = new System.Drawing.Size(67, 17);
            this.cb_toggleRange.TabIndex = 5;
            this.cb_toggleRange.Text = "Zeitraum";
            this.cb_toggleRange.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 684);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Label lbl_dateText;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_toggleRange;
    }
}