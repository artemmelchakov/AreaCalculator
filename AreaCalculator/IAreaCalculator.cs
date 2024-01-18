namespace AreaCalculator
{
    /// <summary>
    /// Интерфейс, реализующий методы, занимающиеся вычислением площади фигуры.
    /// </summary>
    public interface IAreaCalculator
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        /// <returns> Площадь фигуры. </returns>
        abstract double Calculate();
    }
}
