namespace ClickJacking_Detector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelerror = new System.Windows.Forms.Label();
            this.linkLabelSelectMethod = new System.Windows.Forms.LinkLabel();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.labelXframeValue = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clickJackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.owaspDefenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xFrameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 170);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelerror);
            this.panel3.Controls.Add(this.linkLabelSelectMethod);
            this.panel3.Controls.Add(this.textBoxMethod);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelFinalResult);
            this.panel3.Controls.Add(this.labelXframeValue);
            this.panel3.Controls.Add(this.textBoxUrl);
            this.panel3.Controls.Add(this.buttonTest);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 126);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(216, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "ex: http://google.com";
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(72, 79);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(29, 13);
            this.labelerror.TabIndex = 7;
            this.labelerror.Text = "Error";
            this.labelerror.Visible = false;
            // 
            // linkLabelSelectMethod
            // 
            this.linkLabelSelectMethod.AutoSize = true;
            this.linkLabelSelectMethod.Location = new System.Drawing.Point(295, 66);
            this.linkLabelSelectMethod.Name = "linkLabelSelectMethod";
            this.linkLabelSelectMethod.Size = new System.Drawing.Size(14, 13);
            this.linkLabelSelectMethod.TabIndex = 6;
            this.linkLabelSelectMethod.TabStop = true;
            this.linkLabelSelectMethod.Text = "S";
            this.linkLabelSelectMethod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectMethod_LinkClicked);
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethod.Location = new System.Drawing.Point(72, 43);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(237, 20);
            this.textBoxMethod.TabIndex = 5;
            this.textBoxMethod.Text = "GET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Method";
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.AutoSize = true;
            this.labelFinalResult.Location = new System.Drawing.Point(172, 92);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(31, 13);
            this.labelFinalResult.TabIndex = 3;
            this.labelFinalResult.Text = "........";
            this.labelFinalResult.TextChanged += new System.EventHandler(this.labelResult_TextChanged);
            // 
            // labelXframeValue
            // 
            this.labelXframeValue.AutoSize = true;
            this.labelXframeValue.Location = new System.Drawing.Point(71, 106);
            this.labelXframeValue.Name = "labelXframeValue";
            this.labelXframeValue.Size = new System.Drawing.Size(31, 13);
            this.labelXframeValue.TabIndex = 3;
            this.labelXframeValue.Text = "........";
            this.labelXframeValue.TextChanged += new System.EventHandler(this.labelResult_TextChanged);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(72, 9);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(237, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "http://stackoverflow.com/";
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTest.Enabled = false;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTest.Location = new System.Drawing.Point(132, 66);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(123, 23);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.EnabledChanged += new System.EventHandler(this.buttonTest_EnabledChanged);
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 29);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickJackingToolStripMenuItem,
            this.appToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clickJackingToolStripMenuItem
            // 
            this.clickJackingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.owaspDefenseToolStripMenuItem,
            this.wikipediaToolStripMenuItem});
            this.clickJackingToolStripMenuItem.Name = "clickJackingToolStripMenuItem";
            this.clickJackingToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.clickJackingToolStripMenuItem.Text = "ClickJacking";
            // 
            // owaspDefenseToolStripMenuItem
            // 
            this.owaspDefenseToolStripMenuItem.Name = "owaspDefenseToolStripMenuItem";
            this.owaspDefenseToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.owaspDefenseToolStripMenuItem.Text = "Owasp Defense";
            this.owaspDefenseToolStripMenuItem.Click += new System.EventHandler(this.owaspDefenseToolStripMenuItem_Click);
            // 
            // wikipediaToolStripMenuItem
            // 
            this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
            this.wikipediaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.wikipediaToolStripMenuItem.Text = "Wikipedia";
            this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.wikipediaToolStripMenuItem_Click);
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentHeadersToolStripMenuItem,
            this.xFrameOptionsToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(39, 25);
            this.appToolStripMenuItem.Text = "app";
            // 
            // currentHeadersToolStripMenuItem
            // 
            this.currentHeadersToolStripMenuItem.Name = "currentHeadersToolStripMenuItem";
            this.currentHeadersToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.currentHeadersToolStripMenuItem.Text = "Current Headers";
            this.currentHeadersToolStripMenuItem.Visible = false;
            this.currentHeadersToolStripMenuItem.Click += new System.EventHandler(this.currentHeadersToolStripMenuItem_Click);
            // 
            // xFrameOptionsToolStripMenuItem
            // 
            this.xFrameOptionsToolStripMenuItem.Name = "xFrameOptionsToolStripMenuItem";
            this.xFrameOptionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.xFrameOptionsToolStripMenuItem.Text = "X-Frame-Options";
            this.xFrameOptionsToolStripMenuItem.Visible = false;
            this.xFrameOptionsToolStripMenuItem.Click += new System.EventHandler(this.xFrameOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programPageToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // programPageToolStripMenuItem
            // 
            this.programPageToolStripMenuItem.Name = "programPageToolStripMenuItem";
            this.programPageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programPageToolStripMenuItem.Text = "Program page";
            this.programPageToolStripMenuItem.Click += new System.EventHandler(this.programPageToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 179);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clickjacking Detector ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clickJackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem owaspDefenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.Label labelXframeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.LinkLabel linkLabelSelectMethod;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentHeadersToolStripMenuItem;
        private System.Windows.Forms.Label labelFinalResult;
        private System.Windows.Forms.ToolStripMenuItem xFrameOptionsToolStripMenuItem;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Label label3;
    }
}

