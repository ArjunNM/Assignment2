using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle
    {

        private int radius { get; set; }
        public Circle() { 
        
                radius = 1;

        }

        public Circle( int radius)
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

        public double getCircumference( )
        {
            return 2 * 3.14 * this.radius; 
        }

        public double getArea()
        {
            return 3.14 * this.radius * this.radius;
        }

      
    }
}
