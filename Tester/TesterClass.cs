namespace Tester
{
    using System;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using NUnit.Framework;

    [TestFixture]
    public class TesterClass
    {
        public bool HuszonegyWin(int osszeg, int robot, int nehezseg, int x)
        {
            if ((osszeg >= 16 && osszeg < 22 && (robot > 22 || robot < osszeg || (robot == osszeg && nehezseg < 3))) || (x == 0 && osszeg == 22 && (nehezseg < 3 || (nehezseg == 3 && robot != osszeg))))
            {
                return true;
            }

            return false;
        }

        [TestCase(20, 25, 1, 0)]// robot>22
        [TestCase(18, 23, 2, 2)]
        [TestCase(21, 26, 3, 1)]
        [TestCase(21, 20, 1, 2)]// robot<osszeg
        [TestCase(19, 17, 3, 0)]
        [TestCase(17, 16, 2, 1)]
        [TestCase(16, 16, 1, 0)]// robot == osszeg && nehezseg < 3
        [TestCase(21, 21, 2, 5)]
        [TestCase(18, 18, 2, 3)]
        [TestCase(22, 16, 1, 0)]// nehezseg<3
        [TestCase(22, 21, 2, 0)]
        [TestCase(22, 18, 1, 0)]
        [TestCase(22, 18, 3, 0)]// nehezseg == 3 && robot != osszeg
        [TestCase(22, 21, 3, 0)]
        [TestCase(22, 16, 3, 0)]
        public void WinTest(int osszeg, int robot, int nehezseg, int x)
        {
            bool eredmeny = this.HuszonegyWin(osszeg, robot, nehezseg, x);

            Assert.IsTrue(eredmeny);
        }

        [TestCase(15, 21, 1, 0)]
        [TestCase(26, 18, 3, 2)]
        [TestCase(24, 29, 2, 1)]
        [TestCase(12, 15, 2, 0)]
        [TestCase(20, 20, 3, 4)]
        [TestCase(22, 18, 1, 1)]
        [TestCase(22, 22, 3, 0)]
        public void FailTest(int osszeg, int robot, int nehezseg, int x)
        {
            bool eredmeny = this.HuszonegyWin(osszeg, robot, nehezseg, x);

            Assert.IsFalse(eredmeny);
        }
    }
}
