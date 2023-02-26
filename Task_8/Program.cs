Console.Write("Введите значение переменной a = ");
int a = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number < a)
{
    if (number % 2 == 0) 
        Console.WriteLine(number);
    number++;
}
