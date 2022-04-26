// See https://aka.ms/new-console-template for more information
string txt = File.ReadAllText(@"C:\Users\PC\OneDrive\שולחן העבודה\AnimalFarm.txt");
HashSet<string> WordsSet = new HashSet<string>();
WordsSet.Add("yes");
WordsSet.Add("has");
WordsSet.Add("then");
WordsSet.Add("the");
WordsSet.Add("and");
WordsSet.Add("was");
WordsSet.Add("were");
WordsSet.Add("them");
WordsSet.Add("that");
WordsSet.Add("they");
WordsSet.Add("the");
WordsSet.Add("had");
WordsSet.Add("his");
WordsSet.Add("not");
WordsSet.Add("been");
WordsSet.Add("for");
WordsSet.Add("their");
WordsSet.Add("this");
WordsSet.Add("there");
WordsSet.Add("which");
var CharArray = txt.Where(x => x != '.' && x != ',' && x != ':' && x != ';' && x != '?' && x != '"' && x != '-' && x != '!' && x!= '\r').ToArray();
string book = new string(CharArray);
var WordsList = book.Split(' ', '\n').Where(x=> !WordsSet.Contains(x.ToLower()) && x.Length > 2).GroupBy((x) => x);
var TopWords = WordsList.OrderByDescending(x => x.Count()).Select(x => new { Word = x.ElementAt(0), Length = x.Count()}).Take(10);
foreach (var wordList in TopWords)
{
    Console.WriteLine($"The word - {wordList.Word} \nCount - {wordList.Length}");
}


    