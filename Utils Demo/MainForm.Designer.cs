namespace Utils_Demo {
    partial class MainForm {
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
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonWarn = new System.Windows.Forms.Button();
            this.buttonErr = new System.Windows.Forms.Button();
            this.buttonScrolledTextModeless = new System.Windows.Forms.Button();
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonExc1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonScrolledTextModal = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.AutoSize = true;
            this.tableLayoutPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelButtons, 0, 5);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 6;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1030, 302);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 56);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(241, 54);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnFileQuitClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 56);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.overviewToolStripMenuItem.Text = "Overview...";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.OnHelpOverviewClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAboutClick);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonInfo, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonWarn, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonErr, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonScrolledTextModeless, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonScrolledTextModal, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonExc, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonExc1, 1, 1);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(1024, 138);
            this.tableLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInfo.AutoSize = true;
            this.buttonInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInfo.Location = new System.Drawing.Point(132, 2);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(72, 42);
            this.buttonInfo.TabIndex = 9;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.OnInfoClick);
            // 
            // buttonWarn
            // 
            this.buttonWarn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWarn.AutoSize = true;
            this.buttonWarn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWarn.Location = new System.Drawing.Point(440, 2);
            this.buttonWarn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(131, 42);
            this.buttonWarn.TabIndex = 8;
            this.buttonWarn.Text = "Warning";
            this.buttonWarn.UseVisualStyleBackColor = true;
            this.buttonWarn.Click += new System.EventHandler(this.OnWarnClick);
            // 
            // buttonErr
            // 
            this.buttonErr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonErr.AutoSize = true;
            this.buttonErr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonErr.Location = new System.Drawing.Point(805, 2);
            this.buttonErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonErr.Name = "buttonErr";
            this.buttonErr.Size = new System.Drawing.Size(87, 42);
            this.buttonErr.TabIndex = 7;
            this.buttonErr.Text = "Error";
            this.buttonErr.UseVisualStyleBackColor = true;
            this.buttonErr.Click += new System.EventHandler(this.OnErrClick);
            // 
            // buttonScrolledTextModeless
            // 
            this.buttonScrolledTextModeless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrolledTextModeless.AutoSize = true;
            this.buttonScrolledTextModeless.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScrolledTextModeless.Location = new System.Drawing.Point(8, 94);
            this.buttonScrolledTextModeless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonScrolledTextModeless.Name = "buttonScrolledTextModeless";
            this.buttonScrolledTextModeless.Size = new System.Drawing.Size(320, 42);
            this.buttonScrolledTextModeless.TabIndex = 5;
            this.buttonScrolledTextModeless.Text = "Scrolled Text Modeless";
            this.buttonScrolledTextModeless.UseVisualStyleBackColor = true;
            this.buttonScrolledTextModeless.Click += new System.EventHandler(this.OnScrolledTextClickModelessClick);
            // 
            // buttonExc
            // 
            this.buttonExc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExc.AutoSize = true;
            this.buttonExc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExc.Location = new System.Drawing.Point(93, 48);
            this.buttonExc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(151, 42);
            this.buttonExc.TabIndex = 6;
            this.buttonExc.Text = "Exception";
            this.buttonExc.UseVisualStyleBackColor = true;
            this.buttonExc.Click += new System.EventHandler(this.OnExcClick);
            // 
            // buttonExc1
            // 
            this.buttonExc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExc1.AutoSize = true;
            this.buttonExc1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExc1.Location = new System.Drawing.Point(379, 48);
            this.buttonExc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExc1.Name = "buttonExc1";
            this.buttonExc1.Size = new System.Drawing.Size(252, 42);
            this.buttonExc1.TabIndex = 10;
            this.buttonExc1.Text = " Exception / Trace";
            this.buttonExc1.UseVisualStyleBackColor = true;
            this.buttonExc1.Click += new System.EventHandler(this.OnExc1Click);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonQuit);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(473, 254);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(84, 46);
            this.flowLayoutPanelButtons.TabIndex = 0;
            this.flowLayoutPanelButtons.WrapContents = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuit.Location = new System.Drawing.Point(3, 2);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(78, 42);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.OnFileQuitClick);
            // 
            // buttonScrolledTextModal
            // 
            this.buttonScrolledTextModal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrolledTextModal.AutoSize = true;
            this.buttonScrolledTextModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScrolledTextModal.Location = new System.Drawing.Point(367, 94);
            this.buttonScrolledTextModal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonScrolledTextModal.Name = "buttonScrolledTextModal";
            this.buttonScrolledTextModal.Size = new System.Drawing.Size(276, 42);
            this.buttonScrolledTextModal.TabIndex = 11;
            this.buttonScrolledTextModal.Text = "Scrolled Text Modal";
            this.buttonScrolledTextModal.UseVisualStyleBackColor = true;
            this.buttonScrolledTextModal.Click += new System.EventHandler(this.OnScrolledTextClickModalClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 302);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Name = "MainForm";
            this.Text = "Utils Demo";
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonWarn;
        private System.Windows.Forms.Button buttonErr;
        private System.Windows.Forms.Button buttonScrolledTextModeless;
        private System.Windows.Forms.Button buttonExc;
        private System.Windows.Forms.Button buttonExc1;
        private System.Windows.Forms.Button buttonScrolledTextModal;
    }
}

