using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*********************************************************
 * Created by : Arjun Nandanath Madathil , Tanvi Koduru
 * Created on : 5th Feb 2023
 * *******************************************************/
namespace Assignment2
{
    public class Circle
    {

        private int radius { get; set; }
        //default Constructor
        public Circle() { 
        
                radius = 1;

        }
        //Parameterised Constructor
        public Circle( int radius)
        {
            this.radius = radius;
        }

        //get radius value
        public int getRadius()
        { 
            return radius; 
        }
        // Store radius value
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        //get circumference of the circle
        public double getCircumference( )
        {
            return 2 * 3.14 * this.radius; 
        }

        //get area of the circle
        public double getArea()
        {
            return 3.14 * this.radius * this.radius;
        }
    }
}
