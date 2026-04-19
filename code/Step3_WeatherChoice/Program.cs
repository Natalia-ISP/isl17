Console.WriteLine("выбор одежды по погоде");
Console.Write("введите текущую температуру (С): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("наденьте легкую одежду");
}
else
{
    Console.WriteLine("наденьте теплую одежду");
}

Console.WriteLine("хорошего дня!");