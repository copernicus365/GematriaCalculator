# Gematria Calculator

A very fast and efficient gematria calculator, for both Hebrew and Syriac, written in C#. Vowel points, breathings, and spaces are very conveniently ignored, making this very user-friendly, no escaping of vowels needed. Functions are also available for display Unicode information on Hebrew and Syriac (this helped me write this). 

At the moment I've kept this logic in a single file (`GematriaCalculator.cs`), as it's already so short. Before adding Syriac it was less than 100 lines :) In my case I needed to calculate Syriac gematria, which appears to be basically identical in nature to Hebrew's.

For many coming here who are not programmers, you are likely interested in just using this. Well, there are already gematria calculators free online (i.e. little websites that offer this functionality). Even so this project builds to an executable that runs a little console app that asks for input in a loop and does the calculation.

## Usage

```cs
int value = GematriaCalc.Calculate(input);

// or: 
value = GematriaCalc.Calculate(input);

// Syriac:
value = GematriaCalc.CalculateSyriac(input);
```

See [unit tests](Test/src/GematriaCalcTests.cs) for proof of usage.

## Generate Hebrew or Syriac Unicode Letters Report

To generate these run: 
* `GematriaCalc.GetHebrewUnicodeLettersInfoReport()` or 
* `GematriaCalc.GetSyriacUnicodeLettersInfoReport()`

On which see these Wiki pages for their unicode tables:

* For Hebrew [see here](https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet)
* For Syriac [see here](https://en.wikipedia.org/wiki/Syriac_(Unicode_block)).

### GetHebrewUnicodeLettersInfoReport

```txt
0: 1488 -> א
1: 1489 -> ב
2: 1490 -> ג
3: 1491 -> ד
4: 1492 -> ה
5: 1493 -> ו
6: 1494 -> ז
7: 1495 -> ח
8: 1496 -> ט
9: 1497 -> י
10: 1498 -> ך
11: 1499 -> כ
12: 1500 -> ל
13: 1501 -> ם
14: 1502 -> מ
15: 1503 -> ן
16: 1504 -> נ
17: 1505 -> ס
18: 1506 -> ע
19: 1507 -> ף
20: 1508 -> פ
21: 1509 -> ץ
22: 1510 -> צ
23: 1511 -> ק
24: 1512 -> ר
25: 1513 -> ש
26: 1514 -> ת
```

### GetSyriacUnicodeLettersInfoReport

```txt
0: 1808 -> ܐ
1: 1809 -> ܑ
2: 1810 -> ܒ
3: 1811 -> ܓ
4: 1812 -> ܔ
5: 1813 -> ܕ
6: 1814 -> ܖ
7: 1815 -> ܗ
8: 1816 -> ܘ
9: 1817 -> ܙ
10: 1818 -> ܚ
11: 1819 -> ܛ
12: 1820 -> ܜ
13: 1821 -> ܝ
14: 1822 -> ܞ
15: 1823 -> ܟ
16: 1824 -> ܠ
17: 1825 -> ܡ
18: 1826 -> ܢ
19: 1827 -> ܣ
20: 1828 -> ܤ
21: 1829 -> ܥ
22: 1830 -> ܦ
23: 1831 -> ܧ
24: 1832 -> ܨ
25: 1833 -> ܩ
26: 1834 -> ܪ
27: 1835 -> ܫ
28: 1836 -> ܬ
29: 1837 -> ܭ
30: 1838 -> ܮ
31: 1839 -> ܯ
32: 1840 -> ܰ
33: 1841 -> ܱ
34: 1842 -> ܲ
35: 1843 -> ܳ
36: 1844 -> ܴ
37: 1845 -> ܵ
38: 1846 -> ܶ
39: 1847 -> ܷ
40: 1848 -> ܸ
41: 1849 -> ܹ
42: 1850 -> ܺ
43: 1851 -> ܻ
44: 1852 -> ܼ
45: 1853 -> ܽ
46: 1854 -> ܾ
47: 1855 -> ܿ
48: 1856 -> ݀
49: 1857 -> ݁
50: 1858 -> ݂
51: 1859 -> ݃
52: 1860 -> ݄
53: 1861 -> ݅
54: 1862 -> ݆
55: 1863 -> ݇
56: 1864 -> ݈
57: 1865 -> ݉
58: 1866 -> ݊
59: 1867 -> ݋
60: 1868 -> ݌
61: 1869 -> ݍ
62: 1870 -> ݎ
63: 1871 -> ݏ
```

## Future: Syriac to Hebrew conversion?

I may have the need for this, the structures used in this gematria calculation would at least lend themselves in core idea to make a blazing fast, essentially as efficient as conceivable, Syriac to Hebrew converter, or the other way around. I just don't have the need for this at the moment and it's some extra work...
