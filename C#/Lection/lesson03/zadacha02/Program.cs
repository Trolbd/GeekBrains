﻿// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками 
// маленькие буквы "к" заменить большими "К"
// большие "С" заменить маленькими "с"

string text = "- Я думаю, -сказал князь, улыбаясь, - что,"
			+ "ежели бы вас послали вместо нашего милого Винценгероде,"
			+ "вы бы взяли приступом согласие прусского короля."
			+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "sdsd"
//             0123
// s[3] = d

string Replase(string text, char oldValue, char newValue)
{
	string result = String.Empty;

	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}

	return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);



