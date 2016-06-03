using System;

namespace Shapes
{
    /// <summary>
    /// Класс квадрата
    /// </summary>
    public class Quadrate : IShape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="sideA">Первая сторона</param>
        /// <param name="sideB">Вторая сторона</param>
        public Quadrate(int sideA, int sideB)
        {
            Name = "Квадрат";
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Свойство имени фигуры
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Поле свойства первой стороны
        /// </summary>
        private int _sideA;

        /// <summary>
        /// Свойство первой стороны
        /// </summary>
        public int SideA
        {
            get { return _sideA; }
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
                _sideA = value;
            }
        }

        /// <summary>
        /// Поле свойства второй стороны
        /// </summary>
        private int _sideB;

        /// <summary>
        /// Свойство второй стороны
        /// </summary>
        public int SideB {
            get { return _sideB; }
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
                _sideB = value;
            }
        }

        /// <summary>
        /// Свойство площади
        /// </summary>
        public double Square => SideA * SideB;
    }
}