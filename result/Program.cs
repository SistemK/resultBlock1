
string[] getArr (string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    string[] textArr  = text.Split(',');   
    Console.WriteLine("[{0}]", string.Join(", ", textArr));
    return textArr;
}

void findElement (string[] arr)
{
    string[] result = Array.Empty<string>();
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref result, j+1);
            result[j] = arr[i];
            j++;
        }
    }
    //Console.WriteLine(result);
    Console.WriteLine("[{0}]", string.Join(", ", result));
}

string[] array = getArr("Введите элеметны массива через запятую");
findElement(array);