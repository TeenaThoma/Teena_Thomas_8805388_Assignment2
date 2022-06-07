using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teena_Thomas_8805388_Assignment2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle rectObj = new Rectangle();
            int length = 0, width = 0, perimeter = 0, area = 0, option = 0;
            Console.WriteLine("Please Enter the length of the rectangle: ");
          
            while ((!int.TryParse(Console.ReadLine(),out length)) || (length <= 0))
            {     
                    Console.WriteLine("Please Enter a valid integer value!");               
            }
            Console.WriteLine("Please Enter the width of the rectangle: ");
            while ((!int.TryParse(Console.ReadLine(), out width)) || (width <= 0))
            { 
                if (width == 0)
                {
                    Console.WriteLine("Please Enter a valid integer value!");
                }
            }
            rectObj.SetWidth(length);
            rectObj.SetWidth(width);
            do
            {
                option = showMenu();
                if (option == 1)
                {
                    Console.WriteLine("The rectangle Length is: " + rectObj.GetLength());
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter the length of rectangle");
                    while (!int.TryParse(Console.ReadLine(), out length))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");
                    }
                    Console.WriteLine("The new rectangle Length is: " + rectObj.SetLength((int)length));
                }
                else if (option == 3)
                {
                    Console.WriteLine("The rectangle width is: " + rectObj.GetWidth());
                }
                else if (option == 4 )
                {
                    Console.WriteLine("Enter the Width of rectangle");
                    while (!int.TryParse(Console.ReadLine(), out width))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");
                    }
                    Console.WriteLine("The new rectangle Length is: " + rectObj.SetWidth((int)width));
                }
                else if (option == 5)
                {
                    perimeter = rectObj.GetPerimeter();
                    Console.WriteLine("The Perimeter of rectangle is:" + perimeter);
                }
                else if (option == 6)
                {
                    area = rectObj.GetArea();
                    Console.WriteLine("Area of rectangle is:" + area);
                }
            } while (option < 7);
           
            Console.ReadLine();
        }
        public static int showMenu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.Get Rectangle Length");
            Console.WriteLine("2.Change Rectangle Length");
            Console.WriteLine("3.Get Rectangle Width");
            Console.WriteLine("4.Change Rectangle Width");
            Console.WriteLine("5.Get Rectangle Perimeter");
            Console.WriteLine("6.Get Rectangle Area");
            Console.WriteLine("7.Exit");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Enter the option from the menu: ");
            string code = Console.ReadLine();
            int intcode = 0;
            // validates the code entered
            if (code.Length > 0 && int.TryParse(code, out intcode))
            {
                if (intcode < 1 || intcode > 7)
                {

                    Console.WriteLine("Enter a valid option");
                    showMenu();

                }
            }
            else
            {
                Console.WriteLine("Enter a valid option");
                showMenu();
            }
            return intcode;
        }

     }
        
        

       
 }

