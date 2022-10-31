string[] Find3DigitsStrings(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) count++;
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) 
        {
            result[j] = str[i];
            j++;
        }
    }
    return result;
}

System.Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] str = new string[n];
System.Console.WriteLine("Введите строки массива");
for (int i = 0; i < n; i++)
{
    str[i] = Console.ReadLine();
}
System.Console.WriteLine("["+string.Join(", ", Find3DigitsStrings(str))+"]");