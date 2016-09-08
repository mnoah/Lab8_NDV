using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_NDV;

namespace Lab8_test
{
    [TestClass]
    public class avergeTests
    {
        [TestMethod]
        public void TestBattingPercentWnoRuns()
        {
            int[] BattingSheet = new int[5];

            BattingSheet[0] =0;
            BattingSheet[1] =0;
            BattingSheet[2] =0;
            BattingSheet[3] =0;
            BattingSheet[4] =0;
            double BattingAvve = Program.CalcBattingAve(BattingSheet);
            Assert.AreEqual(0, BattingAvve);

        }
        [TestMethod]
        public void TestBattingPercent60 ()
        {
            int[] BattingSheet = new int[5];
                BattingSheet[0] = 0;
                BattingSheet[1] = 0;
                BattingSheet[2] = 2;
                BattingSheet[3] = 4;
                BattingSheet[4] = 1;
            double BattingAve = Program.CalcBattingAve(BattingSheet);
            Assert.AreEqual(0.6, BattingAve);


        }

        [TestMethod]
        public void TestSlugPercent60()
        {
            int[] BattingSheet = new int[5];
            BattingSheet[0] = 0;
            BattingSheet[1] = 0;
            BattingSheet[2] = 2;
            BattingSheet[3] = 4;
            BattingSheet[4] = 1;
            double SlugAve = Program.CalcSlugAve(BattingSheet);
            Assert.AreEqual(0.6, SlugAve);


        }
    }
}
