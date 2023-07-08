// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Input(string message){
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void GetDigitsFromeOneToValue(int value){
    if(value <= 0) return;
    GetDigitsFromeOneToValue(value-1);
    Console.Write(value+ " ");
}

int number = Input("Введите число: ");
GetDigitsFromeOneToValue(number);