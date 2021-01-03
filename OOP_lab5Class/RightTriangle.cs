using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5Class
{

    public class RightTriangle : BaseTriangle
    {
        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override double Area()
        {
            return _fSide * _sSide / 2;
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
                    return Math.Sqrt(Math.Pow(Math.Max(_fSide, _sSide), 2) - Math.Pow(Math.Min(_fSide, _sSide), 2));
                default:
                    throw new Exception("Incorrect side number");
            }
        }
        public override double GetAngle()
        {
            return 90;
        }
        public RightTriangle()
        {
            _fSide = 0;
            _sSide = 0;
        }
        public RightTriangle(double fSide, double sSide)
        {
            if (fSide <= 0 || sSide <= 0)
            {
                throw new Exception("Impermissible side length");
            }
            _fSide = fSide;
            _sSide = sSide;
        }
        private double _fSide; //первый катет
        private double _sSide; //второй катет
    }
}
