// Напишите программу,которая принимает на вход пятизначное число и проверяет,является ли оно палиндром.
Console.Write("Введите  пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
if (number[0]==number[4] || number[1]==number[3]){
Console.WriteLine($"Ваше число: {number} - да является палиндром.");
}
else Console.WriteLine($"Ваше число: {number} - нет не является палиндром.");
}

if (number!.Length == 5){
CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");