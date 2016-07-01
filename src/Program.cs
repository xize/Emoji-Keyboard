using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emoji_keyboard.src
{
    static class Program
    {

        private static Mutex mutex = new Mutex(false,"Emoji-Keyboard");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!mutex.WaitOne(TimeSpan.Zero, false))
            {
                MessageBox.Show("cannot run a duplicate instance of Emoji-Keyboard!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
