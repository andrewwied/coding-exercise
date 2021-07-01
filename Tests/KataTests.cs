
using Kata;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private readonly KataClass kata = new KataClass();
       
        [Test]
        public void Zero_ShouldReturn_Emptystring()
        {
            Assert.AreEqual("", kata.CyclicPermutations(0));
        }

         
        [Test]
        public void One_ShouldReturn_One()
        {
            Assert.AreEqual("1\n", kata.CyclicPermutations(1));
        }

         
        [Test]
        public void TestTwo()
        {
            Assert.AreEqual(
                "12\n" + 
                "21\n",
                kata.CyclicPermutations(2));
        }

        [Test]
        public void TestThree()
        {
            Assert.AreEqual(
                "123\n" + 
                "312\n" + 
                "231\n",
                kata.CyclicPermutations(3));
        }

         
        [Test]
        public void TestNine()
        {
            Assert.AreEqual(
                "123456789\n" +
                "912345678\n" +
                "891234567\n" +
                "789123456\n" +
                "678912345\n" +
                "567891234\n" +
                "456789123\n" +
                "345678912\n" +
                "234567891\n",
                kata.CyclicPermutations(9));
        }

         
        //[Test]
        //public void TestTen()
        //{
        //    Assert.AreEqual(
        //        "12345678910\n" +
        //        "10123456789\n" + 
        //        "91012345678\n" +
        //        "89101234567\n" +
        //        "78910123456\n" +
        //        "67891012345\n" +
        //        "56789101234\n" +
        //        "45678910123\n" +
        //        "34567891012\n" +
        //        "23456789101\n",
        //        kata.CyclicPermutations(10));
        //}

        //[Test]
        //public void TestTwelve()
        //{
        //    Assert.AreEqual(
        //        "123456789101112\n" +
        //        "121234567891011\n" +
        //        "111212345678910\n" +
        //        "101112123456789\n" +
        //        "910111212345678\n" +
        //        "891011121234567\n" +
        //        "789101112123456\n" +
        //        "678910111212345\n" +
        //        "567891011121234\n" +
        //        "456789101112123\n" +
        //        "345678910111212\n" +
        //        "234567891011121\n",
        //        kata.CyclicPermutations(12));
        //}
    }
}