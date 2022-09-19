int Max(int arg1, int arg2,int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1 = 10;
int a2 = 21;
int a3 = 53;
int a4 = 88;
int a5 = 439;
int a6 = 99;
int a7 = 18;
int a8 = 23;
int a9 = 69;

int max = a1;
if(a2>max) max = a2;
if(a3>max) max = a3;
if(a4>max) max = a4;
if(a5>max) max = a5;
if(a6>max) max = a6;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(a4, a5, a6);
//int max3 = Max(a7, a8, a9);
//int maxmax = Max(max1, max2, max3);

int maxmax = Max(
    Max(a1, a2, a3), 
    Max(a4, a5, a6), 
    Max(a7, a8, a9));

Console.WriteLine(max);
Console.WriteLine(maxmax);