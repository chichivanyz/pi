using App.Variables.AreaOfCircle;

namespace App.Tests.Variables.AreaOfCircleTests;

/// <summary>
/// Тесты для обязательной задачи "Площадь круга".
/// На старте они должны падать, т.к. реализация выбрасывает NotImplementedException.
/// После решения студентом — проходить.
/// </summary>
public class AreaOfCircleTests
{
    [Test]
    public void Calculate_RadiusZero_ReturnsZero()
    {
        // Ожидаемый результат: 0
        Assert.That(AreaOfCircle.Calculate(0), Is.EqualTo(0));
    }

    [Test]
    public void Calculate_RadiusOne_ReturnsPi()
    {
        // Ожидаемый результат: PI * 1^2 = PI
        Assert.That(AreaOfCircle.Calculate(1), Is.EqualTo(Math.PI).Within(1e-12));
    }

    [Test]
    public void Calculate_RadiusTwoPointFive_ReturnsExpected()
    {
        // Проверяем нецелый радиус
        var r = 2.5;
        var expected = Math.PI * r * r;
        Assert.That(AreaOfCircle.Calculate(r), Is.EqualTo(expected).Within(1e-12));
    }

    [Test]
    public void Calculate_NegativeRadius_Throws()
    {
        // Некорректный ввод — отрицательный радиус
        Assert.That(() => AreaOfCircle.Calculate(-0.1), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}
