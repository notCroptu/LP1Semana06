using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Console.WriteLine($"Red Color: R={redColor.Red}, G={redColor.Green}, B={redColor.Blue}, A={redColor.Alpha}");

            Sphere redSphere = new Sphere(redColor, 5.0f);

            redSphere.Throw();
            Console.WriteLine($"Sphere thrown {redSphere.Throws} times.");

            redSphere.Pop();
            Console.WriteLine($"Radius is {redSphere.Raio}.");
        }
    }
}
