using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEngine;
using System.Threading;

namespace GameEngine
{
    public class EventAfterMove : EventArgs
    {
        int aIndex, aPosition;

        public int Position
        {
            get { return aPosition; }
            set { aPosition = value; }
        }

        public int Index
        {
            get { return aIndex; }
            set { aIndex = value; }
        }
        string aTeam;

        public string Team
        {
            get { return aTeam; }
            set { aTeam = value; }
        }

        public EventAfterMove(int Index, int Position, string Team)
        {
            aIndex = Index;
            aPosition = Position;
            aTeam = Team;
        }
    }

    public partial class GArea : UserControl
    {
        private Panel[][] FPSquares;
        private Panel[][] FPVLines;
        private Panel[][] FPHLines;

        private GameLevel aRedPlayer;

        public GameLevel RedPlayer
        {
            get { return aRedPlayer; }
            set { aRedPlayer = value; }
        }
        private GameLevel aYellowPlayer;

        public GameLevel YellowPlayer
        {
            get { return aYellowPlayer; }
            set { aYellowPlayer = value; }
        }

        private bool aFirstRed;

        public bool FirstRed
        {
            get { return aFirstRed; }
            set { aFirstRed = value; }
        }

        public delegate void HandleMoved(object sender, EventAfterMove e);

        public event HandleMoved OnMoved;

        private GEngine FEngine;

