Console.Clear();
Console.WriteLine("Enter two numbers");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1%num2 == 0) Console.WriteLine($"Num 1 _{num1}_  is multiple of Num 2 _{num2}_");
else Console.WriteLine($"Reminder of the division of _{num1}_ to _{num2}_ is {num1%num2}");

