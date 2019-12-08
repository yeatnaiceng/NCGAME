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
        Player P1 = new Player(1);
        Player P2 = new Player(2);
        Maps Map1 = new Maps();
        string abc = "Hello";
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer CharacterSkillSound = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
           
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();
           // player.URL = "OP1-＊～アスタリスク～／ORANGE RANGE.m4a";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
           
            PlayerSettingForm CharacterSelectionC1 = new PlayerSettingForm(P1);
            CharacterSelectionC1.Show();
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Player2_Button_Click(object sender, EventArgs e)
        {
            PlayerSettingForm CharacterSelectionC2 = new PlayerSettingForm(P2);
            CharacterSelectionC2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MapSize_Label.Text = "Map Size : " + Map1.XSize + " x " + Map1.YSize;
        }

        private void Map_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Please Select Player 1 Character");
            }
            else
            {
                Player1_Name_Label.Text = "Name : " + P1.Name;
                Player1_Character_Label.Text = "Character : " + P1.CharacterChosen.CharacterName;
                Player1_CharacterS1_Label.Text = "Skill 1 : " + P1.CharacterChosen.NameSkill1;
                Player1_CharacterS2_Label.Text = "Skill 2 : " + P1.CharacterChosen.NameSkill2;
                Player1_CharacterS3_Label.Text = "Skill 3 : " + P1.CharacterChosen.NameSkill3;
            }
            if (P2.CharacterChosen == null)
                MessageBox.Show("Please Select Player 2 Character");
            else
            {
                Player2_Name_Label.Text = "Name : " + P2.Name;
                Player2_Character_Label.Text = "Character : " + P2.CharacterChosen.CharacterName;
                Player2_CharacterS1_Label.Text = "Skill 1 : " + P2.CharacterChosen.NameSkill1;
                Player2_CharacterS2_Label.Text = "Skill 2 : " + P2.CharacterChosen.NameSkill2;
                Player2_CharacterS3_Label.Text = "Skill 3 : " + P2.CharacterChosen.NameSkill3;
            }
        }

        private void Player1_CharacterS1_Label_Click(object sender, EventArgs e)
        {

        }

        private void Player1_CharacterS1Voice_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Player 1 Please Choose Your Character");
                return;
            }
            if (P1.CharacterChosen.CharacterName == "魔法使い")
                CharacterSkillSound.URL= "火遁・炎弾.wav";
            
        }

        private void Player1_CharacterS3Voice_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Player 1 Please Choose Your Character");
                return;
            }
            if (P1.CharacterChosen.CharacterName == "魔法使い")
                CharacterSkillSound.URL = "エクスぷローション.wav";
        }

        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Player 1 Please Choose Your Character");
                return;
            }
            if (P2.CharacterChosen == null)
            {
                MessageBox.Show("Player 2 Please Choose Your Character");
                return;
            }
            GameStartedForm Game1 = new GameStartedForm(P1,P2,Map1);
            Game1.Show();
        }

        private void Player2_CharacterS3Voice_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Player 1 Please Choose Your Character");
                return;
            }
            if (P1.CharacterChosen.CharacterName == "魔法使い")
                CharacterSkillSound.URL = "エクスぷローション.wav";
        }

        private void Player2_CharacterS1Voice_Button_Click(object sender, EventArgs e)
        {
            if (P1.CharacterChosen == null)
            {
                MessageBox.Show("Player 1 Please Choose Your Character");
                return;
            }
            if (P1.CharacterChosen.CharacterName == "魔法使い")
                CharacterSkillSound.URL = "火遁・炎弾.wav";
        }
    }
}
