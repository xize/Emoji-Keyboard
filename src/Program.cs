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
        static void Main(string[] args)
        {
            if(!mutex.WaitOne(TimeSpan.Zero, false))
            {
                MessageBox.Show("cannot run a duplicate instance of Emoji-Keyboard!");
                return;
            }
            if(args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Window(false));
            } else if(args.Length == 1)
            {
                if(args[0].ToLower() == "-tray")
                {
                    Console.WriteLine("I'm trayed");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);
                    Window window = new Window(true);
                    Application.Run(window);
                } else
                {
                    MessageBox.Show("Invalid Argument used "+args[0]+" available arguments:\n\n -tray: starts the program in automatic inside the traybar");
                }
            }
        }
    }
}
