using System.Diagnostics;

int BinarySearch(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int middle = left + (right - left) / 2;

        if (array[middle] == target)
        {
            return middle;
        }
        else if (target < array[middle])
        {
            right = middle - 1;
        }
        else
        {
            left = middle + 1;
        }
    }
    return -1;
}

// 1. Поиск в начале
int[] sortedNumbers = { 10, 20, 30, 40, 50, 60, 70 };
Debug.Assert(BinarySearch(sortedNumbers, 10) == 0);

// 2. Поиск в середине
Debug.Assert(BinarySearch(sortedNumbers, 40) == 3);

// 3. Поиск в конце
Debug.Assert(BinarySearch(sortedNumbers, 70) == 6);

// 4. Поиск отсутствующего элемента
Debug.Assert(BinarySearch(sortedNumbers, 100) == -1);

// 5. Пустой массив
int[] emptyArray = { };
Debug.Assert(BinarySearch(emptyArray, 10) == -1);

// 6. Отрицательные числа
int[] negativeNumbers = { -10, -5, -3, 0, 2, 4 };
Debug.Assert(BinarySearch(negativeNumbers, -5) == 1);
Debug.Assert(BinarySearch(negativeNumbers, 0) == 3);

// 7. Четная длина массива
int[] evenLength = { 1, 3, 5, 7, 9, 11 };
Debug.Assert(BinarySearch(evenLength, 7) == 3);
Debug.Assert(BinarySearch(evenLength, 11) == 5);

Console.WriteLine("Все тесты бинарного поиска пройдены");
