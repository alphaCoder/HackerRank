using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class StringConstructionTests
    {
        [TestMethod]
        public void When_abcd_Should_Return_4()
        {
            var expected = 4;
            var input = "abcd";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_abab_Should_Return_2()
        {
            var expected = 2;
            var input = "abab";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_1_1_Should_Return_7()
        {
            var expected = 7;
            var input = "gbcebabbfffcdgfeeaadecaeecabbabbgcafeabgecfeffcbafgdegdacefcadabbfdcgcebegbfgeeebfegfacdagbbgeagaaceefcaedceacceebdgebeecedcbdbeebecgcfcgdaaaegfbcbfffccffabbceafaagdedadbfcaedaffbaggebfedegfabefafefgdbafedbggabccaedabfgfgggbcfgeggdcdfeebaedaaccefgegbffaaggdcbbbfdbgaaffbbgcfafccdgcaabccbfbgbabegddagcgfbcdfdaccegbabfedbbdaddebddgegedgaabebfeeggddagaeececcafdgddceddcbdagaecceacgfabgccecgecgcefaafcaedfccdeeceffefadeffefggaeggbbfgcacgfaeefbfbccggcbcgeagcaacdcbegcdaacdgbebdaabddeagafbfagfebfefffcbcgefbcfeggafccabfagegccefe";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void When_1_2_Should_Return_7()
        {
            var expected = 11;
            var input = "ckbjbibcbdhhkkfkgfkjbdebggcbhjkbeedbehdggegkjikhgibiieafdkiichaifbjfheijadadicacjbhehhgegghbkdkiedafjdddgekdeahgdjebjhkhbcjdfddggkdhjjgaajbihbkgggjcfaejkgdihkhdhdcaaddhddkdkcejehdaieaiciicaabkaahbjjbjegdbefkkkadjgaiegehedjdfebkhebacaaaafhgcfehfhkdkhgjffkgkfahikdkaagchkggjcheejecdcjbkdkhaeiiijadbc";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void When_1_3_Should_Return_22()
        {
            var expected = 22;
            var input = "khtlbbtscplpugrqlufncvqdankrnduiiqlnosogntpghusnduqpuohhivathehdmurhvlgiefhqffpiajuphsdvhnfrhjaubjeukaihnkobkgbgipdqhkiognhspamaohbctedngrhnleuvapumikfuhbpnjgnvuvuuihrnisctqbogrjtuselhfqkhrflstqqvfncvjvejbvbsmpgqbspopvctdvbvmqeqidseefmiepktqnebufmdqomednrcegggolqebjamhjskgfgbfqatpinhbatsqpbkr";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void When_1_4_Should_Return_11()
        {
            var expected = 11;
            var input = "echgafgdgbchihdkhejfidahajdijjjkdihahhgifakecfiibkgdbgbikciffbegefkbcddijkiegcgbijiffikchgkcbifeekhfdhihfeiaceckdahgcddekaffcbeddaacgcjhcggiaebkdejgaieffjcedaedjdijaeegaghbdijbhedjecjcdcicdkcebbgakkkfahiafbejchgijgjcbebfiiekeehffaefdckidedfcafejekhccjedcehjheiiaihcggiffekjaigcdfjbhggggijkdkgeagcigfbaffciikkkhfaabjefhhcefiidcijjgbidjchbaeegfgaaejffjibedbeaifeejkchjdiaejbeibiiieggkfcgkcgjicbagjdgggbcjfbdhiabajkdafigcaj";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_1_5_Should_Return_11()
        {
            var expected = 4;
            var input = "acacacabcbbccacadcabcbadcbdddbbcbcadbbccadbdaddaaadaddbdbabbaadbcdaccaddccbbcbbaddcabcadbaaddbdaabcdcbabaacbccbbabcccdbdabacccdacbcbabacabcdadcbcdccd";
            var actual = StringConstruction.CalculateCost(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
