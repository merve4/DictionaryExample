// See https://aka.ms/new-console-template for more information


Dictionary<string, int> myDictionary = new Dictionary<string, int>();

myDictionary.Add("Assembly", 1949);
myDictionary.Add("Basic", 1964);
myDictionary.Add("C", 1972);
myDictionary.Add("Python", 1991);
myDictionary.Add("Java", 1995);
myDictionary.Add("C#", 2000);

Console.WriteLine("Eleman Sayısı : " + myDictionary.Count);

foreach (var item in myDictionary)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------");
myDictionary.Remove("C");
myDictionary.Remove("Python");
foreach (var item in myDictionary)
{
    Console.WriteLine(item);
}
Console.WriteLine("Silindikten sonraki eleman sayısı: " + myDictionary.Count);


