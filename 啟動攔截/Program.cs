using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 啟動攔截 {
    static class Program {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            if (args.Length != 0) {
                Form1 f = new Form1(args[0]);

                Application.Run(f);
            } else {
                Application.Run(new Form1());
            }
        }
    }
}
