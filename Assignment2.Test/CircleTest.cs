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
        //checking if the default constructor initialises the Radius value to 1
        public void DefaultConstructor_RadiusValue_1()
        {
            Circle circle = new Circle();
            expected = 1;
            actual = circle.getRadius();
            Assert.AreEqual(expected, actual);
        }
        /*
        [Test]
        public void GetRadius_InputRadiusInConstructorAs50_RadiusIs50()
        {

            int radius = 50;
            Circle circle = new Circle(radius);
            int resultRadius = circle.GetRadius();
            Assert.AreEqual(radius, resultRadius);
        }

        [Test]
        public void GetRadius_SetRadiusAs5_UpdatedRadiusIs5()
        {
            int radius = 5;
            Circle circle = new Circle();
            circle.SetRadius(radius);
            int resultRadius = circle.GetRadius();
            Assert.AreEqual(radius, resultRadius);
        }


        [Test]
        public void SetRadius_SetRadiusAs20_UpdatedRadiusIs20()
        {
            int radius = 20;
            Circle circle = new Circle();
            circle.SetRadius(radius);
            Assert.AreEqual(radius, circle.GetRadius());
        }

        [Test]
        public void SetRadius_InputRadiusInConstructorAs20ThenSetRadiusAs30_UpdatedRadiusIs30()
        {
            Circle circle = new Circle(20);
            circle.SetRadius(30);
            Assert.AreEqual(30, circle.GetRadius());
        }

        [Test]
        public void SetRadius_SetRadiusAs0_AreaIs0()
        {
            Circle circle = new Circle();
            circle.SetRadius(0);
            Assert.AreEqual(0, circle.GetArea());
        }

        [Test]
        public void GetCircumference_DefaulConstructortInstance_CircumferenceIs2PI()
        {
            Circle circle = new Circle();
            Assert.AreEqual(2 * Math.PI, circle.GetCircumference());
        }

        [Test]
        public void GetCircumference_InputRadiusInConstructorAs10_CircumferenceIs20PI()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(20 * Math.PI, circle.GetCircumference());
        }

        [Test]
        public void GetCircumference_SetRadiusAs30_CircumferenceIs60PI()
        {
            Circle circle = new Circle();
            circle.SetRadius(30);
            Assert.AreEqual(60 * Math.PI, circle.GetCircumference());
        }

        [Test]
        public void GetArea_DefaultConstructorInstance_AreaIsPI()
        {
            Circle circle = new Circle();
            Assert.AreEqual(Math.PI, circle.GetArea());
        }

        [Test]
        public void GetArea_InputRadiusInConstructorAs10_AreaIs100PI()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(100 * Math.PI, circle.GetArea());
        }

        [Test]
        public void GetArea_SetRadiusAs20_AreaIs400PI()
        {
            Circle circle = new Circle();
            circle.SetRadius(20);
            Assert.AreEqual(400 * Math.PI, circle.GetArea());
        }
        */
    }
}