using System;

namespace OOP_lab5Class
{
    class Program
    {
        static void Main(string[] args)
        {
            IsoscelesTriangle tr = new IsoscelesTriangle(1, 34);
            Console.WriteLine(tr.GetAngle());
        }
    }
}
