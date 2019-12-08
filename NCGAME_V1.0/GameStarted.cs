using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NCGAME_V1._0
{
    public partial class GameStartedForm : Form
    {
        Random rnd = new Random();
        private Player _p1;
        private Player _p2;
        private Maps _map;
        private string _direction="Up";
        private List<AnimatedObject> _animatedObjects;
        private int _turn=1;
        private int _movement = 0;
        private int _attackstep = 0;
        private int _round = 1;
        WMPLib.WindowsMediaPlayer CharacterSkillSound = new WMPLib.WindowsMediaPlayer();

        public Button[,] btnGrid;
        public GameStartedForm(Player p1,Player p2, Maps map)
        {
            _animatedObjects = new List<AnimatedObject>();
            _p1 = p1;
            _p2 = p2;
            _map = map;
            _p1.InitialisedState();
            _p2.InitialisedState();
            _p1.X = 1; ;
            _p1.Y = _map.YSize / 2;
            _p2.X = _map.XSize;
            _p2.Y = _map.YSize/2;
            _movement = _p1.CharacterChosen.Mobility;
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();

            Player1_Label.Text = _p1.Name + "\n" + _p1.CharacterChosen.CharacterName;
            Player2_Label.Text = _p2.Name + "\n" + _p2.CharacterChosen.CharacterName;
            Player1_LifePointBar.Value = _p1.Hp * 100 / _p1.CharacterChosen.HpState;
            Player1_ManaPointBar.Value = _p1.Mp * 100 / _p1.CharacterChosen.MpState;
            Player2_LifePointBar.Value = _p2.Hp * 100 / _p2.CharacterChosen.HpState;
            Player2_ManaPointBar.Value = _p2.Mp * 100 / _p2.CharacterChosen.MpState;

            Player1_Skill1_Button.Text = _p1.CharacterChosen.NameSkill1;
            Player1_Skill2_Button.Text = _p1.CharacterChosen.NameSkill2;
            Player1_Skill3_Button.Text = _p1.CharacterChosen.NameSkill3;
            Player2_Skill1_Button.Text = _p2.CharacterChosen.NameSkill1;
            Player2_Skill2_Button.Text = _p2.CharacterChosen.NameSkill2;
            Player2_Skill3_Button.Text = _p2.CharacterChosen.NameSkill3;

            _animatedObjects.Add(_p1);
            _animatedObjects.Add(_p2);

            GenerateRandomObstacle();
            GenerateRandomBomb();
           
            _attackstep = 1;
            Turn();
            Print();
        }
        public void Turn()
        {
            if (_turn == 1)
            {
                Player2_Down_Button.Hide();
                Player2_Up_Button.Hide();
                Player2_Left_Button.Hide();
                Player2_Right_Button.Hide();
                Player2_Skill1_Button.Hide();
                Player2_Skill2_Button.Hide();
                Player2_Skill3_Button.Hide();
                Player2_Move_Button.Hide();

                Player1_Down_Button.Show();
                Player1_Up_Button.Show();
                Player1_Left_Button.Show();
                Player1_Right_Button.Show();
                Player1_Skill1_Button.Show();
                Player1_Skill2_Button.Show();
                Player1_Skill3_Button.Show();
                Player1_Move_Button.Show();
            }
                else
            {
                Player1_Down_Button.Hide();
                Player1_Up_Button.Hide();
                Player1_Left_Button.Hide();
                Player1_Right_Button.Hide();
                Player1_Skill1_Button.Hide();
                Player1_Skill2_Button.Hide();
                Player1_Skill3_Button.Hide();
                Player1_Move_Button.Hide();

                Player2_Down_Button.Show();
                Player2_Up_Button.Show();
                Player2_Left_Button.Show();
                Player2_Right_Button.Show();
                Player2_Skill1_Button.Show();
                Player2_Skill2_Button.Show();
                Player2_Skill3_Button.Show();
                Player2_Move_Button.Show();
            }
        }
        public void GenerateRandomObstacle()
        {
            bool AlreadyExist = false;
            int no = rnd.Next(2, 6);

            while(no>0)
            {
                AlreadyExist = false;
                Obstacle newObs = new Obstacle();
                newObs.X= rnd.Next(1, _map.XSize + 1) ;
                newObs.Y= rnd.Next(1, _map.YSize + 1);
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if(newObs.X==a.X&&newObs.Y==a.Y)
                    {
                        AlreadyExist = true;
                    }
                }
                if(AlreadyExist==false)
                {
                    _animatedObjects.Add(newObs);
                    no -= 1;
                }
            }



        }
        public void GenerateRandomBomb()
        {
            bool AlreadyExist = false;
            int no = rnd.Next(2, 6);
            
            while (no > 0)
            {
                AlreadyExist = false;
                Bomb newBomb = new Bomb();
                newBomb.X = rnd.Next(1, _map.XSize + 1);
                newBomb.Y = rnd.Next(1, _map.YSize + 1);
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (newBomb.X == a.X && newBomb.Y == a.Y)
                    {
                        AlreadyExist = true;
                    }
                }
                if (AlreadyExist == false)
                {
                    _animatedObjects.Add(newBomb);
                    no -= 1;
                }
            }
        }
        public void Print()
        {
            Map_Panel.Controls.Clear();
            btnGrid = new Button[_map.XSize, _map.YSize];
             int buttonSize = Map_Panel.Width / _map.XSize;
            for (int i=0; i< _map.XSize;i++)
            {
                for(int j=0;j<_map.YSize;j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    //Add The button to the panel
                    Map_Panel.Controls.Add(btnGrid[i, j]);

                    //set the location of the new button
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    foreach(AnimatedObject a in _animatedObjects)
                    {
                        if ((a.X-1) == i && (a.Y-1) == j)
                        {
                            if (a is Player)
                            {
                                Player b = a as Player;

                                if (b.CharacterChosen is Warrior)
                                {
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Warrior.jpg");
                                    var pic = new Bitmap(btnGrid[i, j].BackgroundImage, new Size(btnGrid[i, j].Width, btnGrid[i, j].Height));
                                    btnGrid[i, j].BackgroundImage = pic;
                                }
                                else if (b.CharacterChosen is Magician)
                                {
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Magician.jpg");
                                    var pic = new Bitmap(btnGrid[i, j].BackgroundImage, new Size(btnGrid[i, j].Width, btnGrid[i, j].Height));
                                    btnGrid[i, j].BackgroundImage = pic;
                                }
                                else if (b.CharacterChosen is Ninja)
                                {
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Ninja.png");
                                    var pic = new Bitmap(btnGrid[i, j].BackgroundImage, new Size(btnGrid[i, j].Width, btnGrid[i, j].Height));
                                    btnGrid[i, j].BackgroundImage = pic;
                                }
                                btnGrid[i, j].Text = b.PlayerNo.ToString();
                            }
                            if(a is Obstacle)
                            {
                                btnGrid[i, j].BackgroundImage = Image.FromFile("Obstacle.png");
                                var pic = new Bitmap(btnGrid[i, j].BackgroundImage, new Size(btnGrid[i, j].Width, btnGrid[i, j].Height));
                                btnGrid[i, j].BackgroundImage = pic;
                            }
                            if(a is Bomb)
                            {
                                btnGrid[i, j].BackgroundImage = Image.FromFile("Bomb.jpg");
                                var pic = new Bitmap(btnGrid[i, j].BackgroundImage, new Size(btnGrid[i, j].Width, btnGrid[i, j].Height));
                                btnGrid[i, j].BackgroundImage = pic;
                            }
                        }
                    }
                }
                Movement_Label.Text = "Movement : " + _movement.ToString();
                AttackStep_Label.Text = "Attack Step : " + _attackstep.ToString();
            }
            //Latest HP and MP Info
            if (_p1.Hp < 0)
                _p1.Hp = 0;
            if (_p2.Hp < 0)
                _p2.Hp = 0;
            Player1_LifePointBar.Value = _p1.Hp * 100 / _p1.CharacterChosen.HpState;
            Player1_ManaPointBar.Value = _p1.Mp * 100 / _p1.CharacterChosen.MpState;
            Player2_LifePointBar.Value = _p2.Hp * 100 / _p2.CharacterChosen.HpState;
            Player2_ManaPointBar.Value = _p2.Mp * 100 / _p2.CharacterChosen.MpState;
            if (_p1.Hp == 0 && _p2.Hp == 0)
            {
                MessageBox.Show("Draw!");
                Close();
            }
            else if (_p1.Hp == 0)
            {
                MessageBox.Show("Player 2 Win !\nPlayer 1 Loss.");
                Close();
            }
            else if (_p2.Hp == 0)
            {
                MessageBox.Show("Player 1 Win!\nPlayer 2 Loss.");
                Close();
            }
            Round_Label.Text = "Round : "+_round.ToString();
        }
        private void GameStartedForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _direction = "Up";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player1_Left_Button_Click(object sender, EventArgs e)
        {
            _direction = "Left";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player1_Down_Button_Click(object sender, EventArgs e)
        {
            _direction = "Down";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player1_Right_Button_Click(object sender, EventArgs e)
        {
            _direction = "Right";
            Direction_Label.Text = "Direction : " + _direction;
            
        }

        private void Player1_Skill1_Button_Click(object sender, EventArgs e)
        {
            if(_attackstep==0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            _p1.CharacterChosen.Skill1(_animatedObjects, _p1, _direction);
            _attackstep -= 1;
            Print();
        }

        private void Player1_Move_Button_Click(object sender, EventArgs e)
        {
            if (_movement <= 0)
            {
                MessageBox.Show("Your Movement Step Finish!");
                return;
            }
           
            if (_direction == "Up")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == _p1.X && a.Y == (_p1.Y - 1))
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p1.Y -= 1;
            }
            else if (_direction == "Left")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == (_p1.X-1) && a.Y == _p1.Y)
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p1.X -= 1;
            }
            else if (_direction == "Right")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == (_p1.X+1) && a.Y == _p1.Y)
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p1.X += 1;
            }
            else
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == _p1.X && a.Y == (_p1.Y + 1))
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p1.Y += 1;
            }
            _movement -= 1;
            Print();
        }

        private void Player1_Skill2_Button_Click(object sender, EventArgs e)
        {
            if (_attackstep == 0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            _p1.CharacterChosen.Skill2(_animatedObjects, _p1, _direction);
            _attackstep -= 1;
            Print();
        }

        private void Player1_Skill3_Button_Click(object sender, EventArgs e)
        {
            if (_attackstep == 0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            if (_p1.CharacterChosen is Magician)
                CharacterSkillSound.URL = "エクスぷローション.wav";
            else if (_p1.CharacterChosen is Warrior)
                CharacterSkillSound.URL = "Detroit Smash.wav";
            else if (_p1.CharacterChosen is Ninja)
                CharacterSkillSound.URL = "雷遁・麒麟.m4a";
            _p1.CharacterChosen.Skill3(_animatedObjects, _p1, _direction);
            _attackstep -= 1;
            Print();
        }

        private void EndTurn_Button_Click(object sender, EventArgs e)
        {

            if (_turn == 1)
                _turn = 2;
            else
                _turn = 1;
            Turn();
            if (_turn == 1)
                _movement = _p1.CharacterChosen.Mobility + rnd.Next(-1, 2);
            else
                _movement = _p2.CharacterChosen.Mobility + rnd.Next(-1, 2);
            _attackstep = 1;
            _round += 1;
            if ((_p1.Mp + 20) > _p1.CharacterChosen.MpState)
                _p1.Mp = _p1.CharacterChosen.MpState;
            else
                _p1.Mp += 20;
            if ((_p2.Mp + 20) > _p2.CharacterChosen.MpState)
                _p2.Mp = _p2.CharacterChosen.MpState;
            else
                _p2.Mp += 20;
            if (_round == 10)
            {
                GenerateRandomObstacle();
                GenerateRandomBomb();
            }
            Print();
        }

        private void Player2_Move_Button_Click(object sender, EventArgs e)
        {
            if (_movement <= 0)
            {
                MessageBox.Show("Your Movement Step Finish!");
                return;
            }


            if (_direction == "Up")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == _p2.X && a.Y == (_p2.Y - 1))
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p2.Y -= 1;
            }
            else if (_direction == "Left")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == (_p2.X - 1) && a.Y == _p2.Y)
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p2.X -= 1;
            }
            else if (_direction == "Right")
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == (_p2.X + 1) && a.Y == _p2.Y)
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p2.X += 1;
            }
            else
            {
                foreach (AnimatedObject a in _animatedObjects)
                {
                    if (a.X == _p2.X && a.Y == (_p2.Y + 1))
                    {
                        MessageBox.Show("Opps Got Something Over there.");
                        return;
                    }
                }
                _p2.Y += 1;
            }
            _movement -= 1;
            Print();
        }

        private void Player2_Left_Button_Click(object sender, EventArgs e)
        {
            _direction = "Left";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player2_Down_Button_Click(object sender, EventArgs e)
        {
            _direction = "Down";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player2_Right_Button_Click(object sender, EventArgs e)
        {
            _direction = "Right";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player2_Up_Button_Click(object sender, EventArgs e)
        {
            _direction = "Up";
            Direction_Label.Text = "Direction : " + _direction;
        }

        private void Player2_Skill1_Button_Click(object sender, EventArgs e)
        {
            if (_attackstep == 0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            _p2.CharacterChosen.Skill1(_animatedObjects, _p2, _direction);
            _attackstep -= 1;
            Print();
        }

        private void Player2_Skill2_Button_Click(object sender, EventArgs e)
        {
            if (_attackstep == 0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            _p2.CharacterChosen.Skill2(_animatedObjects, _p2, _direction);
            _attackstep -= 1;
            Print();
        }

        private void Player2_Skill3_Button_Click(object sender, EventArgs e)
        {
            if (_attackstep == 0)
            {
                MessageBox.Show("Attack Step Finish!");
                return;
            }
            if (_p2.CharacterChosen is Magician)
                CharacterSkillSound.URL = "エクスぷローション.wav";
            else if (_p2.CharacterChosen is Warrior)
                CharacterSkillSound.URL = "Detroit Smash.wav";
            else if (_p2.CharacterChosen is Ninja)
                CharacterSkillSound.URL = "雷遁・麒麟.m4a";
            _p2.CharacterChosen.Skill3(_animatedObjects, _p2, _direction);
            _attackstep -= 1;
            Print();
        }
    }
}
