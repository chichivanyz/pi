namespace App.Loops.NilakanthaPi;

/// <summary>
/// Обязательная задача: вычислить приближение числа PI по ряду Нилаканты.
/// Формула: PI = 3 + sum_{k=1..terms} 4 * (-1)^{k+1} / ((2k)(2k+1)(2k+2))
/// </summary>
public static class Nilakantha
{
    /// <summary>
    /// Вычисляет приближение числа PI, используя первые <paramref name="terms"/> добавочных членов после числа 3.
    /// Ожидаемое поведение (см. тесты):
    /// - terms <= 0: выбросить ArgumentOutOfRangeException
    /// - terms > 0: корректная аппроксимация, сходящаяся быстрее, чем у Лейбница
    /// </summary>
    public static double Approximate(int terms)
    {
        // Подсказка: базовая часть равна 3, далее знакочередующиеся добавки.
        throw new NotImplementedException();
    }
}
