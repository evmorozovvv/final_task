
string[] array = { "qwerty", "agр", ":-)", "1и62", "контрольная" };
string[] arrayResult = new string[array.Length];
string empty = string.Empty;

void PrintArray(string[] array)
{
    Console.Write("[ ");
       for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] != empty)
            Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length < 4)
        {
            arrayResult[i] = array[i];
        }
        else
            arrayResult[i] = empty;
    }


    PrintArray(arrayResult);


