
Console.WriteLine(@"✡✼ Calculate Gematria with GematriaCalculator ✼✡

ܡܢܺܝ ܟܰܘܟ̈ܒܶܐ: ܐܶܢ ܡܶܫܟܰܚ ܀ סְפֹר הַכּ֣וֹכָבִ֔ים אִם־תּוּכַ֖ל

");

while(true) {
	"\nEnter a value to calculate it's gematria: ".Print();

	string input = Console.ReadLine().NullIfEmptyTrimmed();

	if(input.IsNulle())
		continue;

	bool isHebrew = input.Any(c => c >= 'א' && c <= 'ת');

	int value = isHebrew
		? GematriaCalc.Calculate(input)
		: GematriaCalc.CalculateSyriac(input);

	$"Answer: {value} - for {input}\n\n".Print();
}
