using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCGAME_V1._0
{
    public partial class Teleport : Form
    {
        private Player _player;
        public Teleport(Player player)
        {
            _player = player;
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            _player.X = int.Parse(X_TextBox.Text);
            _player.Y = int.Parse(Y_TextBox.Text);
            Close();
        }
    }
}
