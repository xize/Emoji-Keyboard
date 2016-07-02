using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emoji_keyboard.src
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
            this.controlwindow = new ControlWindow(this);
            this.controlwindow.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😘");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😀");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😁");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😂");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😃");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😄");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😅");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😆");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😉");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😊");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😋");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😎");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😍");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😗");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😙");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😚");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("☺️");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🙂");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤗");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😇");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤓");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤔");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😐");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😑");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😶");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🙄");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😏");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😣");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😥");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😮");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤐");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😯");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😪");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😫");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😴");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😌");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😛");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😜");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😝");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😒");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😓");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😔");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😕");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🙃");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤑");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😲");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😷");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤒");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤕");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("☹");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🙁");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😖");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😞");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😟");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😤");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😢");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😭");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😦");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😧");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😨");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😩");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😬");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😰");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😱");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😳");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😵");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😡");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😠");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("😈");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("👿");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("🤖");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("💩");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("💀");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("☠");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("👻");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("👽");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.AppendText("👾");
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox1);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            controlwindow.richTextBox1.Clear();
            controlwindow.richTextBox1.Controls.Clear();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(controlwindow.richTextBox1.Text);
            controlwindow.richTextBox1.AppendText("👾");
            controlwindow.richTextBox2.Text = controlwindow.richTextBox1.Text;
            SmilleyRegex.getFactory().convertTextToSmilleys(controlwindow.richTextBox2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            controlwindow.Visible = false;
            this.icon.BalloonTipTitle = "Emoji Keyboard has been minimized";
            this.icon.BalloonTipText = "in order to open it again, double click on the icon in the start menu";
            this.icon.ShowBalloonTip(100);
        }

        private void icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            controlwindow.Visible = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
