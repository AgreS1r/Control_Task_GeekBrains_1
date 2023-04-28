// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

/* Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", “Denmark", “Kazan"] → [] */

// 1 вариант (без ввода с клавиатуры)
Console.Clear();
string[] input = {"Hello", "2", "world", ":-)"};
string[] output = new string[input.Length];
int index = 0;
for (int i = 0; i < input.Length; i++){
    if (input[i].Length <= 3){
        output[index] = input[i];
        index++;
    }
}
Console.WriteLine("INPUT: " + string.Join(", ", input));
Console.WriteLine("OUTPUT: " + string.Join(" ", output));

Console.WriteLine();
Console.WriteLine();

// 2 вариант (ввод с клавиатуры)
Console.Write("Введите строку элементов через пробел: ");
string inputString = Console.ReadLine();
string[] input2 = inputString.Split(' ');
string[] output2 = new string[input2.Length];
int index2 = 0;
for (int i = 0; i < input2.Length; i++){
    if (input2[i].Length <= 3){
        output2[index2] = input2[i];
        index2++;
    }
}
Console.WriteLine("INPUT_2: " + string.Join(", ", input2));
Console.WriteLine("OUTPUT_2: " + string.Join(" ", output2));