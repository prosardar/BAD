﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEngine;
using System.Threading;

namespace BAD
{
    public partial class Form1 : Form
    {
        int yellow;
        int red;
        SettingsForm sForm;

        delegate void SetText(object sender, EventAfterMove e);

        public Form1()
        {
            InitializeComponent();
            gArea1.OnMoved += new GArea.HandleMoved(gArea1_OnMoved);
            label1.Text = "Red Team";
            label4.Text = "Yellow Team";
            label3.Location = new Point(label3.Location.X + 5, label3.Location.Y);
            red = yellow = 0;
            gArea1.Visible = true;
            sForm = new SettingsForm();
        }

        void gArea1_OnMoved(object sender, EventAfterMove e)
        {
            if (e.Team == "yellow")
            {

                if (label3.InvokeRequired)
                {
                    label3.Invoke(new SetText(gArea1_OnMoved), null, new EventAfterMove(0, 0, "yellow"));
                }
                else
                {
                    yellow++;
                    label3.Text = yellow.ToString();
                }
            }
            else if (e.Team == "red")
            {
                if (label2.InvokeRequired)
                {
                    label2.Invoke(new SetText(gArea1_OnMoved), null, new EventAfterMove(0, 0, "red"));
                }
                else
                {
                    red++;
                    label2.Text = red.ToString();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //новая игра
            gArea1.Clear();
            red = yellow = 0;
            label2.Text = label3.Text = "";
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sForm.ShowDialog();
            gArea1.RedPlayer = sForm.RedPlayer;
            gArea1.YellowPlayer = sForm.YellowPlayer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            gArea1.FirstRed = (r.Next(100) % 3 == 0);
            gArea1.StartButtle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            новаяИграToolStripMenuItem_Click(sender, e);
        }
    }
}

