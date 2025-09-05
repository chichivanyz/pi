using App.Variables.SwapVariablesExtra;

namespace App.Tests.Variables.SwapVariablesExtraTests;

/// <summary>
/// Дополнительные (*) тесты для задачи про обмен значений без третьей переменной.
/// Подсказка: используйте кортежи — (a, b) = (b, a);
/// </summary>
public class SwapperTests_Star
{
    [Test]
    public void Swap_DifferentNumbers_ReturnsSwapped()
    {
        var (a, b) = Swapper.Swap(2, 7);
        Assert.Multiple(() =>
        {
            Assert.That(a, Is.EqualTo(7));
            Assert.That(b, Is.EqualTo(2));
        });
    }

    [Test]
    public void Swap_EqualNumbers_NoChange()
    {
        var (a, b) = Swapper.Swap(5, 5);
        Assert.Multiple(() =>
        {
            Assert.That(a, Is.EqualTo(5));
            Assert.That(b, Is.EqualTo(5));
        });
    }
}
