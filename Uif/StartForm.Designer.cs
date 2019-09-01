namespace Uif
{
    partial class StartForm
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

        public System.Windows.Forms.PictureBox PbxOutput
        {
            get { return pbxOutput; }
            set { pbxOutput = value; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCSharpSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxOutput = new System.Windows.Forms.PictureBox();
            this.gbxCoordinates = new MyControls.Grouper();
            this.btnColor = new System.Windows.Forms.Button();
            this.llbNumberOfInstances = new System.Windows.Forms.LinkLabel();
            this.llbRunGC = new System.Windows.Forms.LinkLabel();
            this.lblX = new System.Windows.Forms.Label();
            this.btnGiven = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.gbxGraphics = new MyControls.Grouper();
            this.btnNavigator = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnPictureData = new System.Windows.Forms.Button();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.llbRectangle = new System.Windows.Forms.LinkLabel();
            this.lblRadius = new System.Windows.Forms.Label();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.llbCircle = new System.Windows.Forms.LinkLabel();
            this.llbDot = new System.Windows.Forms.LinkLabel();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            this.gbxCoordinates.SuspendLayout();
            this.gbxGraphics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(34, 266);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(375, 693);
            this.lbxOutput.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(862, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Uif.Properties.Resources.Create1;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Uif.Properties.Resources.View;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Uif.Properties.Resources.Save;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Uif.Properties.Resources.Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Uif.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Image = global::Uif.Properties.Resources.paint;
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            this.layoutToolStripMenuItem.Click += new System.EventHandler(this.layoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCSharpSolutionToolStripMenuItem,
            this.helpContentsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.testToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutCSharpSolutionToolStripMenuItem
            // 
            this.aboutCSharpSolutionToolStripMenuItem.Image = global::Uif.Properties.Resources.Button_Info_;
            this.aboutCSharpSolutionToolStripMenuItem.Name = "aboutCSharpSolutionToolStripMenuItem";
            this.aboutCSharpSolutionToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.aboutCSharpSolutionToolStripMenuItem.Text = "About Graphical Shape Application";
            this.aboutCSharpSolutionToolStripMenuItem.Click += new System.EventHandler(this.aboutCSharpSolutionToolStripMenuItem_Click);
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Image = global::Uif.Properties.Resources._Button_Help;
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = global::Uif.Properties.Resources.update_icon;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // pbxOutput
            // 
            this.pbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxOutput.BackColor = System.Drawing.Color.White;
            this.pbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxOutput.Location = new System.Drawing.Point(446, 266);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(797, 400);
            this.pbxOutput.TabIndex = 8;
            this.pbxOutput.TabStop = false;
            this.pbxOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxOutput_Paint);
            this.pbxOutput.Resize += new System.EventHandler(this.pbxOutput_Resize);
            // 
            // gbxCoordinates
            // 
            this.gbxCoordinates.BackgroundColor = System.Drawing.Color.White;
            this.gbxCoordinates.BackgroundGradientColor = System.Drawing.SystemColors.Desktop;
            this.gbxCoordinates.BackgroundGradientMode = MyControls.Grouper.GroupBoxGradientMode.Vertical;
            this.gbxCoordinates.BorderColor = System.Drawing.SystemColors.Desktop;
            this.gbxCoordinates.BorderThickness = 1F;
            this.gbxCoordinates.Controls.Add(this.btnColor);
            this.gbxCoordinates.Controls.Add(this.llbNumberOfInstances);
            this.gbxCoordinates.Controls.Add(this.llbRunGC);
            this.gbxCoordinates.Controls.Add(this.lblX);
            this.gbxCoordinates.Controls.Add(this.btnGiven);
            this.gbxCoordinates.Controls.Add(this.lblY);
            this.gbxCoordinates.Controls.Add(this.btnDefault);
            this.gbxCoordinates.Controls.Add(this.tbxX);
            this.gbxCoordinates.Controls.Add(this.tbxY);
            this.gbxCoordinates.CustomGroupBoxColor = System.Drawing.Color.White;
            this.gbxCoordinates.GroupImage = null;
            this.gbxCoordinates.GroupTitle = "Coordinates";
            this.gbxCoordinates.Location = new System.Drawing.Point(34, 42);
            this.gbxCoordinates.Name = "gbxCoordinates";
            this.gbxCoordinates.Padding = new System.Windows.Forms.Padding(20);
            this.gbxCoordinates.PaintGroupBox = false;
            this.gbxCoordinates.RoundCorners = 15;
            this.gbxCoordinates.ShadowColor = System.Drawing.Color.Transparent;
            this.gbxCoordinates.ShadowControl = true;
            this.gbxCoordinates.ShadowThickness = 5;
            this.gbxCoordinates.Size = new System.Drawing.Size(375, 200);
            this.gbxCoordinates.TabIndex = 12;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnColor.Location = new System.Drawing.Point(23, 121);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // llbNumberOfInstances
            // 
            this.llbNumberOfInstances.AutoSize = true;
            this.llbNumberOfInstances.Location = new System.Drawing.Point(146, 131);
            this.llbNumberOfInstances.Name = "llbNumberOfInstances";
            this.llbNumberOfInstances.Size = new System.Drawing.Size(105, 13);
            this.llbNumberOfInstances.TabIndex = 7;
            this.llbNumberOfInstances.TabStop = true;
            this.llbNumberOfInstances.Text = "Number of Instances";
            this.llbNumberOfInstances.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbNumberOfInstances_LinkClicked);
            // 
            // llbRunGC
            // 
            this.llbRunGC.AutoSize = true;
            this.llbRunGC.Location = new System.Drawing.Point(146, 107);
            this.llbRunGC.Name = "llbRunGC";
            this.llbRunGC.Size = new System.Drawing.Size(120, 13);
            this.llbRunGC.TabIndex = 7;
            this.llbRunGC.TabStop = true;
            this.llbRunGC.Text = "Run Garbage Collection";
            this.llbRunGC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRunGC_LinkClicked);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 36);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // btnGiven
            // 
            this.btnGiven.Location = new System.Drawing.Point(138, 70);
            this.btnGiven.Name = "btnGiven";
            this.btnGiven.Size = new System.Drawing.Size(178, 23);
            this.btnGiven.TabIndex = 5;
            this.btnGiven.Text = "Create given xy-coordinates";
            this.btnGiven.UseVisualStyleBackColor = true;
            this.btnGiven.Click += new System.EventHandler(this.btnGiven_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(6, 75);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(138, 30);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(178, 23);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Create default xy-coordinates";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(36, 33);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(50, 20);
            this.tbxX.TabIndex = 2;
            this.tbxX.Text = "50";
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(36, 72);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(50, 20);
            this.tbxY.TabIndex = 3;
            this.tbxY.Text = "100";
            // 
            // gbxGraphics
            // 
            this.gbxGraphics.BackgroundColor = System.Drawing.Color.White;
            this.gbxGraphics.BackgroundGradientColor = System.Drawing.SystemColors.Desktop;
            this.gbxGraphics.BackgroundGradientMode = MyControls.Grouper.GroupBoxGradientMode.Vertical;
            this.gbxGraphics.BorderColor = System.Drawing.SystemColors.Desktop;
            this.gbxGraphics.BorderThickness = 1F;
            this.gbxGraphics.Controls.Add(this.btnNavigator);
            this.gbxGraphics.Controls.Add(this.btnDecrease);
            this.gbxGraphics.Controls.Add(this.btnIncrease);
            this.gbxGraphics.Controls.Add(this.btnPictureData);
            this.gbxGraphics.Controls.Add(this.tbxWidth);
            this.gbxGraphics.Controls.Add(this.lblWidth);
            this.gbxGraphics.Controls.Add(this.tbxHeight);
            this.gbxGraphics.Controls.Add(this.lblHeight);
            this.gbxGraphics.Controls.Add(this.llbRectangle);
            this.gbxGraphics.Controls.Add(this.lblRadius);
            this.gbxGraphics.Controls.Add(this.tbxRadius);
            this.gbxGraphics.Controls.Add(this.llbCircle);
            this.gbxGraphics.Controls.Add(this.llbDot);
            this.gbxGraphics.CustomGroupBoxColor = System.Drawing.Color.White;
            this.gbxGraphics.GroupImage = null;
            this.gbxGraphics.GroupTitle = "Graphics";
            this.gbxGraphics.Location = new System.Drawing.Point(446, 42);
            this.gbxGraphics.Name = "gbxGraphics";
            this.gbxGraphics.Padding = new System.Windows.Forms.Padding(20);
            this.gbxGraphics.PaintGroupBox = false;
            this.gbxGraphics.RoundCorners = 15;
            this.gbxGraphics.ShadowColor = System.Drawing.Color.Transparent;
            this.gbxGraphics.ShadowControl = true;
            this.gbxGraphics.ShadowThickness = 5;
            this.gbxGraphics.Size = new System.Drawing.Size(386, 200);
            this.gbxGraphics.TabIndex = 11;
            // 
            // btnNavigator
            // 
            this.btnNavigator.Location = new System.Drawing.Point(229, 30);
            this.btnNavigator.Name = "btnNavigator";
            this.btnNavigator.Size = new System.Drawing.Size(120, 25);
            this.btnNavigator.TabIndex = 12;
            this.btnNavigator.Text = "Navigator";
            this.btnNavigator.UseVisualStyleBackColor = true;
            this.btnNavigator.Click += new System.EventHandler(this.btnNavigator_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(229, 159);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(120, 25);
            this.btnDecrease.TabIndex = 11;
            this.btnDecrease.Text = "Size - 10%";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(80, 159);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(118, 25);
            this.btnIncrease.TabIndex = 10;
            this.btnIncrease.Text = "Size + 10%";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnPictureData
            // 
            this.btnPictureData.Location = new System.Drawing.Point(80, 30);
            this.btnPictureData.Name = "btnPictureData";
            this.btnPictureData.Size = new System.Drawing.Size(120, 25);
            this.btnPictureData.TabIndex = 9;
            this.btnPictureData.Text = "Print Picture Data";
            this.btnPictureData.UseVisualStyleBackColor = true;
            this.btnPictureData.Click += new System.EventHandler(this.btnPictureData_Click);
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(261, 118);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(80, 20);
            this.tbxWidth.TabIndex = 8;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(220, 121);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(123, 118);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(80, 20);
            this.tbxHeight.TabIndex = 6;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(79, 121);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height";
            // 
            // llbRectangle
            // 
            this.llbRectangle.AutoSize = true;
            this.llbRectangle.Location = new System.Drawing.Point(15, 121);
            this.llbRectangle.Name = "llbRectangle";
            this.llbRectangle.Size = new System.Drawing.Size(56, 13);
            this.llbRectangle.TabIndex = 4;
            this.llbRectangle.TabStop = true;
            this.llbRectangle.Text = "Rectangle";
            this.llbRectangle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRectangle_LinkClicked);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(77, 80);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radius";
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(123, 76);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(80, 20);
            this.tbxRadius.TabIndex = 2;
            // 
            // llbCircle
            // 
            this.llbCircle.AutoSize = true;
            this.llbCircle.Location = new System.Drawing.Point(15, 79);
            this.llbCircle.Name = "llbCircle";
            this.llbCircle.Size = new System.Drawing.Size(33, 13);
            this.llbCircle.TabIndex = 1;
            this.llbCircle.TabStop = true;
            this.llbCircle.Text = "Circle";
            this.llbCircle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCircle_LinkClicked);
            // 
            // llbDot
            // 
            this.llbDot.AutoSize = true;
            this.llbDot.Location = new System.Drawing.Point(15, 36);
            this.llbDot.Name = "llbDot";
            this.llbDot.Size = new System.Drawing.Size(24, 13);
            this.llbDot.TabIndex = 0;
            this.llbDot.TabStop = true;
            this.llbDot.Text = "Dot";
            this.llbDot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDot_LinkClicked);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(862, 478);
            this.Controls.Add(this.gbxCoordinates);
            this.Controls.Add(this.gbxGraphics);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pbxOutput);
            this.Controls.Add(this.lbxOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Shape Application";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
            this.gbxCoordinates.ResumeLayout(false);
            this.gbxCoordinates.PerformLayout();
            this.gbxGraphics.ResumeLayout(false);
            this.gbxGraphics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Button btnGiven;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.LinkLabel llbRunGC;
        private System.Windows.Forms.LinkLabel llbNumberOfInstances;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.LinkLabel llbDot;
        private System.Windows.Forms.PictureBox pbxOutput;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.LinkLabel llbCircle;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.LinkLabel llbRectangle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnPictureData;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnNavigator;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCSharpSolutionToolStripMenuItem;
        private MyControls.Grouper gbxGraphics;
        private MyControls.Grouper gbxCoordinates;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

