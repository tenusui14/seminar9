// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int Input(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GetSumOfDigitsInNumber(int number)
{
    if (number <= 0) return 0;
    return GetSumOfDigitsInNumber(number / 10) + (number % 10);
}

int value = Input("Введите число: ");
Console.WriteLine(GetSumOfDigitsInNumber(value));