/*********************************************************
 * Created by : Arjun Nandanath Madathil , Tanvi Koduru
 * Created on : 5th Feb 2023
 * *******************************************************/

// Variable declarations

using Assignment2;

Circle c = new Circle();
int radius;
bool flag = false;
do
{


    Console.WriteLine("\nPlease enter the Radius of the circle ");
    try
    {
        radius = Convert.ToInt32(Console.ReadLine());
        flag = false;
    }
    catch
    {
        Console.WriteLine("\n****Invalid entry , please enter the Radius again****");
        flag = true;
    }


} while (flag == true);

int inpVal;
do
{

    Console.WriteLine("*******************************Menu*****************************");
    Console.WriteLine("\n1. Get Circle Radius");
    Console.WriteLine("\n2. Change Circle Radius");
    Console.WriteLine("\n3. Get Circle Circumference");
    Console.WriteLine("\n4. Get Circle Area");
    Console.WriteLine("\n5. Exit");
    inpVal = Convert.ToInt32(Console.ReadLine());
    if( inpVal < 1 || inpVal > 5 )
    {
        Console.WriteLine(" Please select a valid option from the Menu ");
    }
    else if (inpVal == 1)
    {
        Console.WriteLine("Radius of the circle is " + c.getRadius());
    }
    else if(inpVal == 2)
    {
        Console.WriteLine("Please enter a radius value you want to store !");
        c.SetRadius(Convert.ToInt32(Console.ReadLine()));
    }
    else if (inpVal == 3)
    {
        Console.WriteLine("The Circumference of the circle with radius : " + c.getRadius() + "  is :" + c.getCircumference());
    }
    else if(inpVal == 4)
    {
        Console.WriteLine("The Area of the circle with radius : " + c.getRadius() + "  is :" + c.getArea());
        
    }
} while (inpVal != 5);

