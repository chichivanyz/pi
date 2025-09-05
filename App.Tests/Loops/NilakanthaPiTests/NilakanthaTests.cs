using App.Loops.NilakanthaPi;

namespace App.Tests.Loops.NilakanthaPiTests;

/// <summary>
/// Тесты для обязательной задачи по ряду Нилаканты.
/// </summary>
public class NilakanthaTests
{
    [Test]
    public void Approximate_InvalidTerms_Throws()
    {
        Assert.That(() => Nilakantha.Approximate(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => Nilakantha.Approximate(-2), Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    public void Approximate_FirstTerm_MatchesKnownValue()
    {
        // terms=1: pi ≈ 3 + 4/(2*3*4) = 3 + 1/6 = 3.1666...
        Assert.That(Nilakantha.Approximate(1), Is.EqualTo(3 + 1.0/6).Within(1e-12));
    }

    [Test]
    public void Approximate_ImprovesFasterThanLeibniz()
    {
        var pi10 = Nilakantha.Approximate(10);
        var pi10_leibniz = App.Loops.LeibnizPi.Leibniz.Approximate(10);
        var errN = Math.Abs(Math.PI - pi10);
        var errL = Math.Abs(Math.PI - pi10_leibniz);
        Assert.That(errN, Is.LessThan(errL));
    }

    [Test]
    public void Approximate_AccuracyThresholds()
    {
        // Для Нилаканты возьмем более строгие пороги
        Assert.That(Math.Abs(Math.PI - Nilakantha.Approximate(100)), Is.LessThan(1e-4));
        Assert.That(Math.Abs(Math.PI - Nilakantha.Approximate(1000)), Is.LessThan(1e-6));
    }
}
