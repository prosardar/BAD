using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameEngine
{
    public class GLine
    {
        PointF FPoint1;
        PointF FPoint2;
        static Graphics FGraphics;

        public GLine()
        {
            FPoint1 = new PointF();
            FPoint2 = new PointF();
        }

        public GLine(PointF aPoint1, PointF aPoint2)
        {
            FPoint1 = aPoint1;
            FPoint2 = aPoint2;
        }

        static public void InitGraphics(Graphics aGraphics)
        {
            FGraphics = aGraphics;
        }

        public GLine(Point aPoint1, Point aPoint2)
        {
            PointConverter aPointConverter = new PointConverter();
            FPoint1 = (PointF)aPointConverter.ConvertTo(aPoint1, typeof(PointF));
            FPoint2 = (PointF)aPointConverter.ConvertTo(aPoint2, typeof(PointF));
        }


    }
}

