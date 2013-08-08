using System;
namespace DrawShape
{
    class DrawShape
    {
        static void Main(string[] args)
        {
            //declare vars
            int response = 0;

            do
            {
                Console.WriteLine("Select drawing shape");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Diamond");
                Console.WriteLine("5. Quit");
                // display user selection
                Console.Write("Enter your selection > ");
                if (Int32.TryParse(Console.ReadLine(), out response) == false)
                {
                    response = 0;
                }
                int size = 0; // use for all 4 cases
                //get size
                if (response > 0 && response < 5)
                {
                    do Console.Write("Enter size: ");
                    while (Int32.TryParse(Console.ReadLine(), out size) == false || size < 2 ||
                        (response > 2 && size % 2 == 0)); //check less than 2 and odd value for 3 and 4 opts
                }
                //perform the ask for the response
                switch (response)
                {
                    case 1: Console.WriteLine("Drawing the square with {0} size", size);
                        for (int row = 0; row < size; row++) Console.WriteLine("{0} ", new string('*', size));
                        // for (int col = 0; col < size; col ++) Console.Write("*");
                        break;
                    case 2: Console.WriteLine("Drawing the Rectangle with {0} size", size);
                        for (int row = 0; row < size / 2; row++) Console.WriteLine("{0} ", new string('*', size));
                        break;
                    case 3: Console.WriteLine("Drawing the Triangle with {0} size", size);
                        for (int space = size / 2, star = 1, row = 0; row < size / 2; row++)
                        {
                            Console.Write("{0}", new string(' ', space));
                            Console.WriteLine("{0}", new string('*', star));
                            space--;
                            star += 2;
                        }
                        Console.WriteLine("{0}", new string('*', size));
                        break;
                    case 4: Console.WriteLine("Drawing the diamond with {0} size", size);
                        for (int space = size / 2, star = 1, row = 0; row < size / 2; row++)
                        {
                            Console.Write("{0}", new string(' ', space));
                            Console.WriteLine("{0}", new string('*', star));
                            space--;
                            star += 2;
                        }
                        Console.WriteLine("{0}", new string('*', size));
                        for (int space = 1, star = size - 2, row = 0; row < size / 2; row++)
                        {
                            Console.Write("{0}", new string(' ', space));
                            Console.WriteLine("{0}", new string('*', star));
                            space++;
                            star -= 2;
                        }
                        break;
                    case 5: break;

                    default:
                        Console.WriteLine("Unknown selection, option " + response);
                        break;
                } // end switch
                Console.WriteLine(); // blank line separator
            } while (response != 5);
        }
    }
}

