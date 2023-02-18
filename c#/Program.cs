Console.WriteLine("Введите количество элементов в массиве:");
String[]array = new String [Convert.ToInt32(Console.ReadLine())];
int counter = 0;
int j = 0;

Console.WriteLine("Введите значения для массива:");
for (int i = 0; i < array.Length; i++) {
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) {
        counter++;
    }
}
Console.WriteLine("Создан массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));
String[]mainArray = new String [counter];

for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3) {
        mainArray[j] = array[i];
        j++;
    }
} 

Console.WriteLine("Массив элементов, где длина меньше 3-х символов:");
Console.WriteLine("[{0}]", string.Join(", ", mainArray));
