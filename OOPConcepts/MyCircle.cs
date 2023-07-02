using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class MyCircle
    {
        MyPoint center;
        int radius;

        public MyCircle(int x, int y, int r)
        {
            this.center = new MyPoint(x, y);
            this.radius = r;
        }

        public MyCircle(MyPoint p, int r)
        {
            this.center = p;
            this.radius = r;
        }

        public MyPoint getCenter()
        {
            return this.center;
        }

        public int getRadius()
        {
            return this.radius;
        }

        public void setRadius(int r)
        {
            this.radius = r;
        }
        public void setCenter(MyPoint p)
        {
            this.center = p;
        }

        public double getArea()
        {
            return (22.0 / 7.0) * Convert.ToDouble(this.radius) * Convert.ToDouble(this.radius);
        }
    }
}
