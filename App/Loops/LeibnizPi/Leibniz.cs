namespace App.Loops.LeibnizPi;

/// <summary>
/// Вычисление числа π с помощью ряда Грегори-Лейбница.
/// </summary>
public static class LeibnizPi
{
    public static double Approximate(int terms)
    {
        if (terms <= 0)
        {
            throw new ArgumentException("Количество членов ряда должно быть положительным", nameof(terms));
        }

        double sum = 0.0;

        for (int k = 0; k < terms; k++)
        {
            double term = 1.0 / (2 * k + 1);

            if (k % 2 == 0)
            {
                sum += term;
            }
            else
            {
                sum -= term;
            }
        }

        return sum * 4;
    }
}