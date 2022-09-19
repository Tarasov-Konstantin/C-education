int Max(int arg1, int arg2,int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int[] array = {14,20,23,14,75,86,27,68,49};
//array[0] = 12;
//Console.WriteLine(array[0]);

//int max1 = Max(a1, a2, a3);
//int max2 = Max(a4, a5, a6);
//int max3 = Max(a7, a8, a9);
//int maxmax = Max(max1, max2, max3);

int maxmax = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));


Console.WriteLine(maxmax);