        public GArea()
        {
            InitializeComponent();

            BackgroundImage = Resources.fon;
            //pos - indx
            FPVLines = new Panel[7][];
            //ind - pos
            FPHLines = new Panel[7][];

            FPSquares = new Panel[6][];

            for (int i = 0; i < 7; i++)
                FPVLines[i] = new Panel[6];

            for (int i = 0; i < 7; i++)
                FPHLines[i] = new Panel[6];

            for (int i = 0; i < 6; i++)
                FPSquares[i] = new Panel[6];

            this.SuspendLayout();
            //  for (int i = 0; i < 7; i++)
            for (int j = 0; j < 6; j++)
            {
                FPVLines[0][j] = new Panel();

                FPVLines[0][j].Name = "v";
                FPVLines[0][j].Location = new Point(27, 39 + 69 * j);
                FPVLines[0][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[0][j].BackgroundImage = Resources.VLine;
                FPVLines[0][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[0][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[0][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[0][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[0][j].Index = 0;
                FPVLines[0][j].Position = j;
                FPVLines[0][j].Direction = Direction.Vertical;
                FPVLines[0][j].Free = true;
                this.Controls.Add(FPVLines[0][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[1][j] = new Panel();

                FPVLines[1][j].Name = "v";
                FPVLines[1][j].Location = new Point(27 + 69, 39 + 69 * j);
                FPVLines[1][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[1][j].BackgroundImage = Resources.VLine;
                FPVLines[1][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[1][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[1][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[1][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[1][j].Index = 1;
                FPVLines[1][j].Position = j;
                FPVLines[1][j].Direction = Direction.Vertical;
                FPVLines[1][j].Free = true;
                this.Controls.Add(FPVLines[1][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[2][j] = new Panel();

                FPVLines[2][j].Name = "v";
                FPVLines[2][j].Location = new Point(27 + 69 * 2, 39 + 69 * j);
                FPVLines[2][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[2][j].BackgroundImage = Resources.VLine;
                FPVLines[2][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[2][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[2][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[2][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[2][j].Index = 2;
                FPVLines[2][j].Position = j;
                FPVLines[2][j].Direction = Direction.Vertical;
                FPVLines[2][j].Free = true;
                this.Controls.Add(FPVLines[2][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[3][j] = new Panel();

                FPVLines[3][j].Name = "v";
                FPVLines[3][j].Location = new Point(27 + 69 * 3, 39 + 69 * j);
                FPVLines[3][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[3][j].BackgroundImage = Resources.VLine;
                FPVLines[3][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[3][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[3][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[3][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[3][j].Index = 3;
                FPVLines[3][j].Position = j;
                FPVLines[3][j].Direction = Direction.Vertical;
                FPVLines[3][j].Free = true;
                this.Controls.Add(FPVLines[3][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[4][j] = new Panel();

                FPVLines[4][j].Name = "v";
                FPVLines[4][j].Location = new Point(27 + 69 * 4, 39 + 69 * j);
                FPVLines[4][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[4][j].BackgroundImage = Resources.VLine;
                FPVLines[4][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[4][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[4][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[4][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[4][j].Index = 4;
                FPVLines[4][j].Position = j;
                FPVLines[4][j].Direction = Direction.Vertical;
                FPVLines[4][j].Free = true;
                this.Controls.Add(FPVLines[4][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[5][j] = new Panel();

                FPVLines[5][j].Name = "v";
                FPVLines[5][j].Location = new Point(27 + 69 * 5, 39 + 69 * j);
                FPVLines[5][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[5][j].BackgroundImage = Resources.VLine;
                FPVLines[5][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[5][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[5][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[5][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[5][j].Index = 5;
                FPVLines[5][j].Position = j;
                FPVLines[5][j].Direction = Direction.Vertical;
                FPVLines[5][j].Free = true;
                this.Controls.Add(FPVLines[5][j]);
            }
            for (int j = 0; j < 6; j++)
            {
                FPVLines[6][j] = new Panel();

                FPVLines[6][j].Name = "v";
                FPVLines[6][j].Location = new Point(27 + 69 * 6, 39 + 69 * j);
                FPVLines[6][j].Size = new System.Drawing.Size(15, 55);
                FPVLines[6][j].BackgroundImage = Resources.VLine;
                FPVLines[6][j].MouseEnter += new EventHandler(Line_MouseEnter);
                FPVLines[6][j].MouseLeave += new EventHandler(Line_MouseLeave);
                FPVLines[6][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                FPVLines[6][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                FPVLines[6][j].Index = 6;
                FPVLines[6][j].Position = j;
                FPVLines[6][j].Direction = Direction.Vertical;
                FPVLines[6][j].Free = true;
                this.Controls.Add(FPVLines[6][j]);
            }

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                {
                    FPHLines[i][j] = new Panel();

                    FPHLines[i][j].Name = "h";
                    FPHLines[i][j].Location = new Point(41 + 69 * j, 25 + 69 * i);
                    FPHLines[i][j].Size = new System.Drawing.Size(55, 15);
                    FPHLines[i][j].BackgroundImage = Resources.HLine;
                    FPHLines[i][j].MouseEnter += new EventHandler(Line_MouseEnter);
                    FPHLines[i][j].MouseLeave += new EventHandler(Line_MouseLeave);
                    FPHLines[i][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                    FPHLines[i][j].MouseClick += new MouseEventHandler(Line_MouseClick);
                    FPHLines[i][j].Index = i;
                    FPHLines[i][j].Position = j;
                    FPHLines[i][j].Direction = Direction.Horizontal;
                    FPHLines[i][j].Free = true;
                    this.Controls.Add(FPHLines[i][j]);
                }

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    FPSquares[i][j] = new Panel();

                    FPSquares[i][j].Name = "";
                    FPSquares[i][j].Location = new Point(43 + 69 * j, 41 + 69 * i);
                    FPSquares[i][j].Size = new System.Drawing.Size(51, 51);
                    FPSquares[i][j].MouseClick += new MouseEventHandler(GArea_MouseClick);
                    FPSquares[i][j].Index = i;
                    FPSquares[i][j].Position = j;
                    FPSquares[i][j].Free = true;
                    this.Controls.Add(FPSquares[i][j]);
                }

            this.ResumeLayout();

            FEngine = new GEngine();
            FEngine.Init();
        }

        void GArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MessageBox.Show(((Panel)sender).Index + " - " + ((Panel)sender).Position);
        }

        public void Clear()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                {
                    FPVLines[i][j].Name = "v";
                    FPVLines[i][j].BackgroundImage = Resources.VLine;
                    FPVLines[i][j].Free = true;
                }

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                {
                    FPHLines[i][j].BackgroundImage = Resources.HLine;
                    FPHLines[i][j].Name = "h";
                    FPHLines[i][j].Free = true;
                }

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    FPSquares[i][j].Name = "";
                    FPSquares[i][j].BackgroundImage = null;
                    FPSquares[i][j].Free = true;
                }

            FEngine.Clear();
        }

        [ReadOnly(true)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        private void Line_MouseEnter(object sender, EventArgs e)
        {
            if (((Panel)sender).Free && ((Panel)sender).Direction == Direction.Vertical)
            {
                ((Panel)sender).BackgroundImage = Resources.RedVLine;
                System.Diagnostics.Debug.WriteLine("mouseEnter v");
            }
            else if (((Panel)sender).Free && ((Panel)sender).Direction == Direction.Horizontal)
            {
                ((Panel)sender).BackgroundImage = Resources.RedHLine;
                System.Diagnostics.Debug.WriteLine("mouseEnter h");
            }
        }

        private void Line_MouseLeave(object sender, EventArgs e)
        {
            if (((Panel)sender).Free && ((Panel)sender).Direction == Direction.Vertical)
            {
                ((Panel)sender).BackgroundImage = Resources.VLine;
                System.Diagnostics.Debug.WriteLine("mouseLeave v");
            }
            else if (((Panel)sender).Free && ((Panel)sender).Direction == Direction.Horizontal)
            {
                ((Panel)sender).BackgroundImage = Resources.HLine;
                System.Diagnostics.Debug.WriteLine("mouseLeave h");
            }
        }

        private void Line_MouseClick(object sender, EventArgs e)
        {
            bool aCanMove = false;

            if (((Panel)sender).Direction == Direction.Vertical)
            {
                ((Panel)sender).BackgroundImage = Resources.RedVLine;
                aCanMove = true;
            }
            else if (((Panel)sender).Direction == Direction.Horizontal)
            {
                ((Panel)sender).BackgroundImage = Resources.RedHLine;
                aCanMove = true;
            }

            ((Panel)sender).Free = false;
            string Clo = "non";

            if (aCanMove)
                if (FEngine.AddMove(((Panel)sender).Index, ((Panel)sender).Position, ((Panel)sender).Direction, out Clo))
                {
                    if (Clo != "non")
                    {
                        // значит мы закрыли квадрат 
                        if (((Panel)sender).Direction == Direction.Vertical)
                        {
                            if (Clo == "left")
                            {
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index - 1].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index - 1].Name = "red";
                                //MessageBox.Show(((Panel)sender).Position + " - " + (((Panel)sender).Index - 1) + " v red square");
                            }
                            else if ((Clo == "leftright") || (Clo == "rightleft"))
                            {
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index - 1].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index - 1].Name = "red";
                                //MessageBox.Show(((Panel)sender).Position + " - " + (((Panel)sender).Index - 1) + " v red square");

                                FPSquares[((Panel)sender).Position][((Panel)sender).Index].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index].Name = "red";
                                //MessageBox.Show(((Panel)sender).Position + " - " + (((Panel)sender).Index) + " v red square");
                            }
                            else if (Clo == "right")
                            {
                                ((Panel)sender).Name += "C";
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Position][((Panel)sender).Index].Name = "red";
                                //MessageBox.Show(((Panel)sender).Position + " - " + (((Panel)sender).Index) + " v red square");
                            }
                        }
                        else if (((Panel)sender).Name == "h")
                        {
                            if (Clo == "up")
                            {
                                ((Panel)sender).Name += "C";
                                FPSquares[((Panel)sender).Index - 1][((Panel)sender).Position].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Index - 1][((Panel)sender).Position].Name = "red";
                                //MessageBox.Show((((Panel)sender).Index - 1) + " - " + (((Panel)sender).Position) + " h red square");
                            }
                            else if ((Clo == "updown") || (Clo == "downup"))
                            {
                                ((Panel)sender).Name += "C";
                                FPSquares[((Panel)sender).Index - 1][((Panel)sender).Position].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Index - 1][((Panel)sender).Position].Name = "red";
                                //MessageBox.Show((((Panel)sender).Index - 1) + " - " + (((Panel)sender).Position) + " h red square");

                                FPSquares[((Panel)sender).Index][((Panel)sender).Position].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Index][((Panel)sender).Position].Name = "red";
                                //MessageBox.Show(((Panel)sender).Index + " - " + (((Panel)sender).Position) + " h red square");
                            }
                            else if (Clo == "down")
                            {
                                ((Panel)sender).Name += "C";
                                FPSquares[((Panel)sender).Index][((Panel)sender).Position].BackgroundImage = Resources.RedSquare;
                                FPSquares[((Panel)sender).Index][((Panel)sender).Position].Name = "red";
                                //MessageBox.Show(((Panel)sender).Index + " - " + (((Panel)sender).Position) + " h red square");
                            }
                        }

                        //MessageBox.Show(((Panel)sender).Position + " - " + ((Panel)sender).Index);
                        if (OnMoved != null)
                            OnMoved(new object(), new EventAfterMove(0, ((Panel)sender).Position, "red"));
                        return;
                    }

                    while (FEngine.go(false, RedPlayer, YellowPlayer) == "yellow")
                    {
                        if (FEngine.Direction == Direction.Vertical)
                        {
                            FPVLines[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowVLine;
                            FPVLines[FEngine.Index][FEngine.Position].Free = false;

                            //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + FEngine.Direction);

                            if (FEngine.Ori == Ori.left)
                            {
                                FPSquares[FEngine.Position][FEngine.Index - 1].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Position][FEngine.Index - 1].Name = "yellow";
                                //MessageBox.Show(FEngine.Position + " - " + (FEngine.Index - 1) + " v yellow square");
                            }
                            else if ((FEngine.Ori == Ori.leftright) || (FEngine.Ori == Ori.rightleft))
                            {
                                FPSquares[FEngine.Position][FEngine.Index - 1].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Position][FEngine.Index - 1].Name = "yellow";
                                //MessageBox.Show(FEngine.Position + " - " + (FEngine.Index - 1) + " v yellow square");

                                FPSquares[FEngine.Position][FEngine.Index].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Position][FEngine.Index].Name = "yellow";
                                //MessageBox.Show(FEngine.Position + " - " + FEngine.Index + " v yellow square");
                            }
                            else if (FEngine.Ori == Ori.right)
                            {
                                FPSquares[FEngine.Position][FEngine.Index].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Position][FEngine.Index].Name = "yellow";
                                //MessageBox.Show(FEngine.Position + " - " + FEngine.Index + " v yellow square");
                            }

                        }
                        else
                        {
                            FPHLines[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowHLine;
                            FPHLines[FEngine.Index][FEngine.Position].Free = false;

                            //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + FEngine.Direction);

                            if (FEngine.Ori == Ori.up)
                            {
                                FPSquares[FEngine.Index - 1][FEngine.Position].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Index - 1][FEngine.Position].Name = "yellow";
                                //MessageBox.Show(FEngine.Index - 1 + " - " + FEngine.Position + " h yellow square");
                            }
                            else if ((FEngine.Ori == Ori.updown) || (FEngine.Ori == Ori.downup))
                            {
                                FPSquares[FEngine.Index - 1][FEngine.Position].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Index - 1][FEngine.Position].Name = "yellow";
                                //MessageBox.Show(FEngine.Index - 1 + " - " + FEngine.Position + " h yellow square");

                                FPSquares[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Index][FEngine.Position].Name = "yellow";
                                //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " h yellow square");
                            }
                            else if (FEngine.Ori == Ori.down)
                            {
                                FPSquares[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowSquare;
                                FPSquares[FEngine.Index][FEngine.Position].Name = "yellow";
                                //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " h yellow square");
                            }
                        }
                        if (OnMoved != null)
                            OnMoved(new object(), new EventAfterMove(0, ((Panel)sender).Position, "yellow"));

                    }
                    if (FEngine.aReturnString != "false")
                    {
                        if (FEngine.Direction == Direction.Vertical)
                        {
                            FPVLines[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowVLine;
                            FPVLines[FEngine.Index][FEngine.Position].Free = false;
                        }
                        else
                        {
                            FPHLines[FEngine.Index][FEngine.Position].BackgroundImage = Resources.YellowHLine;
                            FPHLines[FEngine.Index][FEngine.Position].Free = false;
                        }
                        // MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " nonLine " + FEngine.Direction);
                    }
                }

        }

        public void StartButtle()
        {
            BackgroundWorker woker = new BackgroundWorker();
            woker.DoWork += new DoWorkEventHandler(woker_DoWork);
            woker.RunWorkerAsync();
        }

        void woker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                while (FEngine.go(FirstRed, RedPlayer, YellowPlayer) == "yellow")
                {
                    if (FEngine.Direction == Direction.Vertical)
                    {

                        FPVLines[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedVLine : Resources.YellowVLine;
                        FPVLines[FEngine.Index][FEngine.Position].Free = false;

                        //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + FEngine.Direction);

                        if (FEngine.Ori == Ori.left)
                        {
                            FPSquares[FEngine.Position][FEngine.Index - 1].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Position][FEngine.Index - 1].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Position + " - " + (FEngine.Index - 1) + " v yellow square");
                        }
                        else if ((FEngine.Ori == Ori.leftright) || (FEngine.Ori == Ori.rightleft))
                        {
                            FPSquares[FEngine.Position][FEngine.Index - 1].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Position][FEngine.Index - 1].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Position + " - " + (FEngine.Index - 1) + " v yellow square");

                            FPSquares[FEngine.Position][FEngine.Index].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Position][FEngine.Index].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Position + " - " + FEngine.Index + " v yellow square");
                        }
                        else if (FEngine.Ori == Ori.right)
                        {
                            FPSquares[FEngine.Position][FEngine.Index].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Position][FEngine.Index].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Position + " - " + FEngine.Index + " v yellow square");
                        }
                    }
                    else
                    {
                        //  Thread.Sleep(1000);
                        FPHLines[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedHLine : Resources.YellowHLine;
                        FPHLines[FEngine.Index][FEngine.Position].Free = false;

                        //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + FEngine.Direction);

                        if (FEngine.Ori == Ori.up)
                        {
                            FPSquares[FEngine.Index - 1][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Index - 1][FEngine.Position].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Index - 1 + " - " + FEngine.Position + " h yellow square");
                        }
                        else if ((FEngine.Ori == Ori.updown) || (FEngine.Ori == Ori.downup))
                        {
                            FPSquares[FEngine.Index - 1][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Index - 1][FEngine.Position].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Index - 1 + " - " + FEngine.Position + " h yellow square");

                            FPSquares[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Index][FEngine.Position].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " h yellow square");
                        }
                        else if (FEngine.Ori == Ori.down)
                        {
                            FPSquares[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedSquare : Resources.YellowSquare;
                            FPSquares[FEngine.Index][FEngine.Position].Name = FirstRed ? "red" : "yellow";
                            //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " h yellow square");
                        }
                    }
                    if (OnMoved != null)
                        OnMoved(new object(), new EventAfterMove(0, 0, FirstRed ? "red" : "yellow"));
                }
                if (FEngine.aReturnString != "false")
                {
                    if (FEngine.Direction == Direction.Vertical)
                    {
                        FPVLines[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedVLine : Resources.YellowVLine;
                        FPVLines[FEngine.Index][FEngine.Position].Free = false;
                    }
                    else
                    {
                        FPHLines[FEngine.Index][FEngine.Position].BackgroundImage = FirstRed ? Resources.RedHLine : Resources.YellowHLine;
                        FPHLines[FEngine.Index][FEngine.Position].Free = false;
                    }

                    //MessageBox.Show(FEngine.Index + " - " + FEngine.Position + " nonLine " + FEngine.Direction);
                    FirstRed = !FirstRed;
                }
                else
                {
                    MessageBox.Show("Конец игры");
                    return;
                }
            }
        }


    }

    public partial class Panel : System.Windows.Forms.Panel
    {
        private int aIndex;
        private int aPosition;
        private Direction aDirection;
        private bool aFree;

        public int Index
        {
            get { return aIndex; }
            set { aIndex = value; }
        }
        public int Position
        {
            get { return aPosition; }
            set { aPosition = value; }
        }
        public Direction Direction
        {
            get { return aDirection; }
            set { aDirection = value; }
        }
        public bool Free
        {
            get { return aFree; }
            set { aFree = value; }
        }
    }
}

