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
    public partial class GameStartedForm : Form
    {
        private Player _p1;
        private Player _p2;
        private Maps _map;
        private List<AnimatedObject> _animatedObjects;

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
            _p2.X = 6;
            _p2.Y = 6;
            InitializeComponent();
            
            Player1_Label.Text = _p1.Name + "\n" + _p1.CharacterChosen.CharacterName;
            Player2_Label.Text = _p2.Name + "\n" + _p2.CharacterChosen.CharacterName;
            Player1_LifePointBar.Value = _p1.Hp * 100 / _p1.CharacterChosen.HpState;
            Player1_ManaPointBar.Value = _p1.Mp * 100 / _p1.CharacterChosen.MpState;
            Player2_LifePointBar.Value = _p2.Hp * 100 / _p2.CharacterChosen.HpState;
            Player2_ManaPointBar.Value = _p2.Mp * 100 / _p2.CharacterChosen.MpState;
            _animatedObjects.Add(_p1);
            _animatedObjects.Add(_p2);
            Print();
        }
        public void Print()
        {
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
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Warrior.jpg");
                                else if (b.CharacterChosen is Magician)
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Magician.jpg");
                                else if (b.CharacterChosen is Ninja)
                                    btnGrid[i, j].BackgroundImage = Image.FromFile("Ninja.png");

                            }
                        }
                    }
                }
            }
            

            
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
            
        }
    }
}
