using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagVisual
{
    class Line
    {
        private double length;
        private double lengthSquared;
        private int distanceFromTop;
        private int distanceFromLeft;
        private int distanceFromBottom;

        public Line()
        {
            
        }
        
        public void setLength(double length)
        {
            this.length = length;
            setLengthSquared();
        }

        public void setLengthSquared()
        {
            this.lengthSquared = length * length;
        }

        public void setDistanceFromTop(int distanceFromTop)
        {
            this.distanceFromTop = distanceFromTop;
        }

        public void setDistanceFromLeft(int distanceFromLeft)
        {
            this.distanceFromLeft = distanceFromLeft;
        }

        public void setDistanceFromBottom(int distanceFromBottom)
        {
            this.distanceFromBottom = distanceFromBottom;
        }

        public double getLength()
        {
            return length;
        }

        public double getLengthSquared()
        {
            return lengthSquared;
        }

        public int getDistanceFromTop()
        {
            return distanceFromTop;
        }

        public int getDistanceFromLeft()
        {
            return distanceFromLeft;
        }

        public int getDistanceFromBottom()
        {
            return distanceFromBottom;
        }
    }
}
