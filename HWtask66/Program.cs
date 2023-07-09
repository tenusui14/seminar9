// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GetSumBetweenTwoValues(int first, int second)
{
    if (second < first) return 0;
    return GetSumBetweenTwoValues(first, second - 1) + second;

}

int firstNumber = Input("Введите минимальное значение: ");
int secondNumber = Input("Введите максимальное значение: ");
Console.WriteLine($"Сумма элементов в промежутке от {firstNumber} до {secondNumber} = {GetSumBetweenTwoValues(firstNumber, secondNumber)}");

