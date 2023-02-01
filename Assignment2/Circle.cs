using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle
    {

        Circle() { 
        
                radius = 1;

        }

        Circle( int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        { 
            return radius; 
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double getCircumference( int radius)
        {
            return 2 * 3.14 * radius; 
        }

        public double getArea(int radius)
        {
            return 3.14 * radius * radius;
        }

        public int radius { get; set; }
    }
}
