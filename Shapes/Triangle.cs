using System;

namespace Shapes
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="legA">Первая сторона</param>
        /// <param name="legB">Вторая сторона</param>
        /// <param name="legC">Третья сторона</param>
        public Triangle(int legA, int legB, int legC)
        {
            //if ( (legA >= legB + legC) || (legB >= legA + LegC) || (legC >= legA + LegB))
            //{
            //    throw new ArgumentException("Длина стороны не может быть больше или равна сумме двух других!");
            //}
            Name = "Треугольник";
            LegA = legA;
            LegB = legB;
            LegC = legC;
        }

        /// <summary>
        /// Свойство имени фигуры
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Поле свойства первой стороны
        /// </summary>
        private int _legA;

        /// <summary>
        /// Свойство первой стороны
        /// </summary>
        public int LegA
        {
            get { return _legA; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина стороны не может быть отрицательной!");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Длина стороны не может быть равна нулю!");
                }
                _legA = value;
            }
        }

        /// <summary>
        /// Поле свойства второй стороны
        /// </summary>
        private int _legB;

        /// <summary>
        /// Свойство второй стороны
        /// </summary>
        public int LegB
        {
            get { return _legB; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина стороны не может быть отрицательной!");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Длина стороны не может быть равна нулю!");
                }
                _legB = value;
            }
        }

        /// <summary>
        /// Поле свойства третьей стороны
        /// </summary>
        private int _legC;

        /// <summary>
        /// Свойство третьей стороны
        /// </summary>
        public int LegC {
            get { return _legC; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина стороны не может быть отрицательной!");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Длина стороны не может быть равна нулю!");
                }
                _legC = value;
            }
        }

        /// <summary>
        /// Свойство площади
        /// </summary>
        public double Square
        {
            get
            {
                double p = (LegA + LegB + LegC)/2.0; //half of perimiter
                return Math.Sqrt(p*(p - LegA)*(p - LegB)*(p - LegC));
            }
        }
    }
}
