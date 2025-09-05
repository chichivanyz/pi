namespace App.Loops.LeibnizPi;

/// <summary>
/// Обязательная задача: вычислить приближение числа PI по ряду Грегори-Лейбница.
/// Формула: PI/4 = sum_{k=0..terms-1} (-1)^k / (2k+1)
/// Возвращать значение PI (а не PI/4).
/// </summary>
public static class Leibniz
{
    /// <summary>
    /// Вычисляет приближение числа PI по первому <paramref name="terms"/> членам ряда.
    /// Ожидаемое поведение (см. тесты):
    /// - terms <= 0: выбросить ArgumentOutOfRangeException
    /// - terms > 0: корректная аппроксимация; с ростом terms ошибка уменьшается
    /// </summary>
    public static double Approximate(int terms)
    {
        // Подсказка: используйте цикл for и знакочередование.
        throw new NotImplementedException();
    }
}
