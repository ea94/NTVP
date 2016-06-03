namespace Shapes
{
    /// <summary>
    /// Интерфейс для фигур
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Свойство имя фигуры
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Свойство площадь
        /// </summary>
        double Square { get; }
    }
}
