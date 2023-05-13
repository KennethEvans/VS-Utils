using System.Windows.Forms;
using System.Drawing;

namespace KEUtils.ScrolledHTML2 {
    partial class ScrolledHTMLDialog2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            flowLayoutPanelButtons1 = new FlowLayoutPanel();
            buttonBack = new Button();
            buttonForward = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            flowLayoutPanelButtons1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelButtons1
            // 
            flowLayoutPanelButtons1.Anchor = AnchorStyles.Bottom;
            flowLayoutPanelButtons1.AutoSize = true;
            flowLayoutPanelButtons1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelButtons1.Controls.Add(buttonBack);
            flowLayoutPanelButtons1.Controls.Add(buttonForward);
            flowLayoutPanelButtons1.Controls.Add(buttonCancel);
            flowLayoutPanelButtons1.Location = new Point(151, 1095);
            flowLayoutPanelButtons1.Margin = new Padding(6, 8, 6, 8);
            flowLayoutPanelButtons1.Name = "flowLayoutPanelButtons1";
            flowLayoutPanelButtons1.Size = new Size(513, 83);
            flowLayoutPanelButtons1.TabIndex = 5;
            flowLayoutPanelButtons1.WrapContents = false;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(6, 8);
            buttonBack.Margin = new Padding(6, 8, 6, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 67);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += OnButtonBackClick;
            // 
            // buttonForward
            // 
            buttonForward.AutoSize = true;
            buttonForward.Location = new Point(177, 8);
            buttonForward.Margin = new Padding(6, 8, 6, 8);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(159, 67);
            buttonForward.TabIndex = 1;
            buttonForward.Text = "Forward";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += OnButtonForwardClick;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.Location = new Point(348, 8);
            buttonCancel.Margin = new Padding(6, 8, 6, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(159, 67);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += OnButtonCancelClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanelButtons1, 0, 1);
            tableLayoutPanel1.Controls.Add(webView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(816, 1206);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(3, 3);
            webView.Name = "webView";
            webView.Size = new Size(810, 1081);
            webView.TabIndex = 6;
            webView.ZoomFactor = 1D;
            // 
            // ScrolledHTMLDialog
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(816, 1206);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScrolledHTMLDialog";
            ShowIcon = false;
            Text = "ScrolledHTMLDialog";
            FormClosing += OnFormClosing;
            flowLayoutPanelButtons1.ResumeLayout(false);
            flowLayoutPanelButtons1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}