using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Tunnel
    {
        public float FirstSectionLength { get; private set; }
        public float SecondSectionLength { get; private set; }
        public float Width { get; private set; }
        public double Angle { get; private set; }
        public DotsPair FirstPair { get; private set; }
        public DotsPair SecondPair { get; private set; }
        public DotsPair ThirdPair { get; private set; }

        public Tunnel(float firSecLength, float secSecLength, float width, double angle)
        {
            FirstSectionLength = firSecLength;
            SecondSectionLength = secSecLength;
            Width = width;
            Angle = angle;
            FirstPair = new DotsPair(new PointF(-Width/2.0f, 0.0f), new PointF(Width/2.0f, 0.0f));
            SecondPair = new DotsPair(new PointF(-Width / 2.0f, -FirstSectionLength), new PointF(Width / 2.0f, -FirstSectionLength));
            float xOffset = (float)(SecondSectionLength * Math.Cos(Angle * Math.PI / 180.0));
            float yOffset = (float)(SecondSectionLength * Math.Sin(Angle * Math.PI / 180.0));
            PointF thrdLeft = new PointF(SecondPair.First.X + xOffset, SecondPair.First.Y - yOffset);
            PointF thrdRight = new PointF(SecondPair.Second.X + xOffset, SecondPair.Second.Y - yOffset);
            ThirdPair = new DotsPair(thrdLeft, thrdRight);
        }

        public void Draw(Graphics g, PointF objPos, PointF worldCenter, float pixelsPerMeter)
        {
            Color tunnelColor = Color.Black;
            PointF tunFirstLeftB = Helper.TranslateToWorldCoords(objPos, FirstPair.First, worldCenter, pixelsPerMeter);
            PointF tunFirstLeftT = Helper.TranslateToWorldCoords(objPos, SecondPair.First, worldCenter, pixelsPerMeter);
            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunFirstLeftB, tunFirstLeftT);
            PointF tunFirstRightB = Helper.TranslateToWorldCoords(objPos, FirstPair.Second, worldCenter, pixelsPerMeter);
            PointF tunFirstRightT = Helper.TranslateToWorldCoords(objPos, SecondPair.Second, worldCenter, pixelsPerMeter);
            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunFirstRightB, tunFirstRightT);
            PointF tunSecondLeftB = Helper.TranslateToWorldCoords(objPos, SecondPair.First, worldCenter, pixelsPerMeter);
            PointF tunSecondLeftT = Helper.TranslateToWorldCoords(objPos, ThirdPair.First, worldCenter, pixelsPerMeter);
            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunSecondLeftB, tunSecondLeftT);
            PointF tunSecondRightB = Helper.TranslateToWorldCoords(objPos, SecondPair.Second, worldCenter, pixelsPerMeter);
            PointF tunSecondRightT = Helper.TranslateToWorldCoords(objPos, ThirdPair.Second, worldCenter, pixelsPerMeter);
            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunSecondRightB, tunSecondRightT);

            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunSecondLeftT, tunSecondRightT);
            g.DrawLine(new Pen(new SolidBrush(tunnelColor)), tunFirstLeftB, tunFirstRightB);
        }

        public DotsPair[] GetSides()
        {
            int sidesCnt = 6;
            DotsPair[] dPairs = new DotsPair[sidesCnt];
            dPairs[0] = new DotsPair(FirstPair.First, SecondPair.First);
            dPairs[1] = new DotsPair(SecondPair.First, ThirdPair.First);
            dPairs[2] = new DotsPair(ThirdPair.First, ThirdPair.Second);
            dPairs[3] = new DotsPair(ThirdPair.Second, SecondPair.Second);
            dPairs[4] = new DotsPair(SecondPair.Second, FirstPair.Second);
            dPairs[5] = new DotsPair(FirstPair.Second, FirstPair.First);
            return dPairs;
        }
    }

    public class DotsPair
    {
        public PointF First { get; private set; }
        public PointF Second { get; private set; }

        public DotsPair()
        {
            First = new PointF(0.0f, 0.0f);
            Second = new PointF(0.0f, 0.0f);
        }

        public DotsPair(PointF first, PointF second)
        {
            First = first;
            Second = second;
        }
    }
}

