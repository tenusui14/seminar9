// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int Input(string message){
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void GetDigitsFromOneValueToAnotherValue(int first, int second ){
    if(second < first) return;
    GetDigitsFromOneValueToAnotherValue(first,second-1);
    Console.Write(second+ " ");
}

int firstNumber = Input("Введите минимальное значение: ");
int secondNumber = Input("Введите максимальное значение: ");
GetDigitsFromOneValueToAnotherValue(firstNumber, secondNumber);
