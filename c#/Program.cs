String[]array = new String [4];
int counter = 0;
Console.WriteLine("Введите значения для массива");
for (int i = 0; i < array.Length; i++) {
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) {
        counter++;
        }
}
Console.WriteLine("Создан массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(counter);
