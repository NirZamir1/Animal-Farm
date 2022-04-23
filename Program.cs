// See https://aka.ms/new-console-template for more information
string txt = File.ReadAllText(@"C:\Users\PC\OneDrive\שולחן העבודה\AnimalFarm.txt");
var CharArray = txt.Where(x => x != '.' && x != ',' && x != ':' && x != ';' && x != '?' && x != '"' && x != '-' && x != '!' && x!= '\r').ToArray();
string book = new string(CharArray);
var WordsList = book.Split(' ', '\n').Where(x =>  x.Length > 2 && x.ToLower() != "was" && x.ToLower() != "were" && x.ToLower() != "yes" && x.ToLower() != "the" && x.ToLower() != "and" && x.ToLower()  != "not" && x.ToLower() != "had"  && x.ToLower() != "that"
&& x.ToLower() != "them" && x.ToLower() != "their").GroupBy(x => x);
var TopWords = WordsList.OrderByDescending(x => x.Count()).Select(x => new { Word = x.ElementAt(0), Length = x.Count()}).Take(10);
foreach (var wordList in TopWords)
{
    Console.WriteLine($"The word - {wordList.Word} \nCount - {wordList.Length}");
}


    