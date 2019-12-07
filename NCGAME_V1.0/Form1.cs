using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace NCGAME_V1._0
{
    public partial class Form1 : Form
    {
  
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();
            player.URL = "OP1-＊～アスタリスク～／ORANGE RANGE.m4a";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Player2_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
