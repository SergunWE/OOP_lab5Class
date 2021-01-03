using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5Class
{
    public abstract class ITriangle
    {
        public abstract double Perimeter(); //периметр
        public abstract double Area(); //площадь
        public abstract double GetSide(int num); //получение стороны
        public abstract double GetAngle(); //получение угла
    }
}
