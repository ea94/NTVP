using System;

namespace Shapes
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(int radius)
        {
            Name = "Круг";
            Radius = radius;
        }

        /// <summary>
        /// Свойство имени фигуры
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Поле свойства радиуса
        /// </summary>
        private int _radius;

        /// <summary>
        /// Свойство радиус
        /// </summary>
        public int Radius
        {
            get { return _radius; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным!");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Радиус не может быть равен нулю!");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Свойство площадь
        /// </summary>
        public double Square => Math.Round(Math.PI, 2) * Math.Pow(Radius, 2) / 2;
    }
}