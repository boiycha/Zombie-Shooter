using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Shooter
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDowm, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int zombieSpeed = 3;
        int ammo = 10;
        Random random = new Random();

        List<PictureBox> zombieList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDowm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void ShootBullet(string direction)
        {

        }

        private void CreateZombies()
        {

        }
        private void RestartGame()
        {

        }
    }
}
