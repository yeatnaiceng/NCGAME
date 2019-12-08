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
        private Player _playerSetting;
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
        public Player PlayerSetting
        {
            get { return _playerSetting; }
            set { _playerSetting = value; }
        }

        public PlayerSettingForm(Player playerSetting)
        {
            InitializeComponent();
            _playerSetting = playerSetting;
            _playerNo = _playerSetting.PlayerNo;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Done_Button_Click(object sender, EventArgs e)
        {
            if (Name_TextBox.Text == "")
            {
                MessageBox.Show("Please Key in your name.");
                return;
            }
            else
                _playerSetting.Name = Name_TextBox.Text;

            _character = 0;
            if (Warrior_RadioButton.Checked)
                _character = 1;
            else if (Magician_RadioButton.Checked)
                _character = 2;
            else if (Ninja_RadioButton.Checked)
                _character = 3;
           else
            {
                MessageBox.Show("Please Select a character!!");
                return;
            } 
            _playerSetting.ChooseCharacter(_character);
           

            Close();
        }

        private void CharacterSelectionForm_Load(object sender, EventArgs e)
        {
            PlayerNo_Label.Text = "Player No: " + _playerNo.ToString();
        }
    }
}
