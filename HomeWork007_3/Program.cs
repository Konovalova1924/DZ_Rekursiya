// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] CreateArray(int min, int max, int size){
    int[] array = new int[size];
        for (int i = 0; i < size; i++){
            array[i] = new Random().Next(min, max + 1);
            Console.Write(array[i] + "|");
            }
    return array;
}
void ShowArray(int[] array, int i = 0){
    if (i < array.Length){
        ShowArray(array, i + 1);
        Console.Write(array[i] + "|");
        }
}

int[] myArray = CreateArray(1, 9, 10);
Console.WriteLine();
ShowArray(myArray);