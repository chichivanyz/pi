
namespace App.Variables.AreaOfCircle;

/// <summary>
/// Вычислить площадь круга по радиусу.
/// </summary>
public static class AreaOfCircle
{
    public static double Calculate(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным", nameof(radius));
        }

        return Math.PI * radius * radius;
    }
}