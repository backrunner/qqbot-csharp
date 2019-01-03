using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackRunner.QQBot.BotConsole
{
    public partial class ConsoleWindow : Form
    {
        public ConsoleWindow()
        {
            InitializeComponent();
        }

        private void cb_webApiEnable_CheckedChanged(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;

        }
    }
}
