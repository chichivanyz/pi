using App.Loops.LeibnizPi;

namespace App.Tests.Loops.LeibnizPiTests;

/// <summary>
/// Тесты для обязательной задачи по ряду Грегори-Лейбница.
/// </summary>
public class LeibnizTests
{
    [Test]
    public void Approximate_InvalidTerms_Throws()
    {
        Assert.That(() => Leibniz.Approximate(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => Leibniz.Approximate(-5), Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    public void Approximate_FirstTerm_Equals4()
    {
        // При 1 члене ряда: PI/4 = 1 => PI ≈ 4
        Assert.That(Leibniz.Approximate(1), Is.EqualTo(4.0).Within(1e-12));
    }

    [Test]
    public void Approximate_ImprovesWithMoreTerms()
    {
        // При небольших n ошибка большая, при большем n — меньше.
        var pi5 = Leibniz.Approximate(5);
        var pi50 = Leibniz.Approximate(50);
        var error5 = Math.Abs(Math.PI - pi5);
        var error50 = Math.Abs(Math.PI - pi50);
        Assert.That(error50, Is.LessThan(error5));
    }

    [Test]
    public void Approximate_AccuracyThresholds()
    {
        // Выберем реалистичные пороги для Лейбница
        Assert.That(Math.Abs(Math.PI - Leibniz.Approximate(1000)), Is.LessThan(0.01));
        Assert.That(Math.Abs(Math.PI - Leibniz.Approximate(10_000)), Is.LessThan(0.001));
    }
}
