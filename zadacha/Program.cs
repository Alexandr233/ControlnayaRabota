string[] array = AskArray();
string[] result = InputMass(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] InputMass(string[] input, int m) 
{
    string[] output = new string[IneqSymbols(input, m)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= m) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int IneqSymbols(string[] input, int m) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= m) 
        {
            count++;
        }
    }

    return count;
}
string[] AskArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
