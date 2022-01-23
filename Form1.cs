using PadLib.Misc;

namespace MotPad
{
    public partial class Form1 : Form
    {
        private TabPage tabPage_;
        public Form1(Settings settings)
        {
            InitializeComponent();
            this.TopMost = settings.AlwaysOnTop;

            //tabs
            if (settings.TabsEnabled)
            {
                this.tabControl1.TabPages.Clear();
                tabPage_ = new TabPage()
                {

                };

                tabPage_.Controls.Add(this.richTextBox1);

                this.tabControl1.TabPages.Add(tabPage_);

            }
            //TAB key to indent


            this.richTextBox1.AcceptsTab = true;

            //padding
            this.richTextBox1.Width = this.pictureBox1.Width    - 8;
            this.richTextBox1.Height = this.pictureBox1.Height  -8;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom )));
        }

        //tabs//
        


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tabPage_.Text = this.richTextBox1.Text;
        }

        //private bool alwaysOnTop_ = false;
        private void alwaysOnTop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("aot clicked");
            this.TopMost = !this.TopMost;
        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void font_Click(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Add(new TabPage() { });
        }
    }
}