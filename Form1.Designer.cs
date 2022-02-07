namespace MotPad
{
    partial class Form1
    {
        record Sizes
        {
            public Size Form;
        }

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.save = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveAs = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.Button();
            this.alwaysOnTop = new System.Windows.Forms.Button();
            this.newTabButton = new System.Windows.Forms.Button();
            this.tabButtonsContainer = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.multiPagePanel1 = new MotPad.Components.MultiPagePanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabButtonsContainer.SuspendLayout();
            this.multiPagePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save.Location = new System.Drawing.Point(41, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(32, 32);
            this.save.TabIndex = 0;
            this.save.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.newButton.BackgroundImage = global::MotPad.Properties.Resources.new_box;
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newButton.ForeColor = System.Drawing.Color.Black;
            this.newButton.Location = new System.Drawing.Point(3, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(32, 32);
            this.newButton.TabIndex = 1;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.Controls.Add(this.newButton);
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Controls.Add(this.saveAs);
            this.flowLayoutPanel1.Controls.Add(this.search);
            this.flowLayoutPanel1.Controls.Add(this.font);
            this.flowLayoutPanel1.Controls.Add(this.alwaysOnTop);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1229, 38);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // saveAs
            // 
            this.saveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.saveAs.BackgroundImage = global::MotPad.Properties.Resources.content_save_edit_outline;
            this.saveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveAs.Location = new System.Drawing.Point(79, 3);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(32, 32);
            this.saveAs.TabIndex = 2;
            this.saveAs.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.search.BackgroundImage = global::MotPad.Properties.Resources.search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search.Location = new System.Drawing.Point(117, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(32, 32);
            this.search.TabIndex = 3;
            this.search.UseVisualStyleBackColor = false;
            // 
            // font
            // 
            this.font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.font.BackgroundImage = global::MotPad.Properties.Resources.format_font;
            this.font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.font.Location = new System.Drawing.Point(155, 3);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(32, 32);
            this.font.TabIndex = 4;
            this.font.UseVisualStyleBackColor = false;
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.alwaysOnTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alwaysOnTop.BackgroundImage")));
            this.alwaysOnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alwaysOnTop.Location = new System.Drawing.Point(193, 3);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(32, 32);
            this.alwaysOnTop.TabIndex = 5;
            this.alwaysOnTop.UseVisualStyleBackColor = false;
            this.alwaysOnTop.Click += new System.EventHandler(this.alwaysOnTop_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.BackColor = System.Drawing.Color.Black;
            this.newTabButton.BackgroundImage = global::MotPad.Properties.Resources.baseline_add_white_24dp;
            this.newTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newTabButton.Location = new System.Drawing.Point(0, 0);
            this.newTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(32, 32);
            this.newTabButton.TabIndex = 8;
            this.newTabButton.UseVisualStyleBackColor = false;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // tabButtonsContainer
            // 
            this.tabButtonsContainer.BackColor = System.Drawing.Color.RosyBrown;
            this.tabButtonsContainer.Controls.Add(this.newTabButton);
            this.tabButtonsContainer.Location = new System.Drawing.Point(12, 72);
            this.tabButtonsContainer.Name = "tabButtonsContainer";
            this.tabButtonsContainer.Size = new System.Drawing.Size(587, 35);
            this.tabButtonsContainer.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(439, 215);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // multiPagePanel1
            // 
            this.multiPagePanel1.BackColor = System.Drawing.Color.DimGray;
            this.multiPagePanel1.Controls.Add(this.richTextBox1);
            this.multiPagePanel1.CurrentPageIndex = 0;
            this.multiPagePanel1.Location = new System.Drawing.Point(12, 123);
            this.multiPagePanel1.Name = "multiPagePanel1";
            this.multiPagePanel1.Size = new System.Drawing.Size(668, 366);
            this.multiPagePanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 936);
            this.Controls.Add(this.multiPagePanel1);
            this.Controls.Add(this.tabButtonsContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabButtonsContainer.ResumeLayout(false);
            this.multiPagePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button save;
        private Button newButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveAs;
        private Button search;
        private Button font;
        private Button alwaysOnTop;
        private Button newTabButton;
        private Components.MultiPagePanel multiPagePanel1;
        public RichTextBox richTextBox1;
        private Panel tabButtonsContainer;
    }
}