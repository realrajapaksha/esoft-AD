using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class MyPoint
    {
        public int x;
        public int y;

        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void setX(int x)
        { this.x = x; }

        public int getX()
        { return this.x; }

        public void setY(int y)
        { this.y = y; }

        public int getY()
        { return this.y; }


        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public double distance(int x, int y)
        {
            double one = Math.Pow(Convert.ToDouble(this.x) - Convert.ToDouble(x), 2);
            double two = Math.Pow(Convert.ToDouble(this.y) - Convert.ToDouble(y), 2);

            return Math.Sqrt(one + two);
        }

        public double distance(MyPoint p)
        {
            double one = Math.Pow(Convert.ToDouble(this.x) - Convert.ToDouble(p.x), 2);
            double two = Math.Pow(Convert.ToDouble(this.y) - Convert.ToDouble(p.y), 2);

            return Math.Sqrt(one + two);
        }


    }
}
