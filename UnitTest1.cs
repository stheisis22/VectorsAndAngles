using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMagnitudXY()
        {
            int x = 1;
            int y = 2;
            bool valid = false;
            double z = Math.Sqrt((x ^ 2 + y ^ 2));

            if (z==2.2360)
            {
                Assert.IsTrue(valid);
            }
        }

        [TestMethod]
        public void TesMethodDotProductAB()
        {
            int[] vectorA = { 2, 2 };
            int[] vectorB = { 1, 1 };
            bool valid = false;

            for (int i = 0; i < 3; i++)
            {
                int z = vectorA[i] * vectorB[i];

                if (z==4)
                {
                    Assert.IsTrue(valid);
                }
            }  
        }

        [TestMethod]
        public void TestMethodAngleBetweenAB()
        {
            int[] vectorA = { 2, 2 };
            int[] vectorB = { 1, 1 };
            double toppart = 0;
            bool valid = false;
            

            for (int d = 0; d < 3; d++) toppart += vectorA[d] * vectorB[d];

            double vectorA2 = 0;
            double vectorB2 = 0;

            for (int d = 0; d <3;  d++)
            {
                vectorA2 += vectorA[d] * vectorA[d];
                vectorB2 += vectorB[d] * vectorB[d];
            }

            double bottompart = 0;
            bottompart = Math.Sqrt(vectorA2 * vectorB2);
            
            bool returndegree = false;
            double rtnval = Math.Acos(toppart / bottompart);
            if (returndegree) rtnval *= 360.0 / (2 * Math.PI);

            Assert.IsTrue(returndegree);
            

            

        }



    }
}
