namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(10, 10, 10);
            Console.WriteLine(p1.ToString());

            //Point3D p2 = new Point3D();
            //Point3D p3 = new Point3D();

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Enter 3 Coordinates for Point {i + 1}:");
            //    Console.WriteLine($"X{i + 1} = ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Y{i + 1} = ");
            //    int y, z;
            //    if (int.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.WriteLine($"Z{i + 1} = ");
            //        z = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        y = 0;
            //        z = 0;
            //    }

            //    if (i == 0)
            //    {
            //        p2.X = x;
            //        p2.Y = y;
            //        p2.Z = z;
            //    }
            //    else
            //    {
            //        p3.X = x;
            //        p3.Y = y;
            //        p3.Z = z;
            //    }
            //}
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(p3.ToString());


            Point3D[] points = new Point3D[2];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point3D();
                Console.WriteLine($"Enter 3 Coordinates for Point {i + 1}:");
                Console.Write($"X{i + 1} = ");
                points[i].X = int.Parse(Console.ReadLine());
                Console.Write($"Y{i + 1} = ");
                points[i].Y = int.Parse(Console.ReadLine());
                Console.Write($"Z{i + 1} = ");
                points[i].Z = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i].ToString());
            }
        }
    }
}
