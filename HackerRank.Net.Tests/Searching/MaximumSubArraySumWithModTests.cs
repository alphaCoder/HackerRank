﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Searching;
using System.Linq;
using System.IO;

namespace HackerRank.Net.Tests.Searching
{
    [TestClass]
    public class MaximumSubArraySumWithModTests
    {
        [TestMethod]
        public void ComputeMaxSubArraySum_WhenTest0_Returns6()
        {
            // Arrange
            ulong[] input = new ulong[] { 3, 3, 9, 9, 5 };
            ulong mod = 7;
            ulong expected = 6;

            // Act
            ulong actual = MaximumSubArraySumWithMod.ComputeMaxSubArraySum(input, mod);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeMaxSubArraySum_WhenTest1_Return()
        {
            // Arrange
            ulong[] input = "846930887 1681692778 1714636916 1957747794 424238336 719885387 1649760493 596516650 1189641422 1025202363 1350490028 783368691 1102520060 2044897764 1967513927 1365180541 1540383427 304089173 1303455737 35005212 521595369 294702568 1726956430 336465783 861021531 278722863 233665124 2145174068 468703136 1101513930 1801979803 1315634023 635723059 1369133070 1125898168 1059961394 2089018457 628175012 1656478043 1131176230 1653377374 859484422 1914544920 608413785 756898538 1734575199 1973594325 149798316 2038664371 1129566414".Split(' ').Select(x=>ulong.Parse(x)).ToArray();
            ulong mod = 1804289384;
            ulong expected = 1802192837;

            // Act
            ulong actual = MaximumSubArraySumWithMod.ComputeMaxSubArraySum(input, mod);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeMaxSubArraySum_WhenTest4_1_Return()
        {
            // Arrange
            ulong[] input = "629170223 1319277537 1860567312 1748229126 978412341 1529640718 1067182038 396933341 1793472028 808947535 1674241782 1290525277 943753639 130320569 1077720416 1481496865 878873619 1281103861 1306228351 1040847740 1401120810 1467649826 1409124236 1441916624 512482002 165020272 1144336816 916532467 1683654744 1620665261 756125733 165341319 792459150 469209396 1913570444 1770871490 1998850113 833268833 20321183 1644838493 1642216367 1694562964 787880121 438486357 1824883532 1865600536 1919983222 556273502 999220749 1078727924 1597121241 252857910 398894101 858761829 1694774533 911376102 1023782100 691627700 1827908569 559953195 164809313 436550653 725294513 957268462 905760049 491381308 580656303 757126513 1324650140 600977485 254481357 819382859 148056800 1042361477 1257869215 1972940332 760478365 1030368788 381730185 1759699113 2109096712 1978851426 2012557022 360507164 690129606 1559847906 1271883266 1713911705 103991958 952308186 126381251 268801270 1388858838 851675764 1226069731 147135238 1343057071 1806726033 904261751 520223563 260219870 1158743107 1339606421 408276669 53620936 449991987 233733352 814099300 1480360775 615463537 426314764 1441973838 446831314 291388137 1802481001 1136960919 1851236042 926880618 703388975 1955227999 1879188803 829770225 76545620 1120563993 1681445988 1302615350 1267699230 877019411 961857735 24477332 1397242973 1222077604 1183220439 589365745 1630354272 1236841374 1039357731 1864087624 2050940673 372234857 332067512 329771788 1814208694 778898825 621159924 1469206047 1915859743 324912317 248603016 471765069 132656668 2127791819 1301535293 209202287 1100872163 835497633 1511817637 221087744 1712517043 326191723 245565076 962276367 1548269326 1428785514 1551642111 1031139949 518143239 443516193 747743924 421600263 815751050 1079811435 751372050 482476095 1858710259 1372531973 1951682141 1627086353 1697444289 52801509 2098851421 1830100956 33109679 1252903066 2039303243 1133981841 2088400698 1403637231 1355069584 1653434092 1729828953 1600634659 468226810 1130614630 881936524 2019868920 14270930 1400079762 315901464 762014854 1821680024 1131652513 1841826288 425568425 1614128608 1553052899 1798100397 1418327100 1032655603 1348061038 1471128608 984023376 1030678345 1504238286 89442793 922497939 490736478 30359842 178651521 1845806062 1683793933 1908480473 1298957072 4537094 891611454 33409948 2024406013 905882384 1433489709 192823828 1667897237 1107686085 1324476341 1362239876 1533254509 791121300 767809126 1183871258 61964751 1800464729 384448647 1533093359 637004456 1415126991 889847996 726447248 190141282 1380584474 756807089 368792802 1078906887 293117373 129789627 230380310 297654466 1021401080 263790257 174576830 1927283463 1697279966 367400657 1447697051 657482402 1691876997 662453279 43253262 335514648 1430262404 1227124519 397479399 1083243484 1611573165 1930572757 1720247939 879216508 672937104 299211538 1069357789 2053521577 1056018626 1438150590 984944815 1349135998 1567940216 1215325125 1646790463 441857648 1479115381 1821367292 221657462 1028911698 41284301 1669354513 1686394099 1733161297 184324143 1729647361 2068675945 1614586546 809288231 318671695 550346382 273377748 101760803 123110672 1152594255 774697906 422322210 74468395 680735835 1478340835 1512618984 1665680649 679993185 933075552 733522125 179299999 1374933199 65153858 2000667291 1596590660 1094065555 2041951591 1118461524 632976006 1627629239 1302785666 215139718 1548821535 769888564 1024427948 1867493229 1320234945 1297805695 1969254031 1443345616 302916301 596468289 1865667825 377384695 1277204123 1196525012 1890003679 795401123 1876518196 675595582 1528923248 2055818194 2050528780 1594077105 1909001836 1499635791 540659011 1803469778 470613667 1173635016 1283615369 1773399332 1388774733 684953255 395804247 265719033 404962836 1716039191 1563524727 226733218 1011901159 1866441028 823201506 730085335 96342074 2100405628 1926610346 1986345752 748323103 1655644893 514457685 129762702 1563979439 417502816 1723839806 1325497626 1917138607 117015168 981483756 240268625 1290650184 117615476 2013667956 531941268 802568730 261988555 797660300 1207531565 1978027745 213701379 1434264783 842445255 2080142406 109982640 400 1572530590".Split(' ').Select(x => ulong.Parse(x)).ToArray();
            ulong mod = 1987076915;
            ulong expected = 1987054712;

            // Act
            ulong actual = MaximumSubArraySumWithMod.ComputeMaxSubArraySum1(input, mod);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeMaxSubArraySum_WhenTest4_Full_Return()
        {
            // Arrange
            var lines = File.ReadAllLines(@"c:\temp\test4.txt");
            for (int i = 0; i < 1250; i++)
            {
                ulong[] input;
                ulong mod = 0;
                ulong expected = 0;

                if (i % 2 == 1)
                {
                    input = lines[i].Split(' ').Select(x => ulong.Parse(x)).ToArray();
                    // Act
                    ulong actual = MaximumSubArraySumWithMod.ComputeMaxSubArraySum(input, mod);

                    // Assert
                  //  Assert.AreEqual(expected, actual);
                }
                else
                {
                    mod = ulong.Parse(lines[i].Split(' ')[1]);
                }
            }
        }
    }
}
