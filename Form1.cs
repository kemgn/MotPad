using PadLib.Misc;

namespace MotPad
{
    public partial class Form1 : Form
    {
        private Color backColor = Color.FromArgb(21, 21, 21);
        private Color foreColor = Color.FromArgb(239, 239, 239);
        private TabPage newTabPage_;
        
        public Form1(Settings settings)
        {
            InitializeComponent();

            

            this.TopMost = settings.AlwaysOnTop;


            //tabs
            if (settings.TabsEnabled)
                if (false)      //load existing tabs here
                {

                }
                else
                {
                    this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5); 
                    this.flowLayoutPanel1.Width = this.Width - 55;

                    this.multiPagePanel1.Width = this.Width - 55;
                    this.multiPagePanel1.Height = this.Height - 55;
                    this.multiPagePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom)));

                    newTabButton_Click(null, null);

                    //this.tabControl1.DrawItem += TabControl1_DrawItem;

                    //this.tabControl1.BackColor = Color.Red;
                    //this.tabControl1.ForeColor = Color.Red;

                    //this.tabControl1.TabPages.Clear();
                    //this.tabControl1.Width = 50;/* this.Width-50;*/
                    //this.tabControl1.Height = 50;/* this.Height-127;*/
                    //newTabPage_ = new TabPage()
                    //{
                    //    BorderStyle = BorderStyle.None,

                    //    BackColor = Color.Red,
                    //    ForeColor = Color.Red,

                    //BackColor = Color.Green,
                    //};

                    //newTabPage_.Controls.AddRange(createNewRichTextBox());
                    //newTabPage_.Controls.Find("test", true).First().BringToFront();
                    //this.tabControl1.TabPages.Add(newTabPage_);





                    //tabsContainer.Controls.AddRange(createNewRichTextBox());
                }
            else
            {
                //createNewRichTextBox();
            }

            //TAB key to indent
            //this.richTextBox1.AcceptsTab = true;

            //padding
            //this.richTextBox1.Width  = this.pictureBox1.Width  - 8;
            //this.richTextBox1.Height = this.pictureBox1.Height - 8;
            //this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom)));
        }

        //private void TabControl1_DrawItem(object? sender, DrawItemEventArgs e)
        //{
        //    using (Brush br = new SolidBrush(Color.Red))
        //    {
        //        e.Graphics.FillRectangle(br, e.Bounds);
        //        SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
        //        e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

        //        Rectangle rect = e.Bounds;
        //        rect.Offset(0, 1);
        //        rect.Inflate(0, -1);
        //        e.Graphics.DrawRectangle(Pens.DarkGray, rect);
        //        e.DrawFocusRectangle();
        //    }
        //}

      

        //private class RichTextBoxWithPadding : Control
        //{
        //    PictureBox PictureBox { get; }
        //    RichTextBox RichTextBox { get; }

        //}
        private Control[] createNewRichTextBox(int index)
        {
            
            RichTextBox richTextBox = new RichTextBox()
            {
                Name                = $"richTextbox_{index}",
                BackColor           = backColor,
                DetectUrls          = true,
                EnableAutoDragDrop  = true,
                ForeColor           = foreColor,
                Font                = new Font("Consolas", 12, FontStyle.Regular),
                TabIndex            = 4,
                TabStop             = false,
                AcceptsTab          = true,
                Width               = this.Width  - 66,
                Height              = this.Height - 66,
                Anchor              = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom))),
            };
            richTextBox.TextChanged += (s, e) => this.tabButtonsContainer.Controls.Find($"tab_{index}", false).FirstOrDefault().Text = richTextBox.Text;
            //for padding
            PictureBox pictureBox = new PictureBox()
            {
                Name        = $"pictureBox_{index}",
                BackColor   = Color.Red,
                Width = this.Width - 66,
                Height = this.Height - 66,
                Anchor      = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right))),
                //Location    = new System.Drawing.Point(this.flowLayoutPanel1.Location.X + 50, this.flowLayoutPanel1.Location.Y + 50 )
            };
            richTextBox.Text = index.ToString();

            return new Control[] { pictureBox, richTextBox };
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //newTabPage_.Text = this.richTextBox1.Text;
        }

        private void alwaysOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            Console.WriteLine($"aot: {this.TopMost}");
        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        //private void font_Click(object sender, EventArgs e)
        //{
        //    this.tabControl1.Controls.Add(new TabPage() { });
        //}


        int index = 1;

        private void newTabButton_Click(object sender, EventArgs e)
        {
            //get existing tabs
            index += 1;
            //shift new button
            this.newTabButton.Location = new Point(this.newTabButton.Location.X + 34, this.newTabButton.Location.Y);

            //new tab 
            Button button = new Button()
            {
                Name        = $"tab_{index}",
                Size        = new Size(32, 32),
                Location    = new Point(this.newTabButton.Location.X - 34, this.newTabButton.Location.Y)
            };

            button.Text = index.ToString();

            button.Click += (s, e) => this.multiPagePanel1.CurrentPageIndex = index;

            //delete tab
            //button.MouseDown += Button_MouseDown;
            button.MouseDown += (s, e) =>
            {
                switch (e.Button)
                {
                    case MouseButtons.Middle:
                        this.tabButtonsContainer.Controls.RemoveByKey($"tab_{index}");
                        this.multiPagePanel1.Controls.RemoveByKey($"pictureBox_{index}");
                        this.multiPagePanel1.Controls.RemoveByKey($"richTextbox_{index}");
                        int i = index + 1;
                        while (tabButtonsContainer.Controls.Find($"tab_{i}",false).FirstOrDefault() != null)
                        {
                            Control btn = tabButtonsContainer.Controls.Find($"tab_{i}", false).FirstOrDefault();
                            btn.Location = new Point(btn.Location.X - 34, btn.Location.Y);
                            //tabButtonsContainer.Controls.Find($"tab_{i}", false).FirstOrDefault().Location
                            i = i + 1;
                            //button.Location = new Point(button.Location.X - 34, button.Location.Y);
                        }
                        this.newTabButton.Location = new Point(this.newTabButton.Location.X - 34, this.newTabButton.Location.Y);
                        break;
                    case MouseButtons.Left:
                    case MouseButtons.None:
                    case MouseButtons.Right:
                    case MouseButtons.XButton1:
                    case MouseButtons.XButton2:
                    default:
                        break;
                }
            };
            this.tabButtonsContainer.Controls.Add(button);

            //new richtextbox
            this.multiPagePanel1.AddPages(createNewRichTextBox(index), index);



        }

        private void Button_MouseDown(object? sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Middle:
                    //close tab
                    
                case MouseButtons.Left:
                case MouseButtons.None:
                case MouseButtons.Right:
                case MouseButtons.XButton1:
                case MouseButtons.XButton2:
                default:
                    break;
            }
        }
    }
}