/*********************************************************
 * Created by : Arjun Nandanath Madathil , Tanvi Koduru
 * Created on : 5th Feb 2023
 * *******************************************************/

// Variable declarations

int inpVal;
do
{

    Console.WriteLine("*******************************Menu*****************************");
    Console.WriteLine("\n1. Get Circle Radius");
    Console.WriteLine("\n2. Change Circle Radius");
    Console.WriteLine("\n3. Get Circle Circumference");
    Console.WriteLine("\n4. Get Circle Area");
    Console.WriteLine("\n5. Exit");
    inpVal = Convert.ToInt32(Console.readline());
    if( inpVal < 1 || inpVal > 5 )
    {
        Console.WriteLine("Invalid Input");
    }
} while (inpVal != 5);