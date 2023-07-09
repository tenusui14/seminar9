// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Input(string message){
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int PowFirstNumberToSecondNumber(int first, int second ){
    if(second == 0) return 1; 
    return PowFirstNumberToSecondNumber(first, second-1) * first;
    
}

int firstNumber = Input("Введите число: ");
int secondNumber = Input("Введите степень: ");
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {PowFirstNumberToSecondNumber(firstNumber,secondNumber)}");
