namespace Uif
{
    partial class Navigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigator));
            this.btnNW = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnSW = new System.Windows.Forms.Button();
            this.btnSE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNW
            // 
            this.btnNW.Image = global::Uif.Properties.Resources.dir_NW;
            this.btnNW.Location = new System.Drawing.Point(44, 43);
            this.btnNW.Name = "btnNW";
            this.btnNW.Size = new System.Drawing.Size(42, 42);
            this.btnNW.TabIndex = 0;
            this.btnNW.Tag = "-2;-2";
            this.btnNW.UseVisualStyleBackColor = true;
            this.btnNW.Click += new System.EventHandler(this.moveClick);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Uif.Properties.Resources.turn_off;
            this.btnClose.Location = new System.Drawing.Point(127, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNE
            // 
            this.btnNE.Image = global::Uif.Properties.Resources.dir_NE;
            this.btnNE.Location = new System.Drawing.Point(207, 43);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(42, 42);
            this.btnNE.TabIndex = 2;
            this.btnNE.Tag = "2;-2";
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.moveClick);
            // 
            // btnSW
            // 
            this.btnSW.Image = global::Uif.Properties.Resources.dir_SW;
            this.btnSW.Location = new System.Drawing.Point(44, 175);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(42, 42);
            this.btnSW.TabIndex = 3;
            this.btnSW.Tag = "-2;2";
            this.btnSW.UseVisualStyleBackColor = true;
            this.btnSW.Click += new System.EventHandler(this.moveClick);
            // 
            // btnSE
            // 
            this.btnSE.Image = global::Uif.Properties.Resources.dir_SE;
            this.btnSE.Location = new System.Drawing.Point(207, 175);
            this.btnSE.Name = "btnSE";
            this.btnSE.Size = new System.Drawing.Size(42, 42);
            this.btnSE.TabIndex = 4;
            this.btnSE.Tag = "2;2";
            this.btnSE.UseVisualStyleBackColor = true;
            this.btnSE.Click += new System.EventHandler(this.moveClick);
            // 
            // btnW
            // 
            this.btnW.Image = global::Uif.Properties.Resources.dir_W;
            this.btnW.Location = new System.Drawing.Point(44, 111);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(42, 42);
            this.btnW.TabIndex = 5;
            this.btnW.Tag = "-2;0";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.moveClick);
            // 
            // btnE
            // 
            this.btnE.Image = global::Uif.Properties.Resources.dir_E;
            this.btnE.Location = new System.Drawing.Point(207, 111);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(42, 42);
            this.btnE.TabIndex = 6;
            this.btnE.Tag = "2;0";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.moveClick);
            // 
            // btnN
            // 
            this.btnN.Image = global::Uif.Properties.Resources.dir_N;
            this.btnN.Location = new System.Drawing.Point(127, 43);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(42, 42);
            this.btnN.TabIndex = 7;
            this.btnN.Tag = "0;-2";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.moveClick);
            // 
            // btnS
            // 
            this.btnS.Image = global::Uif.Properties.Resources.dir_S;
            this.btnS.Location = new System.Drawing.Point(127, 175);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(42, 42);
            this.btnS.TabIndex = 8;
            this.btnS.Tag = "0;2";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.moveClick);
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnSE);
            this.Controls.Add(this.btnSW);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Navigator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigator";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.moveClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNW;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnSW;
        private System.Windows.Forms.Button btnSE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
    }
}