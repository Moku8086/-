using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 啟動攔截 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public Form1(string fileName) {
            InitializeComponent();
            MessageBox.Show(fileName);
        }

        private void button1_Click(object sender, EventArgs e) {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(".exe");
            Registry.ClassesRoot.OpenSubKey((string)key.GetValue(null) + "\\shell\\open\\command", true).SetValue(null, "\"" + Application.ExecutablePath + "\"" + " \"%1\"");
        }

        private void button2_Click(object sender, EventArgs e) {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(".exe");
            Registry.ClassesRoot.OpenSubKey((string)key.GetValue(null) + "\\shell\\open\\command", true).SetValue(null, "\"%1\" %*");
        }
    }
}
