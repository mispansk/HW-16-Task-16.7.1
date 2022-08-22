using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_Task_16._7._1.Tests
{
    /// <summary>
    /// класс, который тестирует класс калькулятор
    /// </summary>
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(300, 10) == 3000);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(300, 10) == 30);
        }
        
        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
