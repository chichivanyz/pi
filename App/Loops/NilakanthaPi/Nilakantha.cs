namespace App.Loops.NilakanthaPi;

/// <summary>
/// Вычисление числа π с помощью ряда Нилаканты.
/// </summary>
public static class NilakanthaPi
{
    public static double Approximate(int terms)
    {
        if (terms <= 0)
        {
            throw new ArgumentException("Количество членов ряда должно быть положительным", nameof(terms));
        }

        double pi = 3.0;

        for (int k = 1; k <= terms; k++)
        {
            double denominator = (2 * k) * (2 * k + 1) * (2 * k + 2);
            double term = 4.0 / denominator;

            if (k % 2 == 1)
            {
                pi += term;
            }
            else
            {
                pi -= term;
            }
        }

        return pi;
    }
}