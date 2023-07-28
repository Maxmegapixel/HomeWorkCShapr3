// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string StNum = Console.ReadLine()!;
int IntNum = Convert.ToInt32(StNum);

if(IntNum<10000 || IntNum >99999) Console.WriteLine($"Число {StNum} не пятизначное");
else 
{
    if (StNum[0] == StNum[4] && StNum[1] == StNum[3]) Console.WriteLine($"Число {StNum} является полиндромом");
    else Console.WriteLine($"Число {StNum} не является полиндромом");
}

