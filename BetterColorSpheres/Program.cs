using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Console.WriteLine($"Red Color: R={redColor.red}, G={redColor.green}, B={redColor.blue}, A={redColor.alpha}");

            Sphere redSphere = new Sphere(redColor, 5.0f);

            redSphere.Throw();
            Console.WriteLine($"Sphere thrown {redSphere.throws} times.");

            redSphere.Pop();
            Console.WriteLine($"Radius is {redSphere.raio}.");
        }
    }
}
