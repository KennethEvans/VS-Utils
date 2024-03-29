﻿namespace Utils_Demo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonScrolledHTML = new System.Windows.Forms.Button();
            this.buttonScrolledTextModeless = new System.Windows.Forms.Button();
            this.buttonScrolledTextModal = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonMBOk = new System.Windows.Forms.Button();
            this.buttonMBLonger = new System.Windows.Forms.Button();
            this.buttonMBLong = new System.Windows.Forms.Button();
            this.buttonYesNo = new System.Windows.Forms.Button();
            this.buttonRetryCancel = new System.Windows.Forms.Button();
            this.buttonYesNoCancel = new System.Windows.Forms.Button();
            this.buttonOkCancel = new System.Windows.Forms.Button();
            this.buttonAbortRetryIgnore = new System.Windows.Forms.Button();
            this.buttonMessageLong = new System.Windows.Forms.Button();
            this.buttonMessageLonger = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelButtons, 0, 2);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 3;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1163, 443);
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
            this.menuStrip1.Size = new System.Drawing.Size(1163, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(327, 54);
            this.overviewToolStripMenuItem.Text = "Overview...";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.OnHelpOverviewClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(327, 54);
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
            this.tableLayoutPanelButtons.Controls.Add(this.buttonExc, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonConfirm, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonScrolledHTML, 2, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonScrolledTextModeless, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonScrolledTextModal, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonOk, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMBOk, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMBLonger, 2, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMBLong, 1, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonYesNo, 0, 6);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonRetryCancel, 1, 6);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonYesNoCancel, 2, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonOkCancel, 0, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonAbortRetryIgnore, 1, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMessageLong, 1, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMessageLonger, 2, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonInput, 2, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 7;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(1157, 324);
            this.tableLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInfo.AutoSize = true;
            this.buttonInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInfo.Location = new System.Drawing.Point(155, 2);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(71, 42);
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
            this.buttonWarn.Location = new System.Drawing.Point(506, 2);
            this.buttonWarn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(130, 42);
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
            this.buttonErr.Location = new System.Drawing.Point(916, 2);
            this.buttonErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonErr.Name = "buttonErr";
            this.buttonErr.Size = new System.Drawing.Size(86, 42);
            this.buttonErr.TabIndex = 7;
            this.buttonErr.Text = "Error";
            this.buttonErr.UseVisualStyleBackColor = true;
            this.buttonErr.Click += new System.EventHandler(this.OnErrClick);
            // 
            // buttonExc
            // 
            this.buttonExc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExc.AutoSize = true;
            this.buttonExc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExc.Location = new System.Drawing.Point(115, 49);
            this.buttonExc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(150, 42);
            this.buttonExc.TabIndex = 6;
            this.buttonExc.Text = "Exception";
            this.buttonExc.UseVisualStyleBackColor = true;
            this.buttonExc.Click += new System.EventHandler(this.OnExcClick);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.AutoSize = true;
            this.buttonConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConfirm.Location = new System.Drawing.Point(510, 49);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(123, 42);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.OnPromptClick);
            // 
            // buttonScrolledHTML
            // 
            this.buttonScrolledHTML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrolledHTML.AutoSize = true;
            this.buttonScrolledHTML.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScrolledHTML.Location = new System.Drawing.Point(854, 49);
            this.buttonScrolledHTML.Name = "buttonScrolledHTML";
            this.buttonScrolledHTML.Size = new System.Drawing.Size(211, 42);
            this.buttonScrolledHTML.TabIndex = 21;
            this.buttonScrolledHTML.Text = "Scrolled HTML";
            this.buttonScrolledHTML.UseVisualStyleBackColor = true;
            this.buttonScrolledHTML.Click += new System.EventHandler(this.OnScrolledHTMLClick);
            // 
            // buttonScrolledTextModeless
            // 
            this.buttonScrolledTextModeless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrolledTextModeless.AutoSize = true;
            this.buttonScrolledTextModeless.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScrolledTextModeless.Location = new System.Drawing.Point(412, 96);
            this.buttonScrolledTextModeless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonScrolledTextModeless.Name = "buttonScrolledTextModeless";
            this.buttonScrolledTextModeless.Size = new System.Drawing.Size(319, 42);
            this.buttonScrolledTextModeless.TabIndex = 5;
            this.buttonScrolledTextModeless.Text = "Scrolled Text Modeless";
            this.buttonScrolledTextModeless.UseVisualStyleBackColor = true;
            this.buttonScrolledTextModeless.Click += new System.EventHandler(this.OnScrolledTextClickModelessClick);
            // 
            // buttonScrolledTextModal
            // 
            this.buttonScrolledTextModal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrolledTextModal.AutoSize = true;
            this.buttonScrolledTextModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScrolledTextModal.Location = new System.Drawing.Point(53, 96);
            this.buttonScrolledTextModal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonScrolledTextModal.Name = "buttonScrolledTextModal";
            this.buttonScrolledTextModal.Size = new System.Drawing.Size(275, 42);
            this.buttonScrolledTextModal.TabIndex = 11;
            this.buttonScrolledTextModal.Text = "Scrolled Text Modal";
            this.buttonScrolledTextModal.UseVisualStyleBackColor = true;
            this.buttonScrolledTextModal.Click += new System.EventHandler(this.OnScrolledTextClickModalClick);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOk.Location = new System.Drawing.Point(97, 188);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(187, 42);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Message OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnMessageOkClick);
            // 
            // buttonMBOk
            // 
            this.buttonMBOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMBOk.AutoSize = true;
            this.buttonMBOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMBOk.Location = new System.Drawing.Point(69, 142);
            this.buttonMBOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMBOk.Name = "buttonMBOk";
            this.buttonMBOk.Size = new System.Drawing.Size(243, 42);
            this.buttonMBOk.TabIndex = 18;
            this.buttonMBOk.Text = "Message Box OK";
            this.buttonMBOk.UseVisualStyleBackColor = true;
            this.buttonMBOk.Click += new System.EventHandler(this.OnMessageBoxOk);
            // 
            // buttonMBLonger
            // 
            this.buttonMBLonger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMBLonger.AutoSize = true;
            this.buttonMBLonger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMBLonger.Location = new System.Drawing.Point(814, 142);
            this.buttonMBLonger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMBLonger.Name = "buttonMBLonger";
            this.buttonMBLonger.Size = new System.Drawing.Size(291, 42);
            this.buttonMBLonger.TabIndex = 18;
            this.buttonMBLonger.Text = "Message Box Longer";
            this.buttonMBLonger.UseVisualStyleBackColor = true;
            this.buttonMBLonger.Click += new System.EventHandler(this.OnMessageBoxLonger);
            // 
            // buttonMBLong
            // 
            this.buttonMBLong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMBLong.AutoSize = true;
            this.buttonMBLong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMBLong.Location = new System.Drawing.Point(438, 142);
            this.buttonMBLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMBLong.Name = "buttonMBLong";
            this.buttonMBLong.Size = new System.Drawing.Size(266, 42);
            this.buttonMBLong.TabIndex = 18;
            this.buttonMBLong.Text = "Message Box Long";
            this.buttonMBLong.UseVisualStyleBackColor = true;
            this.buttonMBLong.Click += new System.EventHandler(this.OnMessageBoxLong);
            // 
            // buttonYesNo
            // 
            this.buttonYesNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonYesNo.AutoSize = true;
            this.buttonYesNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonYesNo.Location = new System.Drawing.Point(75, 280);
            this.buttonYesNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYesNo.Name = "buttonYesNo";
            this.buttonYesNo.Size = new System.Drawing.Size(231, 42);
            this.buttonYesNo.TabIndex = 17;
            this.buttonYesNo.Text = "Message YesNo";
            this.buttonYesNo.UseVisualStyleBackColor = true;
            this.buttonYesNo.Click += new System.EventHandler(this.OnMessageYesNoClick);
            // 
            // buttonRetryCancel
            // 
            this.buttonRetryCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRetryCancel.AutoSize = true;
            this.buttonRetryCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRetryCancel.Location = new System.Drawing.Point(420, 280);
            this.buttonRetryCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRetryCancel.Name = "buttonRetryCancel";
            this.buttonRetryCancel.Size = new System.Drawing.Size(302, 42);
            this.buttonRetryCancel.TabIndex = 16;
            this.buttonRetryCancel.Text = "Message RetryCancel";
            this.buttonRetryCancel.UseVisualStyleBackColor = true;
            this.buttonRetryCancel.Click += new System.EventHandler(this.OnMessageRetryCancelClick);
            // 
            // buttonYesNoCancel
            // 
            this.buttonYesNoCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonYesNoCancel.AutoSize = true;
            this.buttonYesNoCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonYesNoCancel.Location = new System.Drawing.Point(799, 234);
            this.buttonYesNoCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYesNoCancel.Name = "buttonYesNoCancel";
            this.buttonYesNoCancel.Size = new System.Drawing.Size(320, 42);
            this.buttonYesNoCancel.TabIndex = 15;
            this.buttonYesNoCancel.Text = "Message YesNoCancel";
            this.buttonYesNoCancel.UseVisualStyleBackColor = true;
            this.buttonYesNoCancel.Click += new System.EventHandler(this.OnMessageYesNoCancelClick);
            // 
            // buttonOkCancel
            // 
            this.buttonOkCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOkCancel.AutoSize = true;
            this.buttonOkCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOkCancel.Location = new System.Drawing.Point(52, 234);
            this.buttonOkCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOkCancel.Name = "buttonOkCancel";
            this.buttonOkCancel.Size = new System.Drawing.Size(276, 42);
            this.buttonOkCancel.TabIndex = 13;
            this.buttonOkCancel.Text = "Message OKCancel";
            this.buttonOkCancel.UseVisualStyleBackColor = true;
            this.buttonOkCancel.Click += new System.EventHandler(this.OnMessageOkCancelClick);
            // 
            // buttonAbortRetryIgnore
            // 
            this.buttonAbortRetryIgnore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAbortRetryIgnore.AutoSize = true;
            this.buttonAbortRetryIgnore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAbortRetryIgnore.Location = new System.Drawing.Point(391, 234);
            this.buttonAbortRetryIgnore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbortRetryIgnore.Name = "buttonAbortRetryIgnore";
            this.buttonAbortRetryIgnore.Size = new System.Drawing.Size(361, 42);
            this.buttonAbortRetryIgnore.TabIndex = 14;
            this.buttonAbortRetryIgnore.Text = "Message AbortRetryIgnore";
            this.buttonAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.buttonAbortRetryIgnore.Click += new System.EventHandler(this.OnMessageAbortRetryIgnoreClick);
            // 
            // buttonMessageLong
            // 
            this.buttonMessageLong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMessageLong.AutoSize = true;
            this.buttonMessageLong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMessageLong.Location = new System.Drawing.Point(466, 188);
            this.buttonMessageLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMessageLong.Name = "buttonMessageLong";
            this.buttonMessageLong.Size = new System.Drawing.Size(210, 42);
            this.buttonMessageLong.TabIndex = 19;
            this.buttonMessageLong.Text = "Message Long";
            this.buttonMessageLong.UseVisualStyleBackColor = true;
            this.buttonMessageLong.Click += new System.EventHandler(this.OnMessageLong);
            // 
            // buttonMessageLonger
            // 
            this.buttonMessageLonger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMessageLonger.AutoSize = true;
            this.buttonMessageLonger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMessageLonger.Location = new System.Drawing.Point(842, 188);
            this.buttonMessageLonger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMessageLonger.Name = "buttonMessageLonger";
            this.buttonMessageLonger.Size = new System.Drawing.Size(235, 42);
            this.buttonMessageLonger.TabIndex = 19;
            this.buttonMessageLonger.Text = "Message Longer";
            this.buttonMessageLonger.UseVisualStyleBackColor = true;
            this.buttonMessageLonger.Click += new System.EventHandler(this.OnMessageLonger);
            // 
            // buttonInput
            // 
            this.buttonInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInput.AutoSize = true;
            this.buttonInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInput.Location = new System.Drawing.Point(875, 96);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(169, 42);
            this.buttonInput.TabIndex = 20;
            this.buttonInput.Text = "InputDialog";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.OnInputDialogClick);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonQuit);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(540, 389);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(83, 52);
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
            this.buttonQuit.Size = new System.Drawing.Size(77, 42);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.OnFileQuitClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 443);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button buttonScrolledTextModal;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonYesNoCancel;
        private System.Windows.Forms.Button buttonAbortRetryIgnore;
        private System.Windows.Forms.Button buttonOkCancel;
        private System.Windows.Forms.Button buttonYesNo;
        private System.Windows.Forms.Button buttonRetryCancel;
        private System.Windows.Forms.Button buttonMBOk;
        private System.Windows.Forms.Button buttonMBLonger;
        private System.Windows.Forms.Button buttonMBLong;
        private System.Windows.Forms.Button buttonMessageLong;
        private System.Windows.Forms.Button buttonMessageLonger;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonScrolledHTML;
    }
}

