// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо
// равна 3 символа. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] inArray = new string[]{"Russia", "Denyeb", "12435"};
int numberChar = 3;
string[] outArray;

outArray = FormingArray(inArray, numberChar);


PrintArray(inArray);
System.Console.Write(" -> ");
PrintArray(outArray);


void PrintArray(string[] ar)
{
    if (ar.Length != 0) 
    {
    System.Console.Write("[");
    int i = 0;
    while (i < ar.Length-1)
    {
        System.Console.Write(ar[i] + ", ");
        i++;
    }
    System.Console.Write(ar[i] + "]");
    }
    else
    {
        System.Console.WriteLine("В массиве нет элементов"); // пустой массив
    }
}

string[] FormingArray(string[] inAr, int numCh)
    {
        int countEl = 0;
        foreach (string elem in inAr)
        {
            if (elem.Length <= numCh) countEl++;
        }
        System.Console.WriteLine(countEl); // количество искомых элементов
        
        string[] outAr = new string[countEl];
        int j = 0;
        for(int i=0; i < inAr.Length ; i++)
        {
            if (inAr[i].Length <= numCh) 
            {
                outAr[j] = inAr[i];
                j++;
            }
        }
        return outAr;
    }




