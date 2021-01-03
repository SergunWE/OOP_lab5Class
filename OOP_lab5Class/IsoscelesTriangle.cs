using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5Class
{
    public class IsoscelesTriangle : BaseTriangle
    {
        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override double Area()
        {
            return base.Area();
        }
        public override double GetSide(int num)
        {
            switch (num)
            {
                case 1:
                case 2:
                    return _side;
                case 3:
                    return _side / (2 * Math.Cos(Math.PI * _angle / 180));
                default:
                    throw new Exception("Incorrect side number");
            }
        }
        public override double GetAngle()
        {
            return _angle;
        }
        public IsoscelesTriangle()
        {
            _side = 0;
            _angle = 0;
        }
        public IsoscelesTriangle(double side, double angle)
        {
            if (side <= 0)
            {
                throw new Exception("Impermissible side length");
            }
            if (angle <= 0 || angle >= 180)
            {
                throw new Exception("Impermissible angle");
            }
            _side = side;
            _angle = angle;
        }
        private double _side;
        private double _angle;
    }
}
