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
    public partial class PlayerSettingForm : Form
    {

        private string _name;
        private int _character;
        private int _playerNo;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Character
        {
            get { return _character; }
            set { _character = value; }
        }
        public int PlayerNo
        {
            get { return _playerNo; }
            set { _playerNo = value; }
        }
        public PlayerSettingForm(int playerNo)
        {
            InitializeComponent();
            _playerNo = playerNo;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Done_Button_Click(object sender, EventArgs e)
        {
             
        }

        private void CharacterSelectionForm_Load(object sender, EventArgs e)
        {
            PlayerNo_Label.Text = "Player No: "+_playerNo.ToString();
        }
    }
}
