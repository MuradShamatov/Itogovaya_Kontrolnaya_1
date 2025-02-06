// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int CountStr (string [] arrayWords)
{
    int  count = 0;
    foreach(string str in arrayWords)
    {
        if(str.Length <= 3)
            {
                count++;
            }
    }
    return count;
}

string [] IsSearch_3_Words (string[] arrayWords)
{
    int count = CountStr(arrayWords);
    
    string [] newArrayWords = new string[count];
    int j = 0;
    for(int i = 0; i< arrayWords.Length; i++)
    {
        if(arrayWords[i].Length <= 3)
        {
            newArrayWords[j] = arrayWords[i];
            j++;
        }
    }
    return newArrayWords;
}

void PrintStrinkg (string [] only_3_letter)
{
    for (int i = 0; i<only_3_letter.Length; i++)
    {
        Console.WriteLine(only_3_letter[i]);
    }
}

string[] arrayWords = {"Hello", "2", "world", ":-)"};
string[] only_3_letter = IsSearch_3_Words(arrayWords);
PrintStrinkg (only_3_letter);

