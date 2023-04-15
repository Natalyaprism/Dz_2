// Напишите программу, которая выводит третью цифру заданного числа
// Или сообщает что третьего числа нет.)

Console.WriteLine("Введите число");
int anyNumber = Convert.ToInt32(Console.ReadLine());
String anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length>2)
{
 Console.WriteLine("Третья цифра "+anyNumberText[2]);   
}
else
{
    Console.WriteLine("Нет цифры");
}