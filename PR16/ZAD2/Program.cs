using MyLibraryClasses;

MyDictionary<int, string> dict = new MyDictionary<int, string>();
dict.Add(1, "Макс");
dict.Add(2, "Брэд");
dict.Add(3, "Баран");

Console.WriteLine($"Количество: {dict.Counter}");
Console.WriteLine(dict.GetElem(3));