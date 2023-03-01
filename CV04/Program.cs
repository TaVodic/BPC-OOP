// See https://aka.ms/new-console-template for more information
using CV04;

Console.WriteLine("Hello, World!");

//str.split()
//RemoveEmpyEntres

//foreach
//regex
//dictionary

//stringBuilder

string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
 + "posledni veta!";

StringStatistics text = new StringStatistics(testovaciText);


Console.WriteLine(text.wordsCount());
Console.WriteLine(text.rowCount());
Console.WriteLine(text.sentenceCount());
Console.WriteLine(text.shortesWord().ToString());
Console.WriteLine(text.longestWord().ToString());
Console.WriteLine(text.occurances());
foreach (string word in text.sorted())
{
    Console.WriteLine(word);
}
