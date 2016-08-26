using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Documents;

namespace emoji_keyboard.src
{
    class ControlWindow : Form
    {
        public Button button1;
        public Button button2;
        public System.Windows.Forms.Integration.ElementHost richTextBox1;
        private regex regex1;
        private Window window;

        public ControlWindow(Window window)
        {
            this.window = window;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.Integration.ElementHost();
            this.regex1 = new emoji_keyboard.regex();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(287, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(206, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 141);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "elementHost1";
            this.richTextBox1.Child = this.regex1;
            // 
            // ControlWindow
            // 
            this.ClientSize = new System.Drawing.Size(374, 194);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlWindow";
            this.Text = "Emoji Control Center";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ControlWindow_Closing);
            this.Load += new System.EventHandler(this.ControlWindow_Load);
            this.ResumeLayout(false);

        }

        private void ControlWindow_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            window.Visible = false;
            window.icon.BalloonTipTitle = "Emoji Keyboard has been minimized";
            window.icon.BalloonTipText = "in order to open it again, double click on the icon in the start menu";
            window.icon.ShowBalloonTip(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
