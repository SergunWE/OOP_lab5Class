using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5Class
{
    public class Triangle : BaseTriangle
    {
        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override double GetAngle()
        {
            return _angle;
        }
        public override double GetSide(int num)
        {
            switch (num)
            {
                case 1:
                    return _fSide;
                case 2:
                    return _sSide;
                case 3:
                    return Math.Sqrt(_fSide * _fSide + _sSide * _sSide - 2 * _fSide * _sSide * Math.Cos(Math.PI * _angle / 180));
                default:
                    throw new Exception("Incorrect side number");
            }
        }
       public Triangle()
        {
            _fSide = 0;
            _sSide = 0;
            _angle = 0;
        }
        public Triangle(int fSide, int sSide, int angle)
            {
            if (fSide <= 0 || sSide <= 0)
            {
                throw new Exception("Impermissible side length");
            }
            if (angle <= 0 || angle >= 180)
            {
                throw new Exception("Impermissible angle");
            }
            _fSide = fSide;
            _sSide = sSide;
            _angle = angle;
        }

        private double _fSide; //первая сторона
        private double _sSide; //вторая сторона
        private double _angle; //угол
    }
}
