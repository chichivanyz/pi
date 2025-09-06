namespace App.Variables.SwapVariablesExtra;

/// <summary>
/// Поменяйте значения двух переменных местами без использования третьей переменной.
/// </summary>
public static class Swapper
{
    /// <summary>
    /// Возвращает кортеж со значениями a и b, поменянными местами.
    /// Ожидаемое поведение см. в тестах.
    /// </summary>
    public static (int a, int b) Snap(int a, int b)
    {
        return (b, a);
    }
}