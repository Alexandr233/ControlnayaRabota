string[] array = AskArray();
string[] result = InputMass(array, 3); //Тут можно изменить колличество символов вместо 3 написать 5,6 и так далее)
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]"); //проставляет запятые между значениями и ставит пробелы при выводе результирующего массива

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
    Console.Write("Введите значения через пробел: "); // при вводе с клавиатуры
    return Console.ReadLine().Split(" ");
}
