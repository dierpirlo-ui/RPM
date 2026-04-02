using System.Diagnostics;

int LinearSearch(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            return i;
        }
    }
    return -1;
}
int[] numbers = { 10, 20, 30, 40, 50 };

// 1. Элемент в начале
Debug.Assert(LinearSearch(numbers, 10) == 0);

// 2. Элемент в середине
Debug.Assert(LinearSearch(numbers, 30) == 2);

// 3. Элемент в конце
Debug.Assert(LinearSearch(numbers, 50) == 4);

// 4. Отсутствующий элемент
Debug.Assert(LinearSearch(numbers, 99) == -1);

// 5. Пустой массив
int[] emptyArray = { };
Debug.Assert(LinearSearch(emptyArray, 10) == -1);

// 6. Дубликаты 
int[] duplicates = { 2, 2, 2 };
Debug.Assert(LinearSearch(duplicates, 2) == 0);

Console.WriteLine("Все тесты линейного поиска пройдены");





