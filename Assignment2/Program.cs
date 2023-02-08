/*********************************************************
 * Created by : Arjun Nandanath Madathil , Tanvi Koduru
 * Created on : 5th Feb 2023
 * *******************************************************/


using Assignment2;
// Variable declarations
        int radius;
        bool flag = false;
        int inpVal;
        Circle c = new Circle(); 
        do
        {

            Console.WriteLine("\nPlease enter the Radius of the circle ");
            try
            {
                radius = Convert.ToInt32(Console.ReadLine());
                if (radius < 1)
                {
                    Console.WriteLine("\nRadius value entered is less than 1 . Invalid Input");
                }
                else
                {
                    flag = true;
                    c = new Circle(radius);
                }

            }
            catch
            {
                Console.WriteLine("\n****Invalid entry , please enter the Radius again****");

            }

        } while (flag != true);
//setting flag 
    flag = false;
//User Menu
    do
        {
            
             try
            {
                Console.WriteLine("*******************************Menu*****************************");
                Console.WriteLine("\n1. Get Circle Radius");
                Console.WriteLine("\n2. Change Circle Radius");
                Console.WriteLine("\n3. Get Circle Circumference");
                Console.WriteLine("\n4. Get Circle Area");
                Console.WriteLine("\n5. Exit");
                Console.WriteLine("\n\n Please select an option from the Menu");
                inpVal = Convert.ToInt32(Console.ReadLine());
                if (inpVal < 1 || inpVal > 5)
                {
                    Console.WriteLine("\n Please select a valid option from the Menu ");
                }
                else if (inpVal == 1)
                {
                    Console.WriteLine("Radius of the circle is " + c.getRadius());
                }
                else if (inpVal == 2)
                {
                    Console.WriteLine("Please enter a radius value you want to store !");
                    c.SetRadius(Convert.ToInt32(Console.ReadLine()));
                }
                else if (inpVal == 3)
                {
                    Console.WriteLine("The Circumference of the circle with radius : " + c.getRadius() + "  is :" + c.getCircumference());
                }
                else if (inpVal == 4)
                {
                    Console.WriteLine("The Area of the circle with radius : " + c.getRadius() + "  is :" + c.getArea());

                }
                else
                {
                    flag = true;
                }
            }
            catch
            {
                Console.WriteLine("\n Please select a valid option from the Menu ");
            }
        } while (flag != true);
