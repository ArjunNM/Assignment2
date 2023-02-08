/*********************************************************
 * Created by : Arjun Nandanath Madathil , Tanvi Koduru
 * Created on : 5th Feb 2023
 * *******************************************************/
namespace Assignment2.Test
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }
        public int expected;
        public int actual;
        [Test]
        //checking if the default constructor initialises the Radius value to 1 and getRadius() returns 1
        public void GetRadius_RadiusValue_1()
        {
            Circle circle = new Circle();
            expected = 1;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //checking if the parameterised constructor assigns the radius value to 25 and getRadius() returns 25
        public void GetRadius_RadiusValue_25()
        {
            Circle circle = new Circle(25);
            expected = 25;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //checking if the setRadius method sets the radius value and GetRadius fetches the Radius
        public void GetRadius_AfterSetRadius_RadiusValue_3()
        {
            Circle circle = new Circle();
            int radius = 3;
            circle.SetRadius(3);
            expected = 3;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //checking if the setRadius sets the value of radiu as 5
        public void SetRadius_UpdateRadius_As5()
        {
            Circle circle = new Circle();
            int radius = 5;
            circle.SetRadius(3);
            expected = 3;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //checking if the setRadius overrides the radius set using Parameterised constructor
        public void UpdateRadius_DefaultConst_SetRadius_UpdateRadius__As15()
        {
            Circle circle = new Circle(10);
            int radius = 15;
            circle.SetRadius(15);
            expected = 15;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //checking if the setRadius can set radius to Zero
        public void UpdateRadius_toZero()
        {
            Circle circle = new Circle();
            int radius = 0;
            circle.SetRadius(0);
            expected = 0;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //checking the getArea method
        public void GetArea_RadiusIs1()
        {
            Circle circle = new Circle();
            double expected = 3.14;
            double actual = circle.getArea();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        //checking the getArea method when radius is 0
        public void GetArea_RadiusIs0()
        {
            Circle circle = new Circle(0);
            double expected = 0;
            double actual = circle.getArea();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //checking the getArea method when radius is decimal
        public void GetArea_RadiusIsDecimal()
        {
            Circle circle = new Circle();
            circle.SetRadius(Convert.ToInt32(1.5));
            double expected = 12.56;
            double actual = circle.getArea();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //checking the getCircumference of circle with radius 1
        public void GetCircumference_DefaultConstructor()
        {
            Circle circle = new Circle();
            double expected = 6.28;
            double actual = circle.getCircumference();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //checking the getCircumference of circle with radius 3 , changed from parameterised constructor
        public void GetCircumference_RadiusIs3()
        {
            Circle circle = new Circle(3);
            double expected = 18.84;
            double actual = circle.getCircumference();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        //checking the getCircumference of circle with radius 3 , changed from parameterised constructor
        public void GetCircumference_RadiusIsdefault()
        {
            Circle circle = new Circle();
            circle.SetRadius(Convert.ToInt32(2.5));
            double expected = 12.56;
            double actual = circle.getCircumference();
            Assert.AreEqual(expected, actual);
        }

    }
}