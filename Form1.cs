using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoRunStartup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFT\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("My application", Application.ExecutablePath.ToString());
            MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
