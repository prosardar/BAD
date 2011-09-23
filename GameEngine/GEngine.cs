using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJC.Psharp.Lang;
using JJC.Psharp.Predicates;

namespace GameEngine
{
    public class GEngine
    {
        private PrologInterface FPEngine;
        private int aIndex;
        public string aReturnString;
        private Ori aOri;
        private int aPosition;
        private Direction aDirection;

        public Ori Ori
        {
            get { return aOri; }
            set { aOri = value; }
        }
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

        public void Clear()
        {
            VariableTerm Index = new VariableTerm();
            VariableTerm Position = new VariableTerm();
            VariableTerm Direction = new VariableTerm();
            Term[] argss = { Index, Position, Direction };

            StructureTerm newLine = new StructureTerm(SymbolTerm.MakeSymbol("line", 3), argss);

            FPEngine.SetPredicate(new Retractall_1(newLine, new ReturnCs(FPEngine)));

            if (FPEngine.Call())
            {
                FPEngine.Success();
            }
        }

        public GEngine()
        {

        }

        public void Init()
        {
            FPEngine = new PrologInterface();
            FPEngine.AddAssembly(System.Reflection.Assembly.GetExecutingAssembly());
        }

        public string go(bool FirstRed, GameLevel RedPlayer, GameLevel YellowPlayer)
        {
            List<int> Indexes = GenerateArray(7);
            List<int> Positions = GenerateArray(6);

            #region Create Terms Indexes and Positions
            ListTerm lindexes = new ListTerm(new IntegerTerm(Indexes[0]),
            new ListTerm(new IntegerTerm(Indexes[1]),
                new ListTerm(new IntegerTerm(Indexes[2]),
                    new ListTerm(new IntegerTerm(Indexes[3]),
                        new ListTerm(new IntegerTerm(Indexes[4]),
                            new ListTerm(new IntegerTerm(Indexes[5]),
                                new ListTerm(new IntegerTerm(Indexes[6]), SymbolTerm.MakeSymbol("[]"))))))));

            ListTerm lpositions = new ListTerm(new IntegerTerm(Positions[0]),
            new ListTerm(new IntegerTerm(Positions[1]),
                new ListTerm(new IntegerTerm(Positions[2]),
                    new ListTerm(new IntegerTerm(Positions[3]),
                        new ListTerm(new IntegerTerm(Positions[4]),
                            new ListTerm(new IntegerTerm(Positions[5]), SymbolTerm.MakeSymbol("[]")))))));
            #endregion

            FPEngine.SetPredicate(new Deldb_0(new ReturnCs(FPEngine)));

            if (!FPEngine.Call())
            {
                aReturnString = "false";
                return aReturnString;
            }

            FPEngine.Success();
            StructureTerm a;
            Term[] args = { lpositions };
            a = new StructureTerm(SymbolTerm.MakeSymbol("availablePositions", 1), args);

            FPEngine.SetPredicate(new Assert_1(a, new ReturnCs(FPEngine)));

            if (FPEngine.Call())
            {
                FPEngine.Success();

                Term[] argss = { lindexes };
                a = new StructureTerm(SymbolTerm.MakeSymbol("availableIndexs", 1), argss);

                FPEngine.SetPredicate(new Assert_1(a, new ReturnCs(FPEngine)));

                if (FPEngine.Call())
                {
                    FPEngine.Success();
                    S();

                    VariableTerm Index = new VariableTerm();
                    VariableTerm Position = new VariableTerm();
                    VariableTerm Dir = new VariableTerm();
                    VariableTerm Team = new VariableTerm();
                    VariableTerm Orientation = new VariableTerm();
                    String aDirection;

                    if (FirstRed)
                        switch (RedPlayer)
                        {
                            case GameLevel.Easy:
                                FPEngine.SetPredicate(new Go_5(Index, Position, Dir, Team, Orientation, new ReturnCs(FPEngine)));
                                break;
                            case GameLevel.Normal:
                                FPEngine.SetPredicate(new GoSmart_5(Index, Position, Dir, Team, Orientation, new ReturnCs(FPEngine)));
                                break;
                            case GameLevel.Hard:
                                break;
                        }
                    else
                        switch (YellowPlayer)
                        {
                            case GameLevel.Easy:
                                FPEngine.SetPredicate(new Go_5(Index, Position, Dir, Team, Orientation, new ReturnCs(FPEngine)));
                                break;
                            case GameLevel.Normal:
                                FPEngine.SetPredicate(new GoSmart_5(Index, Position, Dir, Team, Orientation, new ReturnCs(FPEngine)));
                                break;
                            case GameLevel.Hard:
                                break;
                        }

                    if (!FPEngine.Call())
                    {
                        aReturnString = "false";

                        return aReturnString;
                    }

                    this.aIndex = (int)Index.ToCsObject();
                    this.aPosition = (int)Position.ToCsObject();

                    this.aDirection = (Direction)Dir.ToCsObject();
                    string or = (string)Orientation.ToCsObject();
                    if (or == "left")
                        this.Ori = Ori.left;
                    else if (or == "leftright")
                        this.Ori = Ori.leftright;
                    else if (or == "rightleft")
                        this.Ori = Ori.rightleft;
                    else if (or == "right")
                        this.Ori = Ori.right;
                    else if (or == "up")
                        this.Ori = Ori.up;
                    else if (or == "updown")
                        this.Ori = Ori.updown;
                    else if (or == "downup")
                        this.Ori = Ori.downup;
                    else if (or == "down")
                        this.Ori = Ori.down;
                    else if (or == "non")
                        this.Ori = Ori.non;

                    FPEngine.Success();
                    aReturnString = (string)Team.ToCsObject();
                    return aReturnString;
                }
            }
            aReturnString = "false";
            return aReturnString;
        }

        private List<int> GenerateArray(int max)
        {
            List<int> m = new List<int>();
            Random r = new Random();
            while (m.Count < max)
            {
                int c = r.Next(max);
                if (!m.Contains<int>(c))
                    m.Add(c);
            }
            return m;
        }

        // Direction = V
        // Direction = H
        public bool AddMove(int Index, int Position, Direction Direction, out string clo)
        {
            clo = "non";
            //closeLine(Index, Position, v, Ori).
            VariableTerm aClo = new VariableTerm();

            FPEngine.SetPredicate(new Close_Line_4(new IntegerTerm(Index), new IntegerTerm(Position), new IntegerTerm((int)Direction), aClo, new ReturnCs(FPEngine)));

            if (FPEngine.Call())
            {
                clo = (string)aClo.ToCsObject();
                FPEngine.Success();
            }

            Term[] argss = { new IntegerTerm(Index), new IntegerTerm(Position), new IntegerTerm((int)Direction) };

            StructureTerm newLine = new StructureTerm(SymbolTerm.MakeSymbol("line", 3), argss);

            FPEngine.SetPredicate(new Assert_1(newLine, new ReturnCs(FPEngine)));

            if (FPEngine.Call())
            {
                FPEngine.Success();
                return true;
            }
            else
                return false;
        }

        private void S()
        {
            VariableTerm l1 = new VariableTerm();
            VariableTerm l2 = new VariableTerm();
            VariableTerm l3 = new VariableTerm();

            FPEngine.SetPredicate(new Available_Indexs_1(l1, new ReturnCs(FPEngine)));

            if (FPEngine.Call())
            {
                object m = 0;
                FPEngine.Success();
            }
            int l = 0;

        }
    }
}
