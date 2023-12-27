using System.Text;

namespace GematriaCalculator;

public class GematriaCalc
{
	public static int Calculate(string value, bool ignoreExtras = true)
	{
		if(string.IsNullOrEmpty(value))
			return 0;

		int sum = 0;

		for(int i = 0; i < value.Length; i++) {
			char c = value[i];
			if(c < 'א' || c > 'ת') {
				if(ignoreExtras || char.IsWhiteSpace(c))
					continue;
				return -1;
			}
			int index = c - 'א';

			GematriaLetter letter = HebrewLetters[index];
			sum += letter.GemValue;
		}

		return sum;
	}

	public static int CalculateSyriac(string value, bool ignoreExtras = true)
	{
		if(string.IsNullOrEmpty(value))
			return 0;

		int sum = 0;

		for(int i = 0; i < value.Length; i++) {
			char c = value[i];
			if(c < 'ܐ' || c > 'ܬ') {
				if(ignoreExtras || char.IsWhiteSpace(c))
					continue;
				return -1;
			}
			int index = c - 'ܐ';

			GematriaLetter letter = SyriacLetters[index];
			sum += letter.GemValue;
		}

		return sum;
	}

	public static GematriaLetter[] GetHebrewLetters()
		=> HebrewLetters.Where(c => c.Letter != default).ToArray(); // ! must make new array, never expose internal. items tho as structs are safe

	public static GematriaLetter[] GetSyriacLetters()
		=> SyriacLetters.Where(c => c.Letter != default).ToArray(); // dido

	public static string GetHebrewUnicodeLettersInfoReport()
		=> PrintUnicodeLettersInfo('א', 27);

	public static string GetSyriacUnicodeLettersInfoReport()
		=> PrintUnicodeLettersInfo('ܐ', 64);

	static string PrintUnicodeLettersInfo(char startChar, int count)
	{
		StringBuilder sb = new();

		int start = startChar;

		for(int i = 0; i < count; i++) {
			char c = (char)(start + i);
			sb.AppendLine($"{i}: {(int)c} -> {c}");
		}
		string val = sb.ToString();
		return val;
	}

	readonly static GematriaLetter[] HebrewLetters = [
		new('א', 0, 1),
		new('ב', 1, 2),
		new('ג', 2, 3),
		new('ד', 3, 4),
		new('ה', 4, 5),
		new('ו', 5, 6),
		new('ז', 6, 7),
		new('ח', 7, 8),
		new('ט', 8, 9),
		new('י', 9, 10),
		new('ך', 11, 20),
		new('כ', 10, 20),
		new('ל', 12, 30),
		new('ם', 14, 40),
		new('מ', 13, 40),
		new('ן', 16, 50),
		new('נ', 15, 50),
		new('ס', 17, 60),
		new('ע', 18, 70),
		new('ף', 20, 80),
		new('פ', 19, 80),
		new('ץ', 22, 90),
		new('צ', 21, 90),
		new('ק', 23, 100),
		new('ר', 24, 200),
		new('ש', 25, 300),
		new('ת', 26, 400),
	];

	readonly static GematriaLetter[] SyriacLetters = [
		new('ܐ', 0, 1),
		new(default, 1, 0), //1: 1809 -> ܑ
		new('ܒ', 2, 2),
		new('ܓ', 3, 3),
		new('ܔ', 4, 3),
		new('ܕ', 5, 4),
		new('ܖ', 6, 4),
		new('ܗ', 7, 5),
		new('ܘ', 8, 6),
		new('ܙ', 9, 7),
		new('ܚ', 10, 8),
		new('ܛ', 11, 9),
		new('ܜ', 12, 9),
		new('ܝ', 13, 10),
		new('ܞ', 14, 15),
		new('ܟ', 15, 20),
		new('ܠ', 16, 30),
		new('ܡ', 17, 40),
		new('ܢ', 18, 50),
		new('ܣ', 19, 60), // = 1827
		new('ܤ', 20, 60), // = 1828
		new('ܥ', 21, 70),
		new('ܦ', 22, 80),
		new(default, 23, 0), //23: 1831 -> ܧ
		new('ܨ', 24, 90),
		new('ܩ', 25, 100),
		new('ܪ', 26, 200),
		new('ܫ', 27, 300),
		new('ܬ', 28, 400),
	];
}

public readonly struct GematriaLetter(char letter, byte index, int gemValue)
{
	public char Letter { get; } = letter;

	/// <summary>Index in internal array / from start of first language char ('A')</summary>
	public byte Index { get; } = index;

	/// <summary>The gematria value of this letter.</summary>
	public int GemValue { get; } = gemValue;
}
