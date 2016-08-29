using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace emoji_keyboard.src
{
    class ControlWindow : Form
    {
        public RichTextBox richTextBox1;
        public Button button1;
        public Button button2;
        public RichTextBox richTextBox2;
        private Label preview;
        private CheckBox winrestart;
        private Window window;

        public ControlWindow(Window window)
        {
            this.window = window;
            InitializeComponent();
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32).OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Run", true);
            if (key.GetValue("Emoji-Keyboard") != null)
            {
                winrestart.Checked = true;
            } else
            {
                winrestart.Checked = false;
            }
            key.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.preview = new System.Windows.Forms.Label();
            this.winrestart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(287, 350);
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
            this.button2.Location = new System.Drawing.Point(206, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.Location = new System.Drawing.Point(12, 195);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(350, 135);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // preview
            // 
            this.preview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preview.AutoSize = true;
            this.preview.Location = new System.Drawing.Point(13, 175);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(48, 13);
            this.preview.TabIndex = 5;
            this.preview.Text = "Preview:";
            // 
            // winrestart
            // 
            this.winrestart.AutoSize = true;
            this.winrestart.Location = new System.Drawing.Point(12, 350);
            this.winrestart.Name = "winrestart";
            this.winrestart.Size = new System.Drawing.Size(134, 17);
            this.winrestart.TabIndex = 6;
            this.winrestart.Text = "start at windows restart";
            this.winrestart.UseVisualStyleBackColor = true;
            this.winrestart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ControlWindow
            // 
            this.ClientSize = new System.Drawing.Size(374, 385);
            this.Controls.Add(this.winrestart);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlWindow";
            this.Text = "Emoji Control Center";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ControlWindow_Closing);
            this.Load += new System.EventHandler(this.ControlWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox2.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32).OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Run", true);
            string datafolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Emoji-Keyboard";

            if (winrestart.Checked)
            {
                //install it's self to %appdata%\Emoji-Keyboard\Emoji-Keyboard.exe if not exist yet
                if(!Directory.Exists(datafolder))
                {
                    Directory.CreateDirectory(datafolder);
                }

                String filename = Process.GetCurrentProcess().ProcessName + ".exe";
                String path = Path.Combine(Environment.CurrentDirectory, filename);

                if (!File.Exists(Path.Combine(datafolder, filename)))
                {
                    File.Copy(path, Path.Combine(datafolder, filename), true);
                }

                key.SetValue("Emoji-Keyboard", "\""+Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+ "\\Emoji-Keyboard\\Emoji-Keyboard.exe\" -tray");
            } else
            {
                key.DeleteValue("Emoji-Keyboard");
            }
            key.Close();
        }
    }
}
