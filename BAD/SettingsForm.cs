using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAD
{
    public partial class SettingsForm : Form
    {
        private GameEngine.GameLevel aRedPlayer;

        public GameEngine.GameLevel RedPlayer
        {
            get { return aRedPlayer; }
            set { aRedPlayer = value; }
        }
        private GameEngine.GameLevel aYellowPlayer;

        public GameEngine.GameLevel YellowPlayer
        {
            get { return aYellowPlayer; }
            set { aYellowPlayer = value; }
        }

        public SettingsForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = comboBox2.Enabled = false;
                comboBox3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Enabled = comboBox2.Enabled = comboBox3.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.Enabled = comboBox2.Enabled = true;
                comboBox3.Enabled = false; ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                aYellowPlayer = (GameEngine.GameLevel)comboBox3.SelectedIndex;
            }
            else if (radioButton2.Checked)
            {
                //Пока нету игра двух людей 
            }
            else if (radioButton3.Checked)
            {
                //Комп 1
                aYellowPlayer = (GameEngine.GameLevel)comboBox1.SelectedIndex;
                //Комп 2
                aRedPlayer = (GameEngine.GameLevel)comboBox2.SelectedIndex;
            }

            Close();
        }
    }
}