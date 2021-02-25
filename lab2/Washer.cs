using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Washer
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double SpeedX { get; private set; }
        public double SpeedY { get; private set; }
        public double AccX { get; private set; }
        public double AccY { get; private set; }
        public double Angle { get; private set; }
        public float Mass { get; private set; }
        public float Radius { get; private set; }
        public double TotalDistance { get; private set; }
        public double PathTimer { get; private set; }
        public bool SavePath
        {
            get { return _savePath; }
            set { _savePath = value; _pathTimer = 0.0; }
        }
        private bool _savePath;
        public List<PointF> Path { get; private set; }
        private double _pathTimer;

        public bool IsStopped { get
            {
                if (Math.Abs(SpeedX) <= 0.005 &&
                    Math.Abs(SpeedY) <= 0.005)
                    return true;
                return false;
            } }
        private List<DotsPair> CollidePairs { get; set; }
        private List<DotsPair> PottCollidePairs { get; set; }

        public Washer()
        {
            X = 0.0;
            Y = 0.0;
            SpeedX = 0.0;
            SpeedY = 0.0;
            AccX = 0.0;
            AccY = 0.0;
            Angle = 0.0;
            Mass = 0.0f;
            Radius = 0.0f;
            PottCollidePairs = new List<DotsPair>();
            CollidePairs = new List<DotsPair>();
            Path = new List<PointF>();
            PathTimer = 300.0;
            _pathTimer = 0.0;
            SavePath = true;
        }
        public Washer(double x, double y, double speed, double angle, float mass, float radius, bool savePath = true, double pathTimer = 300.0)
        {
            X = x;
            Y = y;
            SpeedX = speed * Math.Cos(angle * Math.PI / 180.0);
            SpeedY = speed * Math.Sin(-angle * Math.PI / 180.0);
            AccX = 0.0;
            AccY = 0.0;
            Angle = angle;
            Mass = mass;
            Radius = radius;
            PottCollidePairs = new List<DotsPair>();
            CollidePairs = new List<DotsPair>();
            Path = new List<PointF>();
            SavePath = savePath;
            PathTimer = pathTimer;
            _pathTimer = 0.0;
        }

        public void Draw(Graphics g, PointF objPos, PointF worldCenter, float pixelsPerMeter, bool drawPath = true, bool drawAddInfo = false, PointF? linesObjPos = null)
        {
            Color washerColor = Color.Red;
            Color dirVectorColor = Color.DarkGray;
            float diam = Radius * 2.0f * pixelsPerMeter;
            PointF washerWorldPos = Helper.TranslateToWorldCoords(objPos, new PointF((float)X, (float)Y), worldCenter, pixelsPerMeter);
            g.DrawEllipse(new Pen(new SolidBrush(washerColor)),
                (float)washerWorldPos.X - diam /2.0f, (float)washerWorldPos.Y - diam/2.0f, diam, diam);

            //  Отрисовка коллизии и вектора направления (drawAddInfo)
            if (drawAddInfo && linesObjPos != null)
            {
                double normCoef = 5;
                PointF dirVector = Helper.TranslateToWorldCoords(objPos,
                    new PointF((float)(X + Radius * (float)Math.Cos(Angle * Math.PI / 180.0) * normCoef),
                    (float)(Y + Radius * (float)Math.Sin(-Angle * Math.PI / 180.0) * normCoef)), worldCenter, pixelsPerMeter);
                g.DrawLine(new Pen(new SolidBrush(dirVectorColor)), washerWorldPos, dirVector);
                Color checkLinesColor;
                PointF washerWPScale = Helper.TranslateToWorldCoords(objPos, new PointF((float)X, (float)Y), worldCenter, pixelsPerMeter);
                foreach (var pair in PottCollidePairs)
                {
                    checkLinesColor = Color.FromArgb(100, Color.Orange);
                    foreach (var colPair in CollidePairs)
                    {
                        if (pair.First.X == colPair.First.X && pair.First.Y == colPair.First.Y &&
                            pair.Second.X == colPair.Second.X && pair.Second.Y == colPair.Second.Y)
                        {
                            checkLinesColor = Color.FromArgb(255, Color.Red);
                        }
                    }
                    PointF firstPointScale = Helper.TranslateToWorldCoords(linesObjPos.GetValueOrDefault(), pair.First, worldCenter, pixelsPerMeter);
                    PointF secondPointScale = Helper.TranslateToWorldCoords(linesObjPos.GetValueOrDefault(), pair.Second, worldCenter, pixelsPerMeter);
                    g.DrawLine(new Pen(new SolidBrush(checkLinesColor)), washerWPScale, firstPointScale);
                    g.DrawLine(new Pen(new SolidBrush(checkLinesColor)), washerWPScale, secondPointScale);
                    g.FillPolygon(new SolidBrush(Color.FromArgb(50, Color.Orange)), new PointF[] { washerWPScale, firstPointScale, secondPointScale });
                }
            }

            //  Отрисовка пройденного пути
            if (drawPath)
            {
                float pointsCount = Path.Count;
                float cnt = 1;
                if (Path.Count <= 0) return;
                PointF prevPointWorldPos = Helper.TranslateToWorldCoords(objPos, Path.First(), worldCenter, pixelsPerMeter);
                foreach (var pathPoint in Path)
                {
                    int alpha = (int)(cnt / pointsCount * 100.0f) + 50;
                    float pointDiam = cnt / pointsCount * diam / 4.0f + diam / 4.0f;
                    PointF pointWorldPos = Helper.TranslateToWorldCoords(objPos, pathPoint, worldCenter, pixelsPerMeter);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(alpha, Color.Gray)),
                        (float)pointWorldPos.X - pointDiam / 2.0f, (float)pointWorldPos.Y - pointDiam / 2.0f,
                        pointDiam, pointDiam);
                    cnt++;
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(alpha, Color.Gray))), prevPointWorldPos, pointWorldPos);
                    prevPointWorldPos = pointWorldPos;
                }
                g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(100, Color.Gray))), prevPointWorldPos, washerWorldPos);
            }
        }

        public bool checkCollideSegments(DotsPair[] dPairs, PointF objPos, PointF linesObjPos, PointF worldCenter)
        {
            bool isCollide = false;
            PointF washerWP = Helper.TranslateToWorldCoords(objPos, new PointF((float)X, (float)Y), worldCenter);
            CollidePairs = new List<DotsPair>();
            PottCollidePairs = new List<DotsPair>();
            List<double> reflAngles = new List<double>();
            foreach (var pair in dPairs)
            {
                PointF firstPoint = Helper.TranslateToWorldCoords(linesObjPos, pair.First, worldCenter);
                PointF secondPoint = Helper.TranslateToWorldCoords(linesObjPos, pair.Second, worldCenter);
                PointF lineVec = Helper.Vector.GetVector(firstPoint, secondPoint);
                PointF washerWPVecFirst = Helper.Vector.GetVector(washerWP, firstPoint);
                PointF washerWPVecSecond = Helper.Vector.GetVector(washerWP, secondPoint);

                double acosExprF = Helper.Vector.VectorsMul(washerWPVecFirst, lineVec) /
                    (Helper.Vector.GetLength(washerWPVecFirst) * Helper.Vector.GetLength(lineVec));
                double vecAngleFirst = Math.Acos(acosExprF) * 180.0 /Math.PI;
                double acosExprS = Helper.Vector.VectorsMul(washerWPVecSecond, lineVec) /
                    (Helper.Vector.GetLength(washerWPVecSecond) * Helper.Vector.GetLength(lineVec));
                double vecAngleSecond = Math.Acos(acosExprS) * 180.0 / Math.PI;
                double firstDist = Helper.Vector.GetLength(washerWP, firstPoint);
                double secondDist = Helper.Vector.GetLength(washerWP, secondPoint);
                bool mayCollide = false;

                if (Math.Abs(vecAngleFirst) <= 90.0 && Math.Abs(vecAngleSecond) >= 90.0 ||
                Math.Abs(vecAngleFirst) >= 90.0 && Math.Abs(vecAngleSecond) <= 90.0)
                {
                    mayCollide = true;
                    PottCollidePairs.Add(pair);
                }

                double height = Math.Abs(firstDist * Math.Sin(vecAngleFirst * Math.PI / 180.0));

                if ((height <= Radius && mayCollide) || firstDist <= Radius || secondDist <= Radius ||
                    Math.Abs(acosExprF) > 1.0 || Math.Abs(acosExprS) > 1.0)
                {
                    CollidePairs.Add(pair);
                    isCollide = true;
                    PointF dirVec = new PointF(Radius * (float)Math.Cos(Angle * Math.PI / 180.0),
                        Radius * (float)Math.Sin(-Angle * Math.PI / 180.0));
                    PointF wallVec = Helper.Vector.GetVector(pair.First, pair.Second);
                    reflAngles.Add(Helper.Vector.GetReflectedVecAngle(dirVec, wallVec, Angle));
                    X -= (Radius - height) * Math.Cos(Angle * Math.PI / 180.0);
                    Y -= (Radius - height) * Math.Sin(-Angle * Math.PI / 180.0);
                }
            }
            if (isCollide)
            {
                double reflAngle = reflAngles.Sum() / reflAngles.Count;
                double dAngle = reflAngle - Angle;
                double speedXTmp = SpeedX;
                SpeedX = (speedXTmp * Math.Cos(dAngle * Math.PI / 180.0) - SpeedY * Math.Sin(-dAngle * Math.PI / 180.0)) / 2.0;
                SpeedY = (speedXTmp * Math.Sin(-dAngle * Math.PI / 180.0) + SpeedY * Math.Cos(dAngle * Math.PI / 180.0)) /2.0;
                Angle = reflAngle;
            }

            return isCollide;
        }
        
        public void Move(double dTime, float frictionF)
        {
            AccX = frictionF / Mass * Math.Cos((Angle + 180.0) * Math.PI / 180.0) * dTime;
            AccY = frictionF / Mass * Math.Sin(-(Angle + 180.0) * Math.PI / 180.0) * dTime;
            SpeedX += Helper.LimitAccelerationToSpeed(AccX * dTime, SpeedX);
            SpeedY += Helper.LimitAccelerationToSpeed(AccY * dTime, SpeedY);
            X += SpeedX * dTime;
            Y += SpeedY * dTime;
            TotalDistance += Helper.Vector.GetLength(new PointF((float)(SpeedX * dTime), (float)(SpeedY * dTime)));

            AddPathPoint(dTime * 1000.0);
        }

        private void AddPathPoint(double dTime)
        {
            if (SavePath)
            {
                _pathTimer += dTime;
                if (_pathTimer >= PathTimer * Path.Count / 10.0)
                {
                    _pathTimer = 0.0;
                    Path.Add(new PointF((float)X, (float)Y));
                    if (Path.Count > 200) Path.Remove(Path.First());
                }
            }
        }
        
    }

}
