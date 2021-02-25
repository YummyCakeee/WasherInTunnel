using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Helper
    {
        public static PointF TranslateToWorldCoords(PointF objWorldPos, PointF localPointPos, PointF worldCenterPos, float scale)
        {
            float x = worldCenterPos.X + (objWorldPos.X + localPointPos.X) * scale;
            float y = worldCenterPos.Y + (objWorldPos.Y + localPointPos.Y) * scale;
            return new PointF(x, y);
        }

        public static PointF TranslateToWorldCoords(PointF objWorldPos, PointF localPointPos, PointF worldCenterPos)
        {
            return new PointF(worldCenterPos.X + objWorldPos.X + localPointPos.X,
                worldCenterPos.Y + objWorldPos.Y + localPointPos.Y);
        }

        public static double LimitRange(double number, double maxNum, double minNum)
        {
            if (number > maxNum) number = maxNum;
            else if (number < minNum) number = minNum;
            return number;
        }
        public static int LimitRange(int number, int maxNum, int minNum)
        {
            if (number > maxNum) number = maxNum;
            else if (number < minNum) number = minNum;
            return number;
        }

        public static double LimitAccelerationToSpeed(double acceleration, double speed)
        {
            if (Math.Abs(acceleration) > Math.Abs(speed))
                acceleration = speed * Math.Sign(acceleration);
            return acceleration;
        }

        public class Vector
        {
            public static PointF Normalize(PointF vector)
            {
                var sqrt = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
                if (sqrt <= 0.0) return PointF.Empty;
                double length = 1.0 / sqrt;
                return new PointF(vector.X * Convert.ToInt32(length), vector.Y * Convert.ToInt32(length));
            }

            public static PointF GetVector(PointF firstPoint, PointF secondPoint)
            {
                return new PointF(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
            }

            public static double GetLength(PointF firstPoint, PointF secondPoint)
            {
                return Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                    (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y));
            }

            public static double GetLength(PointF vector)
            {
                return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            }

            public static double VectorsMul(PointF firstVec, PointF secondVec)
            {
                return firstVec.X * secondVec.X + firstVec.Y * secondVec.Y;
            }

            public static double GetReflectedVecAngle(PointF fallVector, PointF vector, double angle)
            {
                double dirVecAngle = Math.Atan2(fallVector.Y, fallVector.X) * 180.0 / Math.PI;
                double wallVecAngle = Math.Atan2(vector.Y, vector.X) * 180.0 / Math.PI;
                double collideAngle = 90.0 - (wallVecAngle - dirVecAngle);
                if (collideAngle > 180.0) collideAngle -= 360.0;
                else if (collideAngle < -180.0) collideAngle += 360.0;
                double reflAngle = collideAngle * 2.0 + 180.0 + angle;
                if (reflAngle > 180.0) reflAngle -= 360.0;
                else if (reflAngle < -180.0) reflAngle += 360.0;
                return reflAngle;
            }
        }
    }
}
