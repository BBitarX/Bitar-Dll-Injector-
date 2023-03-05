namespace BitarInjector
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUs = new System.Windows.Forms.ToolStripMenuItem();
            this.clickMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshProcessListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.dllsListBox = new DrakeUI.Framework.DrakeUIListBox();
            this.drakeUILabel2 = new DrakeUI.Framework.DrakeUILabel();
            this.refreshProcListButton = new DrakeUI.Framework.DrakeUIButton();
            this.addDllButton = new DrakeUI.Framework.DrakeUIButton();
            this.removeDllButton = new DrakeUI.Framework.DrakeUIButton();
            this.injectDllsButton = new DrakeUI.Framework.DrakeUIButton();
            this.procListBox = new System.Windows.Forms.ListBox();
            this.penisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.susToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sussyBakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adolfHitleroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLoveJesusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allahuAkbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new DrakeUI.Framework.DrakeUILabel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolMenuStrip,
            this.clickMeToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.penisToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 35);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(570, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolMenuStrip
            // 
            this.helpToolMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUs});
            this.helpToolMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.helpToolMenuStrip.Name = "helpToolMenuStrip";
            this.helpToolMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolMenuStrip.Text = "Help";
            // 
            // contactUs
            // 
            this.contactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.contactUs.Name = "contactUs";
            this.contactUs.Size = new System.Drawing.Size(180, 22);
            this.contactUs.Text = "Contact Us";
            this.contactUs.Click += new System.EventHandler(this.contactUs_Click);
            // 
            // clickMeToolStripMenuItem
            // 
            this.clickMeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.clickMeToolStripMenuItem.Name = "clickMeToolStripMenuItem";
            this.clickMeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.clickMeToolStripMenuItem.Text = "Click Me";
            this.clickMeToolStripMenuItem.Click += new System.EventHandler(this.clickMeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshProcessListToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // refreshProcessListToolStripMenuItem
            // 
            this.refreshProcessListToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.refreshProcessListToolStripMenuItem.Name = "refreshProcessListToolStripMenuItem";
            this.refreshProcessListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshProcessListToolStripMenuItem.Text = "Refresh Process List";
            this.refreshProcessListToolStripMenuItem.Click += new System.EventHandler(this.refreshProcessListToolStripMenuItem_Click);
            // 
            // drakeUILabel1
            // 
            this.drakeUILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUILabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.drakeUILabel1.Location = new System.Drawing.Point(30, 86);
            this.drakeUILabel1.Name = "drakeUILabel1";
            this.drakeUILabel1.Size = new System.Drawing.Size(100, 23);
            this.drakeUILabel1.Style = DrakeUI.Framework.UIStyle.Orange;
            this.drakeUILabel1.TabIndex = 2;
            this.drakeUILabel1.Text = "Processes:";
            this.drakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dllsListBox
            // 
            this.dllsListBox.AutoScroll = true;
            this.dllsListBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dllsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllsListBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.dllsListBox.ItemHeight = 20;
            this.dllsListBox.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dllsListBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dllsListBox.Location = new System.Drawing.Point(284, 114);
            this.dllsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dllsListBox.Name = "dllsListBox";
            this.dllsListBox.Padding = new System.Windows.Forms.Padding(2);
            this.dllsListBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dllsListBox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.dllsListBox.Size = new System.Drawing.Size(239, 111);
            this.dllsListBox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.dllsListBox.TabIndex = 3;
            this.dllsListBox.Text = "dlls list box";
            // 
            // drakeUILabel2
            // 
            this.drakeUILabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUILabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.drakeUILabel2.Location = new System.Drawing.Point(289, 86);
            this.drakeUILabel2.Name = "drakeUILabel2";
            this.drakeUILabel2.Size = new System.Drawing.Size(100, 23);
            this.drakeUILabel2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel2.TabIndex = 4;
            this.drakeUILabel2.Text = "Dll(s):";
            this.drakeUILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshProcListButton
            // 
            this.refreshProcListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshProcListButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.refreshProcListButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.refreshProcListButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.refreshProcListButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.refreshProcListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.refreshProcListButton.Location = new System.Drawing.Point(287, 234);
            this.refreshProcListButton.Name = "refreshProcListButton";
            this.refreshProcListButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.refreshProcListButton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.refreshProcListButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.refreshProcListButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.refreshProcListButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.refreshProcListButton.ShowFocusLine = true;
            this.refreshProcListButton.Size = new System.Drawing.Size(234, 32);
            this.refreshProcListButton.Style = DrakeUI.Framework.UIStyle.Orange;
            this.refreshProcListButton.TabIndex = 5;
            this.refreshProcListButton.Text = "Refresh Process List";
            this.refreshProcListButton.Click += new System.EventHandler(this.refreshProcListButton_Click);
            // 
            // addDllButton
            // 
            this.addDllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDllButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.addDllButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.addDllButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.addDllButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.addDllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDllButton.Location = new System.Drawing.Point(287, 272);
            this.addDllButton.Name = "addDllButton";
            this.addDllButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.addDllButton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.addDllButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.addDllButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.addDllButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.addDllButton.ShowFocusLine = true;
            this.addDllButton.Size = new System.Drawing.Size(234, 32);
            this.addDllButton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.addDllButton.TabIndex = 6;
            this.addDllButton.Text = "Add Dll";
            this.addDllButton.Click += new System.EventHandler(this.addDllButton_Click);
            // 
            // removeDllButton
            // 
            this.removeDllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeDllButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.removeDllButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.removeDllButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.removeDllButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.removeDllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeDllButton.Location = new System.Drawing.Point(287, 310);
            this.removeDllButton.Name = "removeDllButton";
            this.removeDllButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.removeDllButton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.removeDllButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.removeDllButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.removeDllButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.removeDllButton.ShowFocusLine = true;
            this.removeDllButton.Size = new System.Drawing.Size(234, 32);
            this.removeDllButton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.removeDllButton.TabIndex = 7;
            this.removeDllButton.Text = "Remove Dll";
            this.removeDllButton.Click += new System.EventHandler(this.removeDllButton_Click);
            // 
            // injectDllsButton
            // 
            this.injectDllsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.injectDllsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.injectDllsButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.injectDllsButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.injectDllsButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.injectDllsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.injectDllsButton.Location = new System.Drawing.Point(287, 348);
            this.injectDllsButton.Name = "injectDllsButton";
            this.injectDllsButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.injectDllsButton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.injectDllsButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.injectDllsButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.injectDllsButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.injectDllsButton.ShowFocusLine = true;
            this.injectDllsButton.Size = new System.Drawing.Size(234, 32);
            this.injectDllsButton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.injectDllsButton.TabIndex = 8;
            this.injectDllsButton.Text = "Inject Dll(s)";
            this.injectDllsButton.Click += new System.EventHandler(this.injectDllsButton_Click);
            // 
            // procListBox
            // 
            this.procListBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.procListBox.FormattingEnabled = true;
            this.procListBox.ItemHeight = 19;
            this.procListBox.Location = new System.Drawing.Point(28, 114);
            this.procListBox.Name = "procListBox";
            this.procListBox.ScrollAlwaysVisible = true;
            this.procListBox.Size = new System.Drawing.Size(239, 289);
            this.procListBox.TabIndex = 9;
            // 
            // penisToolStripMenuItem
            // 
            this.penisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.susToolStripMenuItem,
            this.sussyBakaToolStripMenuItem,
            this.adolfHitleroToolStripMenuItem,
            this.iLoveJesusToolStripMenuItem,
            this.allahuAkbarToolStripMenuItem});
            this.penisToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.penisToolStripMenuItem.Name = "penisToolStripMenuItem";
            this.penisToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.penisToolStripMenuItem.Text = "Penis";
            // 
            // susToolStripMenuItem
            // 
            this.susToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.susToolStripMenuItem.Name = "susToolStripMenuItem";
            this.susToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.susToolStripMenuItem.Text = "sus";
            // 
            // sussyBakaToolStripMenuItem
            // 
            this.sussyBakaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.sussyBakaToolStripMenuItem.Name = "sussyBakaToolStripMenuItem";
            this.sussyBakaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sussyBakaToolStripMenuItem.Text = "sussy baka";
            // 
            // adolfHitleroToolStripMenuItem
            // 
            this.adolfHitleroToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.adolfHitleroToolStripMenuItem.Name = "adolfHitleroToolStripMenuItem";
            this.adolfHitleroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adolfHitleroToolStripMenuItem.Text = "adolf hitlero";
            // 
            // iLoveJesusToolStripMenuItem
            // 
            this.iLoveJesusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.iLoveJesusToolStripMenuItem.Name = "iLoveJesusToolStripMenuItem";
            this.iLoveJesusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iLoveJesusToolStripMenuItem.Text = "i love jesus";
            // 
            // allahuAkbarToolStripMenuItem
            // 
            this.allahuAkbarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.allahuAkbarToolStripMenuItem.Name = "allahuAkbarToolStripMenuItem";
            this.allahuAkbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allahuAkbarToolStripMenuItem.Text = "allahu akbar";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lblTime.Location = new System.Drawing.Point(491, 392);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 23);
            this.lblTime.Style = DrakeUI.Framework.UIStyle.Custom;
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.procListBox);
            this.Controls.Add(this.injectDllsButton);
            this.Controls.Add(this.removeDllButton);
            this.Controls.Add(this.addDllButton);
            this.Controls.Add(this.refreshProcListButton);
            this.Controls.Add(this.drakeUILabel2);
            this.Controls.Add(this.dllsListBox);
            this.Controls.Add(this.drakeUILabel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Text = "Bitar Injector";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactUs;
        private System.Windows.Forms.ToolStripMenuItem clickMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshProcessListToolStripMenuItem;
        private DrakeUI.Framework.DrakeUILabel drakeUILabel1;
        private DrakeUI.Framework.DrakeUIListBox dllsListBox;
        private DrakeUI.Framework.DrakeUILabel drakeUILabel2;
        private DrakeUI.Framework.DrakeUIButton refreshProcListButton;
        private DrakeUI.Framework.DrakeUIButton addDllButton;
        private DrakeUI.Framework.DrakeUIButton removeDllButton;
        private DrakeUI.Framework.DrakeUIButton injectDllsButton;
        private System.Windows.Forms.ListBox procListBox;
        private System.Windows.Forms.ToolStripMenuItem penisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem susToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sussyBakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adolfHitleroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLoveJesusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allahuAkbarToolStripMenuItem;
        private DrakeUI.Framework.DrakeUILabel lblTime;
    }
}

