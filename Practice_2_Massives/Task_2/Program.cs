Console.Clear();
int num = new Random().Next(100,1000);
Console.WriteLine(num);

int num1 = num/100;
int num3 = num%10;
int result = num1*10+num3;
Console.WriteLine($"Result without 2nd number is {result}");
Console.WriteLine(num1.ToString()+num3.ToString());
