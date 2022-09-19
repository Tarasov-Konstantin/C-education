Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine(num);

int num1 = num/10;
int num2 = num%10;

if (num1>num2) Console.WriteLine($"Number {num1} greater than {num2}");
else Console.WriteLine($"Number {num2} greater than {num1}");