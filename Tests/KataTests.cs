using System;
using System.Collections.Generic;
using System.Linq;
using Kata;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private readonly KataClass kata = new KataClass();
        private string _resultFizz;

        private string[] words = new[]
        {
            "hello", "hi", "root", "rotor", "level", "Andy",
            "Dave", "weather", "kayak", "review",
            "interview", "kata", "katana", "Testing", "Intense", "Get", "Mess",
            "somebody"
        };

        [Test]
        public void TestCyclicPermutations()
        {
            Assert.AreEqual(kata.CyclicPermutations(0), "");
            Assert.AreEqual(kata.CyclicPermutations(1), "1");
            Assert.AreEqual(kata.CyclicPermutations(2), "12\n21");
            Assert.AreEqual(kata.CyclicPermutations(3), "123\n312\n231");
            Assert.AreEqual(kata.CyclicPermutations(4), "1234\n4123\n3412\n2341");
            Assert.AreEqual(kata.CyclicPermutations(5), "12345\n51234\n45123\n34512\n23451");
            Assert.AreEqual(kata.CyclicPermutations(6), "123456\n612345\n561234\n456123\n345612\n234561");
            Assert.AreEqual(kata.CyclicPermutations(7),
                "1234567\n7123456\n6712345\n5671234\n4567123\n3456712\n2345671");
            Assert.AreEqual(kata.CyclicPermutations(8),
                "12345678\n81234567\n78123456\n67812345\n56781234\n45678123\n34567812\n23456781");
            Assert.AreEqual(kata.CyclicPermutations(9),
                "123456789\n912345678\n891234567\n789123456\n678912345\n567891234\n456789123\n345678912\n234567891");
        }


        // For interviewer: TDD Exercise, ambiguous tests and ambiguous description, see if the interviewee can break it down to small pieces and
        // like 2 or 15 to figure out the output

        // Figure out why these tests are failing and write the method
        [Test]
        public void TestDivisorMethod()
        {
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 24, 28, 30, 32, 35, 36, 40, 42, 45, 48, 56,
                    60, 63, 64, 70, 72, 80, 84, 90, 96, 105, 112, 120, 126, 140, 144, 160, 168, 180, 192, 210, 224, 240,
                    252, 280, 288, 315, 320, 336, 360, 420, 448, 480, 504, 560, 576, 630, 672, 720, 840, 960, 1008,
                    1120, 1260, 1344, 1440, 1680, 2016, 2240, 2520, 2880, 3360, 4032, 5040, 6720, 10080
                }, kata.CalculateDivisors(20160));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 24, 28, 30, 32, 35, 36, 40, 42, 45, 48, 56,
                    60, 63, 64, 70, 72, 80, 84, 90, 96, 105, 112, 120, 126, 128, 140, 144, 160, 168, 180, 192, 210, 224,
                    240, 252, 280, 288, 315, 320, 336, 360, 384, 420, 448, 480, 504, 560, 576, 630, 640, 672, 720, 840,
                    896, 960, 1008, 1120, 1152, 1260, 1344, 1440, 1680, 1920, 2016, 2240, 2520, 2688, 2880, 3360, 4032,
                    4480, 5040, 5760, 6720, 8064, 10080, 13440, 20160
                }, kata.CalculateDivisors(40320));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 9, 10, 12, 15, 16, 18, 20, 24, 30, 32, 36, 40, 45, 48, 60, 64, 72, 80, 90, 96,
                    120, 128, 144, 160, 180, 192, 240, 256, 288, 320, 360, 384, 480, 512, 576, 640, 720, 768, 960, 1024,
                    1152, 1280, 1440, 1536, 1920, 2048, 2304, 2560, 2880, 3072, 3840, 4608, 5120, 5760, 6144, 7680,
                    9216, 10240, 11520, 15360, 18432, 23040, 30720, 46080
                }, kata.CalculateDivisors(92160));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 9, 10, 12, 15, 16, 18, 20, 24, 30, 32, 36, 40, 45, 48, 60, 64, 72, 80, 90, 96,
                    120, 128, 144, 160, 180, 192, 240, 256, 288, 320, 360, 384, 480, 512, 576, 640, 720, 768, 960, 1024,
                    1152, 1280, 1440, 1536, 1920, 2048, 2304, 2560, 2880, 3072, 3840, 4096, 4608, 5120, 5760, 6144,
                    7680, 9216, 10240, 11520, 12288, 15360, 18432, 20480, 23040, 30720, 36864, 46080, 61440, 92160
                }, kata.CalculateDivisors(184320));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 9, 10, 11, 12, 15, 16, 18, 20, 22, 23, 24, 30, 32, 33, 36, 40, 44, 45, 46, 48, 55,
                    60, 66, 69, 72, 80, 88, 90, 92, 96, 99, 110, 115, 120, 132, 138, 144, 160, 165, 176, 180, 184, 198,
                    207, 220, 230, 240, 253, 264, 276, 288, 330, 345, 352, 360, 368, 396, 414, 440, 460, 480, 495, 506,
                    528, 552, 660, 690, 720, 736, 759, 792, 828, 880, 920, 990, 1012, 1035, 1056, 1104, 1265, 1320,
                    1380, 1440, 1518, 1584, 1656, 1760, 1840, 1980, 2024, 2070, 2208, 2277, 2530, 2640, 2760, 3036,
                    3168, 3312, 3680, 3795, 3960, 4048, 4140, 4554, 5060, 5280, 5520, 6072, 6624, 7590, 7920, 8096,
                    8280, 9108, 10120, 11040, 11385, 12144, 15180, 15840, 16560, 18216, 20240, 22770, 24288, 30360,
                    33120, 36432, 40480, 45540, 60720, 72864, 91080, 121440, 182160
                }, kata.CalculateDivisors(364320));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 9, 10, 12, 15, 16, 18, 20, 24, 30, 32, 36, 40, 45, 48, 60, 64, 72, 80, 90, 96,
                    120, 128, 144, 160, 180, 192, 240, 256, 288, 320, 360, 384, 480, 512, 576, 640, 720, 768, 960, 1024,
                    1152, 1280, 1440, 1536, 1920, 2048, 2304, 2560, 2880, 3072, 3840, 4096, 4608, 5120, 5760, 6144,
                    7680, 8192, 9216, 10240, 11520, 12288, 15360, 16384, 18432, 20480, 23040, 24576, 30720, 36864,
                    40960, 46080, 49152, 61440, 73728, 81920, 92160, 122880, 147456, 184320, 245760, 368640
                }, kata.CalculateDivisors(737280));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 10, 12, 15, 16, 20, 24, 30, 32, 40, 48, 60, 64, 80, 96, 120, 128, 160, 192, 240,
                    256, 320, 384, 480, 512, 640, 768, 960, 1024, 1280, 1536, 1920, 2048, 2560, 3072, 3840, 4096, 5120,
                    6144, 7680, 8192, 10240, 12288, 15360, 16384, 20480, 24576, 30720, 32768, 40960, 49152, 61440,
                    65536, 81920, 98304, 122880, 163840, 196608, 245760, 327680, 491520
                }, kata.CalculateDivisors(983040));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 10, 12, 15, 16, 20, 24, 30, 32, 40, 48, 60, 64, 80, 96, 120, 128, 160, 192, 240,
                    256, 320, 384, 480, 512, 640, 768, 960, 1024, 1280, 1536, 1920, 2048, 2560, 3072, 3840, 4096, 5120,
                    6144, 7680, 8192, 10240, 12288, 15360, 16384, 20480, 24576, 30720, 32768, 40960, 49152, 61440,
                    65536, 81920, 98304, 122880, 131072, 163840, 196608, 245760, 327680, 393216, 491520, 655360, 983040
                }, kata.CalculateDivisors(1966080));
            Assert.AreEqual(
                new int[]
                {
                    2, 3, 4, 5, 6, 8, 9, 10, 12, 15, 16, 18, 20, 24, 27, 30, 32, 36, 40, 45, 48, 54, 60, 64, 72, 80, 90,
                    96, 108, 120, 128, 135, 144, 160, 180, 192, 216, 240, 256, 270, 288, 320, 360, 384, 432, 480, 512,
                    540, 576, 640, 720, 768, 864, 960, 1024, 1080, 1152, 1280, 1440, 1536, 1728, 1920, 2048, 2160, 2304,
                    2560, 2880, 3072, 3456, 3840, 4096, 4320, 4608, 5120, 5760, 6144, 6912, 7680, 8192, 8640, 9216,
                    10240, 11520, 12288, 13824, 15360, 16384, 17280, 18432, 20480, 23040, 24576, 27648, 30720, 32768,
                    34560, 36864, 40960, 46080, 49152, 55296, 61440, 69120, 73728, 81920, 92160, 98304, 110592, 122880,
                    138240, 147456, 163840, 184320, 221184, 245760, 276480, 294912, 368640, 442368, 491520, 552960,
                    737280, 884736, 1105920, 1474560, 2211840
                }, kata.CalculateDivisors(4423680));
        }


        // Everything is random so the interviewee will not be able to guess the chipher based just on the tests
        // Happy cracking! ;) //

        [Test]
        public void TestDecryptionEncryption()
        {
            string alphabeth = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            Random random = new Random();
            string[] alphabethMod1 = new[] {"Hi, not your string"};
            string[] alphabethMod2 = new[] {"Hi, not your string"};
            string[] alphabethMod3 = new[] {"Hi, not your string"};
            string[] alphabethMod4 = new[] {"Hi, not your string"};

            string[] a = alphabeth.Split(" ");

            int randTemp = 0;
            int[] randNumbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                randTemp = random.Next(0, a.Length);
                while (randTemp >= a.Length)
                {
                    randTemp = random.Next(0, a.Length);
                }

                randNumbers[i] = randTemp;
            }

            alphabethMod1 = MysteryMethod1Kata3(randNumbers[0], alphabethMod1, a, random);
            alphabethMod2 = MysteryMethod1Kata3(randNumbers[1], alphabethMod2, a, random);
            alphabethMod3 = MysteryMethod1Kata3(randNumbers[2], alphabethMod3, a, random);
            alphabethMod4 = MysteryMethod1Kata3(randNumbers[3], alphabethMod4, a, random);

            Dictionary<string, int> ints = new Dictionary<string, int>();

            // Test 1 - Warm up!

            MysteryMethod2Kata3(a, ints, random, true);

            int theRandomizer = random.Next(0, words.Length);
            string word = words[theRandomizer].ToLower();

            string encryptedString = kata.Encrypter(word, ints, 2);
            Assert.AreNotEqual(word, encryptedString);

            string decryptedString = kata.Decrypter(encryptedString, ints, 2);
            Assert.AreEqual(word, decryptedString);


            // Test 2

            MysteryMethod2Kata3(alphabethMod1, ints, random, false);

            theRandomizer = random.Next(0, words.Length);
            word = words[theRandomizer].ToLower();
            int shifts = random.Next(1, alphabethMod1.Length);

            encryptedString = kata.Encrypter(word, ints, shifts);
            Assert.AreNotEqual(word, encryptedString);

            decryptedString = kata.Decrypter(encryptedString, ints, shifts);
            Assert.AreEqual(word, decryptedString);


            // Test 3
            
            MysteryMethod2Kata3(alphabethMod2, ints, random, false);

            theRandomizer = random.Next(0, words.Length);
            word = words[theRandomizer].ToLower();
            shifts = random.Next(1, alphabethMod2.Length);

            encryptedString = kata.Encrypter(word, ints, shifts);
            Assert.AreNotEqual(word, encryptedString);

            decryptedString = kata.Decrypter(encryptedString, ints, shifts);
            Assert.AreEqual(word, decryptedString);


            // Test 4

            MysteryMethod2Kata3(alphabethMod3, ints, random, false);

            theRandomizer = random.Next(0, words.Length);
            word = words[theRandomizer].ToLower();
            shifts = random.Next(1, alphabethMod3.Length);

            encryptedString = kata.Encrypter(word, ints, shifts);
            Assert.AreNotEqual(word, encryptedString);

            decryptedString = kata.Decrypter(encryptedString, ints, shifts);
            Assert.AreEqual(word, decryptedString);


            // Test 5
            
            MysteryMethod2Kata3(alphabethMod4, ints, random, false);

            theRandomizer = random.Next(0, words.Length);
            word = words[theRandomizer].ToLower();
            shifts = random.Next(1, alphabethMod4.Length);


            encryptedString = kata.Encrypter(word, ints, shifts);
            Assert.AreNotEqual(word, encryptedString);

            decryptedString = kata.Decrypter(encryptedString, ints, shifts);
            Assert.AreEqual(word, decryptedString);
        }

        [Test]
        public void CanTestFizz()
        {
            _resultFizz =
                @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
            KataClass kataClass = new KataClass();
            Console.WriteLine(kataClass.PrintFizzBuzz(100));
            Assert.That(kataClass.PrintFizzBuzz(100), Is.EqualTo(_resultFizz));

            _resultFizz = null;
        }

        [Test]
        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(0)]
        public void CanThrowArgumentExceptionWhenSuppliedNumberDoesNotMeetRule(int number)
        {
            _resultFizz =
                @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
            KataClass kataClass = new KataClass();
            var exception = Assert.Throws<ArgumentException>(() => kataClass.PrintFizzBuzz(number));

            Assert.That(exception.Message,
                Is.EqualTo(string.Format(
                    "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.",
                    number)));
            _resultFizz = null;
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void CanTestSingleNumber(int number, string expectedresult)
        {
            KataClass kataClass = new KataClass();
            var actualresult = kataClass.PrintFizzBuzz(number);
            Assert.That(actualresult, Is.EqualTo(expectedresult),
                string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", number,
                    actualresult, expectedresult));
        }


        // These methods are made on purpose really ambiguous so the interviewee will not be able to
        // guess the mappings or what type of cipher it is
        private String[] MysteryMethod1Kata3(int pullBack, string[] pullUp, string[] constant, Random random)
        {
            if (pullBack < 0 || pullBack >= constant.Length)
            {
                return null;
            }

            pullUp = new string[constant.Length - pullBack];
            HashSet<string> doup = new HashSet<string>();

            for (int i = 0; i < pullUp.Length; i++)
            {
                int r = random.Next(0, pullUp.Length);

                while (doup.Contains(constant[r]))
                {
                    r = random.Next(0, constant.Length);
                }

                pullUp[i] = constant[r];
                doup.Add(pullUp[i]);
            }

            return pullUp;
        }

        private void MysteryMethod2Kata3(string[] yourFriendlyStringArray,
            Dictionary<string, int> yourFriendlyDictionary, Random random, bool magic)
        {
            if (!magic)
            {
                yourFriendlyDictionary = new Dictionary<string, int>();
            }

            for (int i = 0; i < yourFriendlyStringArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(yourFriendlyStringArray[i].Trim()))
                {
                    int rand = random.Next(0, i);

                    if (!magic)
                    {
                        while (yourFriendlyDictionary.ContainsValue(rand))
                        {
                            rand = random.Next(0, yourFriendlyStringArray.Length);
                        }

                        yourFriendlyDictionary.Add(yourFriendlyStringArray[i].Trim(), rand);
                    }
                    else
                    {
                        yourFriendlyDictionary.Add(yourFriendlyStringArray[i].Trim(), i);
                    }
                }
            }
        }

        private bool MysteryMethod3Kata3(Dictionary<string, int> mysteryDictionary)
        {
            string[] m = mysteryDictionary.Keys.ToArray();
            bool[] checks = new bool[mysteryDictionary.Count];

            for (int i = 0; i < m.Length; i++)
            {
                if (mysteryDictionary[m[i]] == i)
                {
                    checks[i] = true;
                }
            }

            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == false)
                {
                    return true;
                }
            }

            return false;
        }
    }
}