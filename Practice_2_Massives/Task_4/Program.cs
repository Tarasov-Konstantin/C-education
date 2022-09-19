Console.Clear();
Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"{num} can be divided without reminder by 7 and 23");
else Console.WriteLine($"{num} can NOT be divided without reminder by 7 and 23");