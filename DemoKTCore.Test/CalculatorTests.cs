using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCore.Test
{
    [TestFixture]
    internal class CalculatorTests
    {
        private Calculator cal = null;


        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        //Phan vung: n<=0, 0<n<10, 10<=n

        //Kiem tra phan vung n<=0
        [Test]
        public void NhoHon0()
        {
            //kết quả thực thế
            long kqtt = cal.Sum1ToN(-5);
            //kết quả mong muốn
            long kqmm = 0;
            Assert.That(kqtt, Is.EqualTo(kqmm));
        }

        //Kiem tra phan vung 0<n<10
        [Test]
        public void Tu0den10()
        {
            long kqtt = cal.Sum1ToN(3);
            long kqmm = 6;
            Assert.That(kqtt, Is.EqualTo(kqmm));
        }

    }
}
