using System;

namespace Assignment1_Seng8040Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }

        public static int ValidateLengthWidth(string side)
        {
            int number = 1;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Please enter {0} of rectangle:", side);
                string length = Console.ReadLine();
                bool result = int.TryParse(length, out number);
                if (result == false)
                {
                    Console.WriteLine("Invalid input. Try again");
                }
                else if (number < 0)
                {
                    Console.WriteLine("{0} cannot be less than 0. Try Again", side);
                }
                else if (number == 0)
                {
                    Console.WriteLine("{0} cannot be 0. Try Again", side);
                }
                else
                {
                    valid = true;
                    Console.WriteLine("{0} is now {1}", side, number);

                }

            }
            return number;
        }

        public static int ValidateOptions()
        {
            string menu = "";
            bool validMenu = false;
            while (validMenu == false)
            {
                Console.WriteLine("1.Get Rectangle length\n2.Change Rectangle length\n3.Get Rectangle Width\n4.Change Rectangle Width\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");
                Console.WriteLine("Select option by entering a number:");
                menu = Console.ReadLine();
                if (menu != "1" && menu != "2" && menu != "3" && menu != "4" && menu != "5" && menu != "6" && menu != "7")
                {
                    Console.WriteLine("Invalid Option.Try Again");
                }
                else
                {
                    validMenu = true;
                }

            }
            return int.Parse(menu);
        }

        public static int PerformOperation(Rectangle r, int menuOption)
        {
            int length1;
            int width1;
            int area;
            int perimeter;
            int flag = 0;
            switch (menuOption)
            {
                case 1:
                    length1 = r.GetLength();
                    Console.WriteLine("Length of Rectangle is {0}", length1);
                    break;

                case 2:
                    Console.WriteLine("Enter length of Rectangle:");
                    length1 = Program.ValidateLengthWidth("length");
                    r.SetLength(length1);
                    break;

                case 3:
                    width1 = r.GetWidth();
                    Console.WriteLine("Width of Rectangle is {0}", width1);
                    break;

                case 4:
                    Console.WriteLine("Enter width of Rectangle:");
                    width1 = Program.ValidateLengthWidth("width");
                    r.SetWidth(width1);
                    break;

                case 5:
                    perimeter = r.GetPerimeter();
                    Console.WriteLine("Perimeter of rectangle is {0}", perimeter);
                    break;

                case 6:
                    area = r.GetArea();
                    Console.WriteLine("Area of rectangle is {0}", area);
                    break;

                case 7:
                    flag = 1;
                    break;

                default:
                    flag = 1;
                    break;



            }
            return flag;
        }
        public void Go()
        {
            bool menuValid1 = false;
            int exit = 0;
            while (menuValid1 == false)
            {
                Console.WriteLine("Enter\n 1.To create a rectangle of 1*1 dimension\n2. To create a custom rectangle:");
                int menu1 = int.Parse(Console.ReadLine());
                if (menu1 == 1)
                {
                    Rectangle r = new Rectangle();
                    Console.WriteLine("Rectangle of length 1 and width 1 created");
                    menuValid1 = true;

                    while (exit == 0)
                    {
                        int menuOperation = Program.ValidateOptions();
                        exit = Program.PerformOperation(r, menuOperation);
                    }
                }
                else if (menu1 == 2)
                {

                    int lengthRectangle = Program.ValidateLengthWidth("length");

                    int widthRectangle = Program.ValidateLengthWidth("width");
                    Rectangle r = new Rectangle(lengthRectangle, widthRectangle);
                    Console.WriteLine("Rectangle of length {0} and width {1} created", lengthRectangle, widthRectangle);
                    menuValid1 = true;
                    while (exit == 0)
                    {
                        Console.WriteLine();
                        int menuOperation = Program.ValidateOptions();
                        exit = Program.PerformOperation(r, menuOperation);
                    }

                }
                else
                {
                    Console.WriteLine("Enter valid menu");
                }

            }

        }
    }
}


