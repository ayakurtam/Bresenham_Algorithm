using System;

namespace Bresenham_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int xStart, yStart, xEnd, yEnd;
            // To read Start point
            Console.WriteLine("Please write the Start point");
            string xStart_string, yStart_string;
            Console.Write("X1:");
            xStart_string = Console.ReadLine();
            xStart = Convert.ToInt32(xStart_string);
            Console.Write("Y1:");
            yStart_string = Console.ReadLine();
            yStart = Convert.ToInt32(yStart_string);

            // To read End point
            Console.WriteLine("Please write the End point");
            string xEnd_string, yEnd_string;
            Console.Write("X2:");
            xEnd_string = Console.ReadLine();
            xEnd = Convert.ToInt32(xEnd_string);
            Console.Write("Y2:");
            yEnd_string = Console.ReadLine();
            yEnd = Convert.ToInt32(yEnd_string);

            Bresenham(xStart, yStart, xEnd, yEnd);
        }

        // function for line generation
        static void Bresenham(int x_Start, int y_Start, int x_End, int y_End)
        {
            int m_new = 2 * (y_End - y_Start);
            int slope_error_new = m_new - (x_End - x_Start);
            for (int x = x_Start, y = y_Start; x <= x_End; x++)
            {
                Console.Write("(" + x + "," + y + ")\n");
                // Add slope to increment angle formed
                slope_error_new += m_new;
                // Slope error reached limit, time to increment y and update slope error.
                if (slope_error_new >= 0)
                {
                    y++;
                    slope_error_new -= 2 * (x_End - x_Start);
                }
            }
        }
    }
}
