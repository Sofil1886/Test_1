Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] stringsArray = input.Split(' ');

List<string> result = new List<string>();

for (int i = 0; i < stringsArray.Length; i ++)
{
    if (stringsArray[i].Length == 3)
    {
        result.Add(stringsArray[i]);
    }
}

string[] resultArray = result.ToArray();
Console.WriteLine($"[{string.Join(", ", resultArray)}]");