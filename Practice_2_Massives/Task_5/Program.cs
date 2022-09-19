Console.Clear();
Console.WriteLine("Enter two numbers");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 == num2*num2) Console.WriteLine($"Num 1 _{num1}_  is the square of Num 2 _{num2}_");
else if (num2 == num1*num1) Console.WriteLine($"Num 2 _{num2}_  is the square of Num 1 _{num1}_");
else Console.WriteLine($"Neither of numbers is the square of another one");