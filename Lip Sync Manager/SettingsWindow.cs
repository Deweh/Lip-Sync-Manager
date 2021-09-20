using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lip_Sync_Manager
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openDialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysOnTop = checkBox1.Checked;
            Properties.Settings.Default.FO4Dir = textBox1.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.FO4Dir;
            checkBox1.Checked = Properties.Settings.Default.AlwaysOnTop;
        }
    }
}
